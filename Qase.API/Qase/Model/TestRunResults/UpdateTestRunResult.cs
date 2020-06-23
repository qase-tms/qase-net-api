using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class UpdateTestRunResult
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }
  }
}
