using FluentAssertions;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Ci.Result.Test
{
    [TestClass]
    public class CiResultUnitTest
    {
        [TestMethod]
        public void ResultInitStatusShouldBeFail()
        {
            var result = new CiResult();

            result.Status.Should().Be(CiStatus.Failure);
        }

        [TestMethod]
        public void ResultStatusSettingShouldBeConsistent()
        {
            var result = new CiResult() { Status = CiStatus.Duplicate };

            result.Status.Should().Be(CiStatus.Duplicate);
        }

        [TestMethod]
        public void ResultPayloadInitShouldBeNull()
        {
            var result = new CiResult<string>();

            result.Payload.Should().BeNull();
        }

        [TestMethod]
        public void ResultPayloadTypeShouldBeConsistent()
        {
            var result = new CiResult<string>() { Payload = "" };

            result.Payload.GetType().Should().Be(typeof(string));
        }
    }
}
