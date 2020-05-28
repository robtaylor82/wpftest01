using NUnit.Framework;
using WpfTest01.Business.Service;

namespace WpfTest01.Test
{
    [TestFixture]
    public class SearchServiceTest
    {
        [Test]
        public void CallingSearchReturnsSomeResultsTest()
        {
            var testTarget = new SearchService();

            var actual = testTarget.Search("test name");

            Assert.IsTrue(actual.Count > 0);
        }
    }
}