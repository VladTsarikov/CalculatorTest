using System;
using Calculator.Windows.Menu;
using CalculatorTest.test.calculator.enums;
using Castle.Core.Internal;
using TestFramework.white;
using TestFramework.white.elements;
using TestStack.White.UIItems.Finders;

namespace Calculator.windows
{
    public class MainWindow: BaseWindow
    {
       // private new const string WindowName = "Calculator";
        private const string MainLocator = "150";
        public MenuBar MainMenu = new MenuBar();
        private const string FuncButtonNamePart = "12";

        public MainWindow() : base(ApplicationFactory.Window,"Main Calculator Window")
        {
        }

        private static void ClickNumeral(int number)
        {
            new Button(SearchCriteria.ByAutomationId($"13{number}"), $"Button {number}").Click();
        }

        public void EnterNumber(string number)
        {
            number.ToCharArray().ForEach(numb=>ClickNumeral(int.Parse(numb.ToString())));
        }

        public void ClickFunctionButton(ButtonsEnum.FunctionButton function)
        {
            switch (function)
            {
                case ButtonsEnum.FunctionButton.SaveToMemory:
                    new Button(SearchCriteria.ByAutomationId($"{FuncButtonNamePart}5"), $"{ButtonsEnum.FunctionButton.SaveToMemory} Button").Click();
                    break;
                case ButtonsEnum.FunctionButton.MemoryClear:
                    new Button(SearchCriteria.ByAutomationId($"{FuncButtonNamePart}2"), $"{ButtonsEnum.FunctionButton.MemoryClear} Button").Click();
                    break;
                case ButtonsEnum.FunctionButton.UseMemory:
                    new Button(SearchCriteria.ByAutomationId($"{FuncButtonNamePart}3"), $"{ButtonsEnum.FunctionButton.UseMemory} Button").Click();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(function), function, null);
            }
        }

        public void ClickOperatorsButton(ButtonsEnum.OperatorsButton operators)
        {
            switch (operators)
            {
                case ButtonsEnum.OperatorsButton.Plus:
                    new Button(SearchCriteria.ByAutomationId("93"), $"{ButtonsEnum.OperatorsButton.Plus} Button").Click();
                    break;
                case ButtonsEnum.OperatorsButton.Result:
                    new Button(SearchCriteria.ByAutomationId("121"), $"{ButtonsEnum.OperatorsButton.Result} Button").Click();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(operators), operators, null);
            }
        }

        public string GetResult()
        {
            return new Label(SearchCriteria.ByAutomationId("150"), "Result Field Label").GetPropertyValue();
        }
    }
}
