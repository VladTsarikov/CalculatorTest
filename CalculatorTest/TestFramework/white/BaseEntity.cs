using NUnit.Framework;

namespace TestFramework.white
{
    public class BaseEntity
    {
        private static TestStack.White.UIItems.WindowItems.Window _window;
        protected static Logger Logger = Logger.GetInstance();
        private static readonly string AppPath = AppResource.app_path;
        private static readonly string AppExtension = AppResource.app_extension;
        private static readonly string AppName = AppResource.app_name;

        public static ApplicationFactory GetApplication()
        {           
            return ApplicationFactory.GetInstance();
        }

        public static TestStack.White.UIItems.WindowItems.Window GetWindow()
        {     
            return _window;
        }

        public void SetWindow(string window)
        {
            _window = GetApplication().GetWindow(window);
        }

        protected void Info(string message)
        {
            Logger.Info(message);
        }

        protected void Debug(string message)
        {
            Logger.Debug(message);
        }

        protected void Error(string message)
        {
            Logger.Error(message);
        }

        protected void Fatal(string message)
        {
            Logger.Fatal(message);
        }

        protected void LogStep(int step)
        {
            Logger.Step(step);
        }

        [SetUp]
        public static void BeforeTest()
        {
            Logger.Info(Messages.ResourceManager.GetString("test_start"));
            GetApplication().Launch($"{AppPath}{AppName}{AppExtension}");          
        }

        [TearDown]
        public static void AfterTest()
        {            
            Logger.Info(Messages.ResourceManager.GetString("test_end"));
            GetWindow().Close();
        }
    }
}
