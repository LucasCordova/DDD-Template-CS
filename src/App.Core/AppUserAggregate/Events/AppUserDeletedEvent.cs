using App.SharedKernel;

namespace App.Core.AppUserAggregate.Events;

public class AppUserDeletedEvent : DomainEventBase
{
  public int AppUserId { get; set; }

  public AppUserDeletedEvent(int appUserId)
  {
    AppUserId = appUserId;
  }
}
