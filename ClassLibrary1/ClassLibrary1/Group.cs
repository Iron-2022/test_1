using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Group
    {
        public string Name { get; set; }
        public string College { get; set; }
        public List<Student> Students { get; set; } = new List<Student>();
        public void ShowAll()
        {
            foreach(Student student in Students)
            {
                Console.WriteLine(student.Name + student.Ocenka);
            }
        }
        
    }
}
