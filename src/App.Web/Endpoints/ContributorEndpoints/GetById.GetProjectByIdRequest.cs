namespace App.Web.Endpoints.ContributorEndpoints;

public class GetContributorByIdRequest
{
  public const string Route = "/Contributors/{ContributorId:int}";
  public static string BuildRoute(string contributorId) => Route.Replace("{ContributorId:string}", contributorId);

  public string? ContributorId { get; set; }
}
