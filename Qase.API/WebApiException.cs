using System;

namespace Qase.API
{
  public class WebApiException : Exception
  {
    public WebApiException()
    {
    }

    public WebApiException(Exception innerException) : base(innerException.Message, innerException)
    {
    }

    public WebApiException(string message, Exception innerException) : base(message, innerException)
    {
    }
  }
}
