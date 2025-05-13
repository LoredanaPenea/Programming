using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Inheritance.BrowserDrivers
{
    public class Browser
    {
        private string Network;
        private string Location;
        public int WindowWidth;

        public void NavigateToURL(string url)
        {
        }
        public void LookUpServerLocation()
        {
        }
        public void MakeConnectionToServer()
        {
        }
        public void RequestPage()
        {
        }
        public void HandleServerResponse()
        {
        }
        public void RenderPage()
        {
        }

        public void ChangeWindowWidth(int newWindowWidth)
        {
            WindowWidth = newWindowWidth;
            Console.WriteLine("Window width is: " + newWindowWidth);
        }

    }
}
