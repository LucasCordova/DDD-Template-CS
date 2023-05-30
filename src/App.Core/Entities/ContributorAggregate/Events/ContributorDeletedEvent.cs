using App.SharedKernel;

namespace App.Core.Entities.ContributorAggregate.Events;

public class ContributorDeletedEvent : DomainEventBase
{
  public ContributorDeletedEvent(int contributorId)
  {
    ContributorId = contributorId;
  }

  public int ContributorId { get; set; }
}
