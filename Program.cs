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

//Edit the Time Record 

//IWebElement goToLastPageBox = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//goToLastPageBox.Click();
//Thread.Sleep(3000);

//Click on Edit Button
IWebElement editButton = driver.FindElement(By.XPath("//tbody/tr[last()]/td[5]/a[1]"));
editButton.Click();
Thread.Sleep(3000);

//Edit Code in Code Textbox
IWebElement editCodeTextbox = driver.FindElement(By.Id("Code"));
editCodeTextbox.Clear();
editCodeTextbox.SendKeys("Moneyhest");

//Edit Description in Description Textbox
IWebElement editDescriptionTextBox = driver.FindElement(By.Id("Description"));
editDescriptionTextBox.Clear();
editDescriptionTextBox.SendKeys("Good Series");

Thread.Sleep(5000);

//Edit Price in Price Textbox
IWebElement editPriceOverlappingTag = driver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
IWebElement editPriceTextBox = driver.FindElement(By.Id("Price"));
editPriceOverlappingTag.Click();
editPriceTextBox.Clear();
editPriceOverlappingTag.Click();
editPriceTextBox.SendKeys("500");


//Click on save button
IWebElement editSaveButton = driver.FindElement(By.Id("SaveButton"));
editSaveButton.Click();
Thread.Sleep(3000);

// Click on goToLastPage Button
//IWebElement editGoToLastPageButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
//editGoToLastPageButton.Click();

//driver.FindElement(By.LinkText("Go to the last page")).Click();

IWebElement editedCode = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[1]"));
IWebElement EditedDescription = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[1]/td[3]"));

if (editedCode.Text == "MoneyhestEdited" && EditedDescription.Text == "GOODEdited")
{
    Console.WriteLine("Time Record has been updated successfully");
}
else
{
    Console.WriteLine("Time Record has not been updated");
}

//Code for Delete Time Record
IWebElement goToLastPageButt = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
goToLastPageButt.Click();
Thread.Sleep(3000);

//Click on delete button
IWebElement deleteButton = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[2]"));
deleteButton.Click();

IAlert simpleAlert = driver.SwitchTo().Alert();
simpleAlert.Accept();

IWebElement lastCodeInTable = driver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (lastCodeInTable.Text == "MoneyhestEdited")
{
    Console.WriteLine("Time Record has not been deleted");
}
else
{
    Console.WriteLine("Time Record has been deleted successfully");
}





