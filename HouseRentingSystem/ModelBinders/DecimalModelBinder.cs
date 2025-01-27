using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Globalization;

namespace HouseRentingSystem.ModelBinders
{
    public class DecimalModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            // Check if bindingContext is valid
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            ValueProviderResult valueResult = bindingContext.ValueProvider
                .GetValue(bindingContext.ModelName);

            if (valueResult != ValueProviderResult.None && !string.IsNullOrEmpty(valueResult.FirstValue))
            {
                decimal result = 0M;
                bool success = false;

                try
                {
                    // Normalize the input value to use the current culture's decimal separator
                    string strValue = valueResult.FirstValue.Trim();
                    strValue = strValue.Replace(".", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
                    strValue = strValue.Replace(",", CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);

                    // Attempt to convert to decimal
                    result = Convert.ToDecimal(strValue, CultureInfo.CurrentCulture);
                    success = true;
                }
                catch (FormatException)
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Invalid decimal format.");
                }

                if (success)
                {
                    bindingContext.Result = ModelBindingResult.Success(result);
                }
                else
                {
                    bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Failed to bind decimal value.");
                }
            }
            else
            {
                bindingContext.ModelState.AddModelError(bindingContext.ModelName, "Value is required.");
            }

            return Task.CompletedTask;
        }
    }
}
