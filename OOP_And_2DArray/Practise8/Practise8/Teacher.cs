using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise8
{
    internal class Teacher
    {
        protected string Name;
        protected string Subject;
        public string name {  get => Name; set => Name = value; }
        public string subject { get => Subject; set => Subject = value; }
        public List<Student> students = new List<Student>();
        public void DisplayInfo()
        {
            Console.WriteLine($"Giao vien {Name} day mon {Subject} dam nhiem cac hoc sinh:");
            foreach (Student student in students)
            {
                Console.WriteLine($"Hoc sinh {student.name} hoc lop {student.grade}");
            }
        }
    }
}
