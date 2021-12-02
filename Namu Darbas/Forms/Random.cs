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
    public partial class Random : Form
    {
        public Random()
        {
            InitializeComponent();
            this.FormClosed +=
            new System.Windows.Forms.FormClosedEventHandler(this.Random_FormClosed);
        }

        private void Random_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Random_Load(object sender, EventArgs e)
        {
            var provider = new DataProvider();
            var results = provider.GetRandom();

            if (results != null)
            {
                foreach (var i in results)
                {
                    var item = new ListViewItem(new[] { i.strInstructions });
                    //drinkDATA.Items.Add(item);
                    drinkDATA.Text = i.strInstructions;
                    //------
                    //var ingr = new ListViewItem(new[] { i.strIngredient1, i.strIngredient2, i.strIngredient3, i.strIngredient4, i.strIngredient5, i.strIngredient6, i.strIngredient7, i.strIngredient8, i.strIngredient9, i.strIngredient10, i.strIngredient11, i.strIngredient12, i.strIngredient13, i.strIngredient14, i.strIngredient15 });
                    //ingred.Items.Add(ingr);
                    string[] ingredients = { i.strIngredient1, i.strIngredient2, i.strIngredient3, i.strIngredient4, i.strIngredient5, i.strIngredient6, i.strIngredient7, i.strIngredient8, i.strIngredient9, i.strIngredient10, i.strIngredient11, i.strIngredient12, i.strIngredient13, i.strIngredient14, i.strIngredient15 };
                    var j = 0;
                    while(ingredients[j] != null)
                    {
                        IngredList.AppendText($"{ingredients[j]}" + Environment.NewLine);
                        j++;
                    };
                    //------
                    drinkPhoto.SizeMode = PictureBoxSizeMode.StretchImage;
                    drinkPhoto.ImageLocation = i.strDrinkThumb;
                    //------
                    drinkName.Text = i.strDrink;
                }
            }
            else MessageBox.Show("Nothing found!");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            (new MainMenu()).Show(); this.Hide();
        }

        private void drinkName_Click(object sender, EventArgs e)
        {

        }

      
    }
}
