using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class TestRunsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Result<TestRun> Result { get; set; }
  }
}
