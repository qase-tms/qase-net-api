using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class MilestonesResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Milestone> Result { get; set; }
  }
}
