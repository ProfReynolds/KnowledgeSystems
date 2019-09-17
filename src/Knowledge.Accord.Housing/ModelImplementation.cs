using System;
using System.Data;
using System.Diagnostics;
using System.IO;
using Accord.IO;

namespace Knowledge.Accord.Housing
{
    internal class ModelImplementation
    {
        public bool Ready { get; private set; }
        public bool ErrorHasOccured { get; private set; } = false;
        public string FailureInformation { get; private set; }

        public ModelImplementation()
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