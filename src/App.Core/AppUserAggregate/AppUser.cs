using Ardalis.GuardClauses;
using App.SharedKernel;
using App.SharedKernel.Interfaces;

namespace App.Core.ContributorAggregate;

public class AppUser : EntityBase<string>, IAggregateRoot
{
  public string FirstName { get; private set; }
  public string LastName { get; private set; }

  public AppUser(string firstName, string lastName)
  {
    FirstName = Guard.Against.NullOrEmpty(firstName, nameof(firstName));
    LastName = Guard.Against.NullOrEmpty(firstName, nameof(lastName));
  }

  public void UpdateFirstName(string newFirstName)
  {
    FirstName = Guard.Against.NullOrEmpty(newFirstName, nameof(newFirstName));
  }

  public void UpdateLastName(string newLastName)
  {
    FirstName = Guard.Against.NullOrEmpty(newLastName, nameof(newLastName));
  }
}
