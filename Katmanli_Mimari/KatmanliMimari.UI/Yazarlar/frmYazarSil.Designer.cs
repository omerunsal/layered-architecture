namespace KatmanliMimari.UI.Yazarlar
{
    partial class frmYazarSil
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
            this.lstwYazarSil = new System.Windows.Forms.ListView();
            this.btnYazarSil = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lstwYazarSil
            // 
            this.lstwYazarSil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstwYazarSil.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstwYazarSil.FullRowSelect = true;
            this.lstwYazarSil.GridLines = true;
            this.lstwYazarSil.Location = new System.Drawing.Point(0, 0);
            this.lstwYazarSil.Name = "lstwYazarSil";
            this.lstwYazarSil.Size = new System.Drawing.Size(605, 342);
            this.lstwYazarSil.TabIndex = 0;
            this.lstwYazarSil.UseCompatibleStateImageBehavior = false;
            this.lstwYazarSil.View = System.Windows.Forms.View.Details;
            // 
            // btnYazarSil
            // 
            this.btnYazarSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnYazarSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYazarSil.Location = new System.Drawing.Point(0, 330);
            this.btnYazarSil.Name = "btnYazarSil";
            this.btnYazarSil.Size = new System.Drawing.Size(605, 102);
            this.btnYazarSil.TabIndex = 1;
            this.btnYazarSil.Text = "Seçilen Yazarı Sil";
            this.btnYazarSil.UseVisualStyleBackColor = true;
            this.btnYazarSil.Click += new System.EventHandler(this.btnYazarSil_Click);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "YazarID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "YazarAd";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "YazarSoyad";
            this.columnHeader3.Width = 110;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "YazarOzgecmis";
            this.columnHeader4.Width = 326;
            // 
            // frmYazarSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(605, 432);
            this.Controls.Add(this.btnYazarSil);
            this.Controls.Add(this.lstwYazarSil);
            this.Name = "frmYazarSil";
            this.Text = "Yazar Sil";
            this.Load += new System.EventHandler(this.frmYazarSil_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListView lstwYazarSil;
        private System.Windows.Forms.Button btnYazarSil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
    }
}