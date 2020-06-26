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
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filter = new BaseFilter();
        filter.limit = 100;
        filter.offset = 0;
        var projects = qaseAPI.GetAllProjectsAsync(filter).Result;
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
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var project = qaseAPI.GetSpecificProjectAsync("TEST").Result;
    }

    [TestMethod]
    public void CreateNewProject()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
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
