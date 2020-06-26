using Newtonsoft.Json;

namespace Qase.API.Qase.Model.CustomFields
{
  public partial class CustomFieldsResponse : BaseResponse
  {
    [JsonProperty("result")]
    public BaseResult<CustomField> Result { get; set; }
  }
}
