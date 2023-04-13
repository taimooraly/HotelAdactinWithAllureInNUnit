using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;

namespace Allure_Report
{
    public class BookedItineraryPage : BasePage
    {
        public void Book()
        {
            //Thread.Sleep(1000);
            OpenUrl("https://adactinhotelapp.com/BookedItinerary.php");
            Thread.Sleep(3000);
            Click(By.Id("check_all"));
            Click(By.Name("cancelall"));
            Thread.Sleep(7000);
            Click(By.Id("logout"));
        }
    }
}