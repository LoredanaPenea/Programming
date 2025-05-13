using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.BrowserDrivers
{
    public class TestBrowsers
    {
        [Test]
        public void BrowsersTestMethod()
        {
            Firefox ff = new Firefox();
            ff.ChangeWindowWidth(1900);

            Chrome ch = new Chrome();
            ch.ChangeWindowWidth(1920);
            ch.LoginToWebsite();
        }

    }
}

