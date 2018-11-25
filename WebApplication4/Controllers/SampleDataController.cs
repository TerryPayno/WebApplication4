using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplication4.Models;
using Newtonsoft.Json;

namespace WebApplication4.Controllers
{
    [Route("api/SampleDataController")]
    public class SampleDataController : Controller
    {
        [HttpGet("GetCarData")]
        public string GetCarData()
        {
            Car SampleCar = new Car();
            string test = JsonConvert.SerializeObject(SampleCar);
            return test;
        }
        [HttpGet("GetAll")]
        public List<Car> GetAll()
        {
            Car SampleCar = new Car();
            Car SampleCar2 = new Car();
            SampleCar2.Title = "BushMobile";
            Car SampleCar3 = new Car();
            SampleCar3.Title = "James Wagen";
            List<Car> myList = new List<Car>();
            myList.Add(SampleCar);
            myList.Add(SampleCar2);
            myList.Add(SampleCar3);
            string test = JsonConvert.SerializeObject(myList);
            return myList;
        }


    }
}
