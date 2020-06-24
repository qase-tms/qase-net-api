using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class TestCasesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<TestCases> Result { get; set; }
  }
}
