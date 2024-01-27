using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open the chrome browser
IWebDriver driver = new ChromeDriver();

//Maximize the browser
driver.Manage().Window.Maximize();

//Launch TurnUp Portal and Navigate to website login page
driver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login?ReturnUrl=%2f");


//Identify username textbox and enter valid username
IWebElement usernameTextBox = driver.FindElement(By.Id("UserName"));
usernameTextBox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordTextBox = driver.FindElement(By.Id("Password"));
passwordTextBox.SendKeys("123123");

//Identify the login button and click on the button
IWebElement loginButton = driver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginButton.Click();

Thread.Sleep(5000);

//Check if user has logged in successfully
IWebElement verificationText = driver.FindElement(By.XPath("//*[@id=\"loader\"]"));
if (verificationText.Text != "hello Hari")

{
    Console.WriteLine("User logged in Successfully");
}
else
{
    Console.WriteLine("User hasn't logged in.");
}

//Test Case : Create a new Time record

//Navigate to Time & Material module (Click on Administration -> Time & Material link)
IWebElement administrationdropdown = driver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationdropdown.Click();

IWebElement tmOption = driver.FindElement(By.XPath("//a[contains(text(),'Time & Materials')]"));
tmOption.Click();


//Click on Create new Button
IWebElement createNew = driver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createNew.Click();


//Select Time from dropdown
IWebElement typecodedropdownmain = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
typecodedropdownmain.Click();

IWebElement typecodedropdown = driver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
typecodedropdown.Click();

//Enter code
IWebElement codeTextBox = driver.FindElement(By.Name("Code"));
codeTextBox.SendKeys("THOR");

//Enter description
IWebElement descriptionTextBox = driver.FindElement(By.Name("Description"));
descriptionTextBox.SendKeys("Series");

//Enter price
IWebElement pricePerUnitTextBox = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricePerUnitTextBox.SendKeys("061993");

//Click on save button
IWebElement saveButton = driver.FindElement(By.Id("SaveButton"));
saveButton.Click();

Thread.Sleep(1000);

//Check if new time record has been created successfully 
IWebElement goToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButton.Click();

Thread.Sleep(2000);

IWebElement newRecordData = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr/td[1]"));
if (newRecordData.Text == "THOR")

{
    Console.WriteLine("User has created New Time Record successfully");
}
else
{
    Console.WriteLine("User has not created Time record");
}






