using Entities.Concrete;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.ValidationRules.FluentValidation
{
   public class CarValidator: AbstractValidator<Car>
    {
        public CarValidator()
        {
            RuleFor(c => c.Description).MinimumLength(2).WithMessage("Araç adı en az 2 harf olmalı");
            RuleFor(c => c.DailyPrice).NotEqual(0).WithMessage("Araç fiyatı 0 dan büyük olmalı"); ;
        }
    }
}
