using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes_Basic
{
    public class Human
    {
        //default constructor
        public Human() 
        {
            Console.WriteLine("Object created");
        } 
            
        


        //paramiterized construcor -2-
        public Human(string firstName, string lastName, string eyeColor, int age)
        {
            //global variable = passed variable
            this.firstName = firstName;
            this.lastName = lastName;
            this.eyeColor = eyeColor;
            this.age = age;
        }



        //because of use of constructror, we can make the props private
        public string firstName { get; set; }
        private string lastName { get; set; }
        private string eyeColor { get; set; }
        private int age { get; set; }

        public  void Introduce()
        {
            Console.WriteLine("Hello, my name is {0} {1} im {2} and i have {3} eyes.",firstName,lastName,age,eyeColor);
            
        }
    }
}
