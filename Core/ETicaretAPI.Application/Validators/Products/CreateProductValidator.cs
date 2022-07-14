using ETicaretAPI.Application.ViewModels.Products;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretAPI.Application.Validators.Products
{
    public class CreateProductValidator : AbstractValidator<VM_Create_Product>
    {
        public CreateProductValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen ürün adını boş geçmeyiniz.")
                .MaximumLength(150)
                .MinimumLength(2)
                .WithMessage("Lütfen ürün adını 2-150 karakter arasında giriniz.");
            RuleFor(c => c.Stock)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen stok bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Stok bilgisi negatif olamaz.");
            RuleFor(c => c.Price)
                .NotEmpty()
                .NotNull()
                .WithMessage("Lütfen price bilgisini boş geçmeyiniz.")
                .Must(s => s >= 0)
                .WithMessage("Price bilgisi negatif olamaz.");


        }
    }
}
