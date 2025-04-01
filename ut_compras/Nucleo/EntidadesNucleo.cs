
using lib_dominio.Entidades;
using lib_repositorios.Interfaces;

namespace ut_compras.Nucleo
{
    public class EntidadesNucleo
    {
        public static Compras? Compras(IConexion conexion)
        {
            var cliente = conexion.Clientes!.FirstOrDefault(x => x.Id == 1);
            var sucursal = conexion.Sucursales!.FirstOrDefault(x => x.Id == 1);
            var metodoPago = conexion.MetodosPagos!.FirstOrDefault(x => x.Id == 1);
            var lugar = conexion.Lugares!.FirstOrDefault(x => x.Id == 1);

            var entidad = new Compras();
            entidad.Fecha = DateTime.Now;
            entidad.Codigo = "Compras Prueba";
            entidad.ValorTotal = 10000.05m;

            entidad.Cliente = cliente!.Id;
            entidad.Sucursal = sucursal!.Id;
            entidad.MetodoPago = metodoPago!.Id;
            entidad.Lugar = lugar!.Id;

            return entidad;
        }
    }
}
