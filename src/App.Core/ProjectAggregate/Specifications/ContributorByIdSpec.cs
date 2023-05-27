using Ardalis.Specification;
using App.Core.ContributorAggregate;

namespace App.Core.ProjectAggregate.Specifications;

public class ContributorByIdSpec : Specification<Contributor>, ISingleResultSpecification
{
  public ContributorByIdSpec(string contributorId)
  {
    Query
        .Where(contributor => contributor.Id == contributorId);
  }
}
