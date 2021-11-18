
using Infrastructure.Filters;
using Infrastructure.Interfaces;
using Microsoft.AspNetCore.Mvc;


namespace ApiCotizaciones.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class VehiculosController : Controller
    {

        IVehiculosRepository VehiculoReposiroty { get; set; }
        public VehiculosController(IVehiculosRepository _VehiculoReposiroty) {
            VehiculoReposiroty = _VehiculoReposiroty;
        }

        [HttpGet("{marca}/{linea}/{modelo}")]
        /// <summary>
        /// Metodo para cotizacion de vehiculos
        /// </summary>
        /// <param name="marca">Marca del vehiculo</param>
        /// <param name="linea">Linea de vehiculo por ejemplo: Corolla</param>
        /// <param name="equipamiento">1 basico, 2 medio, 3 full equipo/param>
        /// <param name="modelo">Anio de modelo de vehiculo</param>
        /// <returns></returns>
        public IActionResult BuscarVehiculo(string marca, string linea, int equipamiento,
            int modelo)
        {
            VehiculosFilter Filtros = new VehiculosFilter {Marca = marca, linea=linea, modelo = modelo, equipamiento = equipamiento };
            return Ok(VehiculoReposiroty.GetVehiculos(Filtros));
        }


    }
}
