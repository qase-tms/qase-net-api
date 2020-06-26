using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class Attachment
  {
    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("file")]
    public string File { get; set; }

    [JsonProperty("mime")]
    public string Mime { get; set; }

    [JsonProperty("size")]
    public long Size { get; set; }

    [JsonProperty("full_path")]
    public Uri FullPath { get; set; }
  }
}
