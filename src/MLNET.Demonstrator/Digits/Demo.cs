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

namespace Knowledge.MLNET.Demonstrator.Digits
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
            BtnDisplayRandomDigit.Enabled = false;
            PnlLoadData.BackColor = Color.LightBlue;
            PnlBuildPipelineAndModel.Enabled = false;
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _modelImplementation = new ModelImplementation();

            _modelImplementation.FeatureNames = new Collection<string>();
            for (int cells28X28 = 0; cells28X28 < 28 * 28; cells28X28++)
            {
                var arf = "Cell" + ((cells28X28 / 28) + 1).ToString("00") +
                          ((cells28X28 % 28) + 1).ToString("00");
                _modelImplementation.FeatureNames.Add(arf);
            }
        }

        private void SetupZedGraph()
        {
            ZedGraph.GraphPane myPane = zedGraphControl1.GraphPane;

            // Set the titles
            myPane.Title.IsVisible = false;
            myPane.Legend.IsVisible = false;

            myPane.Fill = new ZedGraph.Fill(Color.White, Color.SlateGray, 45.0f);
            myPane.Chart.Fill = new ZedGraph.Fill(System.Drawing.Color.Transparent); // new Fill(Color.White, Color.LightGoldenrodYellow, 45.0f);

            myPane.XAxis.Title.IsVisible = false;
            myPane.XAxis.Scale.Min = 1;
            myPane.XAxis.Scale.Max = 28;
            myPane.XAxis.MajorGrid.IsVisible = false;
            myPane.XAxis.MinorGrid.IsVisible = false;
            myPane.XAxis.Scale.IsVisible = false;

            myPane.YAxis.Title.IsVisible = false;
            myPane.YAxis.Scale.Min = 1;
            myPane.YAxis.Scale.Max = 28;
            myPane.YAxis.MajorGrid.IsVisible = false;
            myPane.YAxis.MinorGrid.IsVisible = false;
            myPane.YAxis.Scale.IsVisible = false;
            myPane.YAxis.Scale.IsReverse = true;

            zedGraphControl1.AxisChange();
        }


        // ===========================================================================================================


        private void BtnLoadSmallDatasets_Click(object sender, EventArgs e)
        {
            TxtboxTrainingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/mnist_train_100_headers.csv");
            TxtboxTestingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/mnist_test_10_headers.csv");
            TxtboxModelSaveDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/MLModelResultsDigits.zip");
            LoadDatasetsCommon(
                trainingDataPath: TxtboxTrainingDataPath.Text,
                trainingDataHasHeaders: true,
                testingPathData: TxtboxTestingDataPath.Text,
                testingDataHasHeaders: true);
        }

        private void BtnLoadLargeDatasets_Click(object sender, EventArgs e)
        {
            TxtboxTrainingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/mnist_train_headers.csv");
            TxtboxTestingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/mnist_test_headers.csv");
            TxtboxModelSaveDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/MLModelResultsDigits.zip");
            LoadDatasetsCommon(
                trainingDataPath: TxtboxTrainingDataPath.Text,
                trainingDataHasHeaders: true,
                testingPathData: TxtboxTestingDataPath.Text,
                testingDataHasHeaders: true);
        }

        private void LoadDatasetsCommon(
            string trainingDataPath,
            bool trainingDataHasHeaders,
            string testingPathData,
            bool testingDataHasHeaders )
        {
            PnlLoadData.BackColor = Color.LightCoral;
            Application.DoEvents();

            _modelImplementation.LoadTrainingAndTestingData(
                trainingDataPath: trainingDataPath,
                trainingDataHasHeaders: trainingDataHasHeaders,
                testingPathData: testingPathData,
                testingDataHasHeaders: testingDataHasHeaders);

            PnlLoadData.BackColor = Color.LightGreen;
            BtnDisplayRandomDigit.Enabled = true;
            PnlBuildPipelineAndModel.Enabled = true;
        }

        private void BtnDisplayRandomDigit_Click(object sender, EventArgs e)
        {
            if (!_modelImplementation.Ready) return;

            PnlLoadData.BackColor = Color.LightCoral;
            Application.DoEvents();

            var aDigit = _modelImplementation.GetRandomTrainingData();

            if (aDigit == null) return;

            var digitShouldBe = aDigit["Label"].ToString();
            LblRandomDigit.Text = digitShouldBe;

            PointPairList pointPairList = new ZedGraph.PointPairList();

            for (int row = 0; row < 28; row++)
            for (int col = 0; col < 28; col++)
            {
                var key = "Cell" + (col + 1).ToString("00") + (row + 1).ToString("00");
                var aCell = aDigit[key].ToString();
                if (double.TryParse(aCell, out double val))
                {
                    if (val > 128)
                    {
                        pointPairList.Add(x: row, y: col);
                    }
                }
            }

            GraphPane myPane = zedGraphControl1.GraphPane;
            myPane.CurveList.Clear();
            LineItem myCurve = myPane.AddCurve("Performance", pointPairList, Color.Black, SymbolType.Square);
            myCurve.Line.IsVisible = false;
            myCurve.Symbol.Border.IsVisible = false;
            myCurve.Symbol.Fill = new Fill(Color.Firebrick);
            myCurve.Symbol.Size = 15;
            zedGraphControl1.Refresh();

            //https://web.archive.org/web/20110215041641/http://zedgraph.org/wiki/index.php?title=Scatter_Plot_Demo

            PnlLoadData.BackColor = Color.LightGreen;
        }


        // ===========================================================================================================


        private void BtnBuildAndTrainModel_Click(object sender, EventArgs e)
        {
            if (!_modelImplementation.Ready) return;

            PnlBuildPipelineAndModel.BackColor = Color.LightCoral;
            Application.DoEvents();
            PnlLoadTestingDataAndEvaluate.Enabled = false;

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

            PnlBuildPipelineAndModel.BackColor = Color.LightCoral;
            Application.DoEvents();

            _modelImplementation.SaveModel(TxtboxModelSaveDataPath.Text);

            if (_modelImplementation.ErrorHasOccured)
                ShowMessageAlert(_modelImplementation.FailureInformation);

            PnlBuildPipelineAndModel.BackColor = Color.LightSeaGreen;
        }


        // ===========================================================================================================


        private void BtnEvaluateModelUsingTestData_Click(object sender, EventArgs e)
        {
            TxtboxAssessmentResults.Text = string.Empty;

            if (!_modelImplementation.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral;
            Application.DoEvents();

            (int numberOfPredictions, int numberPredictionsCorrect) assessModel = _modelImplementation.AssessModel();

            if (_modelImplementation.ErrorHasOccured)
            {
                ShowMessageAlert(_modelImplementation.FailureInformation);
            }
            else
            {
                TxtboxAssessmentResults.Text =
                    $@"Assessed result: {assessModel.numberPredictionsCorrect} correct predictions out of {assessModel.numberOfPredictions} evaluated";
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
