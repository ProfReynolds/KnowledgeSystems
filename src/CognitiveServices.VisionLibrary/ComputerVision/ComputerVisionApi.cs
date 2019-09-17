using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CognitiveServices.VisionLibrary.ComputerVision
{
    public class GetVisualFeaturesStringResponse : CognitiveServicesStringResponse
    {
        public string VisualFeatures { get; set; }
    }

    public class GetThumbnailRequest : CognitiveServicesRequest
    {
        public (int Width, int Height, bool SmartCropping) ThumbnailSize { get; set; }
    }

    public class GetThumbnailResponse : CognitiveServicesStringResponse
    {
        public Stream Thumbnail = null;
    }

    public class PerformOcrWordInstance
    {
        public string Word { get; set; }
        public int Instances { get; set; }
    }

    public class PerformOcrStringResponse : CognitiveServicesStringResponse
    {
        public IList<string> LinesFound { get; set; } = new List<string>();
        public IList<PerformOcrWordInstance> WordsFound { get; set; } = new List<PerformOcrWordInstance>();
    }

    public abstract class ComputerVisionApi
    {
        public abstract Task<GetVisualFeaturesStringResponse> GetVisualFeatures(CognitiveServicesRequest request);
        public abstract Task<PerformOcrStringResponse> PerformOcr(CognitiveServicesRequest request);
        public abstract Task<GetThumbnailResponse> GetThumbnail(GetThumbnailRequest request);
    }
}
