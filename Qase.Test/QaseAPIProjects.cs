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
  public class QaseAPIProjects
  {
    [TestMethod]
    public void GetAllProjects()
    {
      QaseAPI qaseAPI = new QaseAPI();
      try
      {
        var projects = qaseAPI.GetAllProjectsAsync().Result;
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
  }
}
