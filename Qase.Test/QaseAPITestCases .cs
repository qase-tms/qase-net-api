using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API;
using Qase.API.Qase;
using Qase.API.Qase.Model;
using Qase.API.Qase.Model.TestCases;
using Refit;
using System;
using System.Collections.Generic;

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
        BaseFilter filterCases = new BaseFilter();
        filterCases.DictionaryFilters.Add($"filters[{TypeFilter.type}]", new List<string>() { TypeCase.other.ToString(), TypeCase.performance.ToString() });

        var testCases = qaseAPI.GetAllTestCasesAsync("TEST", filterCases).Result;
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
