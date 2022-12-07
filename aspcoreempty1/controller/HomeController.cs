using aspcoreempty1.modal;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace aspcoreempty1.controller
{
    public class HomeController : Controller
    {
        public ICarRepository _carRepository;
        public HomeController(ICarRepository carRepository) {
            _carRepository = carRepository;
        }
        public string Index() {

            return _carRepository.GetCar(4).name;
        }
        public IActionResult Car() {
            return View();
        }
    }
}
