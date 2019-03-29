using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication2.Models;
using System.Web.Mvc;

namespace WebApplication2.Viewmodels
{
    public class BookingVM
    {
        public Hotel Hotel { get; set; }
        public int RoomId { get; set; }
        List<Room> Rooms { get; set; }
        public Booking Booking { get; set; }

        public IEnumerable<SelectListItem> CollectionRooms
        {
            get

            {
                List<SelectListItem> Items = new List<SelectListItem>();
                foreach (var item in Rooms)
                    Items.Add(new SelectListItem { Value = item.Id.ToString(), Text = item.Type });
                return Items;


            }
        }
    }
}