using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.Events;

// open chrome browser
IWebDriver driver = new ChromeDriver();
driver.Manage().Window.Maximize();

// launch turn up portal 
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");
Thread.Sleep(1000);

// identify username textbox and enter valid username
IWebElement usernameTextbox = driver.FindElement(By.Id("UserName"));
usernameTextbox.SendKeys("hari");

// indentify password textbox and enter valid password
IWebElement passwordTextbox = driver.FindElement(By.Id("Password"));
passwordTextbox.SendKeys("123123");

// indentify login button and click on it
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();
Thread.Sleep(2000);

// check if user has logged in successfully
IWebElement helloHari = driver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));

if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully.");
}
else
{
    Console.WriteLine("User hasn't been logged in.");
}

// Create new time record

// navigate to time and material module
IWebElement administration = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a/span"));
administration.Click();

IWebElement tmOption = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
tmOption.Click();

// click on create new button
IWebElement createNewButton = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNewButton.Click();

// select Time option from dropdown
IWebElement dropdown = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[2]/span"));
dropdown.Click();

IWebElement timeOption = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
timeOption.Click();

// type code into code textbox
IWebElement codeTextbox = driver.FindElement(By.Id("Code"));
codeTextbox.SendKeys("March2023");

// type description into description textbox
IWebElement descriptionTextbox = driver.FindElement(By.Id("Description"));
descriptionTextbox.SendKeys("March2023");

// type price into price per unit textbox
IWebElement priceOverlap = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
priceOverlap.Click();

IWebElement priceTextbox = driver.FindElement(By.Id("Price"));
priceTextbox.SendKeys("12");

// click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();
Thread.Sleep(3000);

// check if new Time record has been created successfully
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click(); 

IWebElement newCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
                                                    
if(newCode.Text == "March2023")
{
    Console.WriteLine("New record has been created successfully.");
}
else
{
    Console.WriteLine("Record hasn't been created.");
}


