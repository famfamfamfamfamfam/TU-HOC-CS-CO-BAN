using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise
{
    internal class Car
    {
        //Tạo một lớp Car với các thuộc tính Make, Model, và Year.
        //    Viết phương thức DisplayInfo để in thông tin của xe ra màn hình.
        //    Tạo một đối tượng của lớp Car và gọi phương thức DisplayInfo.

        protected string Make;
        protected string Model;
        protected int Year;

        public string getMake()
        {
            return Make;
        }
        public void setMake(string value)
        {
            Make = value;
        }

        public string _model
        {
            get { return Model; } 
            set { Model = value; }
        }

        public int _year
        {
            get { return Year; }
            set { Year = value; }
        }
        public void DisplayInfo(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
            Console.WriteLine(Make + Model + Year);
        }
    }
}
