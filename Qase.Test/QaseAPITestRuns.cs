using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
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
      QaseAPI qaseAPI = new QaseAPI();
      try
      {
        var testRuns = qaseAPI.GetAllTestRunsAsync("CFT").Result;
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
      QaseAPI qaseAPI = new QaseAPI();
      var testRun = qaseAPI.GetSpecificTestRunAsync("CFT", 1).Result;
    }

    [TestMethod]
    public void CreateNewTestRun()
    {
      QaseAPI qaseAPI = new QaseAPI();

      var cases = new List<int>();
      cases.Add(1);

      var id = qaseAPI.CreateNewTestRunAsync("CFT", new CreateTestRunRequest
      {
        Title = "TestNet",
        Description = "Test project .Net",
        Cases = cases
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void DeleteTestCase()
    {
      QaseAPI qaseAPI = new QaseAPI();

      var resp = qaseAPI.DeleteTestRunAsync("CFT", 4).Result;
    }
  }
}
