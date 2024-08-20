using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise9
{
    internal class Employee
    {
        public string Name { get; set; }
        public string Position { get; set; }
        public Department Department { get; set; }
        //public Employee(string name) // Có tính đóng gói, hàm Main không cần thực hiện việc khởi tạo đối tượng, đối tượng lớp Department tự động được khởi tạo khi khởi tạo đối tượng lớp Employee
        //{
        //    Department = new Department() { name = name};
        //}
        //public void department(string name) //Không có tính đóng gói, phải gọi hàm để khởi tạo đối tượng
        //{
        //    Department = new Department();
        //    Department.name = name;
        //}
        public void DisplayInfo()
        {
            Console.WriteLine($"Nhan vien {Name} lam o vi tri {Position} thuoc bo phan {Department.name}");
        }
    }
}
