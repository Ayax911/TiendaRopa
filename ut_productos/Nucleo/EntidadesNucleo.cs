
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;

namespace ut_clientes.Nucleo
{
    public class EntidadesNucleo
    {
        public static Productos? Productos(IConexion conexion)
        {
            var marca = conexion.Marcas!.FirstOrDefault(x => x.Nombre == "RopaFina");

            var entidad = new Productos();
            entidad.Nombre = "ArturoCalle";
            entidad.Material = "Lino";
            entidad.ValorUnitario = 100000;
            entidad.Marca = marca!.Id; 

            return entidad;
        }
    }
}
