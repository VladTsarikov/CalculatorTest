﻿using System;
using System.Windows.Automation;
using NUnit.Framework;
using TestStack.White.UIItems;
using TestStack.White.UIItems.Finders;

namespace TestFramework.white.elements
{
    public class BaseElement : BaseEntity
    {
        protected string Name;
        protected SearchCriteria Locator;
        protected IUIItem Element;

        public BaseElement(SearchCriteria locator, string name)
        {
            Element = GetWindow().Get(locator);
            Name = name;
        }

        public void Click()
        {
            Info($"Clicking on {GetName()}");
            GetElement().Click();
        }

        public string GetPropertyValue()
        {
            return GetElement().AutomationElement.GetCurrentPropertyValue(AutomationElement.NameProperty).ToString();
        }

        public IUIItem GetElement()
        {
            return Element;
        }

        public void AssertIsPresent()
        {
            bool enabled;
            try
            {
                enabled = IsEnabled();
            }
            catch (Exception ex)
            {
                Logger.Debug($"{ex}");
                enabled = false;
            }

            Assert.IsTrue(enabled,"Element has not enabled");
        }

        public bool IsEnabled()
        {
            return GetElement().Enabled;
        }

        public bool IsVisible()
        {
            AssertIsPresent();
            return GetElement().Visible;
        }

        public SearchCriteria GetLocator()
        {
            return Locator;
        }

        public string GetName()
        {
            return Name;
        }
    }
}