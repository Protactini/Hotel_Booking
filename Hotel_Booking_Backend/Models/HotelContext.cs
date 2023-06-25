using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Hotel_Booking_Backend.Models;

public class HotelContext : DbContext
{
    public HotelContext(DbContextOptions<HotelContext> options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
}

