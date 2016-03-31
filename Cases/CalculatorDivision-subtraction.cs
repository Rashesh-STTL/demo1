using System;
using System.Text;
using System.Threading;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using demo1.Cases;

namespace demo1.Cases
{
    
    public class CalculatorDivision_subtraction :SetAttributes
    {

        [TestClass]
        public CalculatorDivision_subtraction()
        {
            EnvironmentConfiguration();
            Division();
            subtraction();

            ResetEnvironment();
        }

        [TestMethod]
        public void subtraction()
        {
            try
            {
                var Eight = driver.FindElement(By.Name("8"));
                Eight.Click();
                var plus = driver.FindElement(By.Name("-"));
                plus.Click();
                var four = driver.FindElement(By.Name("4"));
                four.Click();
                var equalTo = driver.FindElement(By.Name("="));
                equalTo.Click();
                var results = driver.FindElement(By.ClassName("android.widget.EditText"));
                Thread.Sleep(500);
                Assert.AreEqual("4", results.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

         [TestMethod]
        public void Division()
        {
            try
            {
                var Eight = driver.FindElement(By.Name("8"));
                Eight.Click();
                var plus = driver.FindElement(By.Name("/"));
                plus.Click();
                var four = driver.FindElement(By.Name("4"));
                four.Click();
                var equalTo = driver.FindElement(By.Name("="));
                equalTo.Click();
                var results = driver.FindElement(By.ClassName("android.widget.EditText"));
                Thread.Sleep(500);
                Assert.AreEqual("2", results.Text);
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}
