using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class SpecificTestRunResponse : BaseResponse
  {
    [JsonProperty("result")]
    public TestRun Result { get; set; }
  }
}
