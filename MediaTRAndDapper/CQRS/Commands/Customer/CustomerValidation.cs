using FluentValidation;

namespace MediaTRAndDapper.CQRS.Commands.Customer
{

    public class CustomerValidator : AbstractValidator<Models.Customer>
    {
        public CustomerValidator()
        {
            RuleFor(customer => customer.FullName)
                .NotEmpty().WithMessage("FullName is required.")
                .Length(1, 100).WithMessage("FullName cannot be longer than 100 characters.");

            RuleFor(customer => customer.Email)
                .NotEmpty().WithMessage("Email is required.")
                .EmailAddress().WithMessage("Invalid email address.")
                .Length(1, 200).WithMessage("Email cannot be longer than 200 characters.");

            RuleFor(customer => customer.PhoneNumber)
                .NotEmpty().WithMessage("PhoneNumber is required.")
                .Matches(@"^\+?\d{10,15}$").WithMessage("Invalid phone number.");

            RuleFor(customer => customer.Address)
                .NotEmpty().WithMessage("Address is required.")
                .Length(1, 500).WithMessage("Address cannot be longer than 500 characters.");

            RuleFor(customer => customer.CreatedAt)
           .NotEmpty().WithMessage("CreatedAt is required.");

            RuleFor(customer => customer.Orders)
                .NotEmpty().WithMessage("Orders are required.")
                .Must(orders => orders.Count > 0).WithMessage("Orders cannot be empty.");
        }
    }
}
