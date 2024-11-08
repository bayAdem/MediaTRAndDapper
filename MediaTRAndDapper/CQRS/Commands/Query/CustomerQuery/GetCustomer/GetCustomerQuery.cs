using MediatR;

namespace MediaTRAndDapper.CQRS.Commands.Query.CustomerQuery.GetCustomer;
public class GetCustomerQuery : IRequest<Models.Customer>
{
    public int Id { get; set; }

    public GetCustomerQuery(int id)
    {
        Id = id;
    }
}
