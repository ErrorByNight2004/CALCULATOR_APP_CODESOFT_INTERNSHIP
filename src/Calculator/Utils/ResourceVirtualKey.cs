using CalculatorApp.ViewModel.Common;
using System;
using Windows.UI.Xaml.Markup;

namespace CalculatorApp.Utils
{
    [MarkupExtensionReturnType(ReturnType = typeof(MyVirtualKey))]
    public sealed class ResourceVirtualKey : MarkupExtension
    {
        public string Name { get; set; }

        protected override object ProvideValue()
        {
            var resourceString = AppResourceProvider.GetInstance().GetResourceString(this.Name);
            return Enum.Parse(typeof(MyVirtualKey), resourceString);
        }
    }
}
