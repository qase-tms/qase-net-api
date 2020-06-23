using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class CreateTestRunRequest
  {
    public CreateTestRunRequest()
    {
      Cases = new List<int>();
    }

    [Required]
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("environment_id")]
    public int? EnvironmentId { get; set; }

    [Required]
    [JsonProperty("cases")]
    public List<int> Cases { get; set; }
  }
}
