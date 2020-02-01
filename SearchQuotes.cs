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
            Search.custom.Text = Program.DeskCustomer[0];
            Search.width.Text = Program.DeskCustomer[1];
            Search.depth.Text = Program.DeskCustomer[2];
            Search.Show();
           this.Hide();

        }

       
       
    }
}
