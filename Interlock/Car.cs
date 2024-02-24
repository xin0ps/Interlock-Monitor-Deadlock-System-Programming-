using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interlock
{
    public class Car
    {

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public String Photo  { get; set; }

        public Car(string marka, string model, string year, string photo)
        {
            Marka = marka;
            Model = model;
            Year = year;
            Photo = photo;
        }

        public Car()
        {
            
        }


    }
}
