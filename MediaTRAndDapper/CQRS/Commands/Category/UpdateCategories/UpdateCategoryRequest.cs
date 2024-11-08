using FastEndpoints;
using MediatR;
using MediaTRAndDapper.Common;
using MediaTRAndDapper.Models;
using ICommand = MediaTRAndDapper.Common.ICommand;

namespace MediaTRAndDapper.CQRS.Commands.Category.UpdateCategories;

public sealed record UpdateCategoryRequest(
    int Id,
    string Name,
    string Description,
    DateTime? CreatedAt,
    ICollection<int> ProductIds) : IRequest<UpdateCategoryResponse>;
