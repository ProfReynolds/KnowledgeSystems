using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Knowledge.Accord.Classification
{
    class ModelSettings
    {
        public static string ModelFilePath { get; } = System.IO.Path.GetFullPath(@"C:/Users/mark/OneDrive/dev/Datasets/AccordClassificationExamples.xls");
        public static string ModelWorksheet { get; } = @"CharacterClassification";
    }
}
