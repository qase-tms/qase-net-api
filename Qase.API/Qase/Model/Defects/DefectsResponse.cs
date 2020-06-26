using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Defects
{
  public partial class DefectsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Defect> Result { get; set; }
  }
}
