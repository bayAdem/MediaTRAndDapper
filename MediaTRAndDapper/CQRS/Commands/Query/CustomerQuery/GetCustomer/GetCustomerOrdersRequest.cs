namespace MediaTRAndDapper.CQRS.Commands.Query.CustomerQuery.GetCustomer;

public class GetCustomerOrdersRequest
{
    public int CustomerId { get; set; }

    public GetCustomerOrdersRequest(int customerId)
    {
        CustomerId = customerId;
    }
}
