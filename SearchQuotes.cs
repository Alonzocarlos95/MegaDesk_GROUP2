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
    public partial class SearchQuotes : Form
    {
        public int area, drawers;
        public int contador = 0;
        public SearchQuotes()
        {
            InitializeComponent();
            
            
            List<DesktopMaterial> MaterialList = new List<DesktopMaterial>().ToList();
            //Adding to List
            foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
                MaterialList.Add(item);

            comboBox1.DataSource = MaterialList;  // Add the List to Desk Surface Material Box

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
        private void SearchQuotes_Load(object sender, EventArgs e)
        {
            AddQuote Test = new AddQuote();

            Test.comboBox1.Text = "";
            /*DataTable TableQuotes = new DataTable();
            TableQuotes.Columns.Add("Name", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Width", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Depth", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Material", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Drawers", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Order Time", Type.GetType("System.String"));
            TableQuotes.Columns.Add("Price", Type.GetType("System.String"));
            
            DisplayQuote Search = new DisplayQuote();
            Search.gridViewList.DataSource = TableQuotes;
            
            switch (comboBox1.Text)
            {
                case "Laminate":
                    Search.titleSearch.Text = "LAMINATE";


                    // Enter n rows
                    for (int j = 0; j < contador + 1; j++)
                    {

                        TableQuotes.Rows.Add(new Object[] {Program.Laminate[contador],

                     Program.Laminate[contador+1], Program.Laminate[contador+2], Program.Laminate[contador+3],
                     Program.Laminate[contador+4], Program.Laminate[contador+5],
                     Program.Laminate[contador+6]});



                    }


                    break;
                case "Oak":
                    Search.titleSearch.Text = "OAK";
                    // Enter n rows
                    for (int j = 0; j < contador + 1; j++)
                    {

                        TableQuotes.Rows.Add(new Object[] {Program.Oak[contador],

                     Program.Oak[contador+1], Program.Oak[contador+2], Program.Oak[contador+3],
                     Program.Oak[contador+4], Program.Oak[contador+5],
                     Program.Oak[contador+6]});



                    }


                    break;
                case "Rosewood":
                    Search.titleSearch.Text = "ROSEWOOD";
                    // Enter n rows
                    for (int j = 0; j < contador + 1; j++)
                    {

                        TableQuotes.Rows.Add(new Object[] {Program.Rosewood[contador],

                     Program.Rosewood[contador+1], Program.Rosewood[contador+2], Program.Rosewood[contador+3],
                     Program.Rosewood[contador+4], Program.Rosewood[contador+5],
                     Program.Rosewood[contador+6]});



                    }
                    break;
                case "Venner":
                    Search.titleSearch.Text = "VENNER";
                    // Enter n rows
                    for (int j = 0; j < contador + 1; j++)
                    {

                        TableQuotes.Rows.Add(new Object[] {Program.Venner[contador],

                     Program.Venner[contador+1], Program.Venner[contador+2], Program.Venner[contador+3],
                     Program.Venner[contador+4], Program.Venner[contador+5],
                     Program.Venner[contador+6]});



                    }
                    break;
                case "Pine":
                    Search.titleSearch.Text = "PINE";
                    // Enter n rows
                    for (int j = 0; j < contador + 1; j++)
                    {

                        TableQuotes.Rows.Add(new Object[] {Program.Pine[contador],

                     Program.Pine[contador+1], Program.Pine[contador+2], Program.Pine[contador+3],
                     Program.Pine[contador+4], Program.Pine[contador+5],
                     Program.Pine[contador+6]});



                    }

                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }

            */



        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {


            /*
                // Item selected
                int selectedIndex = comboBox1.SelectedIndex;
                Object selectedItem = comboBox1.SelectedItem;*/

            // Add values

            DataTable TableQuotes1 = new DataTable();
            TableQuotes1.Columns.Add("Date", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Name", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Width", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Depth", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Material", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Drawers", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Order Time", Type.GetType("System.String"));
            TableQuotes1.Columns.Add("Price", Type.GetType("System.String"));
            DisplayQuote Search1 = new DisplayQuote();
           
           
            if (Program.flag != 0)
           {

                switch (comboBox1.Text)
                {
                    case "Laminate":
                        Search1.titleSearch.Text = "LAMINATE";
                        if (Program.laminateFlag != 0)
                        {

                            // Enter n rows

                            TableQuotes1.Rows.Add(new Object[] {Program.Laminate[contador],

                             Program.Laminate[contador+1], Program.Laminate[contador+2], Program.Laminate[contador+3],
                             Program.Laminate[contador+4], Program.Laminate[contador+5],
                             Program.Laminate[contador+6], Program.Laminate[contador + 7]});
                        }


                        

                       
                        break;
                    case "Oak":
                        Search1.titleSearch.Text = "OAK";
                        if (Program.oakFlag != 0)
                        {

                            // Enter n rows
                            TableQuotes1.Rows.Add(new Object[] {Program.Oak[contador],

                            Program.Oak[contador+1], Program.Oak[contador+2], Program.Oak[contador+3],
                            Program.Oak[contador+4], Program.Oak[contador+5],
                            Program.Oak[contador+6], Program.Oak[contador + 7]});

                        }

                        

                        
                        break;
                    case "Rosewood":
                        Search1.titleSearch.Text = "ROSEWOOD";
                        // Enter n rows

                        if (Program.rosewoodFlag != 0)
                        {
                            TableQuotes1.Rows.Add(new Object[] {Program.Rosewood[contador],

                             Program.Rosewood[contador+1], Program.Rosewood[contador+2], Program.Rosewood[contador+3],
                             Program.Rosewood[contador+4], Program.Rosewood[contador+5],
                             Program.Rosewood[contador+6], Program.Rosewood[contador + 7]});


                        }
                        
                        
                        break;
                    case "Venner":
                        Search1.titleSearch.Text = "VENNER";
                        // Enter n rows
                        if (Program.vennerFlag != 0)
                        {
                            TableQuotes1.Rows.Add(new Object[] {Program.Venner[contador],

                             Program.Venner[contador+1], Program.Venner[contador+2], Program.Venner[contador+3],
                             Program.Venner[contador+4], Program.Venner[contador+5],
                             Program.Venner[contador+6], Program.Venner[contador + 7]});

                        }

                        
                        
                        break;
                    case "Pine":
                        Search1.titleSearch.Text = "PINE";
                        // Enter n rows

                        if (Program.pineFlag != 0)
                        {
                            TableQuotes1.Rows.Add(new Object[] {Program.Pine[contador],

                            Program.Pine[contador+1], Program.Pine[contador+2], Program.Pine[contador+3],
                            Program.Pine[contador+4], Program.Pine[contador+5],
                            Program.Pine[contador+6], Program.Pine[contador + 7]});


                        }
                        
                        
                        break;
                    default:
                        MessageBox.Show("Error");
                        break;
                } // End switch

            }// End If
            Search1.gridViewList.DataSource = TableQuotes1;
            Search1.gridViewList.Columns[1].Width = 150;
            Search1.Show();
            this.Hide();
        }

       
       
    }
}
