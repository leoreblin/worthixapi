using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Worthix.API.Application.Utils
{
    public class CustomValidationCpfAttribute : ValidationAttribute
    {
        public CustomValidationCpfAttribute()
        {

        }

        public override bool IsValid(object value)
        {
            if (value == null || string.IsNullOrEmpty(value.ToString()))
                return true;

            bool valido = Util.ValidaCpf(value.ToString());

            return valido;
        }
    }
}
