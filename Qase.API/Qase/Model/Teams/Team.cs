using Newtonsoft.Json;
using System;

namespace Qase.API.Qase.Model.Teams
{
  public partial class Team
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("email")]
    public string Email { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("status")]
    public int? Status { get; set; }
  }
}
