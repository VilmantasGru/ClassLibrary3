using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prasitestavimui.POM
{
    internal class TopMenu
    {
        IWebDriver driver;
        GeneralMethods generalMethods;

        string SearchFieldXpath = "//input[contains(@class,'sn-suggest-input autocomplete main-search-input')]";
        string SearchButtonXpath = "//i[contains(@class,'main-search-submit__icon icon-svg')]";


        public TopMenu(IWebDriver driver)
        {
            this.driver = driver;
            generalMethods = new GeneralMethods(driver);
        }

        public void SearchByText(string text)
        {
            generalMethods.EnterTextBy(SearchFieldXpath, text);
            generalMethods.ClickElementBy(SearchButtonXpath);
        }
        public void EnterTextToSearch(string text)
        {
            generalMethods.EnterTextBy(SearchFieldXpath, text);
        }
    }
}
