using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;


namespace DemoQATask
{
    class DemoQAHome
    {
        private WebDriverWait waitDriver;
        private IWebDriver driver;

        private By Form = By.XPath("//h5[contains(text(),'Forms')]");
        public DemoQAHome(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver,TimeSpan.FromSeconds(20)); 
        }

       
        public void CLickForm()
        {
            waitDriver.Until(ExpectedConditions.ElementExists(Form));
            {
                driver.FindElement(Form).Click();
            };



            
            
        }

    }
}
