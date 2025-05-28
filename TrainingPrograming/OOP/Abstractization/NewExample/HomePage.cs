using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.NewExample
{
    public class HomePage : WebPage,IPage
    {
        public HomePage(IWebDriver driver) : base(driver)
        {
        }

        public override string GetPageTitle()
        {
            return Driver.Title;
        }

        public void NavigateToURL(string url)
        {
            Console.WriteLine($"HomePage loaded successfully, URL: {url}");
        }

    }
}
