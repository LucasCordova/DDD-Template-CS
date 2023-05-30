using App.Core.Entities.ContributorAggregate;
using App.Core.Services;
using App.SharedKernel.Interfaces;
using Ardalis.Result;
using MediatR;
using Moq;
using Xunit;

namespace App.UnitTests.Core.Services;

public class DeleteContributorService_DeleteContributor
{
  private readonly Mock<IMediator> _mockMediator = new();
  private readonly Mock<IRepository<Contributor>> _mockRepo = new();
  private readonly DeleteContributorService _service;

  public DeleteContributorService_DeleteContributor()
  {
    _service = new DeleteContributorService(_mockRepo.Object, _mockMediator.Object);
  }

  [Fact]
  public async Task ReturnsNotFoundGivenCantFindContributor()
  {
    var result = await _service.DeleteContributor(0);

    Assert.Equal(ResultStatus.NotFound, result.Status);
  }
}
