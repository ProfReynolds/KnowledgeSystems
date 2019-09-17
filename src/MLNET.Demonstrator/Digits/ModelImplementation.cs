using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Drawing.Text;
using System.Linq;
using System.Windows.Forms;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Transforms;

namespace Knowledge.MLNET.Demonstrator.Digits
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

        public Dictionary<string, object> GetRandomTrainingData()
        {
            if (_trainingDataView == null) return null;

            //IEnumerable<ModelInput> samplesForPrediction = _mlContext.Data.CreateEnumerable<ModelInput>(_trainingDataView, false);
            //IEnumerable<ModelInput> aRow = samplesForPrediction.Skip(rowno - 1).Take(1);

            IEnumerable<ModelInput> samplesForPrediction = _mlContext.Data
                .CreateEnumerable<ModelInput>(_trainingDataView, false)
                .ToArray<ModelInput>();

            var numRows = samplesForPrediction.LongCount();

            if (numRows == 0) return null;
            if (numRows > int.MaxValue) return null;

            var random = new Random();
            var rowno = random.Next(0, (int)numRows);

            var aRow = samplesForPrediction.Skip(rowno - 1).Take(1).First();

            var aDict =
                aRow.GetType()
                    .GetProperties()
                    .ToDictionary(prop => prop.Name, prop => prop.GetValue(aRow, null));

            return aDict;
        }


        // ===========================================================================================================


        public void BuildTrainingPipelineAndModel()
        {
            if (ErrorHasOccured) return;

            try
            {
                EstimatorChain<NormalizingTransformer> dataProcessPipeline =
                    _mlContext.Transforms.Conversion.MapValueToKey("Label", "Label")
                        .Append(_mlContext.Transforms.Concatenate(
                            outputColumnName: "Features",
                            inputColumnNames: FeatureNames.ToArray()))
                        .Append(_mlContext.Transforms.NormalizeMinMax("Features", "Features"))
                        .AppendCacheCheckpoint(_mlContext);

                EstimatorChain<KeyToValueMappingTransformer> trainer =
                    _mlContext.MulticlassClassification.Trainers.OneVersusAll(
                            _mlContext.BinaryClassification.Trainers.AveragedPerceptron(labelColumnName: "Label",
                                numberOfIterations: 1, featureColumnName: "Features"), labelColumnName: "Label")
                        .Append(_mlContext.Transforms.Conversion.MapKeyToValue("PredictedLabel", "PredictedLabel"));

                IEstimator<ITransformer> trainingPipeline =
                    dataProcessPipeline.Append(trainer);

                // TODO
                // Evaluate quality of Model
                // Evaluate(_mlContext, _trainingDataView, trainingPipeline);

                // Train Model
                _mlModel = trainingPipeline.Fit(_trainingDataView);

                // TODO
                // Save _mlModel
                // SaveModel(_mlContext, mlModel, ModelSettings.ModelFilePath, _trainingDataView.Schema);

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