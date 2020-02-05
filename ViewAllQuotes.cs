using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MegaDesk_Bustillos
{
    
    public partial class ViewAllQuotes : Form
    {
        public int area;
        public int drawers;
        public int contador = 0;
        
        public ViewAllQuotes()
        {
            InitializeComponent();
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

        private void ViewAllQuotes_Load(object sender, EventArgs e)
        {
            DataTable TableQuotes = new DataTable();
            TableQuotes.Columns.Add("Name", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Width", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Depth", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Material", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Drawers", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Order Time", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Price", Type.GetType("System.String"));

                // Enter n rows
                for (int j =0; j < Program.cont; j++)
                {
                    
                    TableQuotes.Rows.Add(new Object[] {Program.AllQuotes[contador],

                     Program.AllQuotes[contador+1], Program.AllQuotes[contador+2], Program.AllQuotes[contador+3],
                     Program.AllQuotes[contador+4], Program.AllQuotes[contador+5], 
                     Program.AllQuotes[contador+6]});

                contador += 7;
                    
                }
                      
            gridViewQuotes.DataSource = TableQuotes;

           








        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            SearchQuotes MenuFrm = new SearchQuotes();
            MenuFrm.Show();
            this.Hide();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
