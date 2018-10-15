using Calculator.windows;
using Calculator.Windows.Menu;
using CalculatorTest.test.calculator.enums;
using NUnit.Framework;
using TechTalk.SpecFlow;

namespace CalculatorTest.test.steps
{
    [Binding]
    internal class CalculatorSteps
    {
        private MainWindow _mainWindow;     

        [Given("The calculator has opened in '(.*)' view")]
        public void OpenCalculatorMainWindow(MenuBar.ViewItem view)
        {
            _mainWindow = new MainWindow();
            _mainWindow.MainMenu.ClickMenuItem(MenuBar.MenuItem.View);
            _mainWindow.MainMenu.ChooseViewItem(view);
        }

        [When("I enter number '(.*)'")]
        public void ClickNumberButton(string number)
        {
            _mainWindow.EnterNumber(number);
        }

        [When("I press function button '(.*)'")]
        public void ClickFunctionButton(ButtonsEnum.FunctionButton function)
        {
            _mainWindow.ClickFunctionButton(function);
        }

        [When("I press operators button '(.*)'")]
        public void ClickOperatorsButton(ButtonsEnum.OperatorsButton operators)
        {
            _mainWindow.ClickOperatorsButton(operators);
        }

        [Then("The result of operation should be '(.*)'")]
        public void GetResult(string result)
        {
            Assert.AreEqual(result, _mainWindow.GetResult(),$"Result is not equal {result}");
        }
    }
}
