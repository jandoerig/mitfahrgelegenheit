using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace transportApp.Models
{
    public class Event
    {
        public string name { get; set; }
        public string location { get; set; }
        public string datetime { get; set; }
        public List<Car> cars { get; set; }

        public Event(string name, string location, string datetime, List<Car> cars)
        {
            this.name = name;
            this.location = location;
            this.datetime = datetime;
            this.cars = cars;
        }

        public Event(string name, string location, string datetime)
        {
            this.name = name;
            this.location = location;
            this.datetime = datetime;
            this.cars = cars;
        }

        public void addCar(Car car)
        {
            cars.Add(car);
        }

    }
}