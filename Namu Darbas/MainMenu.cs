using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Namu_Darbas
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
        }

        private void MainMenu_FormClosed(object sender, FormClosedEventArgs e)
        {
            //(new Form1()).Show();
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new Drinks()).Show(); this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            (new Alcohol()).Show(); this.Hide();
        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new Glasses()).Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            (new Ingredients()).Show(); this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            (new Random()).Show(); this.Hide();
        }
    }
}
