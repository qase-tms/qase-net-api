using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model
{
  public partial class BaseResult<T>
  {
    [JsonProperty("total")]
    public long Total { get; set; }

    [JsonProperty("filtered")]
    public long Filtered { get; set; }

    [JsonProperty("count")]
    public long Count { get; set; }

    [JsonProperty("entities")]
    public List<T> Entities { get; set; }
  }
}
