using Newtonsoft.Json;
using System;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class Milestone
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("due_date")]
    public object DueDate { get; set; }

    [JsonProperty("preconditions")]
    public string Preconditions { get; set; }

    [JsonProperty("position")]
    public int Position { get; set; }

    [JsonProperty("parent_id")]
    public int? ParentId { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }




    

  }
}
