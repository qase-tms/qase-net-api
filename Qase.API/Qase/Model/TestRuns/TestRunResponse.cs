using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class TestRunResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultTestRun Result { get; set; }
  }
}
