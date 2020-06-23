using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
using Qase.API.Qase.Model.TestCases;
using Qase.API.Qase.Model.TestRuns;
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

    //Projects

    public async Task<ProjectsResponse> GetAllProjectsAsync(int limit = 100, int offset = 0)
    {
      return await _api.GetAllProjects(_api_token, limit, offset);
    }

    public async Task<SpecificProjectResponse> GetSpecificProjectAsync(string code)
    {
      return await _api.GetSpecificProject(_api_token, code);
    }

    public async Task<CreateProjectResponse> CreateNewProjectAsync(CreateProjectRequest createProjectRequest)
    {
      return await _api.CreateNewProject(_api_token, createProjectRequest);
    }

    //Test cases

    public async Task<TestCasesResponse> GetAllTestCasesAsync(string code, int limit = 100, int offset = 0)
    {
      return await _api.GetAllTestCases(_api_token, code, limit, offset);
    }

    public async Task<SpecificTestCaseResponse> GetSpecificTestCaseAsync(string code, int id)
    {
      return await _api.GetSpecificTestCase(_api_token, code, id);
    }

    public async Task<BaseResponse> DeleteTestCaseAsync(string code, int id)
    {
      return await _api.DeleteTestCase(_api_token, code, id);
    }

    //Test runs
    public async Task<TestRunsResponse> GetAllTestRunsAsync(string code, int limit = 100, int offset = 0)
    {
      return await _api.GetAllTestRuns(_api_token, code, limit, offset);
    }

    public async Task<SpecificTestRunResponse> GetSpecificTestRunAsync(string code, int id)
    {
      return await _api.GetSpecificTestRun(_api_token, code, id);
    }

    public async Task<TestRunResponse> CreateNewTestRunAsync(string code, CreateTestRunRequest createTestRunRequest)
    {
      return await _api.CreateNewTestRun(_api_token, code, createTestRunRequest);
    }

    public async Task<TestRunResponse> DeleteTestRunAsync(string code, int id)
    {
      return await _api.DeleteTestRun(_api_token, code, id);
    }
  }
}
