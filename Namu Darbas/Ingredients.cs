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
    public partial class Ingredients : Form
    {
        public Ingredients()
        {
            InitializeComponent();
        }

        private void Ingredients_Load(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            var results = provider.GetIngredients();

            if (results != null)
            {
                foreach (var i in results)
                {
                    var item = new ListViewItem(new[] { i.strIngredient1 });
                    ingredientsList.Items.Add(item);
                }
            }
            else MessageBox.Show("No Meals with specified letter found!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ingredientsList.SelectedItems.Count > 0)
            {
                var SelectedItem = ingredientsList.SelectedItems[0].Text;
                var provider = new DataProvider();

                var results = provider.GetDrinkByIngredients(SelectedItem.ToString());
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

        private void button2_Click(object sender, EventArgs e)
        {
            (new MainMenu()).Show(); this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (ingredientsList.SelectedItems.Count > 0)
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
                        //strDrinkThumb
                    }

                }
                else MessageBox.Show("No drinks with specified category found!");

            }
            else MessageBox.Show("Please, select category from the list");
        }
    }
}
