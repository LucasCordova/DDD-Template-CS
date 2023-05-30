using App.Core.Entities.ContributorAggregate;
using App.Core.Entities.ContributorAggregate.Events;
using App.Core.Interfaces;
using App.SharedKernel.Interfaces;
using Ardalis.Result;
using MediatR;

namespace App.Core.Services;

public class DeleteContributorService : IDeleteContributorService
{
  private readonly IMediator _mediator;
  private readonly IRepository<Contributor> _repository;

  public DeleteContributorService(IRepository<Contributor> repository, IMediator mediator)
  {
    _repository = repository;
    _mediator = mediator;
  }

  public async Task<Result> DeleteContributor(int contributorId)
  {
    var aggregateToDelete = await _repository.GetByIdAsync(contributorId);
    if (aggregateToDelete == null)
    {
      return Result.NotFound();
    }

    await _repository.DeleteAsync(aggregateToDelete);
    var domainEvent = new ContributorDeletedEvent(contributorId);
    await _mediator.Publish(domainEvent);
    return Result.Success();
  }
}
