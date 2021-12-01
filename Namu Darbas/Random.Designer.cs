
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
            this.drinkDATA = new System.Windows.Forms.ListView();
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
            this.drinkPhoto = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.drinkPhoto)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // drinkName
            // 
            this.drinkName.AutoSize = true;
            this.drinkName.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.drinkName.Location = new System.Drawing.Point(417, 33);
            this.drinkName.Name = "drinkName";
            this.drinkName.Size = new System.Drawing.Size(0, 24);
            this.drinkName.TabIndex = 22;
            this.drinkName.Click += new System.EventHandler(this.drinkName_Click);
            // 
            // drinkDATA
            // 
            this.drinkDATA.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.drinkDATA.HideSelection = false;
            this.drinkDATA.Location = new System.Drawing.Point(421, 204);
            this.drinkDATA.Name = "drinkDATA";
            this.drinkDATA.Size = new System.Drawing.Size(377, 114);
            this.drinkDATA.TabIndex = 21;
            this.drinkDATA.TileSize = new System.Drawing.Size(700, 20);
            this.drinkDATA.UseCompatibleStateImageBehavior = false;
            this.drinkDATA.View = System.Windows.Forms.View.Tile;
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
            this.ingred.Location = new System.Drawing.Point(421, 77);
            this.ingred.Name = "ingred";
            this.ingred.Size = new System.Drawing.Size(377, 102);
            this.ingred.TabIndex = 20;
            this.ingred.UseCompatibleStateImageBehavior = false;
            this.ingred.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "";
            this.columnHeader3.Width = 78;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "";
            this.columnHeader16.Width = 83;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "";
            this.columnHeader17.Width = 78;
            // 
            // columnHeader18
            // 
            this.columnHeader18.Text = "";
            this.columnHeader18.Width = 85;
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
            // drinkPhoto
            // 
            this.drinkPhoto.Location = new System.Drawing.Point(12, 12);
            this.drinkPhoto.Name = "drinkPhoto";
            this.drinkPhoto.Size = new System.Drawing.Size(360, 306);
            this.drinkPhoto.TabIndex = 19;
            this.drinkPhoto.TabStop = false;
            // 
            // Random
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 429);
            this.Controls.Add(this.drinkName);
            this.Controls.Add(this.drinkDATA);
            this.Controls.Add(this.ingred);
            this.Controls.Add(this.drinkPhoto);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.ListView drinkDATA;
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
        private System.Windows.Forms.PictureBox drinkPhoto;
    }
}