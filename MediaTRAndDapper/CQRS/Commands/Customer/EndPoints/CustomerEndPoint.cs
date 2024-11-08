using FastEndpoints;
using MediatR;
using MediaTRAndDapper.CQRS.Commands.Customer.AddCustomers;

namespace MediaTRAndDapper.CQRS.Commands.Customer.EndPoints
{
    public class CustomerEndPoint(ISender sender) : Endpoint<AddCustomerRequest>
    {
        private readonly ISender _sender = sender;

        public override void Configure()
        {
            Post("/AddCustomer");
            AllowAnonymous();
        }
        public override async Task HandleAsync(AddCustomerRequest req, CancellationToken ct)
        {
            ArgumentNullException.ThrowIfNull(req);
            var command = new AddCustomerCommand(
                req.Id,
                req.FullName,
                req.Email,
                req.PhoneNumber,
                req.Address,
                req.CreatedAt,
                req.OrdersId
                );
            await _sender.Send(command, ct);
            await SendAsync(req.OrdersId, statusCode: StatusCodes.Status201Created, ct);
        }
    }
}
