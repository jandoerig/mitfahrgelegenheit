using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using transportApp.Models;

namespace transportApp.Models
{
    public static class CarModel
    {
        public static List<Car> cars;
        static CarModel()
        {
            Car driver1 = new Car("Töbi Kuhl", "St. Gallen BHF", 7, "2019.2.21");
            Car driver2 = new Car("Töbi Schwul", "Zürich HB", 7, "2019.2.22");
            cars = new List<Car>();
            cars.Add(driver1);
            cars.Add(driver2);
        }

        public static void insert(Car car)
        {
            cars.Add(car);
        }

        public static void remove(Car car)
        {
            cars.Remove(car);
        }
        public static void modify(Car car, Car newCar)
        {
            cars[cars.IndexOf(car)] = newCar;
        }


    }
}