using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SuiteRequest
  {
    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("parent_id")]
    public int? ParentId { get; set; }

    [JsonProperty("description")]
    public string Description { get; set; }

    [JsonProperty("preconditions")]
    public string Preconditions { get; set; }
  }
}
