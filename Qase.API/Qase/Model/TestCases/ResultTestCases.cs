using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class ResultTestCases
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("filtered")]
    public long Filtered { get; set; }

    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("entities")]
    public List<TestCases> TestCases { get; set; }
  }
}
