using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.VisualStyles;
using Accord.IO;
using Accord.MachineLearning.VectorMachines.Learning;
using Accord.Math;
using Accord.Statistics.Kernels;

namespace Knowledge.Accord.Digits
{
    class AccordImplementer
    {
        public bool Ready { get; set; } = false;
        public bool ErrorHasOccured { get; private set; } = false;
        public string FailureInformation { get; private set; } = string.Empty;
        public ICollection<string> FeatureNames { get; set; }

        private double[][] _trainingInputs;
        private int[] _trainingOutputs;
        private double[][] _testingInputs;
        private int[] _testingOutputs;

        private int _numberOfPredictions = 0;
        private int _numberPredictionsCorrect = 0;

        public AccordImplementer()
        {
            Ready = true;
        }

        public void LoadTrainingDataFromFile(string trainingDataAbsolutePath, bool trainingDataHasHeaders)
        {
            if (ErrorHasOccured) return;

            try
            {
                using (StreamReader sr = new StreamReader(trainingDataAbsolutePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    DataTable table = CsvReader.FromText(line, trainingDataHasHeaders).ToTable();

                    _trainingInputs = table.ToJagged<double>(FeatureNames.ToArray());
                    _trainingOutputs = table.Columns["Label"].ToArray<int>();
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }

        public Tuple<int, double[]> GetRandomTrainingData()
        {
            if (_trainingInputs == null) return null;

            var numRows = _trainingInputs.GetLength(0);

            if (numRows == 0) return null;

            var random = new Random();
            var rowno = random.Next(0, (int)numRows);

            return new Tuple<int, double[]>(_trainingOutputs[rowno], _trainingInputs[rowno]);
        }

        public (int numberOfPredictions, int numberPredictionsCorrect) Assessment()
        {

            return (_numberOfPredictions, _numberPredictionsCorrect);
        }

        public void LoadDataAndRunSvmLinear(string testingDataAbsolutePath, bool testingDataHasHeaders)
        {
            _numberOfPredictions = 0;
            _numberPredictionsCorrect = 0;

            if (ErrorHasOccured) return;

            try
            {
                using (StreamReader sr = new StreamReader(testingDataAbsolutePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    DataTable table = CsvReader.FromText(line, testingDataHasHeaders).ToTable();

                    _testingInputs = table.ToJagged<double>(FeatureNames.ToArray());
                    _testingOutputs = table.Columns["Label"].ToArray<int>();

                    var teacher = new MulticlassSupportVectorLearning<Linear>()
                    {
                        // Configure the learning algorithm
                        Learner = (param) => new LinearDualCoordinateDescent()
                        {
                            Loss = Loss.L2
                        }
                    };

                    // Learn a machine
                    var svm = teacher.Learn(_trainingInputs, _trainingOutputs);

                    // Classify the samples using the model
                    int[] answers = svm.Decide(_testingInputs, _testingOutputs);

                    /*
                    var teacher = new MulticlassSupportVectorLearning<IKernel>()
                    {
                        // Configure the learning algorithm
                        Learner = (param) => new SequentialMinimalOptimization<IKernel>()
                        {
                            Complexity = 10,
                            Tolerance = 2,
                            CacheSize = 500,
                            Strategy = SelectionStrategy.SecondOrder,
                            Kernel = null
                        }
                    };

                    //// Teach the vector machine
                    //var svm = teacher.Learn(_trainingInputs, _trainingOutputs);

                    //// Classify the samples using the model
                    //int[] answers = svm.Transform(_testingInputs, _testingOutputs);
                    */

                    for (int item = 0; item < answers.Length; item++)
                    {
                        _numberOfPredictions++;
                        if (_testingOutputs[item] == answers[item])
                            _numberPredictionsCorrect++;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }
        public void LoadDataAndRunSvmGaussian(string testingDataAbsolutePath, bool testingDataHasHeaders)
        {
            _numberOfPredictions = 0;
            _numberPredictionsCorrect = 0;

            if (ErrorHasOccured) return;

            try
            {
                using (StreamReader sr = new StreamReader(testingDataAbsolutePath))
                {
                    // Read the stream to a string, and write the string to the console.
                    string line = sr.ReadToEnd();
                    DataTable table = CsvReader.FromText(line, testingDataHasHeaders).ToTable();

                    _testingInputs = table.ToJagged<double>(FeatureNames.ToArray());
                    _testingOutputs = table.Columns["Label"].ToArray<int>();

                    var teacher = new MulticlassSupportVectorLearning<Gaussian>()
                    {
                        // Configure the learning algorithm to use SMO to train the
                        //  underlying SVMs in each of the binary class subproblems.
                        Learner = (param) => new SequentialMinimalOptimization<Gaussian>()
                        {
                            // Estimate a suitable guess for the Gaussian kernel's parameters.
                            // This estimate can serve as a starting point for a grid search.
                            UseKernelEstimation = true
                        }
                    };

                    // Learn a machine
                    var machine = teacher.Learn(_trainingInputs, _trainingOutputs);

                    // Classify the samples using the model
                    int[] answers = machine.Decide(_testingInputs, _testingOutputs);

                    // Get class scores for each sample
                    double[] scores = machine.Score(_trainingInputs);

                    for (int item = 0; item < answers.Length; item++)
                    {
                        _numberOfPredictions++;
                        if (_testingOutputs[item] == answers[item])
                            _numberPredictionsCorrect++;
                    }
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine(ex.Message);
                ErrorHasOccured = true;
                FailureInformation = ex.Message;
                return;
            }
        }

    }
}
