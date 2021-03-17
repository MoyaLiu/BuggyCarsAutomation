using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class Login
    {
        IWebDriver _webDriver;

        public Login(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }


    }
}
