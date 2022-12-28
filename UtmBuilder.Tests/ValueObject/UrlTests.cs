using System.Data;
using UtmBuilder.Core.ValueObjects;
using UtmBuilder.Core.ValueObjects.Exceptions;

namespace UtmBuilder.Tests.ValueObject
{
  [TestClass]
  public class UrlTests
  {
    private const string INVALID_URL = "";

    private const string VALID_URL = "https://google.com";

    [TestMethod("Deve lançar uma exception quando url estiver inválida")]
    [TestCategory("Test URL")]
    [ExpectedException(typeof(InvalidUrlException))]
    public void ShouldThrowAnInvalidUrlExceptionWhenInvalidUrlWasSend()
    {
      new Url(INVALID_URL);
    }

    [TestMethod("Deve lançar uma exception quando url estiver inválida apenas um segundo exemplo")]
    [TestCategory("Test URL")]
    [ExpectedException(typeof(InvalidUrlException))]
    [DataRow("")]
    [DataRow("asda")]
    [DataRow("http;a;dal")]
    [DataRow("12312dasd")]
    [DataRow("dw39012j901")]
    public void ShouldThrowAnInvalidUrlExceptionWhenInvalidUrlWasSend(String link)
    {
      new Url(link);
    }

    [TestMethod("Não deve lançar uma exception quando url estiver válida")]
    [TestCategory("Test URL")]
    public void ShouldNOTThrowAnExceptionWhenValidURLWasSend()
    {
      _ = new Url(VALID_URL);
      Assert.IsTrue(true);
    }
  }
}