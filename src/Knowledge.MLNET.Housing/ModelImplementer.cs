using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ML;
using Microsoft.ML.Data;
using Microsoft.ML.Trainers;
using Microsoft.ML.Transforms;

namespace Knowledge.MLNET.Housing
{
    class ModelImplementer
    {
        public bool Ready { get; set; } = false;
        public bool ErrorHasOccured { get; private set; } = false;
        public string FailureInformation { get; private set; } = string.Empty;

        private MLContext _mlContext;
        private IDataView _trainingDataView;
        private IDataView _testingDataView;
        private ITransformer _mlModel;

        public ModelImplementer(int? mlBuilderSeed = null)
        {
            _mlContext = new MLContext(seed: mlBuilderSeed);
            Ready = true;
        }

        public void LoadTrainingDataFromFile(
            string trainingDataAbsolutePath,
            bool trainingDataHasHeaders = true)
        {
            if (ErrorHasOccured) return;

            try
            {
                _trainingDataView = _mlContext.Data.LoadFromTextFile<ModelInput>(
                    path: trainingDataAbsolutePath,
                    hasHeader: trainingDataHasHeaders,
                    separatorChar: ',',
                    allowQuoting: true,
                    allowSparse: false);
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

        public void BuildTrainingPipelineAndModel()
        {
            if (ErrorHasOccured) return;

            try
            {
                EstimatorChain<NormalizingTransformer> dataProcessPipeline = _mlContext.Transforms.Conversion.ConvertType(new[] { new InputOutputColumnPair("CentralAir", "CentralAir") })
                          .Append(_mlContext.Transforms.Categorical.OneHotEncoding(new[] { new InputOutputColumnPair("MSZoning", "MSZoning"), new InputOutputColumnPair("Street", "Street"), new InputOutputColumnPair("Alley", "Alley"), new InputOutputColumnPair("LotShape", "LotShape"), new InputOutputColumnPair("LandContour", "LandContour"), new InputOutputColumnPair("Utilities", "Utilities"), new InputOutputColumnPair("LotConfig", "LotConfig"), new InputOutputColumnPair("LandSlope", "LandSlope"), new InputOutputColumnPair("Neighborhood", "Neighborhood"), new InputOutputColumnPair("Condition1", "Condition1"), new InputOutputColumnPair("Condition2", "Condition2"), new InputOutputColumnPair("BldgType", "BldgType"), new InputOutputColumnPair("HouseStyle", "HouseStyle"), new InputOutputColumnPair("RoofStyle", "RoofStyle"), new InputOutputColumnPair("RoofMatl", "RoofMatl"), new InputOutputColumnPair("Exterior1st", "Exterior1st"), new InputOutputColumnPair("Exterior2nd", "Exterior2nd"), new InputOutputColumnPair("MasVnrType", "MasVnrType"), new InputOutputColumnPair("ExterQual", "ExterQual"), new InputOutputColumnPair("ExterCond", "ExterCond"), new InputOutputColumnPair("Foundation", "Foundation"), new InputOutputColumnPair("BsmtQual", "BsmtQual"), new InputOutputColumnPair("BsmtCond", "BsmtCond"), new InputOutputColumnPair("BsmtExposure", "BsmtExposure"), new InputOutputColumnPair("BsmtFinType1", "BsmtFinType1"), new InputOutputColumnPair("BsmtFinType2", "BsmtFinType2"), new InputOutputColumnPair("Heating", "Heating"), new InputOutputColumnPair("HeatingQC", "HeatingQC"), new InputOutputColumnPair("Electrical", "Electrical"), new InputOutputColumnPair("KitchenQual", "KitchenQual"), new InputOutputColumnPair("Functional", "Functional"), new InputOutputColumnPair("FireplaceQu", "FireplaceQu"), new InputOutputColumnPair("GarageType", "GarageType"), new InputOutputColumnPair("GarageFinish", "GarageFinish"), new InputOutputColumnPair("GarageQual", "GarageQual"), new InputOutputColumnPair("GarageCond", "GarageCond"), new InputOutputColumnPair("PavedDrive", "PavedDrive"), new InputOutputColumnPair("PoolQC", "PoolQC"), new InputOutputColumnPair("Fence", "Fence"), new InputOutputColumnPair("MiscFeature", "MiscFeature"), new InputOutputColumnPair("SaleType", "SaleType"), new InputOutputColumnPair("SaleCondition", "SaleCondition") }))
                          .Append(_mlContext.Transforms.IndicateMissingValues(new[] { new InputOutputColumnPair("LotFrontage_MissingIndicator", "LotFrontage"), new InputOutputColumnPair("MasVnrArea_MissingIndicator", "MasVnrArea"), new InputOutputColumnPair("GarageYrBlt_MissingIndicator", "GarageYrBlt") }))
                          .Append(_mlContext.Transforms.Conversion.ConvertType(new[] { new InputOutputColumnPair("LotFrontage_MissingIndicator", "LotFrontage_MissingIndicator"), new InputOutputColumnPair("MasVnrArea_MissingIndicator", "MasVnrArea_MissingIndicator"), new InputOutputColumnPair("GarageYrBlt_MissingIndicator", "GarageYrBlt_MissingIndicator") }))
                          .Append(_mlContext.Transforms.ReplaceMissingValues(new[] { new InputOutputColumnPair("LotFrontage", "LotFrontage"), new InputOutputColumnPair("MasVnrArea", "MasVnrArea"), new InputOutputColumnPair("GarageYrBlt", "GarageYrBlt") }))
                          .Append(_mlContext.Transforms.Concatenate("Features", new[] { "CentralAir", "MSZoning", "Street", "Alley", "LotShape", "LandContour", "Utilities", "LotConfig", "LandSlope", "Neighborhood", "Condition1", "Condition2", "BldgType", "HouseStyle", "RoofStyle", "RoofMatl", "Exterior1st", "Exterior2nd", "MasVnrType", "ExterQual", "ExterCond", "Foundation", "BsmtQual", "BsmtCond", "BsmtExposure", "BsmtFinType1", "BsmtFinType2", "Heating", "HeatingQC", "Electrical", "KitchenQual", "Functional", "FireplaceQu", "GarageType", "GarageFinish", "GarageQual", "GarageCond", "PavedDrive", "PoolQC", "Fence", "MiscFeature", "SaleType", "SaleCondition", "LotFrontage_MissingIndicator", "MasVnrArea_MissingIndicator", "GarageYrBlt_MissingIndicator", "LotFrontage", "MasVnrArea", "GarageYrBlt", "Id", "MSSubClass", "LotArea", "OverallQual", "OverallCond", "YearBuilt", "YearRemodAdd", "BsmtFinSF1", "BsmtFinSF2", "BsmtUnfSF", "TotalBsmtSF", "1stFlrSF", "2ndFlrSF", "LowQualFinSF", "GrLivArea", "BsmtFullBath", "BsmtHalfBath", "FullBath", "HalfBath", "BedroomAbvGr", "KitchenAbvGr", "TotRmsAbvGrd", "Fireplaces", "GarageCars", "GarageArea", "WoodDeckSF", "OpenPorchSF", "EnclosedPorch", "3SsnPorch", "ScreenPorch", "PoolArea", "MiscVal", "MoSold", "YrSold" }))
                          .Append(_mlContext.Transforms.NormalizeMinMax("Features", "Features"))
                          .AppendCacheCheckpoint(_mlContext);

                LbfgsPoissonRegressionTrainer trainer = _mlContext.Regression.Trainers.LbfgsPoissonRegression(new LbfgsPoissonRegressionTrainer.Options() { L2Regularization = 0.07404655f, L1Regularization = 0.2087761f, OptimizationTolerance = 0.0001f, HistorySize = 5, MaximumNumberOfIterations = 462473459, InitialWeightsDiameter = 0.5613934f, DenseOptimizer = false, LabelColumnName = "SalePrice", FeatureColumnName = "Features" });

                EstimatorChain<RegressionPredictionTransformer<PoissonRegressionModelParameters>> trainingPipeline = dataProcessPipeline.Append(trainer);

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

        public void SaveModel(string modelFilePath)
        {
            if (ErrorHasOccured) return;

            try
            {
                _mlContext.Model.Save(_mlModel, _trainingDataView.Schema, modelFilePath);
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

        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T">Model Input - IModelInput</typeparam>
        /// <param name="testingDataAbsolutePath">path to testing data on disk</param>
        /// <param name="testingDataHasHeaders">is there headers?</param>
        public void LoadTestingDataFromFile(string testingDataAbsolutePath, bool testingDataHasHeaders)
        {
            if (ErrorHasOccured) return;

            try
            {
                _testingDataView = _mlContext.Data.LoadFromTextFile<ModelInput>(
                    path: testingDataAbsolutePath,
                    hasHeader: testingDataHasHeaders,
                    separatorChar: ',',
                    allowQuoting: true,
                    allowSparse: false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }

        public IList<ActualVsPredicted> AssessModel()
        {
            var response = new List<ActualVsPredicted>();

            if (ErrorHasOccured) return response;

            if (_testingDataView == null) return response;

            PredictionEngine<ModelInput, ModelOutput> predictionEngine =
                _mlContext.Model.CreatePredictionEngine<ModelInput, ModelOutput>(_mlModel);

            IEnumerable<ModelInput> samplesForPrediction =
                _mlContext.Data.CreateEnumerable<ModelInput>(_testingDataView, false);

            foreach (var singleRow in samplesForPrediction)
            {
                if (singleRow.SalePrice > 1000)
                {
                    ModelOutput predictionResult = predictionEngine.Predict(singleRow);
                    response.Add(new ActualVsPredicted
                    {
                        ActualValue = singleRow.SalePrice,
                        PredictedValue = predictionResult.Score
                    });
                }
            }

        return response;
        }

    }
}
