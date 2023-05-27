using App.SharedKernel;

namespace App.Core.ContributorAggregate.Events;

public class ContributorDeletedEvent : DomainEventBase
{
  public string ContributorId { get; set; }

  public ContributorDeletedEvent(string contributorId)
  {
    ContributorId = contributorId;
  }
}
