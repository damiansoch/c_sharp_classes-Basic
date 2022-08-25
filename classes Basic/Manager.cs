using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_Basic
{
    public class Manager : Human
    {
        public Manager(string fName, string lName , string eyeColor,int age) : base(fName, lName,eyeColor,age)
        {
        }

        public string position { get; set; }

        public void ImAManager()
        {
            Console.WriteLine("I Am a {0}",position);
        }
    }
}
