using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class ResultSuite
  {
    [JsonProperty("id")]
    public int Id { get; set; }
  }
}
