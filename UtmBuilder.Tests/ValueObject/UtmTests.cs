using UtmBuilder.Core;
using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Tests.ValueObject
{
  [TestClass]
  public class UtmTests
  {
    [TestMethod]
    public void ShouldReturnUrlFromUtm()
    {
      var url = new Url("https://google.com/");
      var cmp = new Campaign("src", "med", "name", "id", "term", "content");
      var utm = new Utm(url, cmp);
      const string result = "https://google.com/?utm_source=src&utm_medium=med&utm_campaign=name&utm_id=id&utm_term=term&utm_content=content";
      Assert.AreEqual(result, utm.ToString());
    }

    [TestMethod]
    public void ShouldReturnUtmFromUrl()
    {
      const string result = "https://google.com/?utm_source=src&utm_medium=med&utm_campaign=name&utm_id=id&utm_term=term&utm_content=content";
      Utm utm = result;
      Assert.AreEqual("https://google.com/", utm.Url.Address);
      Assert.AreEqual("src", utm.Campaign.Source);
      Assert.AreEqual("med", utm.Campaign.Medium);
      Assert.AreEqual("name", utm.Campaign.Name);
      Assert.AreEqual("id", utm.Campaign.Id);
      Assert.AreEqual("term", utm.Campaign.Term);
      Assert.AreEqual("content", utm.Campaign.Content);
    }
  }
}