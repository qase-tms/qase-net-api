using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
using Qase.API.Qase.Model.Suites;
using Qase.API.Qase.Model.TestCases;
using Qase.API.Qase.Model.TestRunResults;
using Qase.API.Qase.Model.TestRuns;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Qase.API.Qase
{
  public class QaseAPI
  {
    readonly string _apiUrl;
    readonly IQaseServiceWebApi _api;
    readonly string _api_token;

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

    #region Projects
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
    #endregion

    #region Test cases
    public async Task<TestCasesResponse> GetAllTestCasesAsync(string code, BaseFilter filterCases)
    {
      return await _api.GetAllTestCases(_api_token, code, filterCases.limit, filterCases.offset, filterCases.DictionaryFilters);
    }

    public async Task<SpecificTestCaseResponse> GetSpecificTestCaseAsync(string code, int id)
    {
      return await _api.GetSpecificTestCase(_api_token, code, id);
    }

    public async Task<BaseResponse> DeleteTestCaseAsync(string code, int id)
    {
      return await _api.DeleteTestCase(_api_token, code, id);
    }
    #endregion

    #region Test runs
    public async Task<TestRunsResponse> GetAllTestRunsAsync(string code, BaseFilter filterTestRun)
    {
      return await _api.GetAllTestRuns(_api_token, code, filterTestRun.limit, filterTestRun.offset, filterTestRun.DictionaryFilters);
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
    #endregion

    #region Test run results
    public async Task<TestRunResultsResponse> GetAllTestRunResultsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllTestRunResults(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificTestRunResultResponse> GetSpecificTestRunResultAsync(string code, string hash)
    {
      return await _api.GetSpecificTestRunResult(_api_token, code, hash);
    }

    public async Task<TestRunResultResponse> AddTestRunResultAsync(string code, int run_id, AddTestRunResultRequest testRunResultRequest)
    {
      return await _api.AddTestRunResult(_api_token, code, run_id, testRunResultRequest);
    }

    public async Task<TestRunResultResponse> UpdateTestRunResultAsync(string code, int run_id, string hash, UpdateTestRunResultRequest updateTestRunResultRequest)
    {
      return await _api.UpdateTestRunResult(_api_token, code, run_id, hash, updateTestRunResultRequest);
    }

    public async Task<TestRunResultResponse> DeleteTestRunResultAsync(string code, int run_id, string hash)
    {
      return await _api.DeleteTestRunResult(_api_token, code, run_id, hash);
    }
    #endregion

    #region Suites
    public async Task<SuitesResponse> GetAllTestSuitesAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllTestSuites(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificSuiteResponse> GetSpecificTestSuiteAsync(string code, int id)
    {
      return await _api.GetSpecificTestSuite(_api_token, code, id);
    }

    public async Task<SuiteResponse> CreateTestSuiteAsync(string code, SuiteRequest suiteRequest)
    {
      return await _api.CreateNewTestSuite(_api_token, code, suiteRequest);
    }

    public async Task<SuiteResponse> UpdateTestSuiteAsync(string code, int id, SuiteRequest suiteRequest)
    {
      return await _api.UpdateTestSuite(_api_token, code, id, suiteRequest);
    }

    public async Task<BaseResponse> DeleteTestSuiteAsync(string code, int id)
    {
      return await _api.DeleteTestSuite(_api_token, code, id);
    }
    #endregion

    #region Milestones
    public async Task<MilestonesResponse> GetAllMilestonesAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllMilestones(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificMilestoneResponse> GetSpecificMilestoneAsync(string code, int id)
    {
      return await _api.GetSpecificMilestone(_api_token, code, id);
    }

    public async Task<MilestoneResponse> CreateMilestoneAsync(string code, MilestoneRequest milestoneRequest)
    {
      return await _api.CreateNewMilestone(_api_token, code, milestoneRequest);
    }

    public async Task<MilestoneResponse> UpdateMilestoneAsync(string code, int id, MilestoneRequest milestoneRequest)
    {
      return await _api.UpdateMilestone(_api_token, code, id, milestoneRequest);
    }

    public async Task<MilestoneResponse> DeleteMilestoneAsync(string code, int id)
    {
      return await _api.DeleteMilestone(_api_token, code, id);
    }
    #endregion

    #region Shared steps
    public async Task<SharedStepsResponse> GetAllSharedStepsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllSharedSteps(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificSharedStepResponse> GetSpecificSharedStepAsync(string code, string hash)
    {
      return await _api.GetSpecificSharedStep(_api_token, code, hash);
    }

    public async Task<SharedStepResponse> CreateSharedStepAsync(string code, SharedStepRequest sharedStepRequest)
    {
      return await _api.CreateNewSharedStep(_api_token, code, sharedStepRequest);
    }

    public async Task<SharedStepResponse> UpdateSharedStepAsync(string code, string hash, SharedStepRequest sharedStepRequest)
    {
      return await _api.UpdateSharedStep(_api_token, code, hash, sharedStepRequest);
    }

    public async Task<SharedStepResponse> DeleteSharedStepAsync(string code, string hash)
    {
      return await _api.DeleteSharedStep(_api_token, code, hash);
    }
    #endregion
  }
}
