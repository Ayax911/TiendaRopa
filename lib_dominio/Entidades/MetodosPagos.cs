
namespace lib_dominio.Entidades
{
    public class MetodosPagos
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public Boolean? Estado { get; set; }


        public List<Compras>? Compras { get; set; }

    }

}
