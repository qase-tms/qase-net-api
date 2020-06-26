using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.SharedSteps
{
  public partial class SharedStep
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("action")]
    public string Action { get; set; }

    [JsonProperty("expected_result")]
    public string ExpectedResult { get; set; }

    [JsonProperty("cases")]
    public List<int> Cases { get; set; }

    [JsonProperty("cases_count")]
    public int CasesCount { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
