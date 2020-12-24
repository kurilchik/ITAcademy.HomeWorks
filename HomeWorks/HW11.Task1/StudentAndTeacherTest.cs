using HW11.Task1.Persons;
using System;

namespace HW11.Task1
{
    static class StudentAndTeacherTest
    {
        public static void Test()
        {
            Person person = new Person();
            person.Greeting();
            Console.WriteLine(String.Empty);

            Student student = new Student();
            student.SetAge(21);
            student.Greeting();
            student.ShowAge();
            Console.WriteLine(String.Empty);

            Teacher teacher = new Teacher();
            teacher.SetAge(30);
            teacher.Greeting();
            teacher.Explain();
        }
    }
}
