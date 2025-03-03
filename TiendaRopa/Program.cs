// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

public class Clientes
{

    public int IdCliente { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public int Telefono { get; set; }

    public List<Compras> Compras { get; set; }

    
}

public class Sucursales
{

    public int IdSucursales { get; set; }
    public string? Nombre { get; set;}

    public List<Compras> Compras { get; set; }

}

public class MetodosPagos
{

    public int IdMetodosPagos { get; set; }
    public string? Nombre { get;set; }


    public List<Compras> Compras { get; set; }

}

public class Lugares
{

    public int IdLugar { get; set; }
    public string Nombre { get; set; }


    public List<Compras> Compras { get; set; }


}

public class Compras
{

    public int IdCompras { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Codigo { get; set; }
    public double ValorTotal { get; set; }


    public Clientes? _Cliente { get; set; }
    public Sucursales? _Sucursales { get; set; }
    public MetodosPagos? _MetodosPagos { get; set; }
    public Lugares? _Lugares { get; set; }

}

public class DetallesCompras
{
    public int IdDetalles { get; set; }
    public int Cantidad { get; set; }
    public double ValorBruto { get; set; }


    public Compras? Compras { get; set; }

}
