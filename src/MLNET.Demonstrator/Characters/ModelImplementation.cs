using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Linq;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;

namespace Knowledge.MLNET.Demonstrator.Characters
{
    internal class ModelImplementation
    {
        public bool Ready { get; private set; }
        public bool ErrorHasOccured { get; private set; }
        public string FailureInformation { get; private set; }
        public Collection<string> FeatureNames { get; set; }

        private readonly MLContext _mlContext;
        private IDataView _trainingDataView;
        private IDataView _testingDataView;
        private ITransformer _mlModel;

        public ModelImplementation()
        {
            _mlContext=new MLContext();
        }

        public void LoadTrainingAndTestingData(string trainingDataPath, bool trainingDataHasHeaders, string testingPathData, bool testingDataHasHeaders)
        {
            if (ErrorHasOccured) return;

            try
            {
                _trainingDataView = _mlContext.Data.LoadFromTextFile<ModelInput>(
                    path: trainingDataPath,
                    hasHeader: trainingDataHasHeaders,
                    separatorChar: ',',
                    allowQuoting: true,
                    allowSparse: false);

                _testingDataView = _mlContext.Data.LoadFromTextFile<ModelInput>(
                    path: testingPathData,
                    hasHeader: testingDataHasHeaders,
                    separatorChar: ',',
                    allowQuoting: true,
                    allowSparse: false);

                Ready = true;
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }


        // ===========================================================================================================


        public void BuildTrainingPipelineAndModel(ClassificationMode classificationMode)
        {
            if (ErrorHasOccured) return;

            try
            {
                switch (classificationMode)
                {
                    case ClassificationMode.OneVersusAll: // first time this project was builot
                        // Data process configuration with pipeline data transformations 
                        EstimatorChain<NormalizingTransformer> dataProcessPipeline1 =
                            _mlContext.Transforms.Conversion.MapValueToKey("Label", "Label")
                                .Append(_mlContext.Transforms.Concatenate(
                                    outputColumnName: "Features",
                                    inputColumnNames: FeatureNames.ToArray()))
                                .Append(_mlContext.Transforms.NormalizeMinMax("Features", "Features"))
                                .AppendCacheCheckpoint(_mlContext);

                        // Set the training algorithm 
                        EstimatorChain<KeyToValueMappingTransformer> trainer1 =
                            _mlContext.MulticlassClassification.Trainers.OneVersusAll(
                                    _mlContext.BinaryClassification.Trainers.AveragedPerceptron(labelColumnName: "Label",
                                        numberOfIterations: 10, featureColumnName: "Features"), labelColumnName: "Label")
                                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

                        IEstimator<ITransformer> trainingPipeline1 =
                            dataProcessPipeline1.Append(trainer1);

                        // Train Model
                        _mlModel = trainingPipeline1.Fit(_trainingDataView);
                        break;

                    case ClassificationMode.LightGbm:
                        // Data process configuration with pipeline data transformations 
                        EstimatorChain<ColumnConcatenatingTransformer> dataProcessPipeline2 =
                            _mlContext.Transforms.Conversion.MapValueToKey("Label", "Label")
                                .Append(_mlContext.Transforms.Concatenate(
                                    outputColumnName: "Features",
                                    inputColumnNames: FeatureNames.ToArray()));

                        // Set the training algorithm 
                        EstimatorChain<KeyToValueMappingTransformer> trainer2 =
                            _mlContext.MulticlassClassification.Trainers.LightGbm(labelColumnName: "Label", featureColumnName: "Features")
                                .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

                        EstimatorChain<TransformerChain<KeyToValueMappingTransformer>> trainingPipeline2 =
                            dataProcessPipeline2.Append(trainer2);

                        // Train Model
                        _mlModel = trainingPipeline2.Fit(_trainingDataView);
                        break;

                    default:
                        throw new ArgumentOutOfRangeException(nameof(classificationMode), classificationMode, null);
                }

                // TODO
                //// Cross-Validate with single dataset (since we don't have two datasets, one for training and for evaluate)
                //// in order to evaluate and get the model's accuracy metrics
                //Console.WriteLine("=============== Cross-validating to get model's accuracy metrics ===============");
                //var crossValidationResults = mlContext.MulticlassClassification.CrossValidate(trainingDataView, trainingPipeline, numberOfFolds: 5, labelColumnName: "Label");
                //PrintMulticlassClassificationFoldsAverageMetrics(crossValidationResults);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }

        }

        public void SaveModel(string txtboxModelSaveDataPath)
        {
            if (ErrorHasOccured) return;

            try
            {
                _mlContext.Model.Save(_mlModel, _trainingDataView.Schema, txtboxModelSaveDataPath);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }


        // ===========================================================================================================


        public (int numberOfPredictions, int numberPredictionsCorrect) AssessModel()
        {
            if (ErrorHasOccured) return (-1, -1);

            if (_testingDataView == null) return (-1, -1);

            PredictionEngine<ModelInput, ModelOutput> predictionEngine =
                _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(_mlModel);

            IEnumerable<ModelInput> samplesForPrediction =
                _mlContext.Data.CreateEnumerable<ModelInput>(_testingDataView, false);

            var numPredictions = 0;
            var numCorrectPreditions = 0;
            foreach (var singleRow in samplesForPrediction)
            {
                numPredictions++;
                ModelOutput predictionResult = predictionEngine.Predict(singleRow);
                if (singleRow.Label.Equals(predictionResult.Prediction))
                    numCorrectPreditions++;
            }

            return (numPredictions, numCorrectPreditions);
        }
    }
}