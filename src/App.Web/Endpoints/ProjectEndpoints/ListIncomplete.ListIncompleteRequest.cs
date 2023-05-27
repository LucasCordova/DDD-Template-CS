using Microsoft.AspNetCore.Mvc;

namespace App.Web.Endpoints.ProjectEndpoints;

public class ListIncompleteRequest
{
  [FromRoute]
  public string? ProjectId { get; set; }
  [FromQuery]
  public string? SearchString { get; set; }
}
