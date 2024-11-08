using MediaTRAndDapper.Common;

namespace MediaTRAndDapper.CQRS.Commands.Customer.DeleteCustomers;

public sealed record DeleteCustomerCommand(int Id) : ICommand
{
}
