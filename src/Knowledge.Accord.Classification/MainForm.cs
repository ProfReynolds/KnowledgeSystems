using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accord.Controls;
using Accord.IO;
using Accord.MachineLearning.Bayes;
using Accord.MachineLearning.DecisionTrees;
using Accord.MachineLearning.DecisionTrees.Learning;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics;
using Accord.Statistics.Distributions.Univariate;
using Accord.Statistics.Kernels;
using Accord.Statistics.Models.Regression;
using Accord.Statistics.Models.Regression.Fitting;

namespace Knowledge.Accord.Classification
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            StartRestartReload();
        }

        private void BtnResetRestart_Click(object sender, EventArgs e)
        {
            StartRestartReload();
        }

        private void StartRestartReload()
        {
            TxtboxTrainingDataPath.Text = ModelSettings.ModelFilePath;
            TxtboxTrainingDataWorksheet.Text = ModelSettings.ModelWorksheet;
            PanelClassifiers.Enabled = false;

        }

        private double[][] _inputs;
        private int[] _outputs;

        private void BtnLoadDataFromExcelSpreadsheet_Click(object sender, EventArgs e)
        {
            DataTable table = new ExcelReader(ModelSettings.ModelFilePath)
                .GetWorksheet(ModelSettings.ModelWorksheet);

            _inputs = table.ToJagged<double>("X", "Y");
            _outputs = table.Columns["G"].ToArray<int>();

            ScatterplotBox.Show("Yin-Yang", _inputs, _outputs);//.Hold();

            PanelClassifiers.Enabled = true;
        }

        private void BtnSvmLinear_Click(object sender, EventArgs e)
        {
            // Create a L2-regularized L2-loss optimization algorithm for
            // the dual form of the learning problem. This is *exactly* the
            // same method used by LIBLINEAR when specifying -s 1 in the 
            // command line (i.e. L2R_L2LOSS_SVC_DUAL).
            //
            var teacher = new LinearCoordinateDescent();

            // Teach the vector machine
            var svm = teacher.Learn(_inputs, _outputs);

            // Classify the samples using the model
            bool[] answers = svm.Decide(_inputs);

            // Convert to Int32 so we can plot:
            int[] zeroOneAnswers = answers.ToZeroOne();

            // Plot the results
            ScatterplotBox.Show("Expected results", _inputs, _outputs);
            ScatterplotBox.Show("LinearSVM results", _inputs, zeroOneAnswers);

            // Grab the index of multipliers higher than 0
            int[] idx = teacher.Lagrange.Find(x => x > 0);

            // Select the input vectors for those
            double[][] sv = _inputs.Get(idx);

            // Plot the support vectors selected by the machine
            ScatterplotBox.Show("Support vectors", sv);//.Hold();
        }

        private void BtnSvmKernal_Click(object sender, EventArgs e)
        {
            // Create a new Sequential Minimal Optimization (SMO) learning 
            // algorithm and estimate the complexity parameter C from data
            var teacher = new SequentialMinimalOptimization<Gaussian>()
            {
                UseComplexityHeuristic = true,
                UseKernelEstimation = true // estimate the kernel from the data
            };

            // Teach the vector machine
            var svm = teacher.Learn(_inputs, _outputs);

            // Classify the samples using the model
            bool[] answers = svm.Decide(_inputs);

            // Convert to Int32 so we can plot:
            int[] zeroOneAnswers = answers.ToZeroOne();

            // Plot the results
            ScatterplotBox.Show("Expected results", _inputs, _outputs);
            ScatterplotBox.Show("GaussianSVM results", _inputs, zeroOneAnswers);
        }

        private void BtnLogisticRegression_Click(object sender, EventArgs e)
        {
            // Create iterative re-weighted least squares for logistic regressions
            var teacher = new IterativeReweightedLeastSquares<LogisticRegression>()
            {
                MaxIterations = 100,
                Regularization = 1e-6
            };

            // Use the teacher algorithm to learn the regression:
            LogisticRegression lr = teacher.Learn(_inputs, _outputs);

            // Classify the samples using the model
            bool[] answers = lr.Decide(_inputs);

            // Convert to Int32 so we can plot:
            int[] zeroOneAnswers = answers.ToZeroOne();

            // Plot the results
            ScatterplotBox.Show("Expected results", _inputs, _outputs);
            ScatterplotBox.Show("Logistic Regression results", _inputs, zeroOneAnswers)
                .Hold();
        }
    }
}
