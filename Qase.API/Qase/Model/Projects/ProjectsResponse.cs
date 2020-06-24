using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ProjectsResponse: BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Project> Result { get; set; }
  }
}
