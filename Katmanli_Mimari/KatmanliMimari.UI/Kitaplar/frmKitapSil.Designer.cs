namespace KatmanliMimari.UI.Kitaplar
{
    partial class frmKitapSil
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
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtYazarId = new System.Windows.Forms.TextBox();
            this.cbKitaplar = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYazarlar = new System.Windows.Forms.ComboBox();
            this.btnKitapSil = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lstwKitapSil = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtKitapId
            // 
            this.txtKitapId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapId.Location = new System.Drawing.Point(280, 203);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(909, 45);
            this.txtKitapId.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(18, 203);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kitap Id:";
            // 
            // txtYazarId
            // 
            this.txtYazarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarId.Location = new System.Drawing.Point(280, 96);
            this.txtYazarId.Name = "txtYazarId";
            this.txtYazarId.Size = new System.Drawing.Size(909, 45);
            this.txtYazarId.TabIndex = 7;
            // 
            // cbKitaplar
            // 
            this.cbKitaplar.FormattingEnabled = true;
            this.cbKitaplar.Location = new System.Drawing.Point(280, 151);
            this.cbKitaplar.Name = "cbKitaplar";
            this.cbKitaplar.Size = new System.Drawing.Size(909, 46);
            this.cbKitaplar.TabIndex = 5;
            this.cbKitaplar.SelectionChangeCommitted += new System.EventHandler(this.cbKitaplar_SelectionChangeCommitted);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(18, 96);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yazar Id:";
            // 
            // cbYazarlar
            // 
            this.cbYazarlar.FormattingEnabled = true;
            this.cbYazarlar.Location = new System.Drawing.Point(280, 44);
            this.cbYazarlar.Name = "cbYazarlar";
            this.cbYazarlar.Size = new System.Drawing.Size(909, 46);
            this.cbYazarlar.TabIndex = 5;
            this.cbYazarlar.SelectionChangeCommitted += new System.EventHandler(this.cbYazarlar_SelectionChangeCommitted);
            // 
            // btnKitapSil
            // 
            this.btnKitapSil.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitapSil.Location = new System.Drawing.Point(280, 265);
            this.btnKitapSil.Name = "btnKitapSil";
            this.btnKitapSil.Size = new System.Drawing.Size(909, 55);
            this.btnKitapSil.TabIndex = 3;
            this.btnKitapSil.Text = "Kitap Sil";
            this.btnKitapSil.UseVisualStyleBackColor = true;
            this.btnKitapSil.Click += new System.EventHandler(this.btnKitapSil_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(18, 151);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(18, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazarı:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtKitapId);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.txtYazarId);
            this.groupBox1.Controls.Add(this.cbKitaplar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbYazarlar);
            this.groupBox1.Controls.Add(this.btnKitapSil);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(28, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 367);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // lstwKitapSil
            // 
            this.lstwKitapSil.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.lstwKitapSil.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstwKitapSil.FullRowSelect = true;
            this.lstwKitapSil.GridLines = true;
            this.lstwKitapSil.Location = new System.Drawing.Point(0, 405);
            this.lstwKitapSil.Name = "lstwKitapSil";
            this.lstwKitapSil.Size = new System.Drawing.Size(1246, 338);
            this.lstwKitapSil.TabIndex = 4;
            this.lstwKitapSil.UseCompatibleStateImageBehavior = false;
            this.lstwKitapSil.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Kitap ID";
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Kitap Adı";
            this.columnHeader2.Width = 105;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Yazar ID";
            this.columnHeader3.Width = 110;
            // 
            // frmKitapSil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1246, 743);
            this.Controls.Add(this.lstwKitapSil);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKitapSil";
            this.Text = "frmKitapSil";
            this.Load += new System.EventHandler(this.frmKitapSil_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtYazarId;
        private System.Windows.Forms.ComboBox cbKitaplar;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbYazarlar;
        private System.Windows.Forms.Button btnKitapSil;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListView lstwKitapSil;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
    }
}