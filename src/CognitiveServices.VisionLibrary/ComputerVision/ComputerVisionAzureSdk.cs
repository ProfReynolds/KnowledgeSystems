using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision;
using Microsoft.Azure.CognitiveServices.Vision.ComputerVision.Models;

/*
 * ProfReynolds
 * Computer Vision Quick Start Tutorial
 * https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/
 */

namespace CognitiveServices.VisionLibrary.ComputerVision
{
    public class ComputerVisionAzureSdk : ComputerVisionApi
    {
        public override async Task<GetVisualFeaturesStringResponse> GetVisualFeatures(CognitiveServicesRequest request)
        {
            var response = new GetVisualFeaturesStringResponse();

            try
            {
                var apiKeyServiceClientCredentials = new ApiKeyServiceClientCredentials(request.EndPointKey1);
                var delegatingHandlers = new System.Net.Http.DelegatingHandler[] { };

                IComputerVisionClient computerVision = new ComputerVisionClient(
                    credentials: apiKeyServiceClientCredentials,
                    handlers: delegatingHandlers)
                {
                    Endpoint = request.EndPoint
                };

                IList<VisualFeatureTypes> features = new List<VisualFeatureTypes>()
                    {
                        VisualFeatureTypes.ImageType,
                        VisualFeatureTypes.Faces,
                        VisualFeatureTypes.Adult,
                        VisualFeatureTypes.Categories,
                        VisualFeatureTypes.Color,
                        VisualFeatureTypes.Tags,
                        VisualFeatureTypes.Description,
                        VisualFeatureTypes.Objects,
                    };

                var imageAnalysis = await computerVision.AnalyzeImageInStreamAsync(
                        image: request.ImageStream,
                        visualFeatures: features);

                var visualFeaturesTemp = new StringBuilder();

                visualFeaturesTemp.AppendLine("Description - Captions");
                foreach (var item in imageAnalysis.Description.Captions)
                {
                    visualFeaturesTemp.AppendLine($"{item.Text} ({item.Confidence})");
                }

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Description - Tags");
                visualFeaturesTemp.AppendLine(string.Join(", ", imageAnalysis.Description.Tags));

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Adult / Racy Content");
                visualFeaturesTemp.AppendLine($"({imageAnalysis.Adult.AdultScore}) , ({imageAnalysis.Adult.RacyScore})");

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Categories - name, score, detail");
                foreach (var item in imageAnalysis.Categories)
                {
                    visualFeaturesTemp.AppendLine($"{item.Name} ({item.Score})");
                    visualFeaturesTemp.AppendLine($"{item.Detail}");
                }

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Color");
                visualFeaturesTemp.AppendLine($"{imageAnalysis.Color}");

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Faces - Age, Gender");
                foreach (var item in imageAnalysis.Faces)
                {
                    visualFeaturesTemp.AppendLine($"{item.Age} {item.Gender}");
                }

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Image Type - ClipArtType, LineDrawingType");
                visualFeaturesTemp.AppendLine($"{imageAnalysis.ImageType.ClipArtType} {imageAnalysis.ImageType.LineDrawingType}");

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Objects");
                foreach (var item in imageAnalysis.Objects)
                {
                    visualFeaturesTemp.AppendLine($"{item.ObjectProperty} ({item.Confidence})");
                }

                visualFeaturesTemp.AppendLine("");
                visualFeaturesTemp.AppendLine("Tags - Name, Confidence, Hint");
                foreach (var item in imageAnalysis.Tags)
                {
                    visualFeaturesTemp.AppendLine($"{item.Name} ({item.Confidence})");
                    visualFeaturesTemp.AppendLine($"{item.Hint}");
                }


                response.VisualFeatures = visualFeaturesTemp.ToString();
                response.Success = true;

            }
            catch (Exception e)
            {
                response.FailureInformation = e.Message;
            }

            return response;
        }

        public override async Task<PerformOcrStringResponse> PerformOcr(CognitiveServicesRequest request)
        {
            var response = new PerformOcrStringResponse();

            try
            {
                var apiKeyServiceClientCredentials = new ApiKeyServiceClientCredentials(request.EndPointKey1);
                var delegatingHandlers = new System.Net.Http.DelegatingHandler[] { };

                IComputerVisionClient computerVision = new ComputerVisionClient(
                    credentials: apiKeyServiceClientCredentials,
                    handlers: delegatingHandlers)
                {
                    Endpoint = request.EndPoint
                };

                var contentString = await computerVision.RecognizePrintedTextInStreamAsync(
                    image: request.ImageStream,
                    detectOrientation: false,
                    language: OcrLanguages.En,
                    cancellationToken: CancellationToken.None);

                var resultsLinesFound = new List<string>();
                var resultsWordsFound = new List<string>();

                foreach (OcrRegion region in contentString.Regions)
                    foreach (OcrLine line in region.Lines)
                    {
                        var words = line.Words.Select(word => word.Text).ToList();

                        resultsWordsFound.AddRange(words);

                        if (words.Count > 0)
                            resultsLinesFound.Add(string.Join<string>(" ", words));
                    }

                var wordGrouping =
                    from word in resultsWordsFound
                    group word by word
                    into g
                    select new { InstanceFound = g.Key, Word = g };

                var groupedWordsFound = wordGrouping
                    .Select(item => new PerformOcrWordInstance
                    {
                        Word = item.Word.Key,
                        Instances = item.Word.Count()
                    });

                response.LinesFound = resultsLinesFound;
                response.WordsFound = groupedWordsFound.ToList();
                response.Success = true;

            }
            catch (Exception e)
            {
                response.FailureInformation = e.Message;
            }

            return response;
        }

        public override async Task<GetThumbnailResponse> GetThumbnail(GetThumbnailRequest request)
        {
            var response = new GetThumbnailResponse();

            try
            {
                var apiKeyServiceClientCredentials = new ApiKeyServiceClientCredentials(request.EndPointKey1);
                var delegatingHandlers = new System.Net.Http.DelegatingHandler[] { };

                IComputerVisionClient computerVision = new ComputerVisionClient(
                    credentials: apiKeyServiceClientCredentials,
                    handlers: delegatingHandlers)
                {
                    Endpoint = request.EndPoint
                };

                response.Thumbnail = await computerVision.GenerateThumbnailInStreamAsync(
                    image: request.ImageStream,
                    width: request.ThumbnailSize.Width,
                    height: request.ThumbnailSize.Height,
                    smartCropping: request.ThumbnailSize.SmartCropping);

                response.Success = true;
            }
            catch (Exception e)
            {
                response.FailureInformation = e.Message;
            }

            return response;
        }

    }
}
