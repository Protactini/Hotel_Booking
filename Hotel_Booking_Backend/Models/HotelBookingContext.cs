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
    public IEnumerable<Booking> GetAllBookings()
    {
        // Retrieve all bookings from the database
        return Bookings;
    }

    public IEnumerable<Booking> GetAllBookingsByHotelId(int hotelId)
    {
        // Retrieve all bookings for a specific hotel from the database
        return Bookings.Include(b => b.Room).Where(b => b.Room.HotelId == hotelId);
    }

    public Booking GetBookingById(int id)
    {
        // Retrieve a booking by its ID from the database
        return Bookings.Find(id);
    }

    public Booking CreateBooking(Booking booking)
    {
        // Add a new booking to the database
        Bookings.Add(booking);
        SaveChanges();
        return booking;
    }

    public void UpdateBooking(Booking booking)
    {
        // Update a booking in the database
        Entry(booking).State = EntityState.Modified;
        SaveChanges();
    }

    public void DeleteBooking(int id)
    {
        // Delete a booking from the database
        var booking = Bookings.Find(id);
        if (booking != null)
        {
            Bookings.Remove(booking);
            SaveChanges();
        }
    }


}

