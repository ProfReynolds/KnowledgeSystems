using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Knowledge.Accord.Housing
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private ModelImplementation _modelImplemention;
        private void MainForm_Loaded(object sender, RoutedEventArgs e)
        {
            TxtboxTrainingDataSource.Text = ModelSettings.TrainingData;
            TxtboxTestingDataSource.Text = ModelSettings.TestingData;

            _modelImplemention = new ModelImplementation();
        }

        private void BtnLoadTrainingAndTextData_Click(object sender, RoutedEventArgs e)
        {
            if (!_modelImplemention.Ready) return;

            TxtblockLoadInformation.Text = string.Empty;

            CanvasLoadData.Background= new SolidColorBrush(Colors.LightCoral);

            _modelImplemention.LoadTrainingDataFromFile(
                trainingDataAbsolutePath: ModelSettings.TrainingData,
                trainingDataHasHeaders: ModelSettings.TrainingDataHasHeaders);

            if (_modelImplemention.Ready)
            {
                ShowMessageAlert(_modelImplemention.FailureInformation);
                TxtblockLoadInformation.Text = _modelImplemention.FailureInformation;
            }

        }

        private void ShowMessageAlert(string modelImplementionFailureInformation)
        {
            MessageBox.Show(
                messageBoxText: modelImplementionFailureInformation,
                caption: @"Model Demonstrator Failure",
                button: MessageBoxButton.OK,
                icon: MessageBoxImage.Error);
        }
    }
}
