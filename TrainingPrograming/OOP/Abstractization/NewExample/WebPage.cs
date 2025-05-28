using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;

namespace TrainingPrograming.OOP.Abstractization.NewExample
{
    public abstract class WebPage
    {
        protected IWebDriver Driver;

        public WebPage(IWebDriver driver)
        {
            Driver = driver;
        }
        public abstract string GetPageTitle();
        public void ClickElement(By locator)
        {
            Driver.FindElement(locator).Click();
        }
        public void EnterText(By locator, string text)
        {
            Driver.FindElement(locator).Clear();
            Driver.FindElement(locator).SendKeys(text);
        }
    }
}
