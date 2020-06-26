using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SharedStepsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<SharedStep> Result { get; set; }
  }
}
