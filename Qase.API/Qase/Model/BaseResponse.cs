using Newtonsoft.Json;

namespace Qase.API.Qase.Model
{
  public abstract class BaseResponse
  {
    [JsonProperty("status")]
    public bool Status { get; set; }
  }
}
