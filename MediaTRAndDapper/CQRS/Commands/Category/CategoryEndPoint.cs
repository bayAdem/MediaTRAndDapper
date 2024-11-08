using FastEndpoints;
using MediatR;
using MediaTRAndDapper.CQRS.Commands.Category.AddCategories;
using MediaTRAndDapper.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Xml.Linq;

namespace MediaTRAndDapper.CQRS.Commands.Category;

public class CategoryEndPoint(ISender sender) : Endpoint<AddCategoryRequest>
{
    private readonly ISender _sender = sender;

    public override void Configure()
    {
        Post("AddCategory");
        AllowAnonymous();
    }

    public override async Task HandleAsync(AddCategoryRequest request, CancellationToken ct)
    {
        ArgumentNullException.ThrowIfNull(request);

        // AddCategoryCommand nesnesini elle oluşturmalısınız
        var command = new AddCategoryCommand(
           request.Id,
           request.Name,
           request.Description,
           request.CreatedAt,
           request.ProductId
        );

        await _sender.Send(command, ct);
        await SendAsync(request.Id, statusCode: StatusCodes.Status201Created, ct);
    }
}

