using Domain.Layer.Models;
using FluentValidation;

namespace Crud.Api.FluentValidator
{
    public class CustomerValidator : AbstractValidator<Customer>
    {

        public CustomerValidator()
        {
            RuleFor(x=>x.Name).NotNull().Empty();
            RuleFor(x => x.LastName).NotNull().Empty();
            RuleFor(x => x.Email).NotNull().EmailAddress().Empty();
        }



    }
}
