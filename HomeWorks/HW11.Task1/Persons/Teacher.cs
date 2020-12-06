using System;

namespace HW11.Task1.Persons
{
    class Teacher : Person
    {
        private string _subject;

        public override void Greeting()
        {
            base.Greeting();
            Console.WriteLine("I am a teacher.");
        }

        public void Explain()
        {
            Console.WriteLine("Explanation  begins.");
        }
    }
}
