using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.MLNET.Housing
{
    class ModelSettings
    {
        /// <summary>
        /// Set a random seed for repeatable/deterministic results across multiple trainings.
        /// </summary>
        // ReSharper disable once InconsistentNaming
        public static int? MLBuilderSeed { get; } = null;

        /// <summary>
        /// Machine Learning model to load and use for predictions
        /// </summary>
        public static string ModelFilePath { get; } = System.IO.Path.GetFullPath(@"../../../../Datasets/MLModelHousing.zip");

        /// <summary>
        /// Dataset to use for training
        /// </summary>
        public static string TrainingData { get; private set; } = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_train.csv");

        public static bool TrainingDataHasHeaders { get; } = true;

        /// <summary>
        /// Dataset to use for predictions 
        /// </summary>
        public static string TestingData { get; private set; } = System.IO.Path.GetFullPath(@"../../../../Datasets/housing_train.csv");

        public static bool TestingDataHasHeaders { get; } = true;

    }
}
