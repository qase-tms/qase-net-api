using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class UploadAttachmentResponse : BaseResponse
  {
    [JsonProperty("result")]
    public List<Attachment> Result { get; set; }
  }
}
