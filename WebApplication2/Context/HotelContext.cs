using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using WebApplication2.Models;

namespace WebApplication2.Context
{
    public class HotelContext : DbContext
    {
        public HotelContext() : base("DefaultConnection") { }

        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<Hotel> Hotels { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<City> Cities { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Booking>().HasRequired(s => s.Member).WithMany().HasForeignKey(s => s.MemberId);
            modelBuilder.Entity<Booking>().HasRequired(s => s.Room).WithMany().HasForeignKey(s => s.RoomId);
            modelBuilder.Entity<Room>().HasRequired(s => s.Hotel).WithMany().HasForeignKey(s => s.HotelId);
            modelBuilder.Entity<Hotel>().HasRequired(s => s.City).WithMany().HasForeignKey(s => s.CityId);

            base.OnModelCreating(modelBuilder);
        }
    }
    }