using CalculatorApp.ViewModel.Common;

namespace CalculatorApp
{
    namespace Controls
    {
        public sealed class RadixButton : Windows.UI.Xaml.Controls.RadioButton
        {
            public RadixButton()
            { }

            internal string GetRawDisplayValue()
            {
                string radixContent = Content?.ToString();
                return LocalizationSettings.GetInstance().RemoveGroupSeparators(radixContent);
            }
        }
    }
}
