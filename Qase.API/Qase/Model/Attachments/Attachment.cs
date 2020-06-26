using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Qase.API.Qase.Model.Attachments
{
  public partial class Attachment
  {
    [JsonProperty("filename")]
    public string Filename { get; set; }

    [JsonProperty("url")]
    public Uri Url { get; set; }

    [JsonProperty("extension")]
    public string Extension { get; set; }

    [JsonProperty("hash")]
    public string Hash { get; set; }

    [JsonProperty("mime")]
    public string Mime { get; set; }

    [JsonProperty("team")]
    public string Team { get; set; }
  }
}
