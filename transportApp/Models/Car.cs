using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace transportApp.Models
{
    public class Car
    {
        public string drivername { get; set; }
        public string pickupLocation { get; set; }
        public int emptySeats { get; set; }
        public string datetime { get; set; }
        public List<User> kids { get; set; }

        public Car(string drivername, string pickupLocation, int seats, string datetime)
        {
            this.drivername = drivername;
            this.pickupLocation = pickupLocation;
            this.emptySeats = seats;
            this.datetime = datetime;
        }

        public void insertKid(User kid)
        {
            kids.Add(kid);
        }

    }
}