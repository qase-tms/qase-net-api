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
    readonly string _api_token = "757aa920165d8f4fff32f179bc4abe0d93268200";

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

    public async Task<SpecificProjectResponse> GetSpecificProjectAsync(string code)
    {
      return await _api.GetSpecificProject(_api_token, code);
    }

    public async Task<CreateProjectResponse> CreateNewProjectAsync(CreateProjectRequest createProjectRequest)
    {
      return await _api.CreateNewProject(_api_token, createProjectRequest);
    }
  }
}
