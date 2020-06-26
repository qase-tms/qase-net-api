using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.TestRuns;
using Refit;
using System;
using System.Collections.Generic;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPITestRuns
  {
    [TestMethod]
    public void GetAllTestRuns()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRun = new BaseFilter();
        filterTestRun.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusTestRun.active.ToString());

        var testRuns = qaseAPI.GetAllTestRunsAsync("TEST", filterTestRun).Result;
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
    public void GetSpecificTestRun()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var testRun = qaseAPI.GetSpecificTestRunAsync("TEST", 1).Result;
    }

    [TestMethod]
    public void CreateNewTestRun()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var cases = new List<int>();
      cases.Add(1);

      var id = qaseAPI.CreateNewTestRunAsync("TEST", new CreateTestRunRequest
      {
        Title = "TestNet2",
        Description = "Test project .Net",
        Cases = cases
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void DeleteTestRun()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteTestRunAsync("TEST", 1).Result;
    }
  }
}
