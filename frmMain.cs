using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CristianPerilli_IIIG
{
    public partial class frmMain : Form
    {
        //CRISTIAN PERILLI IIIG 
        public frmMain()
        {
            InitializeComponent();

        }
        int ricordo1 = 0;
        int ricordo2 = 0;
        int ricordo3 = 0;

        private void button1_Click(object sender, EventArgs e)
        {
         
            string a1;
            int a2;
            do { 
                a1 = comboBox1.Text;
                a2 = Convert.ToInt32(textBox1.Text);
            } while (a2 < 0 && a1 == "");
                Pizze.Items.Add($"{a1} {a2}");
            
            if (a1 == "Pizza margherita")
            {
                ricordo1 = a2 + ricordo1;
                label4.Text = Convert.ToString(ricordo1);

            } else if (a1 == "Pizza 4 stagioni")
            {
                ricordo2 = a2 + ricordo2;
             
                label8.Text = Convert.ToString(ricordo2);
            }
            else {
                ricordo3 = a2 + ricordo3; 
                label7.Text = Convert.ToString(ricordo3); 
            }


        }
    }
}
