using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Defects
{
  public partial class DefectResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultDefect Result { get; set; }
  }
}
