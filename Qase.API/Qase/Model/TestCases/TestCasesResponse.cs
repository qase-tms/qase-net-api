using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class TestCasesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultTestCases Result { get; set; }
  }
}
