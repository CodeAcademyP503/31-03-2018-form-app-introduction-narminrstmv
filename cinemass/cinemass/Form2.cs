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
    public partial class Form2 : Form
    {
        public int rowcount = 5;
        public int columncount = 7;
        public int leftpost = 0;
        public int toppost = 0;
        public int seatnumber = 1;
        public TextBox Result=new TextBox();
        public Button reservbtn=new Button();
        public static List<Button> ReservedSeats = new List<Button>();
        public Form2()
        {
           
            InitializeComponent();
         ;
            for (int row = 0; row < rowcount; row++)
            {
                for (int column = 0; column < columncount; column++)
                {
                    var seat = new Button();
                    seat.BackgroundImage = global::cinemass.Properties.Resources.button;
                    seat.BackgroundImageLayout = ImageLayout.Stretch;
                    seat.FlatStyle = FlatStyle.Flat;
                    seat.FlatAppearance.BorderSize = 0;
                    seat.Width = 50;
                    seat.Height = 50;
                 
                    seat.Left = leftpost;
                    seat.Top = toppost;
                    seat.Text = seatnumber.ToString();
                    seatnumber++;
                    Controls.Add(seat);
                    seat.Click += new EventHandler(selectseat);
                    leftpost += 50;
                }
                leftpost = 0;
                toppost += 50;
            }
            this.Width = columncount * 50 + 17;
            this.Height = rowcount * 50 + 100;
         
            reservbtn.Text = "Rezerv et";
            reservbtn.AutoSize = true;
            reservbtn.Click += new EventHandler(ReserveSeats);
            Controls.Add(reservbtn);
         
            //Controls.Add(Result);
            //Result.Width = 100;
            reservbtn.Top = this.Height - Result.Height - 50;
            reservbtn.Left = this.Width - Result.Width - 200;
           //Result.Top = this.Height - Result.Height-50;
           // Result.Left = this.Width - Result.Width - 50;
        }
          public void selectseat(object obj , EventArgs e)
        {
            var btn = obj as Button;
            btn.BackColor = Color.Green;
            //Result.Text += btn.Text+",";
            ReservedSeats.Add(btn);
        }
        public void ReserveSeats(object obj, EventArgs e)
        {
            foreach (Button item in ReservedSeats)
            {
                item.Enabled = false;

            }
            var checkOutForm = new Form3();
            checkOutForm.Show();

        }
    }

}
