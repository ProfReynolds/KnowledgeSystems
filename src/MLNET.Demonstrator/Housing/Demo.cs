using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Knowledge.MLNET.Demonstrator.Housing
{
    public partial class Demo : Form
    {
        public Demo()
        {
            InitializeComponent();
        }

        private ModelImplementation _modelImplementation;

        private void Demo_Load(object sender, EventArgs e)
        {
            StartRestartReload();
            SetupZedGraph();
        }

        private void BtnResetRestart_Click(object sender, EventArgs e)
        {
            StartRestartReload();
        }

        private void StartRestartReload()
        {
            PnlLoadData.BackColor = Color.LightBlue;
            PnlBuildPipelineAndModel.Enabled = false;
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _modelImplementation = new ModelImplementation();

            _modelImplementation.FeatureNames = new Collection<string>
            {
                "CentralAir", "MSZoning", "Street", "Alley", "LotShape", "LandContour",
                "Utilities", "LotConfig", "LandSlope", "Neighborhood", "Condition1",
                "Condition2", "BldgType", "HouseStyle", "RoofStyle", "RoofMatl",
                "Exterior1st", "Exterior2nd", "MasVnrType", "ExterQual", "ExterCond",
                "Foundation", "BsmtQual", "BsmtCond", "BsmtExposure", "BsmtFinType1",
                "BsmtFinType2", "Heating", "HeatingQC", "Electrical", "KitchenQual",
                "Functional", "FireplaceQu", "GarageType", "GarageFinish", "GarageQual",
                "GarageCond", "PavedDrive", "PoolQC", "Fence", "MiscFeature", "SaleType",
                "SaleCondition", "LotFrontage_MissingIndicator", "MasVnrArea_MissingIndicator",
                "GarageYrBlt_MissingIndicator", "LotFrontage", "MasVnrArea", "GarageYrBlt",
                "Id", "MSSubClass", "LotArea", "OverallQual", "OverallCond", "YearBuilt",
                "YearRemodAdd", "BsmtFinSF1", "BsmtFinSF2", "BsmtUnfSF", "TotalBsmtSF",
                "1stFlrSF", "2ndFlrSF", "LowQualFinSF", "GrLivArea", "BsmtFullBath",
                "BsmtHalfBath", "FullBath", "HalfBath", "BedroomAbvGr", "KitchenAbvGr",
                "TotRmsAbvGrd", "Fireplaces", "GarageCars", "GarageArea", "WoodDeckSF",
                "OpenPorchSF", "EnclosedPorch", "3SsnPorch", "ScreenPorch", "PoolArea",
                "MiscVal", "MoSold", "YrSold"
            };
        }

        private void SetupZedGraph()
        {
            GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.Legend.IsVisible = false;

            myPane.Fill = new Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Chart.Fill = new Fill(System.Drawing.Color.Transparent); // new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);

            myPane.XAxis.Title.IsVisible = true;
            myPane.XAxis.Title.Text = "Predicted Price";
            myPane.XAxis.Scale.Min = 0;
            myPane.XAxis.Scale.Max = 1000000;
            myPane.XAxis.MajorGrid.IsVisible = true;
            myPane.XAxis.MinorGrid.IsVisible = true;
            myPane.XAxis.Scale.IsVisible = true;

            myPane.YAxis.Title.IsVisible = true;
            myPane.YAxis.Title.Text = "Actual Price";
            myPane.YAxis.Scale.Min = 0;
            myPane.YAxis.Scale.Max = 1000000;
            myPane.YAxis.MajorGrid.IsVisible = true;
            myPane.YAxis.MinorGrid.IsVisible = true;
            myPane.YAxis.Scale.IsVisible = true;
            myPane.YAxis.Scale.IsReverse = false;

            zedGraphControl1.AxisChange();
        }


        // ===========================================================================================================


        private void BtnLoadDatasets_Click(object sender, EventArgs e)
        {
            PnlLoadData.BackColor = Color.LightCoral;
            Application.DoEvents();

            TxtboxTrainingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_train.csv");
            TxtboxTestingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_test.csv");
            TxtboxModelSaveDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/MLModelHousing.zip");

            _modelImplementation.LoadTrainingAndTestingData(
                trainingDataPath: TxtboxTrainingDataPath.Text,
                trainingDataHasHeaders: true,
                testingPathData: TxtboxTestingDataPath.Text,
                testingDataHasHeaders: true);

            PnlLoadData.BackColor = Color.LightGreen;
            PnlBuildPipelineAndModel.Enabled = true;
        }


        // ===========================================================================================================


        private void BtnBuildAndTrainModel_Click(object sender, EventArgs e)
        {
            if (!_modelImplementation.Ready) return;

            PnlBuildPipelineAndModel.BackColor = Color.LightCoral;
            PnlLoadTestingDataAndEvaluate.Enabled = false;
            Application.DoEvents();

            _modelImplementation.BuildTrainingPipelineAndModel();

            if (_modelImplementation.ErrorHasOccured)
                ShowMessageAlert(_modelImplementation.FailureInformation);

            PnlBuildPipelineAndModel.BackColor = Color.LightSeaGreen;
            PnlLoadTestingDataAndEvaluate.Enabled = !_modelImplementation.ErrorHasOccured;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
        }

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            if (!_modelImplementation.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral;
            Application.DoEvents();

            _modelImplementation.SaveModel(TxtboxModelSaveDataPath.Text);

            if (_modelImplementation.ErrorHasOccured)
                ShowMessageAlert(_modelImplementation.FailureInformation);

            PnlBuildPipelineAndModel.BackColor = Color.LightSeaGreen;
        }

        private void BtnEvaluateModelUsingTestData_Click(object sender, EventArgs e)
        {
            TxtboxAssessmentResults.Text = string.Empty;

            if (!_modelImplementation.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral;
            Application.DoEvents();

            var assessModel = _modelImplementation.AssessModel(true);

            if (assessModel.Count == 0) return;

            PointPairList pointPairList = new ZedGraph.PointPairList();

            foreach (var singleRow in assessModel)
            {
                pointPairList.Add(x: singleRow.ActualValue, y: singleRow.PredictedValue);
            }

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Performance", pointPairList, Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Firebrick);
            myCurve.Symbol.Size = 5;
            zedGraphControl1.Refresh();

            if (_modelImplementation.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementation.FailureInformation);
            }
            else
            {
            }

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightSeaGreen;
        }
        
        private void BtnEvaluateModelUsingTrainingData_Click(object sender, EventArgs e)
        {
            TxtboxAssessmentResults.Text = string.Empty;

            if (!_modelImplementation.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral;
            Application.DoEvents();

            var assessModel = _modelImplementation.AssessModel(false);

            if (assessModel.Count == 0) return;

            PointPairList pointPairList = new ZedGraph.PointPairList();

            foreach (var singleRow in assessModel)
            {
                pointPairList.Add(x: singleRow.ActualValue, y: singleRow.PredictedValue);
            }

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Performance", pointPairList, Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Firebrick);
            myCurve.Symbol.Size = 5;
            zedGraphControl1.Refresh();

            if (_modelImplementation.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementation.FailureInformation);
            }
            else
            {
            }

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightSeaGreen;
        }


        // ===========================================================================================================


        private void ShowMessageAlert(string modelBuilderFailureInformation)
        {
            MessageBox.Show(
                text: modelBuilderFailureInformation,
                caption: @"Model Demonstrator Failure",
                buttons: MessageBoxButtons.OK,
                icon: MessageBoxIcon.Error);
        }

    }
}
