using Newtonsoft.Json;

namespace Qase.API.Qase.Model.SharedSteps
{
  public partial class SharedStepRequest
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("action")]
    public string Action { get; set; }

    [JsonProperty("expected_result")]
    public string ExpectedResult { get; set; }
  }
}
