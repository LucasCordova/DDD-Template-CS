using App.SharedKernel;

namespace App.Core.ProjectAggregate.Events;

public class ContributorAddedToItemEvent : DomainEventBase
{
  public string ContributorId { get; set; }
  public ToDoItem Item { get; set; }

  public ContributorAddedToItemEvent(ToDoItem item, string contributorId)
  {
    Item = item;
    ContributorId = contributorId;
  }
}
