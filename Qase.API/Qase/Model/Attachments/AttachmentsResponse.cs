using Newtonsoft.Json;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class AttachmentsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<Attachment> Result { get; set; }
  }
}
