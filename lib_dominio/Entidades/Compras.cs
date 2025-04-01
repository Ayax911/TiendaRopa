
namespace lib_dominio.Entidades
{

    public class Compras
    {

        public int Id { get; set; }
        public DateTime Fecha { get; set; }
        public string? Codigo { get; set; }
        public decimal ValorTotal { get; set; }

        //FK
        public int Cliente { get; set; }
        public int Sucursal { get; set; }
        public int MetodoPago { get; set; }
        public int Lugar { get; set; }

        [ForeignKey("Cliente")] public Clientes? _Cliente { get; set; }
        [ForeignKey("Sucursal")] public Clientes? _Sucursal { get; set; }
        [ForeignKey("MetodoPago")] public Clientes? _MetodoPago { get; set; }
        [ForeignKey("Lugar")] public Clientes? _Lugar { get; set; }


        public List<DetallesCompras>? DetallesCompras { get; set; }

    }

}
