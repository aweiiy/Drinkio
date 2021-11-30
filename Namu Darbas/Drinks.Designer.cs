
namespace Namu_Darbas
{
    partial class Drinks
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
            this.button1 = new System.Windows.Forms.Button();
            this.categoriesList = new System.Windows.Forms.ListView();
            this.Drink = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.drinksList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.drinkDATA = new System.Windows.Forms.ListView();
            this.drinkPhoto = new System.Windows.Forms.PictureBox();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ingred = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader19 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader20 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader21 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader22 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader23 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader24 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // categoriesList
            // 
            this.categoriesList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Drink});
            this.categoriesList.HideSelection = false;
            this.categoriesList.Location = new System.Drawing.Point(12, 12);
            this.categoriesList.Name = "categoriesList";
            this.categoriesList.Size = new System.Drawing.Size(183, 203);
            this.categoriesList.TabIndex = 2;
            this.categoriesList.UseCompatibleStateImageBehavior = false;
            this.categoriesList.View = System.Windows.Forms.View.Details;
            this.categoriesList.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Drink
            // 
            this.Drink.Text = "Category";
            this.Drink.Width = 110;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(44, 453);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // drinksList
            // 
            this.drinksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.drinksList.HideSelection = false;
            this.drinksList.Location = new System.Drawing.Point(226, 12);
            this.drinksList.Name = "drinksList";
            this.drinksList.Size = new System.Drawing.Size(183, 203);
            this.drinksList.TabIndex = 4;
            this.drinksList.UseCompatibleStateImageBehavior = false;
            this.drinksList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink";
            this.columnHeader1.Width = 110;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(226, 220);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Select Drink";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // drinkDATA
            // 
            this.drinkDATA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.drinkDATA.HideSelection = false;
            this.drinkDATA.Location = new System.Drawing.Point(12, 262);
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(397, 114);
            this.drinkDATA.TabIndex = 6;
            this.drinkDATA.TileSize = new System.Drawing.Size(300, 200);
            this.drinkDATA.UseCompatibleStateImageBehavior = false;
            this.drinkDATA.View = System.Windows.Forms.View.Tile;
            // 
            // drinkPhoto
            // 
            this.drinkPhoto.Location = new System.Drawing.Point(445, 135);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(360, 306);
            this.drinkPhoto.TabIndex = 7;
            this.drinkPhoto.TabStop = false;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Width = 334;
            // 
            // ingred
            // 
            this.ingred.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader16,
            this.columnHeader17,
            this.columnHeader18,
            this.columnHeader19,
            this.columnHeader20,
            this.columnHeader21,
            this.columnHeader22,
            this.columnHeader23,
            this.columnHeader24});
            this.ingred.HideSelection = false;
            this.ingred.Location = new System.Drawing.Point(445, 12);
            this.ingred.Name = "ingred";
            this.ingred.Size = new System.Drawing.Size(360, 102);
            this.ingred.TabIndex = 15;
            this.ingred.UseCompatibleStateImageBehavior = false;
            this.ingred.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "";
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "";
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "";
            // 
            // columnHeader19
            // 
            this.columnHeader19.Text = "";
            // 
            // columnHeader20
            // 
            this.columnHeader20.Text = "";
            // 
            // columnHeader21
            // 
            this.columnHeader21.Text = "";
            // 
            // columnHeader22
            // 
            this.columnHeader22.Text = "";
            // 
            // columnHeader23
            // 
            this.columnHeader23.Text = "";
            // 
            // columnHeader24
            // 
            this.columnHeader24.Text = "";
            // 
            // Drinks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 490);
            this.Controls.Add(this.ingred);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.drinksList);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.categoriesList);
            this.Controls.Add(this.button1);
            this.Name = "Drinks";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Categories list";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Drinks_FormClosing);
            this.Load += new System.EventHandler(this.Drinks_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView categoriesList;
        private System.Windows.Forms.ColumnHeader Drink;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ListView drinksList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView drinkDATA;
        private System.Windows.Forms.PictureBox drinkPhoto;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ListView ingred;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        private System.Windows.Forms.ColumnHeader columnHeader18;
        private System.Windows.Forms.ColumnHeader columnHeader19;
        private System.Windows.Forms.ColumnHeader columnHeader20;
        private System.Windows.Forms.ColumnHeader columnHeader21;
        private System.Windows.Forms.ColumnHeader columnHeader22;
        private System.Windows.Forms.ColumnHeader columnHeader23;
        private System.Windows.Forms.ColumnHeader columnHeader24;
    }
}