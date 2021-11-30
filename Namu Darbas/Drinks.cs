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
    public partial class Drinks : Form
    {
        public Drinks()
        {
            InitializeComponent();
            this.FormClosed +=
               new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
           // Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (categoriesList.SelectedItems.Count > 0)
            {
                var SelectedItem = categoriesList.SelectedItems[0].Text;
                var provider = new DataProvider();

                var results = provider.GetDrinkByCategory(SelectedItem.ToString());
                drinksList.Items.Clear();
                if (results != null)
                {
                    foreach (var i in results)
                    {
                        var item = new ListViewItem(new[] { i.strDrink });
                        drinksList.Items.Add(item);
                    }
                }
                else MessageBox.Show("No drinks with specified category found!");

            }
            else MessageBox.Show("Please, select category from the list");

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Drinks_Load(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            var results = provider.GetCategories();
            
            if (results != null)
            {
                foreach (var i in results)
                {
                    var item = new ListViewItem(new[] { i.strCategory });
                    categoriesList.Items.Add(item);
                }
            }
            else MessageBox.Show("No categories found!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new MainMenu()).Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (categoriesList.SelectedItems.Count > 0)
            {
                var SelectedItem = drinksList.SelectedItems[0].Text;
                var provider = new DataProvider();

                var results = provider.GetDrinkDATA(SelectedItem.ToString());

                drinkDATA.Items.Clear();
                ingred.Items.Clear();
                if (results != null)
                {
                    foreach (var i in results)
                    {
                        var item = new ListViewItem(new[] { i.strInstructions });
                        drinkDATA.Items.Add(item);
                        //------
                        var ingr = new ListViewItem(new[] { i.strIngredient1, i.strIngredient2, i.strIngredient3, i.strIngredient4, i.strIngredient5, i.strIngredient6, i.strIngredient7, i.strIngredient8, i.strIngredient9, i.strIngredient10, i.strIngredient11, i.strIngredient12, i.strIngredient13, i.strIngredient14, i.strIngredient15 });
                        ingred.Items.Add(ingr);
                        //------
                        drinkPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                        drinkPhoto.ImageLocation = i.strDrinkThumb;

                    }
                    
                }
                else MessageBox.Show("No drinks with specified category found!");

            }
            else MessageBox.Show("Please, select category from the list");
        }

        private void Drinks_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (MessageBox.Show("Ar norite išeiti?", "DrinkData", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
            {
                case DialogResult.Yes:
                    Application.Exit();
                    break;
                case DialogResult.No:
                    break;
            }
        }
    }
}
