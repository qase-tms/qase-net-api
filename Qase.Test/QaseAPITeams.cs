using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Refit;
using System;

namespace Qase.Test
{
  [TestClass]
  public class QaseAPITeams
  {
    [TestMethod]
    public void GetAllTeams()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      try
      {
        BaseFilter filterTestRunResult = new BaseFilter();

        var teams = qaseAPI.GetAllTeamsAsync("TEST", filterTestRunResult).Result;
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
    public void GetSpecificTeam()
    {
      QaseAPI qaseAPI = new QaseAPI("https://api.qase.io/v1", "your api token");
      var team = qaseAPI.GetSpecificTeamAsync("TEST", 1).Result;
    }
  }
}
