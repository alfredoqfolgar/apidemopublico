using Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Filters
{
    public class VehiculosFilter: IVehiculosFilter
    {

        public string Marca { get; set; }

        public string linea { get; set; }

        public int equipamiento { get; set; }

        public int modelo { get; set; }


    }
}
