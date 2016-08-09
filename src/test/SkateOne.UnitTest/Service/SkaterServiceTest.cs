using System.Collections.Generic;
using Moq;
using SkateOne.Data;
using SkateOne.Domain;
using SkateOne.Service;
using Xunit;

namespace SkateOne.UnitTest.Service
{
    public class SkaterServiceTest
    {
        private readonly Mock<ISkaterData> skaterDataMock;
        private readonly SkaterService sut;
        
        public SkaterServiceTest()
        {
            skaterDataMock = new Mock<ISkaterData>();
            skaterDataMock.Setup(s => s.GetAll()).Returns(new List<Skater>{ new Skater() });
            sut = new SkaterService(skaterDataMock.Object);
        }
        
        [Fact]
        public void GetAllSuccess()
        {
            var result = sut.GetAll();

            Assert.NotEmpty(result);

            skaterDataMock.Verify();
        }
    }
}
