using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class SpecificProjectResponse: BaseResponse
  {
    [JsonProperty("result")]
    public ResultSpecific Result { get; set; }
  }
}
