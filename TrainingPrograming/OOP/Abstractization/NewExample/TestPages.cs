using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.NewExample
{
    public class TestPages
    {
        protected IWebDriver driver;

        [Test]
        public void WebPagesTest() 
        { 
            HomePage homePage = new HomePage(driver);
            homePage.NavigateToURL("https://www.google.com/");

          //  LoginPage loginPage = new LoginPage(driver);
           // loginPage.GetPageTitle();
           
        }
    }
}
