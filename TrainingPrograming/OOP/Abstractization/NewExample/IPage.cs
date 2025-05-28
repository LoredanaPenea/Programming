using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainingPrograming.OOP.Abstractization.NewExample
{
    public  interface IPage
    {
        string GetPageTitle();
        void NavigateToURL(string url);
    }
}
