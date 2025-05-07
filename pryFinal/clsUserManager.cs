using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Windows.Forms;



namespace pryFinal
{
    public class clsUserManager
    {
        private static string rutaArchivo = Path.Combine(Application.StartupPath, "usuarios.json");


        public static List<clsUser> CargarUsuarios()
        {
            if (!File.Exists(rutaArchivo))
                return new List<clsUser>();

            string json = File.ReadAllText(rutaArchivo);
            return JsonConvert.DeserializeObject<List<clsUser>>(json);
        }

        public static void GuardarUsuarios(List<clsUser> usuarios)
        {

            string json = JsonConvert.SerializeObject(usuarios, Newtonsoft.Json.Formatting.Indented);
            File.WriteAllText(rutaArchivo, json);
        }
    }
}
