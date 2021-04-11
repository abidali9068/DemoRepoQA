using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace DemoQATask
{
    class DemoQAForm
    {
        private WebDriverWait waitDriver;
        private IWebDriver driver;
        

        private By PracticeForm = By.XPath("//span[contains(text(),'Practice Form')]");
        private By HeaderTextLink = By.XPath("//div[contains(text(),'Form')]");
        private By submitMessage = By.Id("example-modal-sizes-title-lg");


        private By firstname = By.Id("firstName");
        private By lastname = By.Id("lastName");
        private By genderMaleR = By.Id("gender-radio-1");
        private By genderFemaleR = By.Id("gender-radio-2");
        private By genderOtherR = By.Id("gender-radio-3");
        private By userNumber = By.Id("userNumber");


        private By genderMale = By.XPath("//input[@id='gender-radio-1']//parent::div[1]");
        private By genderFemale = By.XPath("//input[@id='gender-radio-2']//parent::div[1]");
        private By genderOther = By.XPath("//input[@id='gender-radio-3']//parent::div[1]");





        // private By DateofBirth = By.Id("");


        private By SubmitButton = By.Id("submit");
        public DemoQAForm(IWebDriver driver)
        {
            this.driver = driver;
            waitDriver = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
        }


        public string getHeaderTextFrom()
        {
            IWebElement HeaderText = driver.FindElement(HeaderTextLink);
            return HeaderText.Text;
            
        }

        

        public void CLickPractice()
        {
            waitDriver.Until(ExpectedConditions.ElementExists(PracticeForm));
            {
                driver.FindElement(PracticeForm).Click();
            };
           
        }
        public void setFirstName(string fname)
        {
            IWebElement element = driver.FindElement(firstname);
            element.Clear();
            element.SendKeys(fname);
        }

        public void setLastName(string lname)
        {
            IWebElement element = driver.FindElement(lastname);
            element.Clear();
            element.SendKeys(lname);
        }

        public void selectGender(char gender)
        {

           // Thread.Sleep(5000);
            IWebElement element1;

            //IWebElement ele1 = waitDriver.Until(ExpectedConditions.ElementToBeClickable(genderMale));
           // ele1.Click();


            switch (gender)
            {
                case 'M':
                    element1 = driver.FindElement(genderMale);
                    element1.Click();
                    break;


                case 'F':
                    element1 = driver.FindElement(genderFemale);
                    element1.Click();
                    break;

                case 'O':
                    element1 = driver.FindElement(genderOther);
                    element1.Click();
                    break;

                default:
                    break;

            }

            //IWebElement element = driver.FindElement(firstname);
           // element.Click();

        }

        public void setNumber(string number)
        {
            IWebElement element = driver.FindElement(userNumber);
            element.Clear();
            element.SendKeys(number);
        }



        public void submitForm()
        {
            IWebElement element = driver.FindElement(SubmitButton);
            element.Submit();
        }


        public string verifyMessage()
        {
            IWebElement element = driver.FindElement(submitMessage);
             return element.Text;
        }



        public bool verifyfirstNameRequired()
        {
            IWebElement element = driver.FindElement(firstname);
            string attribute = element.GetAttribute("required");

            if(attribute != null)
            {
                return true;
            }
            return false;
        }

        public bool verifylastNameRequired()
        {
            IWebElement element = driver.FindElement(lastname);
            string attribute = element.GetAttribute("required");

            if (attribute != null)
            {
                return true;
            }
            return false;
        }


        public bool verifgenderMRequired()
        {
            IWebElement element = driver.FindElement(genderMaleR);
            string attribute = element.GetAttribute("required");

            if (attribute != null)
            {
                return true;
            }
            return false;
        }


        public bool verifgenderFRequired()
        {
            IWebElement element = driver.FindElement(genderFemaleR);
            string attribute = element.GetAttribute("required");

            if (attribute != null)
            {
                return true;
            }
            return false;
        }

        public bool verifgenderORequired()
        {
            IWebElement element = driver.FindElement(genderOtherR);
            string attribute = element.GetAttribute("required");

            if (attribute != null)
            {
                return true;
            }
            return false;
        }





        //From Fields




    }
}
