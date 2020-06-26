using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Milestones
{
  public partial class SpecificMilestoneResponse : BaseResponse
  {
    [JsonProperty("result")]
    public List<Milestone> Result { get; set; }
  }
}
