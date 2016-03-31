using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;

namespace AppiumSample
{
    [TestClass]
    public class DemoSearchApp
    {

        AppiumDriver<AndroidElement> driver;


        [TestInitialize]
        public void BeforeAll()
        {
            try
            {
                DesiredCapabilities capabilities = new DesiredCapabilities();
                capabilities.SetCapability("device", "Android");
                capabilities.SetCapability(CapabilityType.Platform, "Windows");
                capabilities.SetCapability("deviceName", "H30-U10");
                capabilities.SetCapability("platformName", "Android");
                capabilities.SetCapability("platformVersion", "5.1.0");
                capabilities.SetCapability("appPackage", "com.android.ListviewSearchDemo");
                capabilities.SetCapability("appActivity", "com.android.ListviewSearchDemo.ListviewSearchDemo");

                // driver = new AndroidDriver(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities,Timespan.FromSecond(180));
                driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            }
            catch (Exception)
            {
                
                throw;
            }
            


        }

        [TestCleanup]
        public void AfterAll()
        {
            driver.Quit();
        }

        [TestMethod]
        public void SearchApp()
        {

        }
    
    }
}
