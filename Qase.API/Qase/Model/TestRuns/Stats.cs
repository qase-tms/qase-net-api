using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class Stats
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("untested")]
    public long Untested { get; set; }

    [JsonProperty("passed")]
    public long Passed { get; set; }

    [JsonProperty("failed")]
    public long Failed { get; set; }

    [JsonProperty("blocked")]
    public long Blocked { get; set; }

    [JsonProperty("skipped")]
    public long Skipped { get; set; }

    [JsonProperty("retest")]
    public long Retest { get; set; }

    [JsonProperty("deleted")]
    public long Deleted { get; set; }
  }
}
