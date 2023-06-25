﻿using System.ComponentModel.DataAnnotations;

namespace HotelBookingService.Models
{
    public class Room
    {
        public int Id { get; set; }
        public int HotelId { get; set; }
        
        [Required]
        [MaxLength(10)]
        public string RoomNumber { get; set; }
        
        [Required]
        [Range(0, double.MaxValue)]
        public decimal PricePerNight { get; set; }
        
        // Additional properties specific to a room
    }
}
