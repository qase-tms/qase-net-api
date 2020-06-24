using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class TestRunsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<TestRun> Result { get; set; }
  }
}
