
namespace lib_dominio.Entidades
{
    public class Productos
    {

        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Material { get; set; }
        public decimal ValorUnitario { get; set; }

        //FK
        public int Marcas { get; set; }


        public Marcas? _Marca { get; set; }


        public List<DetallesCompras>? DetallesCompras { get; set; }

    }


}
