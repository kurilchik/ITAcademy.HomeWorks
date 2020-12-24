using AssemblyOne;
using System;

namespace AssemblyTwo
{
    class MonkeyBike : Motorcycle
    {
        void ExampleUsing()
        {
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);
            //Console.WriteLine(Motorcycle.MaxSpeedInternal); No access! Available in: AssemblyOne.Program, AssemblyOne.Motorcycle, AssemblyOne.SportBike.
            Console.WriteLine(Motorcycle.MaxSpeedProtected);
            //Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected); No access! Available in: AssemblyOne.Motorcycle, AssemblyOne.SportBike.
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); No access! Available in: AssemblyOne.Motorcycle.

            _vinNumberPublic = Convert.ToInt32(Console.ReadLine());
            _vinNumberProtectedInternal = Convert.ToInt32(Console.ReadLine());
            //_vinNumberInternal = Convert.ToInt32(Console.ReadLine()); No access!
            _vinNumberProtected = Convert.ToInt32(Console.ReadLine());
            //_vinNumberPrivateProtected = Convert.ToInt32(Console.ReadLine()); No access!
            //_vinNumberPrivate = Convert.ToInt32(Console.ReadLine()); No access!

            Console.WriteLine(_vinNumberPublic);
            Console.WriteLine(_vinNumberProtectedInternal);
            //Console.WriteLine(_vinNumberInternal); No access!
            Console.WriteLine(_vinNumberProtected);
            //Console.WriteLine(_vinNumberPrivateProtected); No access!
            //Console.WriteLine(_vinNumberPrivate); No access!

            ModelPublic = Console.ReadLine();
            ModelProtectedInternal = Console.ReadLine();
            //ModelInternal = Console.ReadLine(); No access!
            ModelProtected = Console.ReadLine();
            //ModelPrivateProtected = Console.ReadLine(); No access!
            //ModelPrivate = Console.ReadLine(); No access!

            Console.WriteLine(ModelPublic);
            Console.WriteLine(ModelProtectedInternal);
            //Console.WriteLine(ModelInternal); No access!
            Console.WriteLine(ModelProtected);
            //Console.WriteLine(ModelPrivateProtected); No access!
            //Console.WriteLine(ModelPrivate); No access!

            StartEnginePublic();
            StartEngineProtectedInternal();
            //StartEngineInternal(); No access!
            StartEngineProtected();
            //StartEnginePrivateProtrcted(); No access!
            //StartEnginePrivate(); No access! No access!
        }
    }
}
