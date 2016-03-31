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
    [TestClass]
    public class Calculator:SetAttributes
    {
        public Calculator()
        {
            EnvironmentConfiguration();
            Addition();
            Multiplication();

            ResetEnvironment();
        }

        [TestMethod]
        public void Addition()
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
                Thread.Sleep(500);
                Assert.AreEqual("6", results.Text);
            }
            catch (Exception)
            {
                throw;
            }
        }


        [TestMethod]
        public void Multiplication()
        {
            try
            {
                var six = driver.FindElement(By.Name("6"));
                six.Click();
                var multiply = driver.FindElement(By.Id("op_mul"));
                multiply.Click();
                var four = driver.FindElement(By.Name("4"));
                four.Click();
                var equalTo = driver.FindElement(By.Name("="));
                equalTo.Click();
                var results = driver.FindElement(By.ClassName("android.widget.EditText"));
                Thread.Sleep(500);
                Assert.AreEqual("24", results.Text);
            }
            catch (Exception)
            {
                throw;
            }
            
        }
    }
}
