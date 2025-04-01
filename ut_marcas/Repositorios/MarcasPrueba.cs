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
            lista = iConexion!.Marcas!.ToList();
            return lista.Count > 0;
        }
        public bool Guardar()
        {
            entidad = EntidadesNucleo.Marcas();
            iConexion!.Marcas!.Add(entidad);
            iConexion!.SaveChanges();
            return true;
        }
        public bool Modificar()
        {
            entidad!.Nit = "33333";


            var entry = iConexion!.Entry(entidad);
            entry.State = EntityState.Modified;
            iConexion!.SaveChanges();
            return true;
        }
        public bool Borrar()
        {
            iConexion!.Marcas!.Remove(entidad!);
            iConexion!.SaveChanges();
            return true;
        }
    }

}
