
namespace Namu_Darbas
{
    partial class Random
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
            this.drinkName = new System.Windows.Forms.Label();
            this.drinkPhoto = new System.Windows.Forms.PictureBox();
            this.drinkDATA = new System.Windows.Forms.TextBox();
            this.IngredList = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(18, 571);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drinkName
            // 
            this.drinkName.AutoSize = true;
            this.drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkName.Location = new System.Drawing.Point(626, 51);
            this.drinkName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(0, 33);
            this.drinkName.TabIndex = 22;
            this.drinkName.Click += new System.EventHandler(this.drinkName_Click);
            // 
            // drinkPhoto
            // 
            this.drinkPhoto.Location = new System.Drawing.Point(18, 18);
            this.drinkPhoto.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(540, 471);
            this.drinkPhoto.TabIndex = 19;
            this.drinkPhoto.TabStop = false;
            // 
            // drinkDATA
            // 
            this.drinkDATA.Location = new System.Drawing.Point(632, 318);
            this.drinkDATA.Multiline = true;
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(564, 155);
            this.drinkDATA.TabIndex = 24;
            // 
            // IngredList
            // 
            this.IngredList.Location = new System.Drawing.Point(632, 121);
            this.IngredList.Multiline = true;
            this.IngredList.Name = "IngredList";
            this.IngredList.Size = new System.Drawing.Size(564, 155);
            this.IngredList.TabIndex = 25;
            this.IngredList.Text = "Ingredients:\r\n";
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1221, 660);
            this.Controls.Add(this.IngredList);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.button1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Random";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Random";
            this.Load += new System.EventHandler(this.Random_Load);
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label drinkName;
        private System.Windows.Forms.PictureBox drinkPhoto;
        private System.Windows.Forms.TextBox drinkDATA;
        private System.Windows.Forms.TextBox IngredList;
    }
}