using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClothingShop.MVC.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            //Message myDelegate = () => Console.WriteLine("Hello World");

            //myDelegate += () => Console.WriteLine("Goodbye World");

            //Func<string> myFunc = () => "I return a string.";

            //Action<int> myAction = num => Console.WriteLine(num);

            //myAction(5);

            Predicate<int> myPredicate = intNum => intNum > 5;

            return View();
        }
    }
}
