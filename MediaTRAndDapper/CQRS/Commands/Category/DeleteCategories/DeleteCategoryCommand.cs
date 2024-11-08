using MediaTRAndDapper.Common;

namespace MediaTRAndDapper.CQRS.Commands.Category.DeleteCategories;

public sealed record DeleteCategoryCommand(int Id) : ICommand;
