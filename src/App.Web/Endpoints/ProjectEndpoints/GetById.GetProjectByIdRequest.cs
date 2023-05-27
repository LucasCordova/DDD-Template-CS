
namespace App.Web.Endpoints.ProjectEndpoints;

public class GetProjectByIdRequest
{
  public const string Route = "/Projects/{ProjectId:int}";
  public static string BuildRoute(string projectId) => Route.Replace("{ProjectId:string}", projectId);

  public string? ProjectId { get; set; }
}
