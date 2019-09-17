using System.IO;

namespace CognitiveServices.VisionLibrary
{
    public class CognitiveServicesRequest
    {
        public string EndPointKey1 { get; set; }
        public string EndPoint { get; set; }
        public Stream ImageStream { get; set; }
        public string EndPointExtension { get; set; }
        public string RestRequestParameters { get; set; }
    }

    public class CognitiveServicesStringResponse :
        CommonFramework.Library.ContractsBaseResponseClass
    {
        public string RestResponse { get; set; }
    }

    public class CognitiveServicesStreamResponse :
        CommonFramework.Library.ContractsBaseResponseClass
    {
        public Stream RestResponse { get; set; }
    }
}