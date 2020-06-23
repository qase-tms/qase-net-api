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
  public class QaseAPITestCases
  {

    [TestMethod]
    public void GetAllTestCases()
    {
      QaseAPI qaseAPI = new QaseAPI();
      try
      {
        var testCases = qaseAPI.GetAllTestCasesAsync("TEST").Result;
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
    public void GetSpecificTestCase()
    {
      QaseAPI qaseAPI = new QaseAPI();
      var testCase = qaseAPI.GetSpecificTestCaseAsync("TEST", 1).Result;
    }


    [TestMethod]
    public void DeleteTestCase()
    {
      QaseAPI qaseAPI = new QaseAPI();

      var testCase = qaseAPI.DeleteTestCaseAsync("TEST", 1).Result;

    }
  }
}
