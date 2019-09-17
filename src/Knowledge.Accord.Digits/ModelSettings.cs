namespace Knowledge.Accord.Digits
{
    class ModelSettings
    {
        /// <summary>
        /// Dataset to use for training
        /// </summary>
        public static string TrainingData { get; private set; } = System.IO.Path.GetFullPath(@"C:\Users\mark\OneDrive\dev\Datasets\mnist_train_100_headers.csv");

        public static bool TrainingDataHasHeaders { get; } = true;

        /// <summary>
        /// Dataset to use for predictions 
        /// </summary>
        public static string TestingData { get; private set; } = System.IO.Path.GetFullPath(@"C:\Users\mark\OneDrive\dev\Datasets\mnist_test_10_headers.csv");

        public static bool TestingDataHasHeaders { get; } = true;

        private static bool _useLargeTrainingDataSet = false;
        private static bool _useLargeTestingDataSet = false;

        public static bool UseLargeTrainingDataSet
        {
            get { return _useLargeTrainingDataSet; }
            set
            {
                _useLargeTrainingDataSet = value;
                if (_useLargeTrainingDataSet)
                {
                    TrainingData = System.IO.Path.GetFullPath(@"C:/Users/mark/OneDrive/dev/Datasets/mnist_train_headers.csv");
                }
                else
                {
                    TrainingData = System.IO.Path.GetFullPath(@"C:\Users\mark\OneDrive\dev\Datasets\mnist_train_100_headers.csv");
                }
            }
        }

        public static bool UseLargeTestingDataSet
        {
            get { return _useLargeTestingDataSet; }
            set
            {
                _useLargeTestingDataSet = value;
                if (_useLargeTestingDataSet)
                {
                    TestingData = System.IO.Path.GetFullPath(@"C:/Users/mark/OneDrive/dev/Datasets/mnist_test_headers.csv");
                }
                else
                {
                    TestingData = System.IO.Path.GetFullPath(@"C:\Users\mark\OneDrive\dev\Datasets\mnist_test_10_headers.csv");
                }
            }
        }
    }
}
