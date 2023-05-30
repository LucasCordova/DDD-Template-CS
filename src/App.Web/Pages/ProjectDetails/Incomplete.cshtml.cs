using App.Core.Entities.ProjectAggregate;
using App.Core.Entities.ProjectAggregate.Specifications;
using App.SharedKernel.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace App.Web.Pages.ProjectDetails;

public class IncompleteModel : PageModel
{
  private readonly IRepository<Project> _repository;

  public IncompleteModel(IRepository<Project> repository)
  {
    _repository = repository;
  }

  [BindProperty(SupportsGet = true)] public int ProjectId { get; set; }

  public List<ToDoItem>? ToDoItems { get; set; }

  public async Task OnGetAsync()
  {
    var projectSpec = new ProjectByIdWithItemsSpec(ProjectId);
    var project = await _repository.FirstOrDefaultAsync(projectSpec);
    if (project == null)
    {
      return;
    }

    var spec = new IncompleteItemsSpec();

    ToDoItems = spec.Evaluate(project.Items).ToList();
  }
}
