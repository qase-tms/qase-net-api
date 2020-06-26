﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.Suites
{
  public partial class SpecificMilestoneResponse : BaseResponse
  {
    [JsonProperty("result")]
    public List<Milestone> Result { get; set; }
  }
}