using Newtonsoft.Json;

namespace Qase.API.Qase.Model.TestPlans
{
  public partial class CaseTestPlan
  {
    [JsonProperty("case_id")]
    public long CaseId { get; set; }

    [JsonProperty("assignee_id")]
    public long AssigneeId { get; set; }
  }
}
