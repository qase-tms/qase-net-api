using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class TestCases
  {
    [JsonProperty("id")]
    public long Id { get; set; }

    [JsonProperty("position")]
    public long Position { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("preconditions")]
    public string Preconditions { get; set; }

    [JsonProperty("postconditions")]
    public string Postconditions { get; set; }

    [JsonProperty("severity")]
    public long Severity { get; set; }

    [JsonProperty("priority")]
    public long Priority { get; set; }

    [JsonProperty("type")]
    public long Type { get; set; }

    [JsonProperty("behavior")]
    public long Behavior { get; set; }

    [JsonProperty("automation")]
    public string Automation { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("milestone_id")]
    public object MilestoneId { get; set; }

    [JsonProperty("suite_id")]
    public long SuiteId { get; set; }

    [JsonProperty("tags")]
    public object[] Tags { get; set; }

    [JsonProperty("links")]
    public object[] Links { get; set; }

    [JsonProperty("revision")]
    public int Revision { get; set; }

    [JsonProperty("custom_fields")]
    public object[] CustomFields { get; set; }

    [JsonProperty("attachments")]
    public List<int> Attachments { get; set; }

    [JsonProperty("steps")]
    public List<Step> Steps { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
