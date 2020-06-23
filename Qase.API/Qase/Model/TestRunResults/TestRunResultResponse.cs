using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class TestRunResultResponse : BaseResponse
  {
    [JsonProperty("result")]
    public UpdateTestRunResult Result { get; set; }
  }
}
