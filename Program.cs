using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bustillos
{
   
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        //public static class Globales
        // {
       // public static List<string> DeskCustomer = new List<string>();
        public static List<string> Laminate = new List<string>();
        public static List<string> Oak = new List<string>();
        public static List<string> Rosewood = new List<string>();
        public static List<string> Venner = new List<string>();
        public static List<string> Pine = new List<string>();




        // }

        [STAThread]

       
        static void Main()
        {
               
        Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainMenu());
          
        }
        
    }
}
