using System;
using System.Collections.Generic;

namespace HW15
{
    public interface IMotorcycleRepository<T>
    {
        public T GetMotorcycleByID(Guid id);

        public List<T> GetMotorcycles();

        public void CreateMotorcycle(T motorcycle);

        public void UpdateMotorcycle(T motorcycle);

        public void DeleteMotorcycle(Guid id);
    }
}
