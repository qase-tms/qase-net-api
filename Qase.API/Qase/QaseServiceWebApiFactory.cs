using Refit;

namespace Qase.API.Qase
{
  public static class QaseServiceWebApiFactory
  {
    public static IQaseServiceWebApi CreateWebApi(string serverUrl)
    {
      return RestService.For<IQaseServiceWebApi>(serverUrl, new RefitSettings
      {
        HttpMessageHandlerFactory = () => new WebApiHandler(loggingEnabled: true)
      });
    }
  }
}
