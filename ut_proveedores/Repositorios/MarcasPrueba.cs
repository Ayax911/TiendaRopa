﻿
using lib_dominio.Entidades;
using lib_repositorios.Implementaciones;
using lib_repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;
using ut_marcas.Nucleo;

namespace ut_marcas.Repositorios
{
    [TestClass]
    public class MarcasPrueba
    {
        private readonly IConexion? iConexion;
        private List<Marcas>? lista;
        private Marcas? entidad;
        public MarcasPrueba()
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
            this.lista = this.iConexion!.Marcas!.ToList();
            return lista.Count > 0;
        }
        public bool Guardar()
        {
            this.entidad = EntidadesNucleo.Marcas();
            this.iConexion!.Marcas!.Add(this.entidad);
            this.iConexion!.SaveChanges();
            return true;
        }
        public bool Modificar()
        {
            this.entidad!.Nit = "33333";


            var entry = this.iConexion!.Entry<Marcas>(this.entidad);
            entry.State = EntityState.Modified;
            this.iConexion!.SaveChanges();
            return true;
        }
        public bool Borrar()
        {
            this.iConexion!.Marcas!.Remove(this.entidad!);
            this.iConexion!.SaveChanges();
            return true;
        }
    }

}
