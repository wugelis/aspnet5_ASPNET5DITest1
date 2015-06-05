using Microsoft.AspNet.Mvc;
using System;
using WebTestEmptyApp2.Services;

namespace WebTestEmptyApp2.Controllers
{
    public class HomeController : Controller
    {
        //private ICustomer _customer;

        //public HomeController(ICustomer customer)
        //{
        //    _customer = customer;
        //}
        public IActionResult Index()
        {
            //var result = _customer.GetData();
            return View();
        }
    }
}