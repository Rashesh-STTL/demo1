using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using demo1.Common;

namespace demo1.Cases
{
   public class SetAttributes
    {
       public static AppiumDriver<AndroidElement> driver;

       public void EnvironmentConfiguration()
       {
           if (driver==null)
           {
               driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"),ConfigEnvironment.Testcaseconfig() , TimeSpan.FromSeconds(180));
           }
       }

       public void ResetEnvironment()
       {
           driver.Quit();
       }
       
       
    }
}
