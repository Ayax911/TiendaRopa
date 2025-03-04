// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var lista_clientes = new List <Clientes>();

lista_clientes.Add (new Clientes() { IdClientes = 1, Cedula = "111", Nombre = "Carlos Romero", Telefono = "3157894562" });
lista_clientes.Add(new Clientes() { IdClientes = 2, Cedula = "222", Nombre = "Marco Polo", Telefono = "3164568582" });
lista_clientes.Add(new Clientes() { IdClientes = 3, Cedula = "333", Nombre = "Alan Turing", Telefono = "3125469887" });
lista_clientes.Add(new Clientes() { IdClientes = 4, Cedula = "444", Nombre = "Ada Lovelace", Telefono = "3225648213" });



var lista_sucursales = new List<Sucursales>();

lista_sucursales.Add(new Sucursales() { IdSucursales = 1, Nombre = "A1" , Direccion = "Calle 1"});
lista_sucursales.Add(new Sucursales() { IdSucursales = 2, Nombre = "A2" , Direccion = "Calle 2 " });
lista_sucursales.Add(new Sucursales() { IdSucursales = 3, Nombre = "A3" , Direccion = "Calle 3" });
lista_sucursales.Add(new Sucursales() { IdSucursales = 4, Nombre = "A4" , Direccion = "Calle 4" });


var lista_metodospagos = new List<MetodosPagos>();

lista_metodospagos.Add(new MetodosPagos() { IdMetodosPagos = 1, Nombre = "Credito", Estado = true});
lista_metodospagos.Add(new MetodosPagos() { IdMetodosPagos = 2, Nombre = "Debito" , Estado = true });
lista_metodospagos.Add(new MetodosPagos() { IdMetodosPagos = 3, Nombre = "Efectivo" , Estado = true });


var lista_lugares = new List<Lugares>();

lista_lugares.Add(new Lugares() { IdLugares = 1, Nombre = "San Antonio", CodigoPostal = "5001" });
lista_lugares.Add(new Lugares() { IdLugares = 2, Nombre = "Poblado", CodigoPostal = "5002" });
lista_lugares.Add(new Lugares() { IdLugares = 3, Nombre = "Las Americas", CodigoPostal = "5003" });


var lista_marcas = new List<Marcas>();

lista_marcas.Add(new Marcas() { IdMarcas = 1, Nombre = "Arturo Calle", Nit = 123 });
lista_marcas.Add(new Marcas() { IdMarcas = 2, Nombre = "Patprimo", Nit = 456 });
lista_marcas.Add(new Marcas() { IdMarcas = 3, Nombre = "Estudio F", Nit = 101 });



var lista_productos = new List<Productos>();

lista_productos.Add(new Productos() { IdProductos = 1, Nombre = "Blazer", Material = "Algodón", ValorUnitario = 300000, _Marca = lista_marcas[0] });
lista_productos.Add(new Productos() { IdProductos = 2, Nombre = "Camisa", Material = "Seda", ValorUnitario = 400000, _Marca = lista_marcas[1] });
lista_productos.Add(new Productos() { IdProductos = 3, Nombre = "Blusa", Material = "Algodon", ValorUnitario = 500000, _Marca = lista_marcas[2] });



var lista_compras = new List<Compras>();

lista_compras.Add(new Compras() { IdCompras = 1, Codigo = "A001", Fecha = new DateTime( 2025, 2, 1), ValorTotal = 600000, _Cliente = lista_clientes[0], _Lugar = lista_lugares[0], _MetodoPago = lista_metodospagos[1], _Sucursal = lista_sucursales[0] });
lista_compras.Add(new Compras() { IdCompras = 2, Codigo = "B001", Fecha = new DateTime( 2025, 1, 25), ValorTotal = 1200000, _Cliente = lista_clientes[1], _Lugar = lista_lugares[1], _MetodoPago = lista_metodospagos[0], _Sucursal = lista_sucursales[1] });
lista_compras.Add(new Compras() { IdCompras = 3, Codigo = "C003", Fecha = new DateTime( 2025, 1, 19), ValorTotal = 2000000, _Cliente = lista_clientes[2], _Lugar = lista_lugares[0], _MetodoPago = lista_metodospagos[2], _Sucursal = lista_sucursales[3] });
lista_compras.Add(new Compras() { IdCompras = 4, Codigo = "D004", Fecha = new DateTime( 2025, 2, 1), ValorTotal = 500000, _Cliente = lista_clientes[3], _Lugar = lista_lugares[2], _MetodoPago = lista_metodospagos[1], _Sucursal = lista_sucursales[2] });



var lista_detallescompras = new List<DetallesCompras>();

lista_detallescompras.Add(new DetallesCompras() {IdDetalles = 1, Cantidad = 2, ValorBruto = 600000, _Compra = lista_compras[0], _Producto = lista_productos[0] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 2, Cantidad = 3, ValorBruto = 1200000, _Compra = lista_compras[1], _Producto = lista_productos[1] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 3, Cantidad = 5, ValorBruto = 2000000, _Compra = lista_compras[2], _Producto = lista_productos[1] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 4, Cantidad = 1, ValorBruto = 500000, _Compra = lista_compras[3], _Producto = lista_productos[2] });

;




public class Clientes
{

    public int IdClientes { get; set; }
    public string? Cedula { get; set; }
    public string? Nombre { get; set; }
    public string? Telefono { get; set; }

    public List<Compras> Compras { get; set; }

    
}

public class Sucursales
{

    public int IdSucursales { get; set; }
    public string? Nombre { get; set;}
    public string? Direccion { get; set; }  

    public List<Compras> Compras { get; set; }

}

public class MetodosPagos
{

    public int IdMetodosPagos { get; set; }
    public string? Nombre { get;set; }
    public Boolean? Estado { get; set; }


    public List<Compras> Compras { get; set; }

}

public class Lugares
{

    public int IdLugares { get; set; }
    public string? Nombre { get; set; }
    public string? CodigoPostal { get; set; }


    public List<Compras> Compras { get; set; }


}

public class Marcas
{

    public int IdMarcas { get; set; }
    public string? Nombre { get; set; }
    public int Nit {  get; set; }


    public List<Productos> Productos { get; set; }

}

public class Productos
{

    public int IdProductos { get; set; }
    public string? Nombre { get; set; }
    public string? Material { get; set; }
    public double ValorUnitario { get; set; }

    //FK
    public int IdMarcas { get; set; }   


    public Marcas? _Marca { get; set; }


    public List<DetallesCompras> DetallesCompras { get; set; }

}

public class Compras
{

    public int IdCompras { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Codigo { get; set; }
    public double ValorTotal { get; set; }

    //FK
    public int IdClientes { get; set; }
    public int IdSucursales { get; set; }
    public int IdMetodosPagos { get; set; }
    public int IdLugares { get; set; }


    public Clientes? _Cliente { get; set; }
    public Sucursales? _Sucursal { get; set; }
    public MetodosPagos? _MetodoPago { get; set; }
    public Lugares? _Lugar { get; set; }


    public List<DetallesCompras> DetallesCompras { get; set; }

}

public class DetallesCompras
{
    public int IdDetalles { get; set; }
    public int Cantidad { get; set; }
    public double ValorBruto { get; set; }

    //FK
    public int IdCompras { get; set; }
    public int IdProductos { get; set; }


    public Compras? _Compra { get; set; }
    public Productos? _Producto { get; set; }

}
