using System.ComponentModel.DataAnnotations;

namespace OdeToFood.Models
{
    
    //ENUM type is used to hold the type of cuisine 
    //of each restaurant but you can also use a second model if you like
    public enum CuisineType
         {
             None,
             African,
             Italian,
             Indian,
             Mexican,
             Chinese
             
             
         }
    
    public enum CuisineDays
    {
        All_Days,
        Monday_Friday,
        Monday_Saturday,
        Monday_Thursday,
    }
    
    public class Restaurant
    {
        [Key]
        public int Id { get; set; }
        
        [Required, MaxLength(80)]
        [Display(Name = "Restaurant Name")]
        public string Name { get; set; }
        
        [Required]
        [Display(Name = "Restaurant location")]
        public string Location { get; set; }
        
        [Required]
        [Display(Name = "Phone number")]
        public string Phone { get; set; }
        [Required]
        [Display(Name = "Description")]
        
        public string Description { get; set; }
        
        public CuisineType Cuisine { get; set; } // reference to the enum cuisinetype
        
        [Required]
        [Display(Name = "Working days")]
        public CuisineDays CuisineDays { get; set; } 
    }
}