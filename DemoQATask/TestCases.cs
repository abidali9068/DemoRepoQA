using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using NUnit.Framework;
using OpenQA.Selenium;

namespace DemoQATask
{
    class TestCases
    {
       

        IWebDriver driver;
        DemoQAForm demoForm;
        DemoQAHome demoHome;
        

        FormInputs FI;
        Data dataR;

        [SetUp]
        public void Start()
        {
            driver = new ChromeDriver("F:\\Chrome");
            driver.Manage().Window.Maximize();
            driver.Url = "https://demoqa.com/";
        }

        [Test]
        public void TestCase1()
        {


            dataR = new Data();
            FI = dataR.DataRecord();


            demoHome = new DemoQAHome(driver);
            demoForm = new DemoQAForm(driver);


           

            demoHome.CLickForm();

            string strHead = demoForm.getHeaderTextFrom();

            Assert.AreEqual(strHead, "Forms");


            demoForm.CLickPractice();

           // demoForm.verifyfirstNameRequired();


            demoForm.setFirstName(FI.firstname);
            demoForm.setLastName(FI.lastname);
            demoForm.selectGender(FI.gender);
            demoForm.setNumber(FI.nummber);

            demoForm.submitForm();

            string str = demoForm.verifyMessage();

            Assert.AreEqual(str, "Thanks for submitting the form");



           
            
        }

        [Test]
        public void Testcase2()
        {
            demoHome = new DemoQAHome(driver);
            demoForm = new DemoQAForm(driver);




            demoHome.CLickForm();

            string strHead = demoForm.getHeaderTextFrom();

            Assert.AreEqual(strHead, "Forms");


            demoForm.CLickPractice();

            demoForm.submitForm();





            Assert.IsTrue(demoForm.verifyfirstNameRequired());
            Assert.IsTrue(demoForm.verifylastNameRequired());

            Assert.IsTrue(demoForm.verifgenderFRequired());
            Assert.IsTrue(demoForm.verifgenderMRequired());
            Assert.IsTrue(demoForm.verifgenderORequired());
           


        }

        [TearDown]
        public void End()
        {
            driver.Quit();
        }



    }
}
