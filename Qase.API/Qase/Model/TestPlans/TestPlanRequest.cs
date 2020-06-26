using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Qase.API.Qase.Model.TestPlans
{
  public partial class TestPlanRequest
  {
    [Required]
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [Required]
    [JsonProperty("cases")]
    public List<int> Cases { get; set; }
  }
}
