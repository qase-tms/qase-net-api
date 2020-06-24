using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;

namespace Qase.API.Qase.Model.TestRunResults
{
  public partial class TestRunResultsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<TestRunResult> Result { get; set; }
  }
}
