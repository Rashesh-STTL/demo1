using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace demo1.Common
{
    [TestClass]
    public class ConfigEnvironment
    {

        public static DesiredCapabilities Testcaseconfig()
        {
           
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("device", "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Windows");
            capabilities.SetCapability("deviceName", "H30-U10");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "5.1.0");
            capabilities.SetCapability("appPackage", "com.android.calculator2");
            capabilities.SetCapability("appActivity", "com.android.calculator2.Calculator");
            
            return capabilities;
        }
        
        
    }
}
