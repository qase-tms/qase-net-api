using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Defects
{
  public partial class Defect
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("actual_result")]
    public string ActualResult { get; set; }

    [JsonProperty("status")]
    public string Status { get; set; }

    [JsonProperty("user_id")]
    public int? UserId { get; set; }

    [JsonProperty("attachments")]
    public List<object> Attachments { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
