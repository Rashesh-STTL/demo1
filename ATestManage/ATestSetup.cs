using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using demo1.Common;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using demo1.Cases;

namespace demo1.ATestManage
{
    [TestClass]
    public class ATestSetup:Base
    {
        void TestCases()
        {
            try
            {
                Calculator obj = new Calculator();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
