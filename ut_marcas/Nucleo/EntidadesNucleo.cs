
using lib_dominio.Entidades;

namespace ut_clientes.Nucleo
{
    public class EntidadesNucleo
    {
        public static Marcas? Marcas()
        {
            var entidad = new Marcas();
            entidad.Nit = "222222";
            entidad.Nombre = "Marca Prueba 2";
            
            return entidad;
        }
    }
}
