using System;
using System.ComponentModel.DataAnnotations;

namespace Hotel_Booking_Backend.Models
{
	public class Room
	{
        public int Id { get; set; }

        [Required]
        public int Number { get; set; }

        [Required]
        [MaxLength(50)]
        public string Type { get; set; }

        [Required]
        public double Price { get; set; }
    }
}

