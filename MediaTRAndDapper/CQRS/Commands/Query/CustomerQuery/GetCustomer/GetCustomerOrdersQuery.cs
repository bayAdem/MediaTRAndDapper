using MediatR;

namespace MediaTRAndDapper.CQRS.Commands.Query.CustomerQuery.GetCustomer;
public class GetCustomerOrdersQuery : IRequest<IEnumerable<Models.Order>>
{
    public int CustomerId { get; set; }

    public GetCustomerOrdersQuery(int customerId)
    {
        CustomerId = customerId;
    }
}
