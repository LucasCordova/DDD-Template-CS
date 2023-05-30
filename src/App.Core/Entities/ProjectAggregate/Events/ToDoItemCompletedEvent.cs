using App.SharedKernel;

namespace App.Core.Entities.ProjectAggregate.Events;

public class ToDoItemCompletedEvent : DomainEventBase
{
  public ToDoItemCompletedEvent(ToDoItem completedItem)
  {
    CompletedItem = completedItem;
  }

  public ToDoItem CompletedItem { get; set; }
}
