using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class Runs
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("active")]
    public long Active { get; set; }
  }
}
