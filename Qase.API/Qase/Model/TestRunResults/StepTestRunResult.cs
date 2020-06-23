using Newtonsoft.Json;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class StepTestRunResult
  {
    [Required]
    [JsonProperty("position")]
    public int Position { get; set; }

    [Required]
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("comment", NullValueHandling = NullValueHandling.Ignore)]
    public string Comment { get; set; }

    [JsonProperty("attachments", NullValueHandling = NullValueHandling.Ignore)]
    public List<string> Attachments { get; set; }
  }
}
