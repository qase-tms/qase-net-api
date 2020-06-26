using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Teams
{
  public partial class TeamsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Team> Result { get; set; }
  }
}
