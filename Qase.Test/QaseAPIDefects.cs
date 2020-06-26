using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPIDefects
  {
    [TestMethod]
    public void GetAllDefects()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filter = new BaseFilter();
        filter.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusDefect.open.ToString());

        var defects = qaseAPI.GetAllDefectsAsync("TEST", filter).Result;
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
    public void GetSpecificDefects()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var defects = qaseAPI.GetSpecificDefectAsync("TEST", 1).Result;
    }

    [TestMethod]
    public void Resolve()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.ResolveDefectAsync("TEST", 1)
      .Result.Result.Id;
    }


    [TestMethod]
    public void DeleteDefect()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteDefectAsync("TEST", 1).Result;
    }
  }
}
