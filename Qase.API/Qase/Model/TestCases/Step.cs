using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class Step
  {
    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("action")]
    public string Action { get; set; }
    
    [JsonProperty("expected_result")]
    public string ExpectedResult { get; set; }
    
    [JsonProperty("shared_hash")]
    public string SharedHash { get; set; }
    
    [JsonProperty("attachments")]
    public List<int> Attachments { get; set; }
  }
}
