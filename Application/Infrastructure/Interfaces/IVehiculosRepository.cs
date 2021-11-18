using Domain.Vehiculos;
using Infrastructure.Filters;
using System.Collections.Generic;

namespace Infrastructure.Interfaces
{
    public interface IVehiculosRepository
    {
        public IEnumerable<Vehiculo> GetVehiculos();
        public IEnumerable<Vehiculo> GetVehiculos(VehiculosFilter Filtros);
    }
}
