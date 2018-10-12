using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;

namespace TestFramework.white
{
    public class ApplicationFactory
    {
        private static ApplicationFactory _instance;
        private static Application _application;

        private ApplicationFactory()
        {
        }

        public static ApplicationFactory GetInstance()
        {
            return _instance ?? (_instance = new ApplicationFactory());
        }

        public void Launch(string appName)
        {
            _application = Application.Launch(appName);
        }

        public TestStack.White.UIItems.WindowItems.Window GetWindow(string windowName)
        {
            return _application.GetWindow(SearchCriteria.ByText(windowName), InitializeOption.NoCache);
        }
    }
}
