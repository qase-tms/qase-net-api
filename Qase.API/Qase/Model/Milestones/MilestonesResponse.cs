using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class MilestonesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Milestone> Result { get; set; }
  }
}
