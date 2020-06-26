using Newtonsoft.Json;
using System;
using System.ComponentModel.DataAnnotations;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class MilestoneRequest
  {
    [Required]
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("due_date")]
    public DateTimeOffset DueDate { get; set; }
    
  }
}
