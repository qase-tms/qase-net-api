using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Defects
{
  public partial class SpecificDefectResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Defect Result { get; set; }
  }
}
