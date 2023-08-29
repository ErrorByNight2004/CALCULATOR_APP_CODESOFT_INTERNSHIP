using System.Collections.Generic;

using Windows.UI.Xaml.Automation.Peers;

namespace CalculatorApp
{
    namespace Controls
    {
        public sealed class OverflowTextBlockAutomationPeer : Windows.UI.Xaml.Automation.Peers.FrameworkElementAutomationPeer
        {
            public OverflowTextBlockAutomationPeer(OverflowTextBlock owner) : base(owner)
            {
            }

            protected override AutomationControlType GetAutomationControlTypeCore()
            {
                return AutomationControlType.Text;
            }

            protected override IList<AutomationPeer> GetChildrenCore()
            {
                return null;
            }
        }
    }
}
