using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class CreateProjectRequest
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("code")]
    public string Code { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("access")]
    public string Access { get; set; }

    [JsonProperty("group")]
    public string Group { get; set; }
  }
}
