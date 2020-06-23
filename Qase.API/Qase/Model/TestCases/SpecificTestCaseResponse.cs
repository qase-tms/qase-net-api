using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.TestCases
{
  public partial class SpecificTestCaseResponse
  {
    [JsonProperty("result")]
    public TestCases Result { get; set; }
  }
}
