using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class Counts
  {
    [JsonProperty("cases")]
    public long Cases { get; set; }

    [JsonProperty("suites")]
    public long Suites { get; set; }

    [JsonProperty("milestones")]
    public long Milestones { get; set; }

    [JsonProperty("runs")]
    public Runs Runs { get; set; }

    [JsonProperty("defects")]
    public Defects Defects { get; set; }
  }
}
