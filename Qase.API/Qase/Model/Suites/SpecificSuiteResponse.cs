using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SpecificSuiteResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Suite Result { get; set; }
  }
}
