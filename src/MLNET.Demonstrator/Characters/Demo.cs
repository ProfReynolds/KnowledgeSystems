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

namespace Knowledge.MLNET.Demonstrator.Characters
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
                "x_box", "y_box", "width", "height", "onpix", "x_bar", "y_bar", "x2bar",
                "y2bar", "xybar", "x2ybar", "xy2bar", "x_ege", "xegvy", "y_ege", "yegvx"
            };
        }


        // ===========================================================================================================


        private void BtnLoadDatasets_Click(object sender, EventArgs e)
        {
            PnlLoadData.BackColor = Color.LightCoral;
            Application.DoEvents();

            TxtboxTrainingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/letter_recognition_headers.csv");
            TxtboxTestingDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/letter_recognition_headers.csv");
            TxtboxModelSaveDataPath.Text = System.IO.Path.GetFullPath(@"../../../../Datasets/MLModelResultsCharacter.zip");

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

            ClassificationMode classificationMode =
                (RadioBtnOneVsAll.Checked) ? ClassificationMode.OneVersusAll :
                (RadioBtnLightGbm.Checked) ? ClassificationMode.LightGbm :
                ClassificationMode.Error;
            _modelImplementation.BuildTrainingPipelineAndModel(classificationMode);

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
