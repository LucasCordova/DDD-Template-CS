using Ardalis.Result;
using App.Core.ProjectAggregate;

namespace App.Core.Interfaces;

public interface IToDoItemSearchService
{
  Task<Result<ToDoItem>> GetNextIncompleteItemAsync(string projectId);
  Task<Result<List<ToDoItem>>> GetAllIncompleteItemsAsync(string projectId, string searchString);
}
