using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRental.Models
{
    [Table("Cars")]
    public class Car
    {
        [Key]
        public int Id { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public decimal DailyPrice { get; set; }
        public int Seats { get; set; }
        public string Color { get; set; }
        public int Mileage { get; set; }
        public string ImageURL { get; set; }
        public int Doors { get; set; }
        public int Cylinders { get; set; }
        public int HP { get; set; }
        public string Description { get; set; }
    }
}