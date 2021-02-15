namespace HW09.Task2
{
    class Class1
    {
        private int _myVar;

        public int MyPropertyFull
        {
            get { return _myVar; }
            set { _myVar = value; }
        }

        public int MyPropertyAuto { get; set; }

        public Class1(int num1, int num2)
        {
            MyPropertyFull = num1;
            MyPropertyAuto = num2;
        }
    }
}
