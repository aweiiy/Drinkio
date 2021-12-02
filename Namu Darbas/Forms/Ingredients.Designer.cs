
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
            this.button3 = new System.Windows.Forms.Button();
            this.drinkName = new System.Windows.Forms.Label();
            this.IngredList = new System.Windows.Forms.TextBox();
            this.drinkDATA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // ingredientsList
            // 
            this.ingredientsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Ingredient});
            this.ingredientsList.HideSelection = false;
            this.ingredientsList.Location = new System.Drawing.Point(18, 18);
            this.ingredientsList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ingredientsList.Name = "ingredientsList";
            this.ingredientsList.Size = new System.Drawing.Size(232, 318);
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
            this.button1.Location = new System.Drawing.Point(18, 348);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(18, 638);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 35);
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
            this.drinksList.Location = new System.Drawing.Point(288, 18);
            this.drinksList.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinksList.Name = "drinksList";
            this.drinksList.Size = new System.Drawing.Size(268, 318);
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
            this.drinkPhoto.Location = new System.Drawing.Point(610, 203);
            this.drinkPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(540, 471);
            this.drinkPhoto.TabIndex = 12;
            this.drinkPhoto.TabStop = false;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(288, 348);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 10;
            this.button3.Text = "Select drink";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // drinkName
            // 
            this.drinkName.AutoSize = true;
            this.drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkName.Location = new System.Drawing.Point(234, 423);
            this.drinkName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(0, 29);
            this.drinkName.TabIndex = 18;
            // 
            // IngredList
            // 
            this.IngredList.Location = new System.Drawing.Point(610, 18);
            this.IngredList.Multiline = true;
            this.IngredList.Name = "IngredList";
            this.IngredList.Size = new System.Drawing.Size(540, 155);
            this.IngredList.TabIndex = 27;
            this.IngredList.Text = "Ingredients:\r\n";
            // 
            // drinkDATA
            // 
            this.drinkDATA.Location = new System.Drawing.Point(18, 455);
            this.drinkDATA.Multiline = true;
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(564, 155);
            this.drinkDATA.TabIndex = 26;
            // 
            // Ingredients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 692);
            this.Controls.Add(this.IngredList);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.drinksList);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ingredientsList);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Ingredients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ingredients list";
            this.Load += new System.EventHandler(this.Ingredients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView ingredientsList;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ColumnHeader Ingredient;
        private System.Windows.Forms.ListView drinksList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.PictureBox drinkPhoto;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label drinkName;
        private System.Windows.Forms.TextBox IngredList;
        private System.Windows.Forms.TextBox drinkDATA;
    }
}