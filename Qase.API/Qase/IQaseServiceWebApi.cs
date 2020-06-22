using Qase.API.Qase.Model.Projects;
using Refit;
using System.Threading.Tasks;

namespace Qase.API.Qase
{
  public interface IQaseServiceWebApi
  {
    /// <summary>
    /// Get All Projects
    /// </summary>
    /// <param name="api_token"></param>
    /// <returns></returns>
    [Get("/project")]
    Task<ProjectsResponse> GetAllProjects([Header("Token")] string api_token);
  }
}
