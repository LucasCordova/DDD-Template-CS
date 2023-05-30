using App.SharedKernel;
using App.SharedKernel.Interfaces;
using Ardalis.GuardClauses;

namespace App.Core.Entities.ContributorAggregate;

public class Contributor : EntityBase, IAggregateRoot
{
  public Contributor(string name)
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
  }

  public string Name { get; private set; }

  public void UpdateName(string newName)
  {
    Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }
}
