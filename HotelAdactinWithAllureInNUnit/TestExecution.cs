using AspectInjector.Broker;
using AventStack.ExtentReports.Gherkin.Model;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Allure_Report
{
    [AllureNUnit]
    [TestFixture]
    public class TestExecution : BasePage
    {
        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }
        [OneTimeSetUp]
        public static void AssemblyInit()
        {
            ExtentReport("TestReport");
        }
        [SetUp]
        public void TestInit()
        {
            SeleniumInitialization("Chrome");
            exParentTest = extentReports.CreateTest(TestContext.CurrentContext.Test.Name);
        }
        [TearDown]
        public void TestClose()
        {
            extentReports.Flush();
            SeleniumClose();
        }
        [Test]
        [TestCaseSource(typeof(Login), "LoginDetails")]
        public void Login(string username, string password)
        {
            OpenUrl("https://adactinhotelapp.com/index.php");
            Write(By.Id("username"), username);
            Write(By.Id("password"), password);
            Click(By.Id("login"));
        }
        //[Test]
        //[TestCaseSource(typeof(TestData), "LoginDetails")]
        //public void Login(string username, string password)
        //{
        //    exChildTest = exParentTest.CreateNode("Login");
        //    LoginPage loginPage = new LoginPage();            
        //    loginPage.Login(username, password);
        //}
        //[Test]
        //[TestCaseSource(typeof(Login), "LoginDetails")]
        //[TestCaseSource(typeof(Search), "SearchDetails")]
        //public void Search_Hotel(string username, string password, string location, string hotels, string room_type, string room_nos, string datepick_in, string datepick_out, string adult_room, string child_room)
        //{
        //    exChildTest = exParentTest.CreateNode("Login");
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.Login(username, password);
        //    exChildTest = exParentTest.CreateNode("Search");
        //    SearchPage searchPage = new SearchPage();
        //    searchPage.Search(location, hotels, room_type, room_nos, datepick_in, datepick_out, adult_room, child_room);
        //}
        //[Test]
        //public void Select_Hotel()
        //{
        //    exChildTest = exParentTest.CreateNode("Login");
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.Login();
        //    exChildTest = exParentTest.CreateNode("Search");
        //    SearchPage searchPage = new SearchPage();
        //    searchPage.Search();
        //    exChildTest = exParentTest.CreateNode("Select Hotel");
        //    SelectHotelPage selectHotelPage = new SelectHotelPage();
        //    selectHotelPage.SelectHotel();
        //}
        //[Test]
        //public void Book_Hotel()
        //{
        //    exChildTest = exParentTest.CreateNode("Login");
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.Login();
        //    exChildTest = exParentTest.CreateNode("Search");
        //    SearchPage searchPage = new SearchPage();
        //    searchPage.Search();
        //    exChildTest = exParentTest.CreateNode("Select Hotel");
        //    SelectHotelPage selectHotelPage = new SelectHotelPage();
        //    selectHotelPage.SelectHotel();
        //    exChildTest = exParentTest.CreateNode("Book Hotel");
        //    BookHotelPage bookHotelPage = new BookHotelPage();
        //    bookHotelPage.BookHotel();
        //}
        //[Test]
        //public void AdactinHotel()
        //{
        //    exChildTest = exParentTest.CreateNode("Login");
        //    LoginPage loginPage = new LoginPage();
        //    loginPage.Login();
        //    exChildTest = exParentTest.CreateNode("Search");
        //    SearchPage searchPage = new SearchPage();
        //    searchPage.Search();
        //    exChildTest = exParentTest.CreateNode("Select Hotel");
        //    SelectHotelPage selectHotelPage = new SelectHotelPage();
        //    selectHotelPage.SelectHotel();
        //    exChildTest = exParentTest.CreateNode("Book Hotel");
        //    BookHotelPage bookHotelPage = new BookHotelPage();
        //    bookHotelPage.BookHotel();
        //    exChildTest = exParentTest.CreateNode("Book Itinerary");
        //    BookedItineraryPage book = new BookedItineraryPage();
        //    book.Book();
        //}
    }
}