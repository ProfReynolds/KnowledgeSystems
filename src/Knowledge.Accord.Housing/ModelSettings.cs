using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Accord.Housing
{
    class ModelSettings
    {
        public static string TrainingData { get; private set; } = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_train.csv");
        public static bool TrainingDataHasHeaders { get; } = true;
        public static string TestingData { get; private set; } = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_test.csv");
        public static bool TestingDataHasHeaders { get; } = true;
    }
}
