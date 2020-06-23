using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class Step
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("position")]
    public long Position { get; set; }

    [JsonProperty("action")]
    public string Action { get; set; }

    [JsonProperty("expected_result")]
    public string ExpectedResult { get; set; }

    [JsonProperty("data")]
    public object Data { get; set; }

    [JsonProperty("shared_step_hash")]
    public object SharedStepHash { get; set; }

    [JsonProperty("attachments")]
    public List<object> Attachments { get; set; }
  }
}
