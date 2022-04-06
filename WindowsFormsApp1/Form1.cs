using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void populateCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            carComp1.vin.Text = "0119";
            carComp1.cost.Text = "$300";
            carComp1.pictureBox1.Load(@"C:\Users\PC\Pictures\Cars\c1.jpg");
            carComp2.vin.Text = "0120";
            carComp2.cost.Text = "$6000";
            carComp2.pictureBox1.Load(@"C:\Users\PC\Pictures\Cars\c2.jpg");
        }

        private void addExtraCarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CarComp carCompx = new CarComp();
            carCompx.vin.Text = "0121";
            carCompx.cost.Text = "$32342";
            carCompx.pictureBox1.Load(@"C:\Users\PC\Pictures\Cars\c3.jpg");

            this.Controls.Add(carCompx);
            Globals.carComps.Add(carCompx);

            carCompx.Location = new Point(32, 283);
        }

        private void clearAllCarsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (CarComp theCar in Globals.carComps)
            {
                theCar.vin.Text = "---";
                theCar.cost.Text = "----";
                theCar.Hide();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Globals.carComps.Add(carComp1);
            Globals.carComps.Add(carComp2);
        }
    }
}
