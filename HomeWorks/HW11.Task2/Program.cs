namespace HW11.Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            SmallApartment smallApartment = new SmallApartment("red");
            Person person = new Person("Nick", smallApartment);
            person.ShowData();
        }
    }
}
