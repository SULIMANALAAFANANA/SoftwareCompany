using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace SoftwareCompany.Models
{
    public class Slider
    {
       
        public int Id { get; set; }
        public string Mainaddress { get; set; } 
        public string Subaddress { get; set; } 
        //[Required]
        public string? Text { get; set; }
    }
    
    public class SliderViewModel
    {
        public int Id { get; set; }
        public string Mainaddress { get; set; }
        public string Subaddress { get; set; } 
        public string Text { get; set; }
    }

}
