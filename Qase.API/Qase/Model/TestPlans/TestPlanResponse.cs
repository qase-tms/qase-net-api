using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class TestPlanResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultTestPlan Result { get; set; }
  }
}
