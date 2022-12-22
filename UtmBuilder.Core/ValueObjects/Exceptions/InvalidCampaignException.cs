namespace UtmBuilder.Core.ValueObjects.Exceptions
{
  public class InvalidCampaignException : Exception
  {
    private const string DEFAULT_ERROR_MESSAGE = "Invalid UTM parameters";

    public InvalidCampaignException() : base()
    {
    }

    public InvalidCampaignException(string message = DEFAULT_ERROR_MESSAGE) : base(message)
    {
    }

    public InvalidCampaignException(string? message, Exception? innerException) : base(message, innerException)
    {
    }

    public static void ThrowIfNull(string? item, string message = DEFAULT_ERROR_MESSAGE)
    {
      if (string.IsNullOrWhiteSpace(item))
      {
        throw new InvalidCampaignException(message);
      }
    }
  }
}