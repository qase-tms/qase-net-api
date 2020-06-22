using Qase.API.Qase.Model.Projects;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Qase.API.Qase
{
  public class QaseAPI
  {
    readonly string _apiUrl = "https://api.qase.io/v1";
    readonly IQaseServiceWebApi _api;
    readonly string _api_token = "";

    public QaseAPI()
    {
      _api = QaseServiceWebApiFactory.CreateWebApi(_apiUrl);
    }

    public QaseAPI(string url, string api_token)
    {
      _apiUrl = url;
      _api_token = api_token;
      _api = QaseServiceWebApiFactory.CreateWebApi(_apiUrl);
    }

    public async Task<ProjectsResponse> GetAllProjectsAsync()
    {
      return await _api.GetAllProjects(_api_token);
    }
  }
}
