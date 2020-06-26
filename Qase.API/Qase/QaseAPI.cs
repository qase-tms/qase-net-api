using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Attachments;
using Qase.API.Qase.Model.CustomFields;
using Qase.API.Qase.Model.Defects;
using Qase.API.Qase.Model.Milestones;
using Qase.API.Qase.Model.Projects;
using Qase.API.Qase.Model.SharedSteps;
using Qase.API.Qase.Model.Suites;
using Qase.API.Qase.Model.Teams;
using Qase.API.Qase.Model.TestCases;
using Qase.API.Qase.Model.TestPlans;
using Qase.API.Qase.Model.TestRunResults;
using Qase.API.Qase.Model.TestRuns;
using Refit;
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

    public async Task<SuiteResponse> DeleteTestSuiteAsync(string code, int id)
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

    #region Test plans
    public async Task<TestPlansResponse> GetAllTestPlansAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllTestPlans(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificTestPlanResponse> GetSpecificTestPlanAsync(string code, int id)
    {
      return await _api.GetSpecificTestPlan(_api_token, code, id);
    }

    public async Task<TestPlanResponse> CreateTestPlanAsync(string code, TestPlanRequest testPlanRequest)
    {
      return await _api.CreateNewTestPlan(_api_token, code, testPlanRequest);
    }

    public async Task<TestPlanResponse> UpdateTestPlanAsync(string code, int id, TestPlanRequest testPlanRequest)
    {
      return await _api.UpdateTestPlan(_api_token, code, id, testPlanRequest);
    }

    public async Task<TestPlanResponse> DeleteTestPlanAsync(string code, int id)
    {
      return await _api.DeleteTestPlan(_api_token, code, id);
    }
    #endregion

    #region Defects
    public async Task<DefectsResponse> GetAllDefectsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllDefects(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset, filterTestRunResult.DictionaryFilters);
    }

    public async Task<SpecificDefectResponse> GetSpecificDefectAsync(string code, int id)
    {
      return await _api.GetSpecificDefect(_api_token, code, id);
    }

    public async Task<DefectResponse> ResolveDefectAsync(string code, int id)
    {
      return await _api.ResolveDefect(_api_token, code, id);
    }

    public async Task<DefectResponse> DeleteDefectAsync(string code, int id)
    {
      return await _api.DeleteDefect(_api_token, code, id);
    }
    #endregion

    #region Custom Fields
    public async Task<CustomFieldsResponse> GetAllCustomFieldsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllCustomFields(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset);
    }

    public async Task<SpecificCustomFieldResponse> GetSpecificCustomFieldAsync(string code, int id)
    {
      return await _api.GetSpecificCustomField(_api_token, code, id);
    }
    #endregion

    #region Teams
    public async Task<TeamsResponse> GetAllTeamsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllTeams(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset);
    }

    public async Task<SpecificTeamResponse> GetSpecificTeamAsync(string code, int id)
    {
      return await _api.GetSpecificTeam(_api_token, code, id);
    }
    #endregion

    #region Attachments
    public async Task<AttachmentsResponse> GetAllAttachmentsAsync(string code, BaseFilter filterTestRunResult)
    {
      return await _api.GetAllAttachments(_api_token, code, filterTestRunResult.limit, filterTestRunResult.offset);
    }

    public async Task<SpecificAttachmentResponse> GetSpecificAttachmentAsync(string hash)
    {
      return await _api.GetSpecificAttachment(_api_token, hash);
    }

    public async Task<UploadAttachmentResponse> UploadAttachmentAsync(string code, StreamPart file)
    {
      return await _api.UploadAttachment(_api_token, code, file);
    }

    public async Task<AttachmentResponse> DeleteAttachmentAsync(string hash)
    {
      return await _api.DeleteAttachment(_api_token, hash);
    }
    #endregion
  }
}
