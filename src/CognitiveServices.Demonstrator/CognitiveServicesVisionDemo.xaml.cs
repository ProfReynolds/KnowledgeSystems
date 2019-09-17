using System;
using System.Collections.Generic;
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
using CommonFramework.Library;
using CognitiveServices.VisionLibrary;
using CognitiveServices.VisionLibrary.ComputerVision;
using Microsoft.Win32;


namespace Knowledge.Demonstrator
{
    /// <summary>
    /// Interaction logic for CognitiveServicesVisionDemo.xaml
    /// </summary>
    public partial class CognitiveServicesVisionDemo : Window
    {
        public CognitiveServicesVisionDemo()
        {
            InitializeComponent();
        }

        private string _validatedImageFileLocation = string.Empty;
        private ComputerVisionApi _computerVisionApi;

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            _validatedImageFileLocation = Properties.Settings.Default.PreviousImagePath;
            LblImageFileLocation.Content = _validatedImageFileLocation;
        }

        private void BtnSelectImage_Click(object sender, RoutedEventArgs e)
        {
            var openFileDialog1 = new OpenFileDialog
            {
                Filter =
                    "All Images Files (*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif)|*.png;*.jpeg;*.gif;*.jpg;*.bmp;*.tiff;*.tif" +
                    "|PNG Portable Network Graphics (*.png)|*.png" +
                    "|JPEG File Interchange Format (*.jpg *.jpeg *jfif)|*.jpg;*.jpeg;*.jfif" +
                    "|BMP Windows Bitmap (*.bmp)|*.bmp" +
                    "|TIF Tagged Imaged File Format (*.tif *.tiff)|*.tif;*.tiff" +
                    "|GIF Graphics Interchange Format (*.gif)|*.gif",
                Title = "Select Image to Utilize",
                //FileName = Properties.Settings.Default.PreviousImagePath
            };

            // Notice: if DialogResult is not OK, the process is short-circuited
            if (openFileDialog1.ShowDialog() != true) return;

            _validatedImageFileLocation = openFileDialog1.FileName;
            this.LblImageFileLocation.Content = _validatedImageFileLocation;
            Properties.Settings.Default.PreviousImagePath = _validatedImageFileLocation;
            Properties.Settings.Default.Save();
        }

        private void RadioInterface_Checked(object sender, RoutedEventArgs e)
        {
            void UiEnabledStatus(bool setAllEnabled)
            {
                BtnGetVisualFeatures.IsEnabled = setAllEnabled;
                BtnRunOcr.IsEnabled = setAllEnabled;
                BtnGetThumbnail.IsEnabled = setAllEnabled;
            }

            UiEnabledStatus(false);

            if (!(sender is RadioButton azureInterface)) return;

            if (!(azureInterface?.IsChecked ?? false)) return;

            switch (azureInterface.Name)
            {
                case "RadioAzureSdk":
                    _computerVisionApi = new ComputerVisionAzureSdk();
                    UiEnabledStatus(true);
                    break;
                case "RadioHttpClient":
                    _computerVisionApi = new ComputerVisionHttpClient();
                    UiEnabledStatus(true);
                    break;
                case "RadioProjectOxford":
                    _computerVisionApi = null;
                    UiEnabledStatus(false);
                    break;
                default:
                    _computerVisionApi = null;
                    break;
            }
        }

        private async void BtnGetVisualFeatures_Click(object sender, RoutedEventArgs e)
        {
            TxtCognitiveServicesAnalysisResponse.Text = string.Empty;

            if (!System.IO.File.Exists(_validatedImageFileLocation)) return;

            if (_computerVisionApi == null) return;

            var imageStream = CommonFramework.Library.Helpers.ImagesHelpers.GetImagesAsStream(_validatedImageFileLocation);

            var request = new CognitiveServicesRequest
            {
                EndPointKey1 = Properties.Settings.Default.EndPointKey1,
                EndPoint = Properties.Settings.Default.EndPoint,
                ImageStream = imageStream,
                EndPointExtension = "/vision/v2.0/analyze",
                RestRequestParameters = "visualFeatures=Categories,Tags,Description,Faces,ImageType,Color,Adult&details=Celebrities,Landmarks&language=en",
            };

            var response = await _computerVisionApi.GetVisualFeatures(request);

            TxtCognitiveServicesAnalysisResponse.Text = response.Success
                ? response.VisualFeatures
                : response.FailureInformation;
        }

        private async void BtnRunOcr_Click(object sender, RoutedEventArgs e)
        {
            TxtCognitiveServicesAnalysisResponse.Text = string.Empty;

            if (!System.IO.File.Exists(_validatedImageFileLocation)) return;

            if (_computerVisionApi == null) return;

            var imageStream = CommonFramework.Library.Helpers.ImagesHelpers.GetImagesAsStream(_validatedImageFileLocation);

            var request = new CognitiveServicesRequest
            {
                EndPointKey1 = Properties.Settings.Default.EndPointKey1,
                EndPoint = Properties.Settings.Default.EndPoint,
                ImageStream = imageStream,
                EndPointExtension = "/vision/v2.0/ocr",
                RestRequestParameters = "language=unk&detectOrientation=true",
            };

            var response = await _computerVisionApi.PerformOcr(request);

            if (response.Success)
            {
                var output = new StringBuilder();

                foreach (var word in response.WordsFound)
                {
                    output.AppendLine($"{word.Word}     ---     {word.Instances}");
                }

                output.AppendLine();
                output.AppendLine("=============================================");
                output.AppendLine();

                output.AppendLine(string.Join("\n", response.LinesFound));

                TxtCognitiveServicesAnalysisResponse.Text = output.ToString();
            }
            else
            {
                TxtCognitiveServicesAnalysisResponse.Text = response.FailureInformation;
            }
        }

        private async void BtnGetFacialFeatures_Click(object sender, RoutedEventArgs e)
        {
            TxtCognitiveServicesAnalysisResponse.Text = string.Empty;

            if (!System.IO.File.Exists(_validatedImageFileLocation)) return;

            var httpClient = new CognitiveServicesRestHttpClient();

            var imageStream = CommonFramework.Library.Helpers.ImagesHelpers.GetImagesAsStream(_validatedImageFileLocation);

            var request = new CognitiveServicesRequest
            {
                EndPointKey1 = Properties.Settings.Default.EndPointKey1,
                EndPoint = Properties.Settings.Default.EndPoint,
                ImageStream = imageStream,
                EndPointExtension = "/face/v1.0/detect",
                RestRequestParameters = "returnFaceId=true&returnFaceLandmarks=false" +
                                        "&returnFaceAttributes=age,gender,headPose,smile,facialHair,glasses," +
                                        "emotion,hair,makeup,occlusion,accessories,blur,exposure,noise",
            };

            // ReSharper disable once PossibleNullReferenceException

            var response = await httpClient.GetRestHttpStringResponse(request);
            var visualFeatures = CommonFramework.Library.Helpers.JsonHelpers.JsonPrettyPrint(response.RestResponse);

            TxtCognitiveServicesAnalysisResponse.Text = response.Success
                ? visualFeatures
                : response.FailureInformation;
        }

        private async void BtnGetThumbnail_Click(object sender, RoutedEventArgs e)
        {
            if (!System.IO.File.Exists(_validatedImageFileLocation)) return;

            if (_computerVisionApi == null) return;

            var imageStream = CommonFramework.Library.Helpers.ImagesHelpers.GetImagesAsStream(_validatedImageFileLocation);

            var width = TxtWidth.Text.ToInt();
            var height = TxtHeight.Text.ToInt();
            var request = new GetThumbnailRequest()
            {
                EndPointKey1 = Properties.Settings.Default.EndPointKey1,
                EndPoint = Properties.Settings.Default.EndPoint,
                ImageStream = imageStream,
                EndPointExtension = "/vision/v2.0/generateThumbnail",
                RestRequestParameters =
                    $"width={width}&height={height}&smartCropping={CheckSmartCropping.IsChecked ?? false}",
                ThumbnailSize = (Width: width, Height: height, SmartCropping: CheckSmartCropping.IsChecked ?? false),
            };

            var response = await _computerVisionApi.GetThumbnail(request);

            var imageSource = new BitmapImage();
            imageSource.BeginInit();
            imageSource.StreamSource = response.Thumbnail;
            imageSource.EndInit();

            ImageThumbnail.Source = response.Success
                ? imageSource
                : null;
        }

    }
}
