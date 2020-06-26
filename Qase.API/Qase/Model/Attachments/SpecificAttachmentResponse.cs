using Newtonsoft.Json;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class SpecificAttachmentResponse : BaseResponse
  {
    [JsonProperty("result")]
    public Attachment Result { get; set; }
  }
}
