using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Projects
{
  public partial class Defects
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("open")]
    public long Open { get; set; }
  }
}
