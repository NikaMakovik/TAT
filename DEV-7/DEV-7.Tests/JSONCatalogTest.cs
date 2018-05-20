using Xunit;

namespace DEV_7.Tests
{
    public class JSONCatalogTest
    {
        JSONCatalog jsonCatalog = new JSONCatalog();
        [Fact]
        public void DeserializatorTest()
        {
            string str = jsonCatalog.Deserializator();
            Assert.Equal("BMW X5", str);
        }
    }
}
