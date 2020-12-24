namespace HW12
{
    class Passenger
    {
        private readonly string _name;

        public bool Passport { get; set; }
        public bool Ticket { get; set; }
        public bool CarryOn { get; set; }
        public bool Baggage { get; set; }


        public string Name
        {
            get { return _name; }
        }

        public Passenger(string name, bool passport)
        {
            _name = name;
            Passport = passport;
        }
        public Passenger(string name, bool passport, bool ticket)
        {
            _name = name;
            Passport = passport;
            Ticket = ticket;
        }
    }
}
