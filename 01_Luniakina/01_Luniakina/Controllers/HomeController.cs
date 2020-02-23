using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _01_Luniakina.Models;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace _01_Luniakina.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public ViewResult Index()
        {
            return View();
        }

       
        [HttpPost]
        public ViewResult Index(Person person)
        {
            // TODO: Email response to the party organizer
            return View("Age", person);
        }

        public static int CalculateAge(DateTime BirthDate){

            int YearsPassed = DateTime.Now.Year - BirthDate.Year;

            if (DateTime.Now.Month<BirthDate.Month ||
                (DateTime.Now.Month == BirthDate.Month &&
                DateTime.Now.Day<BirthDate.Day)){
                    YearsPassed--;
            }

            return YearsPassed;
        }

        public static bool isBirthday(DateTime BirthDate)
        {
            if(BirthDate.Month == DateTime.Now.Month)
            {
                if(BirthDate.Day == DateTime.Now.Day)
                {
                    return true;
                }
            }
            return false;
        }

        public static String astrologicalSign(DateTime BirthDate)
        {
            int month = BirthDate.Month;
            int day = BirthDate.Day;

            if(month == 12 && day >=22 || month == 1 && day <= 22)
            {
                return "Capricorn";
            }

            if (month == 1 && day >= 21 || month == 2 && day <= 18)
            {
                return "Aquarius";
            }

            if (month == 2 && day >= 19 || month == 3 && day <= 20)
            {
                return "Pisces";
            }

            if (month == 3 && day >= 21 || month == 4 && day <= 20)
            {
                return "Aries";
            }

            if (month == 4 && day >= 21 || month == 5 && day <= 20)
            {
                return "Taurus";
            }

            if (month == 5 && day >= 21 || month == 6 && day <= 21)
            {
                return "Gemini";
            }

            if (month == 6 && day >= 22 || month == 7 && day <= 22)
            {
                return "Cancer";
            }

            if (month == 7 && day >= 23 || month == 8 && day <= 23)
            {
                return "Leo";
            }

            if (month == 8 && day >= 24 || month == 9 && day <= 23)
            {
                return "Virgo";
            }

            if (month == 9 && day >= 24 || month == 10 && day <= 23)
            {
                return "Libra";
            }

            if (month == 10 && day >= 24 || month == 11 && day <= 22)
            {
                return "Scorpio";
            }

            if (month == 11 && day >= 23 || month == 12 && day <= 21)
            {
                return "Sagittarius";
            }

            return "";
        }

        public static String ChineeseZodiacSign(DateTime BirthDate) {

            switch (BirthDate.Year % 12)
            {
                case 0:
                    return "Monkey";
                    break;

                case 1:
                    return "Rooster";
                    break;

                case 2:
                    return "Dog";
                    break;

                case 3:
                    return "Pig";
                    break;

                case 4:
                    return "Rat";
                    break;

                case 5:
                    return "Ox";
                    break;

                case 6:
                    return "Tiger";
                    break;

                case 7:
                    return "Rabbit";
                    break;

                case 8:
                    return "Dragon";
                    break;

                case 9:
                    return "Snake";
                    break;

                case 10:
                    return "Horse";
                    break;

                case 11:
                    return "Goat";
                    break;


                 
            }
            return "";
        }


        


    }
}
