using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class TestCases
  {
    [JsonProperty("id")]
    public int Id { get; set; }

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
    public Severity Severity { get; set; }

    [JsonProperty("priority")]
    public Priority Priority { get; set; }

    [JsonProperty("type")]
    public TypeCase Type { get; set; }

    [JsonProperty("behavior")]
    public Behavior Behavior { get; set; }

    [JsonProperty("automation")]
    public object Automation { get; set; }

    [JsonProperty("status")]
    public TestCaseStatus Status { get; set; }

    [JsonProperty("milestone_id")]
    public int? MilestoneId { get; set; }

    [JsonProperty("suite_id")]
    public int? SuiteId { get; set; }

    [JsonProperty("tags")]
    public List<object> Tags { get; set; }

    [JsonProperty("links")]
    public List<object> Links { get; set; }

    [JsonProperty("revision")]
    public int? Revision { get; set; }

    [JsonProperty("custom_fields")]
    public List<object> CustomFields { get; set; }

    [JsonProperty("attachments")]
    public List<object> Attachments { get; set; }

    [JsonProperty("steps")]
    public List<Step> Steps { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
