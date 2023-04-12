using March2023.Pages;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using March2023.Utilities;

namespace March2023.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {
        [SetUp]
        public void LoginActions()
        {
            driver = new ChromeDriver();

            // Login page object initialization and definition
            LoginPage loginPageObj = new LoginPage();
            loginPageObj.LoginSteps(driver);

            // Home page object initialization and definition
            HomePage homePageObj = new HomePage();
            homePageObj.GoToTMPage(driver);
        }

        [Test]
        public void CreateTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.CreateTM(driver);
        }

        [Test]
        public void EditTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.EditTM(driver);
        }

        [Test]
        public void DeleteTM_Test()
        {
            // TM page object initialization and definition
            TMPage tmPageObject = new TMPage();
            tmPageObject.DeleteTM(driver);
        }

        [TearDown]
        public void CloseTestRun()
        {

        }
    }
}
