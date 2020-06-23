using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestRuns
{
  public partial class ResultTestRun
  {
    [JsonProperty("id")]
    public int Id { get; set; }
  }
}
