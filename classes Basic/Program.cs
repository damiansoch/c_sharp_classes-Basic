using System;

namespace classes_Basic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            //without constructors (wont work because constructor created)
            Manager employee1 = new Manager();
            employee1.firstName = "Damian";
            employee1.lastName = "Socha";
            employee1.position = "BOSS";

            employee1.Introduce();
            employee1.ImAManager();

            // simplifiesd (wont work because constructor created)
            
            Manager employee2 = new()
            {
                firstName = "Kinga",
                lastName = "Socha"
            };
            

            employee2.Introduce();
            */
            //with constructor (from -1-)
            Human basic = new();
            basic.firstName = "john";//we can assign properties, but they need to be declared as public in the class


            //with constructor (from -2-)
            Human employee3 = new("Milena", "Socha","blue",13);
            employee3.Introduce();

            Human employee4 = new("Szymon", "Socha","green",2);
            employee4.Introduce();
        }
    }
}
