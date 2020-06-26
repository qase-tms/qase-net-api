using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class AttachmentResponse : BaseResponse
  {
    [JsonProperty("result")]
    public ResultAttachment Result { get; set; }
  }
}
