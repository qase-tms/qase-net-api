using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Projects
{
  public partial class CreateProjectResponse: BaseResponse
  {
    [JsonProperty("result")]
    public ResultCreateProject Result { get; set; }
  }
}
