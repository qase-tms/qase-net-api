using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class SpecificTestRunResultResponse : BaseResponse
  {
    [JsonProperty("result")]
    public TestRunResult Result { get; set; }
  }
}
