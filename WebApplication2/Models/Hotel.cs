using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Hotel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte[] Image { get; set; }
        public string Information { get; set; }
        public int NoOfRooms { get; set; }
        public int CityId { get; set; }
        public City City { get; set; }
    }
}