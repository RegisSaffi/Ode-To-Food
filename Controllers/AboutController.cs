using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdeToFood.Models;
using OdeToFood.Services;
using OdeToFood.ViewModels;

namespace OdeToFood.Controllers
{
    public class AboutController : Controller
    {
        private readonly IRestaurantData _restaurantData;

        public AboutController(IRestaurantData restaurantData)
        {
            _restaurantData = restaurantData;
        }
        // GET
        public IActionResult Index()
        {
            return View();
        }
        
        public IActionResult Delete(int id)
        {
            var restaurant = new Restaurant {Id = id};
              _restaurantData.DeleteRestaurant(restaurant);
              
              return RedirectToAction("Index","Home"); 

        }
        
        public IActionResult Update(int id)
        {
            ViewBag.data = _restaurantData.Get(id);
            return View();
        }
        
        [HttpPost]
        public IActionResult Update(Restaurant model)
        {
            if (ModelState.IsValid)
            {
                var restaurant = _restaurantData.Get(model.Id);               
                _restaurantData.UpdateRestaurant(restaurant);
                
                // return View("Details", restaurant);

                return RedirectToAction("Details", "Home",new {id = restaurant.Id}); // TODO :fix redirection to details

            }

            return View();
        }
    }
}