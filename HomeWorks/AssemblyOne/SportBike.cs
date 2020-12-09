using System;

namespace AssemblyOne
{
    class SportBike : Motorcycle
    {
        void ExampleUsing()
        {
            Console.WriteLine(Motorcycle.MaxSpeedPublic);
            Console.WriteLine(Motorcycle.MaxSpeedProtectedInternal);
            Console.WriteLine(Motorcycle.MaxSpeedInternal);
            Console.WriteLine(Motorcycle.MaxSpeedProtected);
            Console.WriteLine(Motorcycle.MaxSpeedPrivateProtected);
            //Console.WriteLine(Motorcycle.MaxSpeedPrivate); No access! Available in: AssemblyOne.Motorcycle.

            _vinNumberPublic = Convert.ToInt32(Console.ReadLine());
            _vinNumberProtectedInternal = Convert.ToInt32(Console.ReadLine());
            _vinNumberInternal = Convert.ToInt32(Console.ReadLine());
            _vinNumberProtected = Convert.ToInt32(Console.ReadLine());
            _vinNumberPrivateProtected = Convert.ToInt32(Console.ReadLine());
            //_vinNumberPrivate = Convert.ToInt32(Console.ReadLine()); No access!

            Console.WriteLine(_vinNumberPublic);
            Console.WriteLine(_vinNumberProtectedInternal);
            Console.WriteLine(_vinNumberInternal);
            Console.WriteLine(_vinNumberProtected);
            Console.WriteLine(_vinNumberPrivateProtected);
            //Console.WriteLine(_vinNumberPrivate); No access!

            ModelPublic = Console.ReadLine();
            ModelProtectedInternal = Console.ReadLine();
            ModelInternal = Console.ReadLine();
            ModelProtected = Console.ReadLine();
            ModelPrivateProtected = Console.ReadLine();
            //ModelPrivate = Console.ReadLine(); No access!

            Console.WriteLine(ModelPublic);
            Console.WriteLine(ModelProtectedInternal);
            Console.WriteLine(ModelInternal);
            Console.WriteLine(ModelProtected);
            Console.WriteLine(ModelPrivateProtected);
            //Console.WriteLine(ModelPrivate); No access!

            StartEnginePublic();
            StartEngineProtectedInternal();
            StartEngineInternal();
            StartEngineProtected();
            StartEnginePrivateProtrcted();
            //StartEnginePrivate(); No access!
        }
    }
}
