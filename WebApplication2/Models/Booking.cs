using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int RoomId { get; set; }
        public DateTime BookDate { get; set; }
        public DateTime CheckIn { get; set; }
        public DateTime CheckOut { get; set; }
        public int NoOfRooms { get; set; }
        public string Status { get; set; }
        public Member Member { get; set; }
        public Room Room { get; set; }


    }
}