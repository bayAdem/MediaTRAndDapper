using MediaTRAndDapper.CQRS.Commands.Customer.AddCustomers;
public static class AddCustomerMapping
{
    public static AddCustomerCommand AddCustomerCommandMapping(this AddCustomerRequest request, int Id)
    {
        ArgumentNullException.ThrowIfNull(request);
               
        return new AddCustomerCommand(
            Id,
            request.FullName,
            request.Email,
            request.PhoneNumber,
            request.Address,
            request.CreatedAt,
            request.OrdersId         
        );
    }
}
