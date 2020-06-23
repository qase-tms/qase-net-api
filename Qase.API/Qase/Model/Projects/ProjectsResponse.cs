using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ProjectsResponse: BaseResponse
  {
    [JsonProperty("result")]
    public Result<Project> Result { get; set; }
  }
}
