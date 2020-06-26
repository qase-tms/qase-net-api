using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class MilestoneRequest
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }
  }
}
