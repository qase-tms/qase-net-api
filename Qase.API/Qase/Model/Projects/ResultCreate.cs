using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ResultCreate
  {
    [JsonProperty("code")]
    public string Code { get; set; }
  }
}
