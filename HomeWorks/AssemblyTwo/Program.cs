using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            //Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal); No access! Available in: AssemblyOne.Program, AssemblyOne.Motorcycle, AssemblyOne.SportBike, AssemblyTwo.MonkeyBike.
            //Console.WriteLine(Motorcycle.MaxSpeedInternal); No access! Available in: AssemblyOne.Program, AssemblyOne.Motorcycle, AssemblyOne.SportBike.
            //Console.WriteLine(Motorcycle.MaxSpeedProtected); No access! Available in: AssemblyOne.Motorcycle, AssemblyOne.SportBike, AssemblyTwo.MonkeyBike.
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected); No access! Available in: AssemblyOne.Motorcycle, AssemblyOne.SportBike.
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); No access! Available in: AssemblyOne.Motorcycle.

            Motorcycle moto = new Motorcycle();

            moto._vinNumberPublic = Convert.ToInt32(Console.ReadLine());
            //moto._vinNumberProtectedInternal = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberInternal = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberProtected = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberPrivateProtected = Convert.ToInt32(Console.ReadLine()); No access!
            //moto._vinNumberPrivate = Convert.ToInt32(Console.ReadLine()); No access!

            Console.WriteLine(moto._vinNumberPublic);
            //Console.WriteLine(moto._vinNumberProtectedInternal); No access!
            //Console.WriteLine(moto._vinNumberInternal); No access!
            //Console.WriteLine(moto._vinNumberProtected); No access!
            //Console.WriteLine(moto._vinNumberPrivateProtected); No access!
            //Console.WriteLine(moto._vinNumberPrivate); No access!

            moto.ModelPublic = Console.ReadLine();
            //moto.ModelProtectedInternal = Console.ReadLine(); No access!
            //moto.ModelInternal = Console.ReadLine(); No access!
            //moto.ModelProtected = Console.ReadLine(); No access!
            //moto.ModelPrivateProtected = Console.ReadLine(); No access!
            //moto.ModelPrivate = Console.ReadLine(); No access!

            Console.WriteLine(moto.ModelPublic);
            //Console.WriteLine(moto.ModelProtectedInternal); No access!
            //Console.WriteLine(moto.ModelInternal); No access!
            //Console.WriteLine(moto.ModelProtected); No access!
            //Console.WriteLine(moto.ModelPrivateProtected); No access!
            //Console.WriteLine(moto.ModelPrivate); No access!

            moto.StartEnginePublic();
            //moto.StartEngineProtectedInternal(); No access!
            //moto.StartEngineInternal(); No access!
            //moto.StartEngineProtected(); No access!
            //moto.StartEnginePrivateProtrcted(); No access!
            //moto.StartEnginePrivate(); No access!
        }
    }
}
