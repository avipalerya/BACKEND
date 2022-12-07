using Microsoft.AspNetCore.Mvc;
using ShoppingCart.modal;
using ShoppingCart.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShoppingCart.controller
{
    public class HomeController : Controller
    {

        public ICartRepository _cartRepository;
        public HomeController(ICartRepository cartRepository) {
            _cartRepository = cartRepository;
        }


        //public ViewResult Details() {
        //    Cart modal = _cartRepository.GetCart(2);
        //    ViewBag.Cart = modal;
        //    ViewBag.Title = "details of employee";
        //    return View();
        //}



        ///using view model 
        public ViewResult Details() {// fetch details from strongly typed view
            HomeDetailsViewModel homeDetailsViewModel = new HomeDetailsViewModel() {
                cart = _cartRepository.GetCart(3),
                Title = "Details of Employee"
            };
            return View(homeDetailsViewModel);
        }


        public IActionResult AllCart() {
            var modal = _cartRepository.GetAllCart();
            return View(modal);
        }





        public IActionResult Index() {
            return View("MyViews/Test.cshtml");
        }
        public IActionResult cart() {
            return View();
        }
    }

}

