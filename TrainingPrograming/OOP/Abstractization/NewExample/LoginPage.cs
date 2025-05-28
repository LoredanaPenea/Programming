using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.NewExample
{
    public class LoginPage : WebPage
    {
        private By usernameField = By.Id("username");
        private By passwordField = By.Id("password");
        private By loginButton = By.Id("login");

        public LoginPage(IWebDriver driver) : base(driver) { }

        public override string GetPageTitle()
        {
            return Driver.Title;
        }

        public void Login(string username, string password)
        {
            EnterText(usernameField, username);
            EnterText(passwordField, password);
            ClickElement(loginButton);
        }
    }
}
