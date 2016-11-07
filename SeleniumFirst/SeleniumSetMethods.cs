﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;

namespace SeleniumFirst
{
    class SeleniumSetMethods
    {
        // Enter Text
        public static void EnterText(IWebElement element, string value)
        {
            element.SendKeys(value);
        }

        // Click into a button, checkbox, option etc

        public static void Click(IWebElement element)
        {
            element.Click();
        }
        
        // Selectiong a dropdown control

        public static void SelectDropDown(IWebElement element, string value)
        {

            new SelectElement(element).SelectByText(value);
     
        }
    }
}