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
    public partial class AddQuote : Form
    {
        public int basePrice = 200;
        public int area;
        public int drawers;
        public int materials;
        public int widthNumber;
        public int depthNumber;
        public int drawersNumber;
        public double results;
        public int orderRush;
        public AddQuote()
        {
            InitializeComponent();
           
            List<DesktopMaterial> MaterialList = new List<DesktopMaterial>().ToList();
            //Adding to List
           foreach (DesktopMaterial item in Enum.GetValues(typeof(DesktopMaterial)))
               MaterialList.Add(item);
               
            comboBox1.DataSource = MaterialList;  // Add the List to Desk Surface Material Box
            
        }

        // Date

        
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

        private void AddQuote_Load(object sender, EventArgs e)
        {
           
        }

        private void ReturnBtn_Click(object sender, EventArgs e)
        {
            MainMenu MenuFrm = new MainMenu();
            MenuFrm.Show();
           
            this.Hide();
        }

        static bool isNumber(string s)
        {
            for (int i = 0; i < s.Length; i++)
                if (char.IsDigit(s[i]) == false)
                    return false;

            return true;
        }
        private void WidthValidate(object sender, CancelEventArgs e)
        {

            int width;
            
            try
            {
                width = Convert.ToInt32(widthInput.Text);
                if (width >= 24 && width <= 96)
                {

                }
                else
                {
                    MessageBox.Show(width + " is not a integer valid, it should be between 24 and 96", "MegaDesk");
                    widthInput.Text = "";
                    widthInput.Focus();
                }
            } catch (Exception)
            {
                MessageBox.Show("Your number is not an integer", "MegaDesk");
                widthInput.Text = "";
                widthInput.Focus();
            }
            
            

            

        }

        private void IsInteger_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
        (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void DepthInput_Validating(object sender, CancelEventArgs e)
        {
            int depth;

            try
            {
                depth = Convert.ToInt32(DepthInput.Text);
                if (depth >= 12 && depth <= 48)
                {

                }
                else
                {
                    MessageBox.Show(depth + " is not a integer valid, it should be between 12 and 48", "MegaDesk");
                    DepthInput.Text = "";
                    DepthInput.Focus();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Your number is not an integer", "MegaDesk");
                DepthInput.Text = "";
                DepthInput.Focus();
            }
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            bool EmptyFields = true;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please insert the name", "MegaDesk");
                textBox1.Focus();
                EmptyFields = false;
            } else if (widthInput.Text == "")
            {
                MessageBox.Show("Please insert the width", "MegaDesk");
                widthInput.Focus();
                EmptyFields = false;
            } else if (DepthInput.Text == "")
            {
                MessageBox.Show("Please insert the depth", "MegaDesk");
                DepthInput.Focus();
                EmptyFields = false;
            } else if (comboBox2.Text == "")
            {
                MessageBox.Show("Please select the number of Drawers", "MegaDesk");
                comboBox2.Focus();
                EmptyFields = false;
            } else if (comboBox1.Text == "")
            {
                MessageBox.Show("Please select the surface Material", "MegaDesk");
                comboBox1.Focus();
                EmptyFields = false;
            } else if (comboBox3.Text == "")
            {
                MessageBox.Show("Please select the processing Time", "MegaDesk");
                comboBox3.Focus();
                EmptyFields = false;
            }

            if (EmptyFields == true)
            {
                // Calculate
                widthNumber = Int32.Parse(widthInput.Text);
                depthNumber = Int32.Parse(DepthInput.Text);
                area = widthNumber * depthNumber; // $1 the price per in2
                drawersNumber = Int32.Parse(comboBox2.Text);
                drawers = drawersNumber * 50;
                if (comboBox1.Text == "Laminate")
                    materials = 100;
                else if (comboBox1.Text == "Oak")
                    materials = 200;
                else if (comboBox1.Text == "Pine")
                    materials = 50;
                else if (comboBox1.Text == "Rosewood")
                    materials = 300;
                else if (comboBox1.Text == "Venner")
                    materials = 125;

                if (comboBox3.Text == "3" && area < 1000)
                    orderRush = 60;
                else if (comboBox3.Text == "5" && area < 1000)
                    orderRush = 40;
                else if (comboBox3.Text == "7" && area < 1000)
                    orderRush = 30;

                if (comboBox3.Text == "3" && (area >= 1000 && area <= 2000))
                    orderRush = 70;
                else if (comboBox3.Text == "5" && (area >= 1000 && area <= 2000))
                    orderRush = 50;
                else if (comboBox3.Text == "7" && (area >= 1000 && area <= 2000))
                    orderRush = 35;

                if (comboBox3.Text == "3" && area > 2000)
                    orderRush = 80;
                else if (comboBox3.Text == "5" && area > 2000)
                    orderRush = 60;
                else if (comboBox3.Text == "7" && area > 2000)
                    orderRush = 40;



                results = basePrice + area + drawers + materials + orderRush;
                switch (comboBox1.Text)
                {
                    case "Laminate":
                        Program.Laminate.Add("Name Customer: " + textBox1.Text);
                        Program.Laminate.Add("Width: " + widthInput.Text);
                        Program.Laminate.Add("Depth: " + DepthInput.Text);
                        Program.Laminate.Add("Drawers: " + comboBox2.Text);
                        Program.Laminate.Add("Order Processing Days: " + comboBox3.Text);
                        Program.Laminate.Add("Price Quote: " + results);
                        break;

                    case "Oak":

                        Program.Oak.Add("Name Customer: " + textBox1.Text);
                        Program.Oak.Add("Width: " + widthInput.Text);
                        Program.Oak.Add("Depth: " + DepthInput.Text);
                        Program.Oak.Add("Drawers: " + comboBox2.Text);
                        Program.Oak.Add("Order Processing Days: " + comboBox3.Text);
                        Program.Oak.Add("Price Quote: " + results);
                        break;
                    case "Rosewood":
                        Program.Rosewood.Add("Name Customer: " + textBox1.Text);
                        Program.Rosewood.Add("Width: " + widthInput.Text);
                        Program.Rosewood.Add("Depth: " + DepthInput.Text);
                        Program.Rosewood.Add("Drawers: " + comboBox2.Text);
                        Program.Rosewood.Add("Order Processing Days: " + comboBox3.Text);
                        Program.Rosewood.Add("Price Quote: " + results);
                        break;
                    case "Venner":
                        Program.Venner.Add("Name Customer: " + textBox1.Text);
                        Program.Venner.Add("Width: " + widthInput.Text);
                        Program.Venner.Add("Depth: " + DepthInput.Text);
                        Program.Venner.Add("Drawers: " + comboBox2.Text);
                        Program.Venner.Add("Order Processing Days: " + comboBox3.Text);
                        Program.Venner.Add("Price Quote: " + results);
                        break;
                    case "Pine":
                        Program.Pine.Add("Name Customer: " + textBox1.Text);
                        Program.Pine.Add("Width: " + widthInput.Text);
                        Program.Pine.Add("Depth: " + DepthInput.Text);
                        Program.Pine.Add("Drawers: " + comboBox2.Text);
                        Program.Pine.Add("Order Processing Days: " + comboBox3.Text);
                        Program.Pine.Add("Price Quote: " + results);
                        break;
                    default:

                        MessageBox.Show("Error");
                        break;
                }
                AddQuote Adding = new AddQuote();
                textBox1.Text = "";
                widthInput.Text = "";
                DepthInput.Text = "";
                comboBox2.Text = "";
                comboBox3.Text = "";
                Adding.Show();
                Adding.Hide();
            }
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
