using NUnit.Framework;
using TestFramework.white.elements;
using TestStack.White;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.ScreenObjects;


namespace TestFramework.white
{
    public class BaseWindow: AppScreen
    {
        protected string WindowName;
        protected SearchCriteria Locator;
        protected Window window;
        protected string Title;

        public BaseWindow(Window window, string title) : base(window, null)
        {
            Title = title;
            // AssertIsOpen();
        }

        //        public (Window window, ScreenRepository screenRepository) : base (window, screenRepository)
        //        {
        //            //ApplicationFactory.SetWindow(window);
        //            Locator = locator;
        //            Title = title;
        //            AssertIsOpen();
        //        }

        public void AssertIsOpen()
        {
            var label = new Label(SearchCriteria.ByText(ApplicationFactory.Window.Title), $"{Title} Locator");
            try
            {
                label.AssertIsPresent();
            }
            catch (AssertionException e)
            {
                //Logger.Debug(e.Message);
            }            
        }      
    }
}
