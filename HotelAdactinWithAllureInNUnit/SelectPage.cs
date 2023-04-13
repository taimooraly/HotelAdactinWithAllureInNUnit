using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;

namespace Allure_Report
{
    public class SelectHotelPage : BasePage
    {
        public void SelectHotel()
        {
            Click(By.Id("radiobutton_0"));
            Click(By.Id("continue"));
        }
    }
}