using System.ComponentModel.DataAnnotations;

namespace Worthix.API.Domain.Utils
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
