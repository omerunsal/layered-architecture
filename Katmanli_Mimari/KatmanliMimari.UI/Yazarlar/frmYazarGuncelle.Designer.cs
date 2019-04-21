namespace KatmanliMimari.UI.Yazarlar
{
    partial class frmYazarGuncelle
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnYazarGuncelle = new System.Windows.Forms.Button();
            this.txtOzgecmis = new System.Windows.Forms.TextBox();
            this.txtGuncelSoyadi = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtYazarId = new System.Windows.Forms.TextBox();
            this.cbGuncelYazarAdi = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtGuncelAdi = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbGuncelYazarAdi);
            this.groupBox1.Controls.Add(this.btnYazarGuncelle);
            this.groupBox1.Controls.Add(this.txtOzgecmis);
            this.groupBox1.Controls.Add(this.txtYazarId);
            this.groupBox1.Controls.Add(this.txtGuncelAdi);
            this.groupBox1.Controls.Add(this.txtGuncelSoyadi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1067, 612);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnYazarGuncelle
            // 
            this.btnYazarGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnYazarGuncelle.Location = new System.Drawing.Point(268, 438);
            this.btnYazarGuncelle.Name = "btnYazarGuncelle";
            this.btnYazarGuncelle.Size = new System.Drawing.Size(781, 55);
            this.btnYazarGuncelle.TabIndex = 4;
            this.btnYazarGuncelle.Text = "Yazar Güncelle";
            this.btnYazarGuncelle.UseVisualStyleBackColor = true;
            this.btnYazarGuncelle.Click += new System.EventHandler(this.btnYazarGuncelle_Click);
            // 
            // txtOzgecmis
            // 
            this.txtOzgecmis.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtOzgecmis.Location = new System.Drawing.Point(268, 232);
            this.txtOzgecmis.Multiline = true;
            this.txtOzgecmis.Name = "txtOzgecmis";
            this.txtOzgecmis.Size = new System.Drawing.Size(781, 181);
            this.txtOzgecmis.TabIndex = 3;
            // 
            // txtGuncelSoyadi
            // 
            this.txtGuncelSoyadi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuncelSoyadi.Location = new System.Drawing.Point(268, 130);
            this.txtGuncelSoyadi.Name = "txtGuncelSoyadi";
            this.txtGuncelSoyadi.Size = new System.Drawing.Size(781, 45);
            this.txtGuncelSoyadi.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 232);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Özgeçmiş:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Yazar Soyadı:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Yazar Adı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 181);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(152, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yazar Id:";
            // 
            // txtYazarId
            // 
            this.txtYazarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarId.Enabled = false;
            this.txtYazarId.Location = new System.Drawing.Point(268, 181);
            this.txtYazarId.Name = "txtYazarId";
            this.txtYazarId.Size = new System.Drawing.Size(781, 45);
            this.txtYazarId.TabIndex = 2;
            // 
            // cbGuncelYazarAdi
            // 
            this.cbGuncelYazarAdi.FormattingEnabled = true;
            this.cbGuncelYazarAdi.Location = new System.Drawing.Point(268, 27);
            this.cbGuncelYazarAdi.Name = "cbGuncelYazarAdi";
            this.cbGuncelYazarAdi.Size = new System.Drawing.Size(781, 46);
            this.cbGuncelYazarAdi.TabIndex = 0;
            this.cbGuncelYazarAdi.SelectionChangeCommitted += new System.EventHandler(this.cbGuncelYazarAdi_SelectionChangeCommitted);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 79);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(173, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazar Adı:";
            // 
            // txtGuncelAdi
            // 
            this.txtGuncelAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtGuncelAdi.Location = new System.Drawing.Point(268, 79);
            this.txtGuncelAdi.Name = "txtGuncelAdi";
            this.txtGuncelAdi.Size = new System.Drawing.Size(781, 45);
            this.txtGuncelAdi.TabIndex = 1;
            // 
            // frmYazarGuncelle
            // 
            this.AcceptButton = this.btnYazarGuncelle;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1091, 636);
            this.Controls.Add(this.groupBox1);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "frmYazarGuncelle";
            this.Text = "Yazar Güncelle";
            this.Load += new System.EventHandler(this.frmYazarGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnYazarGuncelle;
        private System.Windows.Forms.TextBox txtOzgecmis;
        private System.Windows.Forms.TextBox txtGuncelSoyadi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbGuncelYazarAdi;
        private System.Windows.Forms.TextBox txtYazarId;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtGuncelAdi;
        private System.Windows.Forms.Label label5;
    }
}