﻿using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SharedStepResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultSharedStep Result { get; set; }
  }
}
