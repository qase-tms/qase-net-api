using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
using Qase.API.Qase.Model.Suites;
using Qase.API.Qase.Model.TestRunResults;
using Qase.API.Qase.Model.TestRuns;
using Refit;
using System;
using System.Collections.Generic;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPISuites
  {
    [TestMethod]
    public void GetAllSuites()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();
        filterTestRunResult.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "");

        var suites = qaseAPI.GetAllTestSuitesAsync("TEST", filterTestRunResult).Result;
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
    public void GetSpecificSuite()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var suite = qaseAPI.GetSpecificTestSuiteAsync("TEST", 1).Result;
    }

    [TestMethod]
    public void CreateNewSuite()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.CreateTestSuiteAsync("TEST", new SuiteRequest
      {
        Title = "Test suite",
        Description = "Suite description",
        Preconditions = "Suite preconditions"
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void UpdateSuite()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.UpdateTestSuiteAsync("TEST", 1, new SuiteRequest
      {
        Title = "Test suite title",
        Description = "Suite description",
        Preconditions = "Suite preconditions"
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void DeleteTestSuite()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteTestSuiteAsync("TEST", 2).Result;
    }
  }
}
