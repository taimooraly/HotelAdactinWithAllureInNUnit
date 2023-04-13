using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;

namespace Allure_Report
{
    public class BookHotelPage : BasePage
    {
        public void BookHotel()
        {
            Write(By.Id("first_name"), "Syed Taimoor");
            Write(By.Id("last_name"), "Ali");
            Write(By.Id("address"), "Karachi, Pakistan");
            Write(By.Id("cc_num"), "5590524126324522");
            Write(By.Id("cc_type"), "Master Card");
            Write(By.Id("cc_exp_month"), "August");
            Write(By.Id("cc_exp_year"), "2022");
            Write(By.Id("cc_cvv"), "542");
            Click(By.Id("book_now"));
        }
    }
}