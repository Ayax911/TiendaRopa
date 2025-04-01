
using lib_dominio.Nucleo;

namespace ut_compras.Nucleo
{

    public class Configuracion
    {
        private static Dictionary<string, string>? datos = null;

        public static string ObtenerValor(string clave)
        {
            string respuesta = "";
            if (datos == null)
                Cargar();
            respuesta = datos![clave].ToString();
            return respuesta;
        }

        public static void Cargar()
        {
            string ruta_json = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @""+DatosGenerales.ruta_json);
            if (!File.Exists(ruta_json))
                return;
            datos = new Dictionary<string, string>();
            StreamReader jsonStream = File.OpenText(DatosGenerales.ruta_json);
            var json = jsonStream.ReadToEnd();
            datos = JsonConversor.ConvertirAObjeto<Dictionary<string, string>>(json)!;
        }
    }
}
