using Newtonsoft.Json;

namespace Qase.API.Qase.Model.SharedSteps
{
  public partial class SharedStepsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<SharedStep> Result { get; set; }
  }
}
