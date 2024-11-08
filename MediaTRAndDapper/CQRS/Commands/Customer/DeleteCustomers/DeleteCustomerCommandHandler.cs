using MediaTRAndDapper.Common;
using Platform.Api.Database.Repositories.Abstract;

namespace MediaTRAndDapper.CQRS.Commands.Customer.DeleteCustomers
{
    public class DeleteCustomerCommandHandler(ICustomerRepository customerRepository) : ICommandHandler<DeleteCustomerCommand>
    {
        private readonly ICustomerRepository _customerRepository = customerRepository;

        public async Task Handle(DeleteCustomerCommand request, CancellationToken cancellationToken)
        {
            if (request.Id == null)
            {
                throw new ArgumentException("Id bulunamadı");
            }
            await _customerRepository.DeleteAsync(request.Id);
        }
    }
}
