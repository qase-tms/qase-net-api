using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.TestPlans;
using Refit;
using System;
using System.Collections.Generic;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPITestPlans
  {
    [TestMethod]
    public void GetAllTestPlans()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();
        filterTestRunResult.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "");

        var testPlans = qaseAPI.GetAllTestPlansAsync("TEST", filterTestRunResult).Result;
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
    public void GetSpecificTestPlan()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var testPlan = qaseAPI.GetSpecificTestPlanAsync("TEST", 1).Result;
    }

    [TestMethod]
    public void CreateNewTestPlan()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.CreateTestPlanAsync("TEST", new TestPlanRequest
      {
        Title = "new",
        Cases = new List<int>() { 1 }
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void UpdateTestPlan()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.UpdateTestPlanAsync("TEST", 1, new TestPlanRequest
      {
        Title = "Test testPlan",
        Description = "TestPlan description",
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void DeleteTestPlan()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteTestPlanAsync("TEST", 1).Result;
    }
  }
}
