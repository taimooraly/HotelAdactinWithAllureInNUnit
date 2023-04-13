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
    public class SearchPage : BasePage
    {
        public void Search(string location, string hotels, string room_type, string room_nos, string datepick_in, string datepick_out, string adult_room, string child_room)
        {
            Write(By.Id("location"), location);
            Write(By.Id("hotels"), hotels);
            Write(By.Id("room_type"), room_type);
            Write(By.Id("room_nos"), room_nos);
            Write(By.Id("datepick_in"), datepick_in);
            Write(By.Id("datepick_out"), datepick_out);
            Write(By.Id("adult_room"), adult_room);
            Write(By.Id("child_room"), child_room);
            Click(By.Id("Submit"));
        }
    }
    public class Search
    {
        public static object[] SearchDetails
        {
            get
            {
                //string path = @"C:\Users\Syed Taimoor Ali\source\repos\HotelAdactinWithAllureInNUnit\HotelAdactinWithAllureInNUnit\bin\Debug\net6.0\search.json";
                //using (StreamReader r = new StreamReader(path))
                string path = @"C:\Users\Syed Taimoor Ali\source\repos\HotelAdactinWithAllureInNUnit\HotelAdactinWithAllureInNUnit\bin\Debug\net6.0\new.json";
                using (StreamReader r = new StreamReader(path))
                {
                    string json = r.ReadToEnd();
                    dynamic data = JsonConvert.DeserializeObject(json);
                    List<object[]> loginDataList = new List<object[]>();
                    foreach (var loginObject in data)
                    {
                        string location = loginObject.location;
                        string hotels = loginObject.hotels;
                        string room_type = loginObject.room_type;
                        string room_nos = loginObject.room_nos;
                        string datepick_in = loginObject.datepick_in;
                        string datepick_out = loginObject.datepick_out;
                        string adult_room = loginObject.adult_room;
                        string child_room = loginObject.child_room;
                        loginDataList.Add(new object[] {location, hotels, room_type, room_nos, datepick_in, datepick_out, adult_room, child_room});
                    }
                    return loginDataList.ToArray();
                }
            }
        }
    }
}