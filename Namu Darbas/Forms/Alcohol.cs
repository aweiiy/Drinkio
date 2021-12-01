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
    public partial class Alcohol : Form
    {
        public Alcohol()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.Alcohol_FormClosed);
        }

        private void Alcohol_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }


        private void Alcohol_Load(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            IList<Models.AlcoholModel> results = provider.GetAlcohol();

            if (results != null)
            {
                foreach (var i in results)
                {
                    var item = new ListViewItem(new[] { i.strAlcoholic });
                    alcoholList.Items.Add(item);
                }
            }
            else MessageBox.Show("No Meals with specified letter found!");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            (new MainMenu()).Show(); this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (alcoholList.SelectedItems.Count > 0 && drinksList.SelectedItems[0].Text != null)
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
                        //------
                        drinkName.Text = i.strDrink;
                    }

                }
                else MessageBox.Show("No drinks with specified category found!");

            }
            else MessageBox.Show("Select the type first");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (alcoholList.SelectedItems.Count > 0)
            {
                var SelectedItem = alcoholList.SelectedItems[0].Text;
                var provider = new DataProvider();

                var results = provider.GetDrinkByAlcohol(SelectedItem.ToString());
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
            else MessageBox.Show("Nothing selected!");
        }

        private void drinkName_Click(object sender, EventArgs e)
        {

        }
    }
}
