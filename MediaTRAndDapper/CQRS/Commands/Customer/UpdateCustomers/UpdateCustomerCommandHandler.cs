using MediaTRAndDapper.Common;
using Platform.Api.Database.Repositories.Abstract;

namespace MediaTRAndDapper.CQRS.Commands.Customer.UpdateCustomers
{
    public class UpdateCustomerCommandHandler(ICustomerRepository customerRepository) : ICommandHandler<UpdateCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository = customerRepository;
        public async Task Handle(UpdateCustomerCommand request, CancellationToken cancellationToken)
        {
            var customer = new Models.Customer
            {
                Id = request.Id,
                FullName = request.FullName,
                Email = request.Email,
                PhoneNumber = request.PhoneNumber,
                Address = request.Address,
                CreatedAt = DateTime.TryParse(request.CreatedAt, out var createdAt) ? createdAt : DateTime.Now,
                Orders = request.OrdersId
            };
            await _customerRepository.UpdateAsync(customer);
        }
    }
}
