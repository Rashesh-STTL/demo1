using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace demo1.ATestManage
{
   public class Base
    {
       public static string Setup=string.Empty;
       public static AppiumDriver<AndroidElement> driver;
       public static string ErrorMessage;
    }
}
