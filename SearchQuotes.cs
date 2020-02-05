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
                
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
            this.Hide();
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            
            
            // Item selected
            int selectedIndex = comboBox1.SelectedIndex;
            Object selectedItem = comboBox1.SelectedItem;

            // Add values
           
            
            ViewAllQuotes Search = new ViewAllQuotes();
           
            switch (comboBox1.Text)
            {
                case "Laminate":
                    Search.materialTitle.Text = "LAMINATE";
                    foreach (var item in Program.Laminate)
                       Search.CustomerQuotes.Items.Add(item);
                                  
                    break;
                case "Oak":
                    Search.materialTitle.Text = "OAK";
                    foreach (string item in Program.Oak)
                        Search.CustomerQuotes.Items.Add(item);
                    break;
                case "Rosewood":
                    Search.materialTitle.Text = "ROSEWOOD";
                    foreach (string item in Program.Rosewood)
                        Search.CustomerQuotes.Items.Add(item);
                    break;
                case "Venner":
                    Search.materialTitle.Text = "VENNER";
                    foreach (string item in Program.Venner)
                        Search.CustomerQuotes.Items.Add(item);
                    break;
                case "Pine":
                    Search.materialTitle.Text = "PINE";
                    foreach (string item in Program.Pine)
                        Search.CustomerQuotes.Items.Add(item);

                    break;
                default:
                    MessageBox.Show("Error");
                    break;
            }
             Search.Show();
           this.Hide();

        }

       
       
    }
}
