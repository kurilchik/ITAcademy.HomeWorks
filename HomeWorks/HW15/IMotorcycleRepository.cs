using System.Collections.Generic;

namespace HW15
{
    public interface IMotorcycleRepository
    {
        public Motorcycle GetMotorcycleByID(int id);

        public List<Motorcycle> GetMotorcycles();

        public void CreateMotorcycle(Motorcycle motorcycle);

        public void UpdateMotorcycle(Motorcycle motorcycle);

        public void DeleteMotorcycle(int id);
    }
}
