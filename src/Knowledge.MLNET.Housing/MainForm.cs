using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZedGraph;

namespace Knowledge.MLNET.Housing
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private ModelImplementer _modelImplementer;

        private void Mainform_Load(object sender, EventArgs e)
        {
            StartRestartReload();
            SetupZedGraph();
        }
        private void BtnResetRestart_Click(object sender, EventArgs e)
        {
            StartRestartReload();
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

        private void StartRestartReload()
        {
            TxtboxTrainingDataPath.Text = ModelSettings.TrainingData;
            TxtboxTestingDataPath.Text = ModelSettings.TestingData;
            PnlBuildPipelineAndModel.Enabled = false;
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _modelImplementer = new ModelImplementer(ModelSettings.MLBuilderSeed);
        }

        private void BtnLoadDataFromFile2TrainingData_Click(object sender, EventArgs e)
        {
            if (!_modelImplementer.Ready) return;

            TxtboxLoadInformation.Clear();
            PnlLoadTrainingData.BackColor = Color.LightCoral; Application.DoEvents();

            _modelImplementer.LoadTrainingDataFromFile(
                trainingDataAbsolutePath: ModelSettings.TrainingData,
                trainingDataHasHeaders: ModelSettings.TrainingDataHasHeaders);

            if (_modelImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementer.FailureInformation);
                TxtboxLoadInformation.Text = _modelImplementer.FailureInformation;
            }
            else
            {
            }

            PnlBuildPipelineAndModel.Enabled = !_modelImplementer.ErrorHasOccured;
            PnlLoadTestingDataAndEvaluate.Enabled = false;
            PnlLoadTrainingData.BackColor = Color.LightSeaGreen;
            PnlBuildPipelineAndModel.BackColor = Color.LightBlue;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
        }

        // ===========================================================================================================

        private void BtnBuildTrainingPipelineEvaluateAndTrainModel_Click(object sender, EventArgs e)
        {
            if (!_modelImplementer.Ready) return;

            TxtboxModelInformation.Clear();
            PnlBuildPipelineAndModel.BackColor = Color.LightCoral; Application.DoEvents();
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _modelImplementer.BuildTrainingPipelineAndModel();

            if (_modelImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementer.FailureInformation);
                TxtboxModelInformation.Text = _modelImplementer.FailureInformation;
            }
            else
            {
            }

            PnlBuildPipelineAndModel.BackColor = Color.LightSeaGreen;
            PnlLoadTestingDataAndEvaluate.Enabled = !_modelImplementer.ErrorHasOccured;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
        }

        private void BtnSaveModel_Click(object sender, EventArgs e)
        {
            if (!_modelImplementer.Ready) return;

            TxtboxModelInformation.Clear(); PnlBuildPipelineAndModel.BackColor = Color.LightCoral; Application.DoEvents();

            _modelImplementer.SaveModel(ModelSettings.ModelFilePath);

            if (_modelImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementer.FailureInformation);
                TxtboxModelInformation.Text = _modelImplementer.FailureInformation;
            }
            else
            {
            }

            PnlBuildPipelineAndModel.BackColor = Color.LightSeaGreen;
        }

        // ===========================================================================================================

        private void BtnLoadTestingData2TestingData_Click(object sender, EventArgs e)
        {
            if (!_modelImplementer.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral; Application.DoEvents();

            _modelImplementer.LoadTestingDataFromFile(
                testingDataAbsolutePath: ModelSettings.TestingData,
                testingDataHasHeaders: ModelSettings.TestingDataHasHeaders);

            if (_modelImplementer.ErrorHasOccured) ShowMessageAlert(_modelImplementer.FailureInformation);

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightSeaGreen;
        }

        private void BtnEvaluateModelUsingTestData_Click(object sender, EventArgs e)
        {
            TxtboxAssessmentResults.Text = string.Empty;

            if (!_modelImplementer.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral; Application.DoEvents();

            var assessModel = _modelImplementer.AssessModel();

            if (assessModel.Count == 0) return;

            PointPairList pointPairList = new ZedGraph.PointPairList();

            foreach (var singleRow in assessModel)
            {
                if (singleRow.ActualValue > 1000)
                {
                    pointPairList.Add(x: singleRow.ActualValue, y: singleRow.PredictedValue);
                }
            }

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Performance", pointPairList, Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Firebrick);
            myCurve.Symbol.Size = 5;
            zedGraphControl1.Refresh();

            if (_modelImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementer.FailureInformation);
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
