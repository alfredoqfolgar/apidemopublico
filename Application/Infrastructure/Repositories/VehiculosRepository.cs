using Domain.Interfaces;
using Domain.Vehiculos;
using Infrastructure.Filters;
using Infrastructure.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Infrastructure.Repositories
{
    public class VehiculosRepository : IVehiculosRepository
    {
        public IEnumerable<Vehiculo> GetVehiculos()
        {
            var Vehiculos = Enumerable.Range(2004, 18).Select(y => new Vehiculo
            {
                Modelo = y,
                Marca = "TOYOTA",
                Linea = "COROLLA",
                Equipamiento = 1,
                Precio = y + new Random().Next()
            }
            );
            return Vehiculos;
        }

        public IEnumerable<Vehiculo> GetVehiculos(VehiculosFilter Filtros){
           return GetVehiculos().Where(v => v.Marca == Filtros.Marca.ToUpper()
           && v.Modelo == Filtros.modelo && v.Equipamiento == Filtros.equipamiento && v.Linea == Filtros.linea.ToUpper());
            }

    }
}
