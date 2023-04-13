using Newtonsoft.Json;
using NUnit.Allure.Attributes;
using NUnit.Allure.Core;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Security.Policy;
using System.Threading;

namespace Allure_Report
{
    public class LoginPage : BasePage
    {
        public void Login(string username, string password)
        {
            OpenUrl("https://adactinhotelapp.com/index.php");
            Write(By.Id("username"), username);
            Write(By.Id("password"), password);
            Click(By.Id("login"));
        }
    }
    public class Login
    {
        public static object[] LoginDetails
        {
            get
            {
                //string path = @"C:\Users\Syed Taimoor Ali\source\repos\HotelAdactinWithAllureInNUnit\HotelAdactinWithAllureInNUnit\bin\Debug\net6.0\TestData.json";
                string path = @"C:\Users\Syed Taimoor Ali\source\repos\HotelAdactinWithAllureInNUnit\HotelAdactinWithAllureInNUnit\bin\Debug\net6.0\login.json";
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    List<object[]> loginDataList = new List<object[]>();
                    foreach (var loginObject in data)
                    {                        
                        string username = loginObject.username;
                        string password = loginObject.password;
                        loginDataList.Add(new object[] {username, password});
                    }
                    return loginDataList.ToArray();
                }
            }
        }
    }
}