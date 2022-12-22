using UtmBuilder.Core.ValueObjects;

namespace UtmBuilder.Core
{
  public static class Program
  {
    public static void Main()
    {
      var url = new Url("https://go.io.com");
      var campaign = new Campaign("sourceX", "medium", "named");
      var utm = new Utm(url, campaign);
      Console.WriteLine(utm);
    }
  }
}