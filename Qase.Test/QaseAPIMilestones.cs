using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.Milestones;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPIMilestones
  {
    [TestMethod]
    public void GetAllMilestones()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();
        filterTestRunResult.DictionaryFilters.Add($"filters[{TypeFilter.search}]", "");

        var milestones = qaseAPI.GetAllMilestonesAsync("IC", filterTestRunResult).Result;
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
    public void GetSpecificMilestone()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var milestone = qaseAPI.GetSpecificMilestoneAsync("IC", 1).Result;
    }

    [TestMethod]
    public void CreateNewMilestone()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.CreateMilestoneAsync("TEST", new MilestoneRequest
      { 
        Title = "new"
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void UpdateMilestone()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var id = qaseAPI.UpdateMilestoneAsync("TEST", 1, new MilestoneRequest
      {
        Title = "Test milestone",
        Description = "Milestone description",
      }).Result
      .Result.Id;
    }

    [TestMethod]
    public void DeleteMilestone()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");

      var resp = qaseAPI.DeleteMilestoneAsync("TEST", 1).Result;
    }
  }
}
