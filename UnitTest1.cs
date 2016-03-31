using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
//using demo1.Cases;

namespace AppiumSample
{
    //public class test
    //{
    //    //CalculatorDivision_subtraction ob1 = new CalculatorDivision_subtraction();
    //    //Calculator ob2 = new Calculator();
    //   // ademotest ob = new ademotest();
    //}

    [TestClass]
    public class UnitTest1
    {

        AppiumDriver<AndroidElement> driver;
        [TestInitialize]
        public void BeforeAll()
        {
            DesiredCapabilities capabilities = new DesiredCapabilities();
            capabilities.SetCapability("device", "Android");
            capabilities.SetCapability(CapabilityType.Platform, "Windows");
            capabilities.SetCapability("deviceName", "Samsung Galaxy S4");
            capabilities.SetCapability("platformName", "Android");
            capabilities.SetCapability("platformVersion", "4.3.0");
            capabilities.SetCapability("appPackage", "com.android.calculator2");
            capabilities.SetCapability("appActivity", "com.android.calculator2.Calculator");
            driver = new AndroidDriver<AndroidElement>(new Uri("http://127.0.0.1:4723/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            //driver = new AndroidDriver<AndroidElement>(new Uri("http://Silver_123:136c0731-0a3f-4709-8542-4f4832f97a71@ondemand.saucelabs.com:80/wd/hub"), capabilities, TimeSpan.FromSeconds(180));
            
        }

        [TestCleanup]
        public void AfterAll()
        {
            driver.Quit();
        }

        [TestMethod]
        public void TestCalculator()
        {
            try
            {
                var two = driver.FindElement(By.Name("2"));
                two.Click();
                var plus = driver.FindElement(By.Name("+"));
                plus.Click();
                var four = driver.FindElement(By.Name("4"));
                four.Click();
                var equalTo = driver.FindElement(By.Name("="));
                equalTo.Click();
                var results = driver.FindElement(By.ClassName("android.widget.EditText"));
                Assert.AreEqual("6", results.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }

        [TestMethod]
        public void TestCalculator1()
        {
            try
            {
                var two = driver.FindElement(By.Name("2"));
                two.Click();
                var plus = driver.FindElement(By.Name("*"));
                plus.Click();
                var four = driver.FindElement(By.Name("4"));
                four.Click();
                var equalTo = driver.FindElement(By.Name("="));
                equalTo.Click();
                var results = driver.FindElement(By.ClassName("android.widget.EditText"));
                Assert.AreEqual("8", results.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}