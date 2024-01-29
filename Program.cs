using Deekshi_TurnUpport.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


public class Program
{
    public static void Main(string[] args)
    {
        //Open the chrome browser
        IWebDriver driver = new ChromeDriver();
        
        //Login page object initialization and definition
        LoginPage loginPageObj = new LoginPage();
        loginPageObj.LoginActions(driver);

        //Home Page Object initialization and definition
        HomePage homePageObj = new HomePage();
        homePageObj.verifyLoggedInUser(driver);
        homePageObj.GoTOTMPage(driver);

        //TMPage object initialization and definition
        TimeMaterialPage tmPageObj = new TimeMaterialPage();
        tmPageObj.CreateTimeRecord(driver);
        tmPageObj.EditTimeRecord(driver);
        tmPageObj.DeleteTimeRecord(driver);

    }
}