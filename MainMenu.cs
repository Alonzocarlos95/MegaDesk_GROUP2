using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Newtonsoft.Json;

namespace MegaDesk_Bustillos
{
    public partial class MainMenu : Form
    {
        public string myJson;
        public MainMenu()
        {
            InitializeComponent();
           
        }
        
        private void MainMenu_Load(object sender, EventArgs e)
        {
            string path = @"rushOrderPrices.txt";
            if (!File.Exists(path))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("60");
                    sw.WriteLine("70");
                    sw.WriteLine("80");
                    sw.WriteLine("40");
                    sw.WriteLine("50");
                    sw.WriteLine("60");
                    sw.WriteLine("30");
                    sw.WriteLine("35");
                    sw.WriteLine("40");

                }
            }

            // Json
           
            //var CopyList = Program.AllQuotes;

            //var list = JsonConvert.DeserializeObject<List<object>>();
            //list.Add(CopyList);

            string JsPath = @"quotes.json";
            if (!File.Exists(JsPath))
            {
                // Create a file to write to.
                using (StreamWriter sw = File.CreateText(JsPath))
                {
                    

                }
            }

        }

        // DISABLE X BUTTON
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }

        private void ANQbtn_Click(object sender, EventArgs e)
        {
            AddQuote AQFORM = new AddQuote();
            AQFORM.Show();
            this.Hide();
        }

        private void VQbtn_Click(object sender, EventArgs e)
        {
            ViewAllQuotes VAQFORM = new ViewAllQuotes();
            VAQFORM.Show();
            this.Hide();
        }

        private void SQbtn_Click(object sender, EventArgs e)
        {
            
            SearchQuotes SQFrm = new SearchQuotes();
            SQFrm.Show();
            this.Hide();
        }
        
        private void Exitbtn_Click(object sender, EventArgs e)
        {
            Application.Exit();
           
        }
    }
}
