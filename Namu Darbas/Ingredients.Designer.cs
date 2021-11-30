
namespace Namu_Darbas
{
    partial class Ingredients
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ingredientsList = new System.Windows.Forms.ListView();
            this.Ingredient = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.drinksList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkPhoto = new System.Windows.Forms.PictureBox();
            this.drinkDATA = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.ingred = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientsList
            // 
            this.ingredientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredient});
            this.ingredientsList.HideSelection = false;
            this.ingredientsList.Location = new System.Drawing.Point(12, 12);
            this.ingredientsList.Name = "ingredientsList";
            this.ingredientsList.Size = new System.Drawing.Size(156, 208);
            this.ingredientsList.TabIndex = 0;
            this.ingredientsList.UseCompatibleStateImageBehavior = false;
            this.ingredientsList.View = System.Windows.Forms.View.Details;
            // 
            // Ingredient
            // 
            this.Ingredient.Text = "Ingredients";
            this.Ingredient.Width = 108;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(37, 399);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drinksList
            // 
            this.drinksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.drinksList.HideSelection = false;
            this.drinksList.Location = new System.Drawing.Point(192, 12);
            this.drinksList.Name = "drinksList";
            this.drinksList.Size = new System.Drawing.Size(180, 208);
            this.drinksList.TabIndex = 13;
            this.drinksList.UseCompatibleStateImageBehavior = false;
            this.drinksList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink";
            this.columnHeader1.Width = 110;
            // 
            // drinkPhoto
            // 
            this.drinkPhoto.Location = new System.Drawing.Point(407, 132);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(360, 306);
            this.drinkPhoto.TabIndex = 12;
            this.drinkPhoto.TabStop = false;
            // 
            // drinkDATA
            // 
            this.drinkDATA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.drinkDATA.HideSelection = false;
            this.drinkDATA.Location = new System.Drawing.Point(12, 272);
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(360, 101);
            this.drinkDATA.TabIndex = 11;
            this.drinkDATA.TileSize = new System.Drawing.Size(300, 200);
            this.drinkDATA.UseCompatibleStateImageBehavior = false;
            this.drinkDATA.View = System.Windows.Forms.View.Tile;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 334;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(192, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Select drink";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // ingred
            // 
            this.ingred.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.ingred.HideSelection = false;
            this.ingred.Location = new System.Drawing.Point(407, 12);
            this.ingred.Name = "ingred";
            this.ingred.Size = new System.Drawing.Size(360, 102);
            this.ingred.TabIndex = 14;
            this.ingred.UseCompatibleStateImageBehavior = false;
            this.ingred.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Ingredients";
            this.columnHeader3.Width = 108;
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ingred);
            this.Controls.Add(this.drinksList);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ingredientsList);
            this.Name = "Ingredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredients list";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView ingredientsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Ingredient;
        private System.Windows.Forms.ListView drinksList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox drinkPhoto;
        private System.Windows.Forms.ListView drinkDATA;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView ingred;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}