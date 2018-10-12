using NUnit.Framework;
using TestFramework.white.elements;
using TestStack.White.UIItems.Finders;

namespace TestFramework.white
{
    public class BaseWindow: BaseEntity
    {
        protected string WindowName;
        protected SearchCriteria Locator;
        protected string Title;

        public BaseWindow(string windowName, SearchCriteria locator, string title)
        {
            SetWindow(windowName);
            Init(windowName, locator, title);
            AssertIsOpen();
        }

        public void AssertIsOpen()
        {
            var label = new Label(Locator,$"{Title} Locator");
            try
            {
                label.AssertIsPresent();
            }
            catch (AssertionException e)
            {
                Logger.Debug(e.Message);
            }
            
        }

        public void Init(string windowName, SearchCriteria locator, string title)
        {
            WindowName = windowName;
            Locator = locator;
            Title = title;
        }
    }
}
