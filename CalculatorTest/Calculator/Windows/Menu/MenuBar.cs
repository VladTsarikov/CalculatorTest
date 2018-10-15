using TestFramework.white.elements;
using TestStack.White.UIItems.Finders;

namespace Calculator.Windows.Menu
{
    public class MenuBar
    {
        public enum MenuItem
        {
            View,
            Edit,
            Help,
        }

        public enum ViewItem
        {
            Standard,
            Scientific,
            Programmer,
        }

        public void ClickMenuItem(MenuItem menuItem)
        {
            new Label(SearchCriteria.ByText(menuItem.ToString()), menuItem + " Label").Click();
        }

        public void ChooseViewItem(ViewItem viewItem)
        {
            new Label(SearchCriteria.ByText(viewItem.ToString()), viewItem + " Label").Click();
        }
    }
}
