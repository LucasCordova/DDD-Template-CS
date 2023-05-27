﻿
namespace App.SharedKernel.Interfaces;

public interface IDomainEventDispatcher
{
  Task DispatchAndClearEvents(IEnumerable<EntityBase<string>> entitiesWithEvents);
}
