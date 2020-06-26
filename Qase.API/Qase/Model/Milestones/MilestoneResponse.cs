using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class MilestoneResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultMilestone Result { get; set; }
  }
}
