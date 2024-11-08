using MediaTRAndDapper.Common;

namespace MediaTRAndDapper.CQRS.Commands.Query.CategoryQuery;

public sealed record GetCagetoryNameQuery(string Name) : IQuery<GetCategoryNameQueryRequest?>
{
}
