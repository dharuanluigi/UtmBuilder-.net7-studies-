using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObject
{
  [TestClass]
  public class CampaignTests
  {

    [TestMethod]
    [DataRow("", "", "", true)]
    [DataRow("asda", "", "", true)]
    [DataRow("asdas", "asd", "", true)]
    [DataRow("asda", "asdas", "asd", false)]
    public void TestCampaign(string source, string medium, string name, bool expectException)
    {
      if (expectException)
      {
        try
        {
          _ = new Campaign(source, medium, name);
          Assert.Fail();
        }
        catch (InvalidCampaignException)
        {
          Assert.IsTrue(true);
        }
      }
      else
      {
        _ = new Campaign(source, medium, name);
        Assert.IsTrue(true);
      }
    }

  }
}