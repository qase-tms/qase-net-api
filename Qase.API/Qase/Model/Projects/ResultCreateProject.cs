using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Projects
{
  public partial class ResultCreateProject
  {
    [JsonProperty("code")]
    public string Code { get; set; }
  }
}
