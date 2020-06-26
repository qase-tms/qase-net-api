using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SuitesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Suite> Result { get; set; }
  }
}
