using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EuroLab.Helpers
{
    public static class Log
    {

        private static string path = Environment.CurrentDirectory; // "";
       

        public static void Add(Exception sLog)
        {
            CreateDirectory();
            string nombre = GetNameFile();
            string cadena = "";
            cadena  = String.Concat( DateTime.Now + " - " + sLog + Environment.NewLine);
            StreamWriter sw = new StreamWriter(path + "/" + nombre, true);
            sw.Write(cadena);
            MessageBox.Show(sLog.Message.ToString(),"Error de Sistema",MessageBoxButtons.OK);
            sw.Close();

        }

        #region HELPER
        private static string GetNameFile()
        {
            string nombre = "";
            nombre =String.Concat(  "log_" , DateTime.Now.Year , "_" , DateTime.Now.Month , "_" + DateTime.Now.Day , ".txt");
            return nombre;
        }

        private static void CreateDirectory()
        {
            try
            {
                if (!Directory.Exists(path))
                    Directory.CreateDirectory(path);
            }
            catch (DirectoryNotFoundException ex)
            {
                throw new Exception(ex.Message);

            }
        }
    }
        #endregion
}
