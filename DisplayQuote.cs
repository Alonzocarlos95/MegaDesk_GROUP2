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
    public partial class DisplayQuote : Form
    {
      
        public DisplayQuote()
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
        //Make a method in order to get the Month name through and int
       
        private void DisplayQuote_Load(object sender, EventArgs e)
        {
            //Get the current date
            DateTime thisDate = DateTime.Today;
            //Obtain the month number
            int month = thisDate.Month;
            // send it to the method in order to obtain the name
//string monthName = getMonthName(month);
            //Display on screen the text
            //label2.Text = "Order Date: " + thisDate.Day + " " + monthName + " " + thisDate.Year;


        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SearchQuotes SearchQuote = new SearchQuotes();
            SearchQuote.Show();
            this.Hide();
        }
    }
}
