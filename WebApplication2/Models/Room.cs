using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Room
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public int NoOfRooms { get; set; }
        public int HotelId { get; set; }
        public Hotel Hotel { get; set; }
    }
}