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
        public static List<string> AllQuotes = new List<String>();

        public static int area = 7;
        public static int drawers = 9;
        public static int cont = 0;
        public static int i = 0;
        public static int flag = 0;
        public static int laminateFlag = 0;
        public static int oakFlag = 0;
        public static int rosewoodFlag = 0;
        public static int vennerFlag = 0;
        public static int pineFlag = 0;




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
