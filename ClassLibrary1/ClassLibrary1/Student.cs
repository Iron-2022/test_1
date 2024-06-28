using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Student:IComparable<Student>
    {
        public string Name { get; set; }
        public double Ocenka { get; set; }
        public void Show()
        {
            Console.WriteLine(this.Name);
        }
        public int CompareTo(Student obj)
        {
            if (obj == this) return 1;
            else return 0;
        }
    }
}
