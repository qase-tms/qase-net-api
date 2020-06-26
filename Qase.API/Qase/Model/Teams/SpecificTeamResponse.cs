using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Teams
{
  public partial class SpecificTeamResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Team Result { get; set; }
  }
}
