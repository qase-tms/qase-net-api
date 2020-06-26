using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.CustomFields
{
  public partial class SpecificCustomFieldResponse : BaseResponse
  {
    [JsonProperty("result")]
    public CustomField Result { get; set; }
  }
}
