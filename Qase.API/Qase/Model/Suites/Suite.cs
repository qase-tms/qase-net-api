using Newtonsoft.Json;
using System;

namespace Qase.API.Qase.Model.Suites
{
  public partial class Suite
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("preconditions")]
    public string Preconditions { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("cases_count")]
    public int CasesCount { get; set; }

    [JsonProperty("parent_id")]
    public int? ParentId { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
