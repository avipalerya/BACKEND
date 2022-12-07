using System;
using System.Globalization;
using System.Collections.ObjectModel;

class TimeZoneInfoDemo
{
    
    public void TimeZone() { 
        DateTime dateTime1;//instance of dateTime1
        TimeZoneInfo time_zone = TimeZoneInfo.Local; //convert to local timezone

        dateTime1 = new DateTime(2022, 03, 13, 9, 00, 00);//provide own date and time 

        if (time_zone.IsDaylightSavingTime(dateTime1))     //to check whether the instance of date n time falls under daylightsavingtime
            Console.WriteLine("It is daylight saving time");
        else
            Console.WriteLine("It is not daylight saving time");
    }
   
       
    }
