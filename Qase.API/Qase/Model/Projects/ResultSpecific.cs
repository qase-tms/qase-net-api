using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ResultSpecific
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("counts")]
    public Counts Counts { get; set; }
  }
}
