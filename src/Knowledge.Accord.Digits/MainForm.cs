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

namespace Knowledge.Accord.Digits
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private AccordImplementer _accordImplementer;

        private void MainForm_Load(object sender, EventArgs e)
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

        private void StartRestartReload()
        {
            TxtboxTrainingDataPath.Text = ModelSettings.TrainingData;
            TxtboxTestingDataPath.Text = ModelSettings.TestingData;
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _accordImplementer = new AccordImplementer();

            _accordImplementer.FeatureNames = new Collection<string>();
            for (int cells28X28 = 0; cells28X28 < 28 * 28; cells28X28++)
            {
                var arf = "Cell" + ((cells28X28 / 28) + 1).ToString("00") +
                          ((cells28X28 % 28) + 1).ToString("00");
                _accordImplementer.FeatureNames.Add(arf);
            }

        }

        private void ChkboxUseLargeTrainingDataSet_CheckedChanged(object sender, EventArgs e)
        {
            ModelSettings.UseLargeTrainingDataSet = ((CheckBox)sender).Checked;
            TxtboxTrainingDataPath.Text = ModelSettings.TrainingData;
            TxtboxTestingDataPath.Text = ModelSettings.TestingData;
        }

        private void ChkboxUseLargeTestingDataSet_CheckedChanged(object sender, EventArgs e)
        {
            ModelSettings.UseLargeTestingDataSet = ((CheckBox)sender).Checked;
            TxtboxTrainingDataPath.Text = ModelSettings.TrainingData;
            TxtboxTestingDataPath.Text = ModelSettings.TestingData;
        }

        private void BtnLoadDataFromFile2TrainingData_Click(object sender, EventArgs e)
        {
            if (!_accordImplementer.Ready) return;

            TxtboxLoadInformation.Clear();
            PnlLoadTrainingData.BackColor = Color.LightCoral; Application.DoEvents();

            _accordImplementer.LoadTrainingDataFromFile(
                trainingDataAbsolutePath: ModelSettings.TrainingData,
                trainingDataHasHeaders: ModelSettings.TrainingDataHasHeaders);

            if (_accordImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_accordImplementer.FailureInformation);
                TxtboxLoadInformation.Text = _accordImplementer.FailureInformation;
            }
            else
            {
            }

            PnlLoadTestingDataAndEvaluate.Enabled = !_accordImplementer.ErrorHasOccured;
            PnlLoadTrainingData.BackColor = Color.LightSeaGreen;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
        }

        private void BtnDisplayRandomDigit_Click(object sender, EventArgs e)
        {
            if (!_accordImplementer.Ready) return;

            TxtboxLoadInformation.Clear();

            var aDigit = _accordImplementer.GetRandomTrainingData();

            if (aDigit == null)
            {
                TxtboxLoadInformation.Text = "Load the data first!";
                return;
            }

            LblRandomDigit.Text = aDigit.Item1.ToString();

            PointPairList pointPairList = new ZedGraph.PointPairList();

            for (int row = 0; row < 28; row++)
            for (int col = 0; col < 28; col++)
            {
                var element = row + col * 28;
                if (aDigit.Item2[element] > 128)
                {
                    pointPairList.Add(x: row, y: col);
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
        }

        private void BtnSvmLinear_Click(object sender, EventArgs e)
        {
            if (!_accordImplementer.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral; Application.DoEvents();
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _accordImplementer.LoadDataAndRunSvmLinear(
                testingDataAbsolutePath: ModelSettings.TestingData,
                testingDataHasHeaders: ModelSettings.TestingDataHasHeaders);

            if (_accordImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_accordImplementer.FailureInformation);
            }
            else
            {
                (int numberOfPredictions, int numberPredictionsCorrect) assessModel = _accordImplementer.Assessment();

                TxtboxAssessmentResults.Text =
                    $@"Assessed result: {assessModel.numberPredictionsCorrect} correct predictions out of {assessModel.numberOfPredictions} evaluated";

                PnlLoadTestingDataAndEvaluate.BackColor = Color.LightSeaGreen;
            }

            PnlLoadTestingDataAndEvaluate.Enabled = !_accordImplementer.ErrorHasOccured;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
        }

        private void BtnSvmGaussian_Click(object sender, EventArgs e)
        {
            if (!_accordImplementer.Ready) return;

            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightCoral; Application.DoEvents();
            PnlLoadTestingDataAndEvaluate.Enabled = false;

            _accordImplementer.LoadDataAndRunSvmGaussian(
                testingDataAbsolutePath: ModelSettings.TestingData,
                testingDataHasHeaders: ModelSettings.TestingDataHasHeaders);

            if (_accordImplementer.ErrorHasOccured)
            {
                ShowMessageAlert(_accordImplementer.FailureInformation);
            }
            else
            {
                (int numberOfPredictions, int numberPredictionsCorrect) assessModel = _accordImplementer.Assessment();

                TxtboxAssessmentResults.Text =
                    $@"Assessed result: {assessModel.numberPredictionsCorrect} correct predictions out of {assessModel.numberOfPredictions} evaluated";

                PnlLoadTestingDataAndEvaluate.BackColor = Color.LightSeaGreen;
            }

            PnlLoadTestingDataAndEvaluate.Enabled = !_accordImplementer.ErrorHasOccured;
            PnlLoadTestingDataAndEvaluate.BackColor = Color.LightBlue;
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
