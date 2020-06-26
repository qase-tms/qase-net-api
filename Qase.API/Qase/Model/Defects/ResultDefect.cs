using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Defects
{
  public partial class ResultDefect
  {
    [JsonProperty("id")]
    public int Id { get; set; }
  }
}
