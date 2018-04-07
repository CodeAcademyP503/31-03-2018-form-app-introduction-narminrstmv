using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cinemass
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            foreach (Button item in Form2.ReservedSeats)
            {
                selectedseats.Text += item.Text + " ,";
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var result = "Siz " + selectedseats.Text + " REZERV ETDİNİZ"+"     " +"Məbləğ" + Form2.ReservedSeats.Count * 7 + "AZN";
          label2.Text += result;
        }
    }
}
