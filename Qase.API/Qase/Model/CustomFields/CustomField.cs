using Newtonsoft.Json;
using System;

namespace Qase.API.Qase.Model.CustomFields
{
  public partial class CustomField
  {
    [JsonProperty("id")]
    public int Id { get; set; }

    [JsonProperty("title")]
    public string Title { get; set; }

    [JsonProperty("type")]
    public string Type { get; set; }

    [JsonProperty("placeholder")]
    public string Placeholder { get; set; }

    [JsonProperty("default_value")]
    public object DefaultValue { get; set; }

    [JsonProperty("value")]
    public object Value { get; set; }

    [JsonProperty("is_required")]
    public bool IsRequired { get; set; }

    [JsonProperty("is_visible")]
    public bool IsVisible { get; set; }

    [JsonProperty("is_filterable")]
    public bool IsFilterable { get; set; }

    [JsonProperty("created")]
    public DateTimeOffset Created { get; set; }

    [JsonProperty("updated")]
    public DateTimeOffset Updated { get; set; }
  }
}
