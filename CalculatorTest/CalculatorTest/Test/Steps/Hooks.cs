using TechTalk.SpecFlow;
using TestFramework.white;

namespace CalculatorTest.test.steps
{
    [Binding]
    internal class Hooks
    {
        [BeforeScenario]
        public void Before()
        {
            BaseEntity.BeforeTest();
        }

        [AfterScenario]
        public void After()
        {
            BaseEntity.AfterTest();       
        }
    }
}
