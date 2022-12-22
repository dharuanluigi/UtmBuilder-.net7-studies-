using System.Text.RegularExpressions;

namespace UtmBuilder.Core.ValueObjects.Exceptions
{
  public partial class InvalidUrlException : Exception
  {
    private const string DEFAULT_ERROR_MESSAGE = "Invalid Url";

    public InvalidUrlException(string message = DEFAULT_ERROR_MESSAGE) : base(message)
    {
    }

    public InvalidUrlException() : base()
    {
    }

    public InvalidUrlException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public static void ThrowsIfInvalid(string address, string message = DEFAULT_ERROR_MESSAGE)
    {
      if (string.IsNullOrWhiteSpace(address))
      {
        throw new InvalidUrlException(message);
      }

      if (!UrlRegex().IsMatch(address))
      {
        throw new InvalidUrlException(message);
      }
    }

    [GeneratedRegex("^(http|https):(\\/\\/www\\.|\\/\\/www\\.|\\/\\/|\\/\\/)[a-z0-9]+([\\-\\.]{1}[a-z0-9]+)*\\.[a-z]{2,5}(:[0-9]{1,5})?(\\/.*)?$|(http|https):(\\/\\/localhost:\\d*|\\/\\/127\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5])\\.([0-9]|[1-9][0-9]|1[0-9][0-9]|2[0-4][0-9]|25[0-5]))(:[0-9]{1,5})?(\\/.*)?$")]
    private static partial Regex UrlRegex();
  }
}