using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Threading.Tasks;

/*
 * ProfReynolds
 * Computer Vision Quick Start Tutorial
 * https://docs.microsoft.com/en-us/azure/cognitive-services/computer-vision/
 */

namespace CognitiveServices.VisionLibrary.ComputerVision
{
    public class ComputerVisionHttpClient : ComputerVisionApi
    {
        public override async Task<GetVisualFeaturesStringResponse> GetVisualFeatures(CognitiveServicesRequest request)
        {
            var cognitiveServicesRestHttpClient = new CognitiveServicesRestHttpClient();
            var restHttpResponse = await cognitiveServicesRestHttpClient.GetRestHttpStringResponse(request);
            var getVisualFeaturesResponse = new GetVisualFeaturesStringResponse
            {
                Success = restHttpResponse.Success,
                ImplementedInModule = restHttpResponse.ImplementedInModule,
                FailureInformation = restHttpResponse.FailureInformation,
                VisualFeatures =
                    CommonFramework.Library.Helpers.JsonHelpers.JsonPrettyPrint(restHttpResponse.RestResponse),
            };
            return getVisualFeaturesResponse;
        }

        public override async Task<PerformOcrStringResponse> PerformOcr(CognitiveServicesRequest request)
        {
            var cognitiveServicesRestHttpClient = new CognitiveServicesRestHttpClient();
            var restHttpResponse = await cognitiveServicesRestHttpClient.GetRestHttpStringResponse(request);
            var performOcrResponse = new PerformOcrStringResponse
            {
                Success = restHttpResponse.Success,
                ImplementedInModule = restHttpResponse.ImplementedInModule,
                FailureInformation = restHttpResponse.FailureInformation,
                // LinesFound = new List<string>(),
                // WordsFound = new List<PerformOcrWordInstance>(),
            };
            performOcrResponse.LinesFound.Add(CommonFramework.Library.Helpers.JsonHelpers.JsonPrettyPrint(restHttpResponse.RestResponse));

            return performOcrResponse;
        }

        public override async Task<GetThumbnailResponse> GetThumbnail(GetThumbnailRequest request)
        {
            var cognitiveServicesRestHttpClient = new CognitiveServicesRestHttpClient();
            var restHttpResponse = await cognitiveServicesRestHttpClient.GetRestHttpStreamResponse(request);
            var servicesStreamResponseApi = new GetThumbnailResponse
            {
                Success = restHttpResponse.Success,
                ImplementedInModule = restHttpResponse.ImplementedInModule,
                FailureInformation = restHttpResponse.FailureInformation,
                Thumbnail = restHttpResponse.RestResponse,
            };

            return servicesStreamResponseApi;
        }

    }
}
