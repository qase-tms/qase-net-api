using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Projects;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPITest
  {
    [TestMethod]
    public void GetAllProjects()
    {
      QaseAPI qaseAPI = new QaseAPI();
      var projects = qaseAPI.GetAllProjectsAsync().Result;
    }

    [TestMethod]
    public void GetSpecificProject()
    {
      QaseAPI qaseAPI = new QaseAPI();
      var project = qaseAPI.GetSpecificProjectAsync("CFT").Result;
    }

    [TestMethod]
    public void CreateNewProject()
    {
      QaseAPI qaseAPI = new QaseAPI();
      var project = qaseAPI.CreateNewProjectAsync(new CreateProjectRequest
      {
         Title = "TestNet",
         Code = "TESTNET",
         Description = "Test project .Net",
         Access =  AccessLevel.All.ToString(),
         Group = null
      }).Result;
    }

    [TestMethod]
    public void GetAllTestCases()
    {
      QaseAPI qaseAPI = new QaseAPI();
      var testCases = qaseAPI.GetAllTestCasesAsync("CFT").Result;
    }

    [TestMethod]
    public void GetSpecificTestCase()
    {
      QaseAPI qaseAPI = new QaseAPI();
      try
      {
        var testCase = qaseAPI.GetSpecificTestCaseAsync("CFT", 1).Result;
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
    public void DeleteTestCase()
    {
      QaseAPI qaseAPI = new QaseAPI();

      var testCase = qaseAPI.DeleteTestCaseAsync("CFT", 2).Result;

    }
  }
}
