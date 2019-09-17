using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using CognitiveServices.VisionLibrary;
using CognitiveServices.VisionLibrary.ComputerVision;
using NUnit.Framework;
using Shouldly;
#pragma warning disable 1998 // suppresses warning about the async

namespace Knowledge.CognitiveServicesVision.Tests
{
    [TestFixture]
    public class ComputerVisionApiTests
    {
        class AbstractClassTestInstance : ComputerVisionApi
        {
            public override async Task<GetVisualFeaturesStringResponse> GetVisualFeatures(CognitiveServicesRequest request)
            {
                throw new System.NotImplementedException();
            }

            public override async Task<GetThumbnailResponse> GetThumbnail(GetThumbnailRequest request)
            {
                throw new System.NotImplementedException();
            }

            public override async Task<PerformOcrStringResponse> PerformOcr(CognitiveServicesRequest request)
            {
                throw new System.NotImplementedException();
            }
        }

        private AbstractClassTestInstance _abstractClassTestInstance;

        [OneTimeSetUp]
        public void TestInitializer()
        {
            _abstractClassTestInstance = new AbstractClassTestInstance();
        }

        [Test]
        public void TestMethod1()
        {
            _abstractClassTestInstance.ShouldNotBeNull();
        }
    }
}
