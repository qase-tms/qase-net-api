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
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Qase.API.Qase
{
  public interface IQaseServiceWebApi
  {
    #region Projects
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
    #endregion

    #region Test cases
    /// <summary>
    /// Get all test cases
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/case/{code}")]
    Task<TestCasesResponse> GetAllTestCases([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string,object> dictionaryFilter);

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
    #endregion

    #region Test runs
    /// <summary>
    /// Get all test runs
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/run/{code}")]
    Task<TestRunsResponse> GetAllTestRuns([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

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
    #endregion

    #region Test run results
    /// <summary>
    /// Get all test run results
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/result/{code}")]
    Task<TestRunResultsResponse> GetAllTestRunResults([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific test run result
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    [Get("/result/{code}/{hash}")]
    Task<SpecificTestRunResultResponse> GetSpecificTestRunResult([Header("Token")] string api_token, string code, string hash);

    /// <summary>
    /// Add a new test run result
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="run_id"></param>
    /// <param name=""></param>
    /// <returns></returns>
    [Post("/result/{code}/{run_id}")]
    Task<TestRunResultResponse> AddTestRunResult([Header("Token")] string api_token, string code, int run_id, AddTestRunResultRequest testRunResultRequest);

    /// <summary>
    /// Update test run result
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="run_id"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    [Patch("/result/{code}/{run_id}/{hash}")]
    Task<TestRunResultResponse> UpdateTestRunResult([Header("Token")] string api_token, string code, int run_id, string hash, UpdateTestRunResultRequest updateTestRunResultRequest);

    /// <summary>
    /// Delete test run result
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    [Delete("/result/{code}/{run_id}/{hash}")]
    Task<TestRunResultResponse> DeleteTestRunResult([Header("Token")] string api_token, string code, int run_id, string hash);
    #endregion

    #region Suites
    /// <summary>
    /// Get all test suites
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="dictionaryFilter"></param>
    /// <returns></returns>
    [Get("/suite/{code}")]
    Task<SuitesResponse> GetAllTestSuites([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific test suite
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/suite/{code}/{id}")]
    Task<SpecificSuiteResponse> GetSpecificTestSuite([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Create a new test suite
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name=""></param>
    /// <returns></returns>
    [Post("/suite/{code}")]
    Task<SuiteResponse> CreateNewTestSuite([Header("Token")] string api_token, string code, SuiteRequest suiteRequest);

    /// <summary>
    /// Update test suite
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <param name=""></param>
    /// <returns></returns>
    [Patch("/suite/{code}/{id}")]
    Task<SuiteResponse> UpdateTestSuite([Header("Token")] string api_token, string code, int id, SuiteRequest suiteRequest);

    /// <summary>
    /// Delete test suite
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/suite/{code}/{id}")]
    Task<BaseResponse> DeleteTestSuite([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Milestones
    /// <summary>
    /// Get all milestones
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="dictionaryFilter"></param>
    /// <returns></returns>
    [Get("/milestone/{code}")]
    Task<MilestonesResponse> GetAllMilestones([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific milestone
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/milestone/{code}/{id}")]
    Task<SpecificMilestoneResponse> GetSpecificMilestone([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Create a new milestone
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name=""></param>
    /// <returns></returns>
    [Post("/milestone/{code}")]
    Task<MilestoneResponse> CreateNewMilestone([Header("Token")] string api_token, string code, MilestoneRequest milestoneRequest);

    /// <summary>
    /// Update milestone
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <param name=""></param>
    /// <returns></returns>
    [Patch("/milestone/{code}/{id}")]
    Task<MilestoneResponse> UpdateMilestone([Header("Token")] string api_token, string code, int id, MilestoneRequest milestoneRequest);

    /// <summary>
    /// Delete milestone
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/milestone/{code}/{id}")]
    Task<MilestoneResponse> DeleteMilestone([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Shared steps
    /// <summary>
    /// Get all shared steps
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="dictionaryFilter"></param>
    /// <returns></returns>
    [Get("/shared_step/{code}")]
    Task<SharedStepsResponse> GetAllSharedSteps([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific shared step
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    [Get("/shared_step/{code}/{hash}")]
    Task<SpecificSharedStepResponse> GetSpecificSharedStep([Header("Token")] string api_token, string code, string hash);

    /// <summary>
    /// Create a new shared step
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="sharedStepRequest"></param>
    /// <returns></returns>
    [Post("/shared_step/{code}")]
    Task<SharedStepResponse> CreateNewSharedStep([Header("Token")] string api_token, string code, SharedStepRequest sharedStepRequest);

    /// <summary>
    /// Update shared step
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="hash"></param>
    /// <param name="sharedStepRequest"></param>
    /// <returns></returns>
    [Patch("/shared_step/{code}/{hash}")]
    Task<SharedStepResponse> UpdateSharedStep([Header("Token")] string api_token, string code, string hash, SharedStepRequest sharedStepRequest);

    /// <summary>
    /// Delete shared step
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="hash"></param>
    /// <returns></returns>
    [Delete("/shared_step/{code}/{hash}")]
    Task<SharedStepResponse> DeleteSharedStep([Header("Token")] string api_token, string code, string hash);
    #endregion

    #region Test plans
    /// <summary>
    /// Get all test plans
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="dictionaryFilter"></param>
    /// <returns></returns>
    [Get("/plan/{code}")]
    Task<TestPlansResponse> GetAllTestPlans([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific test plan
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/suite/plan/{code}/{id}")]
    Task<SpecificTestPlanResponse> GetSpecificTestPlan([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Create a new plan
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="testPlanRequest"></param>
    /// <returns></returns>
    [Post("/plan/{code}")]
    Task<TestPlanResponse> CreateNewTestPlan([Header("Token")] string api_token, string code, TestPlanRequest testPlanRequest);

    /// <summary>
    /// Update test plan
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <param name="testPlanRequest"></param>
    /// <returns></returns>
    [Patch("/plan/{code}/{id}")]
    Task<TestPlanResponse> UpdateTestPlan([Header("Token")] string api_token, string code, int id, TestPlanRequest testPlanRequest);

    /// <summary>
    /// Delete test plan
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/suite/plan/{code}/{id}")]
    Task<TestPlanResponse> DeleteTestPlan([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Defects
    /// <summary>
    /// Get all defects
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <param name="dictionaryFilter"></param>
    /// <returns></returns>
    [Get("/defect/{code}")]
    Task<DefectsResponse> GetAllDefects([Header("Token")] string api_token, string code, int limit, int offset, Dictionary<string, object> dictionaryFilter);

    /// <summary>
    /// Get a specific defect
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/defect/{code}/{id}")]
    Task<SpecificDefectResponse> GetSpecificDefect([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Resolve
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Patch("/defect/{code}/resolve/{id}")]
    Task<DefectResponse> ResolveDefect([Header("Token")] string api_token, string code, int id);

    /// <summary>
    /// Delete defect
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Delete("/defect/{code}/{id}")]
    Task<DefectResponse> DeleteDefect([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Custom Fields
    /// <summary>
    /// Get all custom fields
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/custom_field/{code}")]
    Task<CustomFieldsResponse> GetAllCustomFields([Header("Token")] string api_token, string code, int limit, int offset);

    /// <summary>
    /// Get a specific custom field
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/custom_field/{code}/{id}")]
    Task<SpecificCustomFieldResponse> GetSpecificCustomField([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Teams
    /// <summary>
    /// Get all team members
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="limit"></param>
    /// <param name="offset"></param>
    /// <returns></returns>
    [Get("/user")]
    Task<TeamsResponse> GetAllTeams([Header("Token")] string api_token, string code, int limit, int offset);

    /// <summary>
    /// Get a specific team member
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <param name="id"></param>
    /// <returns></returns>
    [Get("/user/{id}")]
    Task<SpecificTeamResponse> GetSpecificTeam([Header("Token")] string api_token, string code, int id);
    #endregion

    #region Shared steps

    [Get("/attachment")]
    Task<AttachmentsResponse> GetAllAttachments([Header("Token")] string api_token, string code, int limit, int offset);


    [Get("/attachment/{hash}")]
    Task<SpecificAttachmentResponse> GetSpecificAttachment([Header("Token")] string api_token, string hash);


    [Post("attachment/{code}")]
    Task<UploadAttachmentResponse> UploadAttachment([Header("Token")] string api_token, string code, [AliasAs("file")] StreamPart file);


    [Delete("/attachment/{hash}")]
    Task<AttachmentResponse> DeleteAttachment([Header("Token")] string api_token, string hash);
    #endregion
  }
}
