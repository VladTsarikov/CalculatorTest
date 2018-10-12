using System.Globalization;
using System.Reflection;
using System.Resources;

namespace TestFramework.white
{
    public class ResourcesReader
    {
        private readonly ResourceManager _resourceManager;

        public ResourcesReader(string resourcesFileName)
        {
            _resourceManager = new ResourceManager(resourcesFileName,
                Assembly.GetExecutingAssembly());
        }

        public string GetResourceValue(string valueName)
        {
            return _resourceManager.GetString(valueName, CultureInfo.CurrentCulture);
        }
    }
}
