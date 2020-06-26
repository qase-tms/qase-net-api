using Newtonsoft.Json;
using Qase.API.Qase.Model.TestPlans;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestPlans
{
  public partial class TestPlan
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("cases_count")]
    public int? CasesCount { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }

    [JsonProperty("average_time")]
    public int? AverageTime { get; set; }

    [JsonProperty("cases")]
    public List<CaseTestPlan> Cases { get; set; }
  }
}
