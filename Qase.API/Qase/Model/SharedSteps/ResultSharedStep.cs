using Newtonsoft.Json;

namespace Qase.API.Qase.Model.SharedSteps
{
  public partial class ResultSharedStep
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }
  }
}
