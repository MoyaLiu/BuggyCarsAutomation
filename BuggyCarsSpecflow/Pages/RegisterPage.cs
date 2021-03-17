using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace BuggyCarsSpecflow.Pages
{
    class RegisterPage
    {
        IWebDriver _webDriver;
        public RegisterPage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

    }
}
