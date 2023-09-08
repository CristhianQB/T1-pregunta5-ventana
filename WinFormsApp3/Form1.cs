using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            int edad = int.Parse(txtb1.Text);

            if (edad <= 17)

            {
                lbl.Text = "Usted es menor de edad";
            }
            else if (edad >= 18 && edad <= 59)
            {
                lbl.Text = "Useted es un adulto";
            }
            else
            {
                lbl.Text = "Usted es un adulto mayor";
            }
        }
    }
}
