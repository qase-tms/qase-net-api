using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class TestRun
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public object Description { get; set; }

    [JsonProperty("status")]
    public int Status { get; set; }

    [JsonProperty("start_time")]
    public DateTimeOffset? StartTime { get; set; }

    [JsonProperty("end_time")]
    public DateTimeOffset? EndTime { get; set; }

    [JsonProperty("public")]
    public bool Public { get; set; }

    [JsonProperty("stats")]
    public Stats Stats { get; set; }

    [JsonProperty("time_spent")]
    public int? TimeSpent { get; set; }

    [JsonProperty("user_id")]
    public int? UserId { get; set; }

    [JsonProperty("environment")]
    public object Environment { get; set; }

    [JsonProperty("cases")]
    public List<int> Cases { get; set; }
  }
}
