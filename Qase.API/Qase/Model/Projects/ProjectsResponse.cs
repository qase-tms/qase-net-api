using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ProjectsResponse
  {
    [JsonProperty("status")]
    public bool Status { get; set; }

    [JsonProperty("result")]
    public Result Result { get; set; }
  }
}
