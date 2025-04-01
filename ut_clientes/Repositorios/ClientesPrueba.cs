
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging.Abstractions;
using ut_compras.Nucleo;

namespace ut_compras.Repositorios
{
    [TestClass]
    public class ClientesPrueba
    {
        #region obj cliente prueba
        private Clientes clientePrueba = new Clientes
         {
            //Id = 1,
            Cedula = "1234567890",
            Nombre = "Juan Pérez",
            Telefono = "3001234567",
            Compras = new List<Compras>
            {
                new Compras
                {
                    //Id = 1,
                    Fecha = DateTime.Now,
                    Codigo = "COMPRA001",
                    ValorTotal = 250000,
                    //Cliente = 1,
                    //Sucursal = 1,
                    //MetodoPago = 1,
                    //Lugar = 1
                }
            }
         };
        #endregion
        private readonly IConexion? iConexion;
        private List<Clientes>? lista;
        private Clientes? entidad;
        public ClientesPrueba()
        {
            iConexion = new Conexion();
            iConexion.StringConexion = Configuracion.ObtenerValor("StringConexion");
        }
        [TestMethod]
        public void Ejecutar()
        {
            Assert.AreEqual(true, Guardar());
            Assert.AreEqual(true, Modificar());
            Assert.AreEqual(true, Listar());
            Assert.AreEqual(true, Borrar());
        }
        public bool Listar()
        {
            this.lista = this.iConexion!.Clientes!.ToList();
            return lista.Count > 0;
        }
        public bool Guardar()
        {
            this.entidad = this.clientePrueba;
            this.entidad = EntidadesNucleo.Clientes();
            this.iConexion!.Clientes!.Add(!String.IsNullOrEmpty(this.entidad.ToString()) ? this.entidad : this.clientePrueba);
            this.iConexion!.SaveChanges();
            return true;
        }
        public bool Modificar()
        {
            this.entidad!.Cedula = "11111";
            
            var entry = this.iConexion!.Entry<Clientes>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }
        public bool Borrar()
        {
            this.iConexion!.Clientes!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }

}
