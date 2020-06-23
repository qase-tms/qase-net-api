using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
using Qase.API.Qase.Model.TestCases;
using Qase.API.Qase.Model.TestRuns;
using Refit;
using System.Threading.Tasks;

namespace Qase.API.Qase
{
  public interface IQaseServiceWebApi
  {
    /// <summary>
    /// Get All Projects
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/project?limit={limit}&offset={offset}")]
    Task<ProjectsResponse> GetAllProjects([Header("Token")] string api_token, int limit, int offset);

    /// <summary>
    /// Get a Specific Project
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <returns></returns>
    [Get("/project/{code}")]
    Task<SpecificProjectResponse> GetSpecificProject([Header("Token")] string api_token, string code);

    /// <summary>
    /// Create a new project
    /// </summary>
    /// <param name="projectRequest"></param>
    /// <returns></returns>
    [Post("/project")]
    Task<CreateProjectResponse> CreateNewProject([Header("Token")] string api_token, CreateProjectRequest createProjectRequest);

    /// <summary>
    /// Get all test cases
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/case/{code}?limit={limit}&offset={offset}")]
    Task<TestCasesResponse> GetAllTestCases([Header("Token")] string api_token, string code, int limit, int offset);

    /// <summary>
    /// Get a specific test case
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/case/{code}/{id}")]
    Task<SpecificTestCaseResponse> GetSpecificTestCase([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Delete test case
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/case/{code}/{id}")]
    Task<BaseResponse> DeleteTestCase([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Get all test runs
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/run/{code}?limit={limit}&offset={offset}")]
    Task<TestRunsResponse> GetAllTestRuns([Header("Token")] string api_token, string code, int limit, int offset);

    /// <summary>
    /// Get a specific test run
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/run/{code}/{id}")]
    Task<SpecificTestRunResponse> GetSpecificTestRun([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Create a new test run
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="createTestRunRequest"></param>
    /// <returns></returns>
    [Post("/run/{code}")]
    Task<TestRunResponse> CreateNewTestRun([Header("Token")] string api_token, string code, CreateTestRunRequest createTestRunRequest);

    /// <summary>
    /// Delete test run
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/run/{code}/{id}")]
    Task<TestRunResponse> DeleteTestRun([Header("Token")] string api_token, string code, int id);
  }
}
