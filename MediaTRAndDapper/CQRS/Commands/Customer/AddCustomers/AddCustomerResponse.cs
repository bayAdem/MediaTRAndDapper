namespace MediaTRAndDapper.CQRS.Commands.Customer.AddCustomers;

public class AddCustomerResponse
{
    public int Id { get; }

    public AddCustomerResponse(int id)
    {
        Id = id;
    }
}
