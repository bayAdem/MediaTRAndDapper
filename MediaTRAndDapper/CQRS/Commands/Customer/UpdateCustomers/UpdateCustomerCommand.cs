using MediaTRAndDapper.Common;
using MediaTRAndDapper.Models;

namespace MediaTRAndDapper.CQRS.Commands.Customer.UpdateCustomers;

public sealed record UpdateCustomerCommand(int Id,
                                           string FullName,
                                           string Email,
                                           string PhoneNumber,
                                           string Address,
                                           string CreatedAt,
                                           ICollection<Order> OrdersId) : ICommand
{
}
