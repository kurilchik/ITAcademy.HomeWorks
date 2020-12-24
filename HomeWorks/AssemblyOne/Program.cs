using System;

namespace AssemblyOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);
            Console.WriteLine(Motorcycle.MaxSpeedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedProtected); No access! Available in: AssemblyOne.Motorcycle, AssemblyOne.SportBike, AssemblyTwo.MonkeyBike.
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected); No access! Available in: AssemblyOne.Motorcycle, AssemblyOne.SportBike.
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); No access! Available in: AssemblyOne.Motorcycle.

            Motorcycle moto = new Motorcycle();

            moto._vinNumberPublic = Convert.ToInt32(Console.ReadLine());
            moto._vinNumberProtectedInternal = Convert.ToInt32(Console.ReadLine());
            moto._vinNumberInternal = Convert.ToInt32(Console.ReadLine());
            //moto._vinNumberProtected = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberPrivateProtected = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberPrivate = Convert.ToInt32(Console.ReadLine()); No access!

            Console.WriteLine(moto._vinNumberPublic);
            Console.WriteLine(moto._vinNumberProtectedInternal);
            Console.WriteLine(moto._vinNumberInternal);
            //Console.WriteLine(moto._vinNumberProtected); No access!
            //Console.WriteLine(moto._vinNumberPrivateProtected); No access!
            //Console.WriteLine(moto._vinNumberPrivate); No access!

            moto.ModelPublic = Console.ReadLine();
            moto.ModelProtectedInternal = Console.ReadLine();
            moto.ModelInternal = Console.ReadLine();
            //moto.ModelProtected = Console.ReadLine(); No access!
            //moto.ModelPrivateProtected = Console.ReadLine(); No access!
            //moto.ModelPrivate = Console.ReadLine(); No access!

            Console.WriteLine(moto.ModelPublic);
            Console.WriteLine(moto.ModelProtectedInternal);
            Console.WriteLine(moto.ModelInternal);
            //Console.WriteLine(moto.ModelProtected); No access!
            //Console.WriteLine(moto.ModelPrivateProtected); No access!
            //Console.WriteLine(moto.ModelPrivate); No access!

            moto.StartEnginePublic();
            moto.StartEngineProtectedInternal();
            moto.StartEngineInternal();
            //moto.StartEngineProtected(); No access!
            //moto.StartEnginePrivateProtrcted(); No access!
            //moto.StartEnginePrivate(); No access!
        }
    }
}
