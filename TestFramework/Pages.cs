using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFramework
{
    public static class Pages
    {
        public static class HomePage
        {
            static string Url = "https://trick.nmbrs-test.nl/";
            static string PageTitle = "Trick - TestLive";

            public static void Goto()
            {
                Browser.Goto(Url);
            }

            public static bool IsAt()
            {
                return Browser.Title == PageTitle;
                

            }
        }
    }

}
