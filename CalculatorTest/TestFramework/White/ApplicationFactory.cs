using TestStack.White;
using TestStack.White.Factory;
using TestStack.White.UIItems.Finders;
using TestStack.White.UIItems.WindowItems;

namespace TestFramework.white
{
    public static class ApplicationFactory
    {
        private static Application _application;
        private static string _windowName;

        public static Application Application { get; }

        public static void Launch(string appName, string windowName)
        {
            _application = Application.Launch(appName);
            _windowName = _application.GetWindow(windowName).Title;
        }

        public static void Close()
        {
            Window.Close();
            _application.Kill();
        }

        public static Window Window => _application.GetWindow(_windowName);






//        public static void SetWindow(Window window)
//        {
//            _windowName = window;
//        }
//
//
//        public TestStack.White.UIItems.WindowItems.Window GetWindow(string windowName)
//        {
//            return _application.GetWindow(SearchCriteria.ByText(windowName), InitializeOption.NoCache);
//        }
//
//        public void CreateWindow(string windowName)
//        {
//            _windowName = _application.GetWindow(SearchCriteria.ByText(windowName), InitializeOption.NoCache);
//        }
    }
}
