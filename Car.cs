using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR26
{
    class Car
    {
        string model;
        int year;
        public static int totalCars = 0;
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                model = value;
            }
        }
        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                this.year = value;
            }
        }
        public Car() {}
        public Car(string model,int Year)
        {
            this.Model = model;
            this.Year = year;
            totalCars++;
        }
    }
}
