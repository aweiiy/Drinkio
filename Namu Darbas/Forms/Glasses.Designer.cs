
namespace Namu_Darbas
{
    partial class Glasses
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
            this.glassList = new System.Windows.Forms.ListView();
            this.Glass = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.drinkPhoto = new System.Windows.Forms.PictureBox();
            this.drinksList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.drinkName = new System.Windows.Forms.Label();
            this.IngredList = new System.Windows.Forms.TextBox();
            this.drinkDATA = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // glassList
            // 
            this.glassList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Glass});
            this.glassList.HideSelection = false;
            this.glassList.Location = new System.Drawing.Point(12, 12);
            this.glassList.Name = "glassList";
            this.glassList.Size = new System.Drawing.Size(160, 208);
            this.glassList.TabIndex = 0;
            this.glassList.UseCompatibleStateImageBehavior = false;
            this.glassList.View = System.Windows.Forms.View.Details;
            this.glassList.SelectedIndexChanged += new System.EventHandler(this.glassView_SelectedIndexChanged);
            // 
            // Glass
            // 
            this.Glass.Text = "Glass";
            this.Glass.Width = 127;
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
            this.button2.Location = new System.Drawing.Point(12, 415);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Back";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(189, 226);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Select drink";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // drinkPhoto
            // 
            this.drinkPhoto.Location = new System.Drawing.Point(404, 132);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(360, 306);
            this.drinkPhoto.TabIndex = 8;
            this.drinkPhoto.TabStop = false;
            this.drinkPhoto.Click += new System.EventHandler(this.drinkPhoto_Click);
            // 
            // drinksList
            // 
            this.drinksList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.drinksList.HideSelection = false;
            this.drinksList.Location = new System.Drawing.Point(189, 12);
            this.drinksList.Name = "drinksList";
            this.drinksList.Size = new System.Drawing.Size(183, 208);
            this.drinksList.TabIndex = 9;
            this.drinksList.UseCompatibleStateImageBehavior = false;
            this.drinksList.View = System.Windows.Forms.View.Details;
            this.drinksList.SelectedIndexChanged += new System.EventHandler(this.drinksList_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Drink";
            this.columnHeader1.Width = 110;
            // 
            // drinkName
            // 
            this.drinkName.AutoSize = true;
            this.drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkName.Location = new System.Drawing.Point(12, 274);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(0, 20);
            this.drinkName.TabIndex = 18;
            // 
            // IngredList
            // 
            this.IngredList.Location = new System.Drawing.Point(404, 12);
            this.IngredList.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.IngredList.Multiline = true;
            this.IngredList.Name = "IngredList";
            this.IngredList.Size = new System.Drawing.Size(361, 102);
            this.IngredList.TabIndex = 29;
            this.IngredList.Text = "Ingredients:\r\n";
            // 
            // drinkDATA
            // 
            this.drinkDATA.Location = new System.Drawing.Point(9, 296);
            this.drinkDATA.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.drinkDATA.Multiline = true;
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(377, 102);
            this.drinkDATA.TabIndex = 28;
            // 
            // Glasses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IngredList);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.drinksList);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.glassList);
            this.Name = "Glasses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Glass list";
            this.Load += new System.EventHandler(this.Glasses_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView glassList;
        private System.Windows.Forms.ColumnHeader Glass;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox drinkPhoto;
        private System.Windows.Forms.ListView drinksList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Label drinkName;
        private System.Windows.Forms.TextBox IngredList;
        private System.Windows.Forms.TextBox drinkDATA;
    }
}