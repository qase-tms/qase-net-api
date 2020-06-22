using Microsoft.VisualStudio.TestTools.UnitTesting;
using Qase.API.Qase;

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
  }
}
