using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.SharedSteps;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPISharedSteps
  {
    [TestMethod]
    public void GetAllSharedSteps()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();
        //filterTestRunResult.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "");

        var sharedSteps = qaseAPI.GetAllSharedStepsAsync("TEST", filterTestRunResult).Result;
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
    public void GetSpecificSharedStep()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var sharedStep = qaseAPI.GetSpecificSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7").Result;
    }

    [TestMethod]
    public void CreateNewSharedStep()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var hash = qaseAPI.CreateSharedStepAsync("TEST", new SharedStepRequest
      { 
        Title = "Test SharedStep",
        Action = "test"
      }).Result
      .Result.Hash;
    }

    [TestMethod]
    public void UpdateSharedStep()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var hash = qaseAPI.UpdateSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7", new SharedStepRequest
      {
        Title = "Test SharedStep",
        Action = "test up"
      }).Result
      .Result.Hash;
    }

    [TestMethod]
    public void DeleteSharedStep()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteSharedStepAsync("TEST", "7d03f27a6a841fa50019a16d47a86d855da50da7").Result;
    }
  }
}
