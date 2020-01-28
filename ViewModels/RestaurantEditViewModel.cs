using System.ComponentModel.DataAnnotations;
using OdeToFood.Models;

namespace OdeToFood.ViewModels
{
    /**/
    public class RestaurantEditViewModel
    {
        [Required, MaxLength(80)]
        public string Name { get; set; }
        public CuisineType Cuisine { get; set; }
        
        public string Location { get; set; }
        public string Phone { get; set; }
        public CuisineDays Days { get; set; }
        public string Description { get; set; }
     
    }
}