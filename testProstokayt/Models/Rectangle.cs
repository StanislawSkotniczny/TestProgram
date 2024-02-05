using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace testProstokayt.Models
{
    public class Rectangle
    {
        public Guid Id { get; set; }

        [Required]
        [Range(1, 1000000)]
        public double Width { get; set; }
        public string WidthUnit { get; set; } = "m"; 

        [Required]
        [Range(1, 1000000)]
        public double Height { get; set; }
        public string HeightUnit { get; set; } = "m"; // Dodaj tę linię

        public double Area => ConvertToMeters(Width, WidthUnit) * ConvertToMeters(Height, HeightUnit); // Zaktualizuj tę linię

        private double ConvertToMeters(double value, string unit) // Zaktualizuj tę metodę
        {
            return unit switch
            {
                "mm" => value / 1000,
                "cm" => value / 100,
                "m" => value,
                _ => value,
            };
        }
    }



    
}
