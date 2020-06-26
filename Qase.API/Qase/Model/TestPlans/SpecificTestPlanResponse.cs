using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.TestPlans
{
  public partial class SpecificTestPlanResponse : BaseResponse
  {
    [JsonProperty("result")]
    public List<TestPlan> Result { get; set; }
  }
}
