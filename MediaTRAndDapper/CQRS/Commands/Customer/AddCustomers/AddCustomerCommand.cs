using MediaTRAndDapper.Common;
using MediaTRAndDapper.Models;

namespace MediaTRAndDapper.CQRS.Commands.Customer.AddCustomers;

public sealed record AddCustomerCommand(
    int Id,
    string FullName,
    string Email,
    string PhoneNumber,
    string Address,
    DateTime CreatedAt,
    ICollection<int> OrdersId
) : ICommand;


