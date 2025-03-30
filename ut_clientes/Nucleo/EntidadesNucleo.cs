
using lib_dominio.Entidades;

namespace ut_clientes.Nucleo
{
    public class EntidadesNucleo
    {
        public static Clientes? Clientes()
        {
            var entidad = new Clientes();
            entidad.Cedula = "Pruebas-" + DateTime.Now.ToString("yyyyMMddhhmmss");
            entidad.Nombre = "Sujeto Prueba 2";
            entidad.Telefono = "3105254987";
            return entidad;
        }
    }
}
