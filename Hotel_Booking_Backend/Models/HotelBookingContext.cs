using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace Hotel_Booking_Backend.Models;

public class HotelBookingContext : DbContext
{
    public HotelBookingContext(DbContextOptions<HotelBookingContext> options) : base(options)
    {
    }

    public DbSet<Hotel> Hotels { get; set; }
    public DbSet<Room> Rooms { get; set; }
    public DbSet<Booking> Bookings { get; set; }
    public DbSet<User> Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // Configure entity relationships and other model configurations

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.User)
            .WithMany(u => u.Bookings)
            .HasForeignKey(b => b.UserId).IsRequired();

        modelBuilder.Entity<Booking>()
            .HasOne(b => b.Room)
            .WithOne(r => r.Booking)
            .HasForeignKey<Booking>(b => b.RoomId).IsRequired();

        modelBuilder.Entity<Hotel>()
            .HasMany(h => h.Rooms)
            .WithOne(r => r.Hotel)
            .HasForeignKey(r => r.HotelId).IsRequired();
    }
 

}

