using System;

namespace HW11.Task2
{
    class House
    {
        private protected int _area;
        private protected readonly string _doorColor;        

        public int Area
        {
            get { return _area; }
            private set { _area = value; }
        }

        protected House(string doorColor)
        {
            _doorColor = doorColor;
        }

        public House(int area, string doorColor)
        {
            Area = area;
            _doorColor = doorColor;
        }

        public void ShowData()
        {
            Console.WriteLine($"I  am  a  house,  my  area  is  {Area}  m2.");
        }

        public void GetDoor()
        {
            Door _door = new Door(_doorColor);
            _door.ShowData();
        }


        protected class Door
        {
            private protected string _color;

            public string Color
            {
                get { return _color; }
                set { _color = value; }
            }

            public Door(string doorColor)
            {
                Color = doorColor;
            }

            public void ShowData()
            {
                Console.WriteLine($"I  am  a  door,  my  color  is {_color}.");
            }
        }
    }
}
