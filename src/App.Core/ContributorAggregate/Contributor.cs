using Ardalis.GuardClauses;
using App.SharedKernel;
using App.SharedKernel.Interfaces;

namespace App.Core.ContributorAggregate;

public class Contributor : EntityBase<string>, IAggregateRoot
{
  public string Name { get; private set; }

  public Contributor(string name)
  {
    Name = Guard.Against.NullOrEmpty(name, nameof(name));
  }

  public void UpdateName(string newName)
  {
    Name = Guard.Against.NullOrEmpty(newName, nameof(newName));
  }
}
