using System;
namespace Hotel_Booking_Backend.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int RoomId { get; set; }
        public DateTime CheckInDate { get; set; }
        public DateTime CheckOutDate { get; set; }
        public BookingStatus Status { get; set; }
    }

    public enum BookingStatus
    {
        Pending,
        Confirmed,
        Cancelled
    }
}

