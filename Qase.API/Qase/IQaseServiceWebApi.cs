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

    /// <summary>
    /// Get a Specific Project
    /// </summary>
    /// <param name="api_token"></param>
    /// <param name="code"></param>
    /// <returns></returns>
    [Get("/project/{code}")]
    Task<SpecificProjectResponse> GetSpecificProject([Header("Token")] string api_token, string code);

    /// <summary>
    /// Create a new project
    /// </summary>
    /// <param name="projectRequest"></param>
    /// <returns></returns>
    [Post("/project")]
    Task<CreateProjectResponse> CreateNewProject([Header("Token")] string api_token, CreateProjectRequest createProjectRequest);
  }
}
