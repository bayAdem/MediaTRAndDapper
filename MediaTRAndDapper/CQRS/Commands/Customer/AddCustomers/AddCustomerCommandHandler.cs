using MediaTRAndDapper.Common;
using Platform.Api.Database.Repositories.Abstract;

namespace MediaTRAndDapper.CQRS.Commands.Customer.AddCustomers;

public class AddCustomerCommandHandler(ICustomerRepository customerRepository) : ICommand<AddCustomerCommand>
{
    private readonly ICustomerRepository _customerRepository = customerRepository;

    public async Task HandleAsync(AddCustomerCommand request, CancellationToken cancellationToken)
    {
        var customer = new Models.Customer
        {
            FullName = request.FullName,
            Email = request.Email,
            PhoneNumber = request.PhoneNumber,
            Address = request.Address,
            CreatedAt = request.CreatedAt,
            Orders = request.OrdersId.Select(orderId => new Models.Order { Id = orderId }).ToList() 
        };
        await _customerRepository.AddAsync(customer);
    }

}
