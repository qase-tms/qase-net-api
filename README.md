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

var testCases = await qaseAPI.GetAllTestCasesAsync("TEST", filterCases);
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

var testRuns = await qaseAPI.GetAllTestRunsAsync("TEST", filterTestRun);
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

var testRunResults = await qaseAPI.GetAllTestRunResultsAsync("TEST", filterTestRunResult);
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