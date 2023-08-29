using OpenQA.Selenium.Appium;

namespace CalculatorUITestFramework
{
    public class MemoryItem
    {
        public AppiumWebElement Item { get; }

        public MemoryItem(AppiumWebElement item)
        {
            Item = item;
        }

        public string GetValue()
        {
            return Item.Text;
        }
    }
}
