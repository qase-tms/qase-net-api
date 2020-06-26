# qase-net-api
# [Qase TMS](https://qase.io) .Net Api Client

## Usage ##
Qase.io uses API tokens to authenticate requests. You can view an manage your API keys in [API tokens pages](https://app.qase.io/user/api/token).

You must replace api token with your personal API key.

```C#
QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
```

### Projects ###

#### Get All Projects ####
This method allows to retrieve all projects available for your account. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.limit = 100;
filter.offset = 0;
var projects = await qaseAPI.GetAllProjectsAsync(filter);
```

#### Get a specific project ####
This method allows to retrieve a specific project.

```C#
var project = await qaseAPI.GetSpecificProjectAsync("TEST");
```

#### Create a new project ####
This method is used to create a new project through API.

```C#
using Qase.API.Qase.Model.Projects

var project = await qaseAPI.CreateNewProjectAsync(new CreateProjectRequest
{
   Title = "TestNet",
   Code = "TESTNET",
   Description = "Test project .Net",
   Access =  AccessLevel.All.ToString(),
   Group = null
});
```

### Test cases ###

#### Get all test cases ####
This method allows to retrieve all test cases stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.type}]", new List<string>() { TypeCase.other.ToString(), TypeCase.performance.ToString() });

var testCases = await qaseAPI.GetAllTestCasesAsync("TEST", filter);
```

#### Get a specific test case ####
This method allows to retrieve a specific test case.

```C#
var testCase = await qaseAPI.GetSpecificTestCaseAsync("TEST", 1);
```


#### Delete test case ####
This method completely deletes a test case from repository.

```C#
var testCase = await qaseAPI.DeleteTestCaseAsync("TEST", 1);
```

### Test runs ###

#### Get all test runs ####
This method allows to retrieve all test runs stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusTestRun.active.ToString());

var testRuns = await qaseAPI.GetAllTestRunsAsync("TEST", filter);
```

#### Get a specific test run ####
This method allows to retrieve a specific test run.

```C#
var testRun = await qaseAPI.GetSpecificTestRunAsync("TEST", 1);
```


#### Create a new test run ####
This method is used to create a new test run through API.

```C#
using Qase.API.Qase.Model.TestRuns;

var cases = new List<int>();
cases.Add(1);

var resp = await qaseAPI.CreateNewTestRunAsync("TEST", new CreateTestRunRequest
{
   Title = "TestNet2",
   Description = "Test project .Net",
   Cases = cases
});

var id = resp.Result.Id;
```

#### Delete test run ####
This method completely deletes a test run from repository.

```C#
var resp = await qaseAPI.DeleteTestRunAsync("TEST", 1);
```

### Test run results ###

#### Get all test run results ####
This method allows to retrieve all test run results stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusTestRunResult.passed.ToString());

var testRunResults = await qaseAPI.GetAllTestRunResultsAsync("TEST", filter);
```

#### Get a specific test run result ####
This method allows to retrieve a specific test run result.

```C#
var testRunResult = await qaseAPI.GetSpecificTestRunResultAsync("TEST", "5796a7fb165a0eff2a7de3436485154beff88afc");
```

#### Create a new test run result ####
This method is used to create a new test run result through API.

```C#
using Qase.API.Qase.Model.TestRunResults;

var steps = new List<StepTestRunResult>();
steps.Add(new StepTestRunResult
{
   Position = 1,
   Status = "failed",
   Comment = "Something went wrong",
   Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
});

var resp = await qaseAPI.AddTestRunResultAsync("TEST", 2, new AddTestRunResultRequest
{
    CaseId = 1,
    Time = 100,
    Status = "failed",
    MemberId = 1,
    Comment = "Failed via API .Net",
    Defect = true,
    Steps = steps,
    Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
});
var hash = resp.Result.Hash;
```

#### Update test run result ####
This method is used to update existing test run result through API.

```C#
using Qase.API.Qase.Model.TestRunResults;

var steps = new List<StepTestRunResult>();
steps.Add(new StepTestRunResult
{
    Position = 1,
    Status = "passed"
});

var resp = await qaseAPI.UpdateTestRunResultAsync("TEST", 2, "c0def82a1d5e2df80d991a917c21df0944b49b7b", new UpdateTestRunResultRequest
{
    Time = 100,
    Status = "passed",
    Comment = "Failed via API v2 .Net",
    Defect = true,
    Steps = steps,
    Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
});
var hash = resp.Result.Hash;
```

#### Delete test run result ####
This method completely deletes a test run result from repository.

```C#
var resp = await qaseAPI.DeleteTestRunResultAsync("TEST", 4, "2898ba7f3b4d857cec8bee4a852cdc85f8b33132");
```

### Suites ###

#### Get all test suites ####
This method allows to retrieve all test suites stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "text search");

var suites = await qaseAPI.GetAllTestSuitesAsync("TEST", filter);
```

#### Get a specific test suite ####
This method allows to retrieve a specific test suite.

```C#
var suite = await qaseAPI.GetSpecificTestSuiteAsync("TEST", 1);
```

#### Create a new test suite ####
This method is used to create a new test suite through API.

```C#
using Qase.API.Qase.Model.Suites;

var resp = await qaseAPI.CreateTestSuiteAsync("TEST", new SuiteRequest
{
   Title = "Test suite",
   Description = "Suite description",
   Preconditions = "Suite preconditions"
});
var id = resp.Result.Id;
```

#### Update test suite ####
This method is used to update a test suite through API. You should provide an object with a list of fields you want to update in a payload. At least one field is required. Fields in payload will overwrite existing values.

```C#
using Qase.API.Qase.Model.Suites;

var resp = await qaseAPI.CreateTestSuiteAsync("TEST", 1, new SuiteRequest
{
    Title = "Test suite title",
    Description = "Suite description",
    Preconditions = "Suite preconditions"
});
var id = resp.Result.Id;
```

#### Delete test suite ####
This method completely deletes a test suite from repository.

```C#
var resp = await qaseAPI.DeleteTestSuiteAsync("TEST", 1);
```

### Milestones ###

#### Get all milestones ####
This method allows to retrieve all milestones stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "text search");

var milestones = await qaseAPI.GetAllMilestonesAsync("TEST", filter);
```

#### Get a specific milestone ####
This method allows to retrieve a specific milestone.

```C#
 var milestone = await qaseAPI.GetSpecificMilestoneAsync("TEST", 1);
```

#### Create a new milestone ####
This method is used to create a new milestone through API.

```C#
using Qase.API.Qase.Model.Milestones;

var resp = await qaseAPI.CreateMilestoneAsync("TEST", new MilestoneRequest
{ 
   Title = "New milestone"
});
var id = resp.Result.Id;
```

#### Update milestone ####
This method is used to update a milestone through API. You should provide an object with a list of fields you want to update in a payload. At least one field is required. Fields in payload will overwrite existing values.

```C#
using Qase.API.Qase.Model.Milestones;

var resp = await qaseAPI.UpdateMilestoneAsync("TEST", 1, new MilestoneRequest
{
    Title = "Test milestone",
    Description = "Milestone description",
});
var id = resp.Result.Id;
```

#### Delete milestone ####
This method completely deletes a milestone from repository.

```C#
 var resp = await qaseAPI.DeleteMilestoneAsync("TEST", 1);
```

### Shared steps ###

#### Get all shared steps ####
This method allows to retrieve all shared steps stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();

var sharedSteps = await qaseAPI.GetAllSharedStepsAsync("TEST", filter);
```

#### Get a specific shared step ####
This method allows to retrieve a specific shared step.

```C#
 var sharedStep = await qaseAPI.GetSpecificSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7");
```

#### Create a new shared step ####
This method is used to create a new shared step through API.

```C#
using Qase.API.Qase.Model.SharedSteps;

var resp = await qaseAPI.CreateSharedStepAsync("TEST", new SharedStepRequest
{ 
    Title = "Test SharedStep"
});
var hash = resp.Result.Hash;
```

#### Update shared step ####
This method is used to update a shared step through API. You should provide an object with a list of fields you want to update in a payload. At least one field is required. Fields in payload will overwrite existing values.

```C#
using Qase.API.Qase.Model.SharedSteps;

var resp = await qaseAPI.UpdateSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7", new SharedStepRequest
{
    Title = "Test SharedStep update"
});
var hash = resp.Result.Hash;
```

#### Delete shared step ####
This method completely deletes a shared step from repository. Also it will be removed from all test cases.

```C#
 var resp = await qaseAPI.DeleteSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7");
 var hash = resp.Result.Hash;
```

### Test plans ###

#### Get all test plans ####
This method allows to retrieve all test plans stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();

var testPlans = await qaseAPI.GetAllTestPlansAsync("TEST", filter);
```

#### Get a specific test plan ####
This method allows to retrieve a specific test plan with detailed information about test cases in that plan and assignee.

```C#
  var testPlan = await qaseAPI.GetSpecificTestPlanAsync("TEST", 1);
```

#### Create a new plan ####
This method is used to create a new test plan through API. In response you will receive an ID of newly created plan.

```C#
using Qase.API.Qase.Model.TestPlans;

var resp = await qaseAPI.CreateTestPlanAsync("TEST", new TestPlanRequest
{
    Title = "New Test Plan",
    Cases = new List<int>() { 1 }
});
var id = resp.Result.Id;
```

#### Update test plan ####
This method is used to update a test plan through API. You should provide an object with a list of fields you want to update in a payload. At least one field is required. Fields in payload will overwrite existing values.

```C#
using Qase.API.Qase.Model.TestPlans;

var resp = await qaseAPI.UpdateTestPlanAsync("TEST", 1, new TestPlanRequest
{
    Title = "Test testPlan",
    Description = "TestPlan description",
});
var id = resp.Result.Id;
```

#### Delete test plan ####
This method completely deletes a test plan from repository.

```C#
var resp = qaseAPI.DeleteTestPlanAsync("TEST", 1);
var id = resp.Result.Id;
```

### Defects ###

#### Get all defects ####
This method allows to retrieve all defects stored in selected project. You can you limit and offset params to paginate.

```C#
BaseFilter filter = new BaseFilter();
filter.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusDefect.open.ToString());

var defects = await qaseAPI.GetAllDefectsAsync("TEST", filter);
```

#### Get a specific defect ####
This method allows to retrieve a specific defect.

```C#
var defects = await qaseAPI.GetSpecificDefectAsync("TEST", 1);
```

#### Resolve ####
This method is used to resolve defect through API. If defect is already resolved, you will get a message that defect is not found.

```C#
var resp = await qaseAPI.ResolveDefectAsync("TEST", 1)
var id = resp.Result.Id;
```

#### Delete defect ####
This method completely deletes a defect from repository.

```C#
var resp = await qaseAPI.DeleteDefectAsync("TEST", 1);
var id = resp.Result.Id;
```

### Custom Fields ###

#### Get all custom fields ####
This method allows to retrieve all custom fields for a specific project. You can you limit and offset params to paginate.

```C#
BaseFilter filterTestRunResult = new BaseFilter();

var customFields = await qaseAPI.GetAllCustomFieldsAsync("TEST", filterTestRunResult);
```

#### Get a specific custom field ####
This method allows to retrieve one custom fields for specific project by id.

```C#
var customField = await qaseAPI.GetSpecificCustomFieldAsync("TEST", 1);
```

### Team ###

#### Get all team members ####
This method allows to retrieve all users in your team. You can you limit and offset params to paginate.

```C#
 BaseFilter filterTestRunResult = new BaseFilter();

var teams = await qaseAPI.GetAllTeamsAsync("TEST", filterTestRunResult);
```

#### Get a specific team member ####
This method allows to retrieve a specific team member by id.

```C#
var team = await qaseAPI.GetSpecificTeamAsync("TEST", 1);
```