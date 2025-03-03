// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");



var lista_clientes = new List <Clientes>();

lista_clientes.Add (new Clientes() { IdCliente = 1, Nombre = "Carlos", Apellido = "Romero", Telefono = "3157894562" });
lista_clientes.Add(new Clientes() { IdCliente = 2, Nombre = "Marco", Apellido = "Polo", Telefono = "3164568582" });
lista_clientes.Add(new Clientes() { IdCliente = 3, Nombre = "Alan", Apellido = "Turing", Telefono = "3125469887" });
lista_clientes.Add(new Clientes() { IdCliente = 4, Nombre = "Ada", Apellido = "Lovelace", Telefono = "3225648213" });
lista_clientes.Add(new Clientes() { IdCliente = 5, Nombre = "Grace", Apellido = "Hopper", Telefono = "3124567898" });
lista_clientes.Add(new Clientes() { IdCliente = 6, Nombre = "Dorothy", Apellido = "Sayers", Telefono = "3124587951" });


var lista_sucursales = new List<Sucursales>();

lista_sucursales.Add(new Sucursales() { IdSucursales = 1, Nombre = "A1"});
lista_sucursales.Add(new Sucursales() { IdSucursales = 2, Nombre = "A2" });
lista_sucursales.Add(new Sucursales() { IdSucursales = 3, Nombre = "A3" });
lista_sucursales.Add(new Sucursales() { IdSucursales = 4, Nombre = "A4" });


var lista_metodospagos = new List<MetodosPagos>();

lista_metodospagos.Add(new MetodosPagos() { IdMetodoPago = 1, Nombre = "Credito"});
lista_metodospagos.Add(new MetodosPagos() { IdMetodoPago = 2, Nombre = "Credito" });
lista_metodospagos.Add(new MetodosPagos() { IdMetodoPago = 3, Nombre = "Credito" });


var lista_lugares = new List<Lugares>();

lista_lugares.Add(new Lugares() { IdLugar = 1, Nombre = "San Antonio" });
lista_lugares.Add(new Lugares() { IdLugar = 2, Nombre = "Poblado" });
lista_lugares.Add(new Lugares() { IdLugar = 3, Nombre = "Las Americas" });


var lista_marcas = new List<Marcas>();

lista_marcas.Add(new Marcas() { IdMarca = 1, Nombre = "Arturo Calle" });
lista_marcas.Add(new Marcas() { IdMarca = 2, Nombre = "Patprimo" });
lista_marcas.Add(new Marcas() { IdMarca = 3, Nombre = "Estudio F" });
lista_marcas.Add(new Marcas() { IdMarca = 4, Nombre = "Seven seven" });


var lista_productos = new List<Productos>();

lista_productos.Add(new Productos() { IdProducto = 1, Nombre = "Blazer", Material = "Algodón", ValorUnitario = 300000, _Marca = lista_marcas[0] });
lista_productos.Add(new Productos() { IdProducto = 2, Nombre = "Camisa", Material = "Seda", ValorUnitario = 400000, _Marca = lista_marcas[1] });
lista_productos.Add(new Productos() { IdProducto = 3, Nombre = "Polo", Material = "Poliester", ValorUnitario = 100000, _Marca = lista_marcas[1] });
lista_productos.Add(new Productos() { IdProducto = 4, Nombre = "Blusa", Material = "Algodón", ValorUnitario = 500000, _Marca = lista_marcas[2] });
lista_productos.Add(new Productos() { IdProducto = 5, Nombre = "Chaleco", Material = "Algodón", ValorUnitario = 200000, _Marca = lista_marcas[2] });
lista_productos.Add(new Productos() { IdProducto = 6, Nombre = "Cardigan", Material = "Poliester", ValorUnitario = 150000, _Marca = lista_marcas[3] });


var lista_compras = new List<Compras>();

lista_compras.Add(new Compras() { IdCompras = 1, Codigo = "A001", Fecha = new DateTime( 2025, 2, 1), ValorTotal = 600000, _Cliente = lista_clientes[0], _Lugar = lista_lugares[0], _MetodoPago = lista_metodospagos[1], _Sucursal = lista_sucursales[0] });
lista_compras.Add(new Compras() { IdCompras = 2, Codigo = "B001", Fecha = new DateTime( 2025, 1, 25), ValorTotal = 1300000, _Cliente = lista_clientes[1], _Lugar = lista_lugares[1], _MetodoPago = lista_metodospagos[0], _Sucursal = lista_sucursales[1] });
lista_compras.Add(new Compras() { IdCompras = 3, Codigo = "C003", Fecha = new DateTime( 2025, 1, 19), ValorTotal = 2000000, _Cliente = lista_clientes[2], _Lugar = lista_lugares[0], _MetodoPago = lista_metodospagos[2], _Sucursal = lista_sucursales[0] });
lista_compras.Add(new Compras() { IdCompras = 4, Codigo = "D004", Fecha = new DateTime( 2025, 2, 1), ValorTotal = 1300000, _Cliente = lista_clientes[3], _Lugar = lista_lugares[2], _MetodoPago = lista_metodospagos[1], _Sucursal = lista_sucursales[2] });
lista_compras.Add(new Compras() { IdCompras = 5, Codigo = "Z001", Fecha = new DateTime( 2025, 1, 5), ValorTotal = 450000, _Cliente = lista_clientes[4], _Lugar = lista_lugares[1], _MetodoPago = lista_metodospagos[2], _Sucursal = lista_sucursales[1] });
lista_compras.Add(new Compras() { IdCompras = 6, Codigo = "Y002", Fecha = new DateTime( 2025, 5, 1), ValorTotal = 300000, _Cliente = lista_clientes[5], _Lugar = lista_lugares[1], _MetodoPago = lista_metodospagos[2], _Sucursal = lista_sucursales[3] });


var lista_detallescompras = new List<DetallesCompras>();

lista_detallescompras.Add(new DetallesCompras() {IdDetalles = 1, Cantidad = 2, ValorBruto = 600000, _Compra = lista_compras[0], _Producto = lista_productos[0] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 2, Cantidad = 3, ValorBruto = 1200000, _Compra = lista_compras[1], _Producto = lista_productos[1] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 3, Cantidad = 1, ValorBruto = 100000, _Compra = lista_compras[1], _Producto = lista_productos[2] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 4, Cantidad = 5, ValorBruto = 2000000, _Compra = lista_compras[2], _Producto = lista_productos[1] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 5, Cantidad = 1, ValorBruto = 500000, _Compra = lista_compras[3], _Producto = lista_productos[3] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 6, Cantidad = 4, ValorBruto = 800000, _Compra = lista_compras[3], _Producto = lista_productos[4] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 7, Cantidad = 3, ValorBruto = 450000, _Compra = lista_compras[4], _Producto = lista_productos[5] });
lista_detallescompras.Add(new DetallesCompras() { IdDetalles = 8, Cantidad = 1, ValorBruto = 300000, _Compra = lista_compras[5], _Producto = lista_productos[0] });




public class Clientes
{

    public int IdCliente { get; set; }
    public string? Nombre { get; set; }
    public string? Apellido { get; set; }
    public string? Telefono { get; set; }

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

    public int IdMetodoPago { get; set; }
    public string? Nombre { get;set; }


    public List<Compras> Compras { get; set; }

}

public class Lugares
{

    public int IdLugar { get; set; }
    public string Nombre { get; set; }


    public List<Compras> Compras { get; set; }


}

public class Marcas
{

    public int IdMarca { get; set; }
    public string Nombre { get; set; }


    public List<Productos> Productos { get; set; }

}

public class Productos
{

    public int IdProducto { get; set; }
    public string? Nombre { get; set; }
    public string? Material { get; set; }
    public double ValorUnitario { get; set; }


    public Marcas? _Marca { get; set; }


    public List<DetallesCompras> DetallesCompras { get; set; }

}

public class Compras
{

    public int IdCompras { get; set; }
    public DateTime? Fecha { get; set; }
    public string? Codigo { get; set; }
    public double ValorTotal { get; set; }


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


    public Compras? _Compra { get; set; }
    public Productos? _Producto { get; set; }

}
