using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class TestPlansResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<TestPlan> Result { get; set; }
  }
}
