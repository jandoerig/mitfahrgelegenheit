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
        public static List<Car> cars = new List<Car>();
        static CarModel()
        {
            Car driver1 = new Car("Töbi Kuhl", "St. Gallen BHF", 7, "2019.2.21");
            Car driver2 = new Car("Töbi Schwul", "Zürich HB", 7, "2019.2.22");
            cars.Add(driver2);
            cars.Add(driver1);
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