using System;
using System.Collections.Generic;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using CognitiveServices.VisionLibrary.ComputerVision;

namespace CognitiveServices.VisionLibrary
{
    public class CognitiveServicesRestHttpClient
    {
        public async Task<CognitiveServicesStringResponse> GetRestHttpStringResponse(CognitiveServicesRequest request)
        {
            var response = new CognitiveServicesStringResponse();

            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", request.EndPointKey1);

                // Assemble the URI for the REST API method.
                var uri = request.EndPoint + request.EndPointExtension + "?" + request.RestRequestParameters;

                // Read the contents of the specified local image into a byte array.
                byte[] photoBytes = new byte[request.ImageStream.Length];
                request.ImageStream.Read(photoBytes, 0, photoBytes.Length);

                // Add the byte array as an octet stream to the request body.
                using (var byteArrayContent = new ByteArrayContent(photoBytes))
                {
                    // This example uses the "application/octet-stream" content type.
                    // The other content types you can use are "application/json"
                    // and "multipart/form-data".
                    byteArrayContent.Headers.ContentType =
                        new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    // Asynchronously call the REST API method.
                    var responseMessage = await httpClient.PostAsync(uri, byteArrayContent);

                    response.RestResponse = await responseMessage.Content.ReadAsStringAsync();

                    response.Success = true;
                }
            }
            catch (Exception e)
            {
                response.FailureInformation = e.Message;
            }

            return response;
        }

        public async Task<CognitiveServicesStreamResponse> GetRestHttpStreamResponse(CognitiveServicesRequest request)
        {
            var response = new CognitiveServicesStreamResponse();

            try
            {
                var httpClient = new HttpClient();
                httpClient.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", request.EndPointKey1);

                var uri = request.EndPoint + request.EndPointExtension + "?" + request.RestRequestParameters;

                byte[] photoBytes = new byte[request.ImageStream.Length];
                request.ImageStream.Read(photoBytes, 0, photoBytes.Length);

                using (var byteArrayContent = new ByteArrayContent(photoBytes))
                {
                    byteArrayContent.Headers.ContentType =
                        new System.Net.Http.Headers.MediaTypeHeaderValue("application/octet-stream");

                    var responseMessage = await httpClient.PostAsync(uri, byteArrayContent);

                    var readAsByteArrayAsync = await responseMessage.Content.ReadAsByteArrayAsync();

                    response.RestResponse = new MemoryStream(readAsByteArrayAsync);

                    response.Success = true;
                }
            }
            catch (Exception e)
            {
                response.FailureInformation = e.Message;
            }

            return response;
        }
    }
}
