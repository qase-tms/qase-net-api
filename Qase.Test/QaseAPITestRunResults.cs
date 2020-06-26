using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.TestRunResults;
using Refit;
using System;
using System.Collections.Generic;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPITestRunResults
  {
    [TestMethod]
    public void GetAllTestRunResults()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();
        filterTestRunResult.DictionaryFilters.Add($"filters[{TypeFilter.status}]", StatusTestRunResult.passed.ToString());

        var testRunResults = qaseAPI.GetAllTestRunResultsAsync("TEST", filterTestRunResult).Result;
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
    public void GetSpecificTestRunResult()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var testRunResult = qaseAPI.GetSpecificTestRunResultAsync("TEST", "5796a7fb165a0eff2a7de3436485154beff88afc").Result;
    }

    [TestMethod]
    public void AddTestRunResult()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var steps = new List<StepTestRunResult>();

      steps.Add(new StepTestRunResult
      {
        Position = 1,
        Status = "failed",
        Comment = "Something went wrong",
        Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
      });

      try
      {
        var hash = (qaseAPI.AddTestRunResultAsync("TEST", 2, new AddTestRunResultRequest
        {
          CaseId = 1,
          Time = 100,
          Status = "failed",
          MemberId = 1,
          Comment = "Failed via API .Net",
          Defect = true,
          Steps = steps,
          Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
        }).Result)
      .Result.Hash;
      }
      catch (Exception ex)
      {
      }
    }

    [TestMethod]
    public void UpdateTestRunResult()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var steps = new List<StepTestRunResult>();
      steps.Add(new StepTestRunResult
      {
        Position = 1,
        Status = "passed"
      });

      var hash = (qaseAPI.UpdateTestRunResultAsync("TEST", 2, "c0def82a1d5e2df80d991a917c21df0944b49b7b", new UpdateTestRunResultRequest
      {
        Time = 100,
        Status = "passed",
        Comment = "Failed via API v2 .Net",
        Defect = true,
        Steps = steps,
        Attachments = new List<string>() { "2898ba7f3b4d857cec8bee4a852cdc85f8b33132" }
      }).Result)
      .Result.Hash;
    }

    [TestMethod]
    public void DeleteTestRunResult()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteTestRunResultAsync("TEST", 4, "").Result;
    }
  }
}
