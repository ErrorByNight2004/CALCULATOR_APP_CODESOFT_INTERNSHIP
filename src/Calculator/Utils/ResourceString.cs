using CalculatorApp.ViewModel.Common;
using Windows.UI.Xaml.Markup;

namespace CalculatorApp.Utils
{
    [MarkupExtensionReturnType(ReturnType = typeof(string))]
    public sealed class ResourceString : MarkupExtension
    {
        public string Name { get; set; }

        protected override object ProvideValue()
        {
            return AppResourceProvider.GetInstance().GetResourceString(this.Name);
        }
    }
}
