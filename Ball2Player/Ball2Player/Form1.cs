using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball2Player
{
    public partial class FRMMain : Form
    {
        public FRMMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void FRMMain_Load(object sender, EventArgs e)
        {
            TXTX.Text = PXBBall.Location.X.ToString();
            TXTY.Text = PXBBall.Location.Y.ToString();
        }

        private void BTNPlayer2_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int p = r.Next(1, 201);
            int a = PXBBall.Location.X + p;
            int b = PXBBall.Location.Y;
            PXBBall.Location = new Point(a, b);
            LBLCount.Text = (a - int.Parse(TXTX.Text)).ToString();
            TXTX.Text = a.ToString();
            if (int.Parse(TXTX.Text) >= 1920)
            {
                MessageBox.Show("بازیکن دوم برنده شد", "اتمام بازی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void BTNPlayer1_Click(object sender, EventArgs e)
        {
            Random r = new Random();
            int p = r.Next(1, 201);
            int a = PXBBall.Location.X - p;
            int b = PXBBall.Location.Y;
            PXBBall.Location = new Point(a, b);
            LBLCount.Text = (a - int.Parse(TXTX.Text)).ToString();
            TXTX.Text = a.ToString();
            if (int.Parse(TXTX.Text) <= 0)
            {
                MessageBox.Show("بازیکن اول برنده شد", "اتمام بازی", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}
