using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ResultProjects
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("filtered")]
    public long Filtered { get; set; }

    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("entities")]
    public List<Entity> Entities { get; set; }
  }
}
