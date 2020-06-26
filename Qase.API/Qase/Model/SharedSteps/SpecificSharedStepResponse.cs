using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SpecificSharedStepResponse : BaseResponse
  {
    [JsonProperty("result")]
    public List<SharedStep> Result { get; set; }
  }
}
