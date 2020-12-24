using System;

namespace HW11.Task1.Persons
{
    class Person
    {
        private protected int _age;

        public void SetAge(int age)
        {
            _age = age;
        }

        public virtual void Greeting()
        {
            Console.WriteLine("Hello!");
        }
    }
}
