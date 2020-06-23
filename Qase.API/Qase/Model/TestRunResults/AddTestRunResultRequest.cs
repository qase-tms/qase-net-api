using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class AddTestRunResultRequest
  {
    [JsonProperty("case_id")]
    public int CaseId { get; set; }

    [JsonProperty("time")]
    public int Time { get; set; }

    [Required]
    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("member_id")]
    public int? MemberId { get; set; }

    [JsonProperty("comment")]
    public string Comment { get; set; }

    [JsonProperty("defect")]
    public bool Defect { get; set; }

    [JsonProperty("steps")]
    public List<StepTestRunResult> Steps { get; set; }

    [JsonProperty("attachments")]
    public List<string> Attachments { get; set; }
  }
}
