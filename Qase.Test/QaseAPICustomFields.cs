using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPICustomFields
  {
    [TestMethod]
    public void GetAllCustomFields()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filter = new BaseFilter();

        var customFields = qaseAPI.GetAllCustomFieldsAsync("TEST", filter).Result;
      }
      catch (WebApiException ex)
      {
      }
      catch (ApiException ex)
      {
      }
      catch (Exception ex)
      {
      }
    }

    [TestMethod]
    public void GetSpecificCustomField()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var customField = qaseAPI.GetSpecificCustomFieldAsync("TEST", 1).Result;
    }
  }
}
