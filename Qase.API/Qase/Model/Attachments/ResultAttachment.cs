using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class ResultAttachment
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }
  }
}
