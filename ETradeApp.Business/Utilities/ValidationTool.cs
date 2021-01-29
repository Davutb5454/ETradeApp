using ETradeApp.Entities.Abstract;
using ETradeApp.Entities.Concrete;
using FluentValidation;

namespace ETradeApp.Business.Utilities
{
    public static class ValidationTool
    {
        public static void Validate(AbstractValidator<Product> validator,object entity)
        {
            var result = validator.Validate((Product) entity);
            if (result.Errors.Count > 0)
            {
                throw new ValidationException(result.Errors);
            }
        }
    }
}