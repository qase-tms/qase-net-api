using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class TestCasesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Result<TestCases> Result { get; set; }
  }
}
