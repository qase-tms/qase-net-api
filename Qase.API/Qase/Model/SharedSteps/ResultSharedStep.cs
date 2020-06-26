using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class ResultSharedStep
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }
  }
}
