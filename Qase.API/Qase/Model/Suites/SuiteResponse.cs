using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SuiteResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultSuite Result { get; set; }
  }
}
