using Newtonsoft.Json;
using Qase.API.Qase.Model.TestCases;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class TestRunResult
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonProperty("run_id")]
    public int? RunId { get; set; }

    [JsonProperty("case_id")]
    public int? CaseId { get; set; }

    [JsonProperty("steps")]
    public List<StepTestRunResult> Steps { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("is_api_result")]
    public bool IsApiResult { get; set; }

    [JsonProperty("time_spent")]
    public int TimeSpent { get; set; }

    [JsonProperty("end_time")]
    public DateTimeOffset EndTime { get; set; }
  }
}
