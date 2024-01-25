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
