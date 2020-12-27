using System.Collections.Generic;

namespace HW15
{
    class ListMotorcycleRepository : IMotorcycle
    {
        List<Motorcycle> _motorcycles = new List<Motorcycle>();

        public void CreateMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Add(motorcycle);
        }

        public void DeleteMotorcycle(int id)
        {
            _motorcycles.Remove(_motorcycles.Find(x => x.Id == id));
        }

        public Motorcycle GetMotorcycleByID(int id)
        {
            return _motorcycles.Find(x => x.Id == id);
        }

        public List<Motorcycle> GetMotorcycles()
        {
            return _motorcycles;
        }

        public void UpdateMotorcycle(Motorcycle motorcycle)
        {
            _motorcycles.Remove(_motorcycles.Find(x => x.Id == motorcycle.Id));
            _motorcycles.Add(motorcycle);
        }
    }
}
