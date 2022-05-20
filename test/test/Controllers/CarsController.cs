using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace test.Controllers
{
    public class CarsController : Controller
    {
        [HttpGet]
        public string GetCarsList()
        {
            var c = new Car();
            return JsonConvert.SerializeObject(Car.Cars);


        }

        [HttpPost]
        public void AddCar(JObject car)
        {
            Car newCar = new Car();
            newCar.Name = car["Name"].ToString();
            newCar.Model = car["Model"].ToString();
            newCar.Volume = int.Parse(car["Volume"].ToString());

            Car.Cars.Add(newCar);

        }

        [HttpDelete]
        public void RemoveCar(string model)
        {

            //  int m = int.Parse(model);
            //var carsList = new List<Car>();
            // Car.Cars.Remove();
            var car = Car.Cars.Select(x => x.Model == model) as Car;
            Car.Cars.Remove(car);


        }
    }

    public class Car
    {
        public static List<Car> Cars = new List<Car>();
        public string Name { get; set; }
        public string Model
        {
            get;set;
        }

        public Car()
        {
            var cal = new Car();
            cal.Name = "Subaru";
            cal.Model = "1.2.3";
            cal.Volume = 1000;
            Car.Cars.Add(cal);
        }
        public int Volume { get; set; }

    }
}