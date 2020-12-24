using System;

namespace HW11.Task1.Persons
{
    class Student : Person
    {
        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("I am a student.");
        }

        public void ShowAge()
        {
            Console.WriteLine($"My age is: {_age} years old.");
        }

        public void GoToClasses()
        {
            Console.WriteLine("I’m going to class.");
        }
    }
}
