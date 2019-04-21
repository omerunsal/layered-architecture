namespace KatmanliMimari.UI.Kitaplar
{
    partial class frmKitapGuncelle
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
            this.txtYazarId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbYazarlar = new System.Windows.Forms.ComboBox();
            this.dtpYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.btnKitapGuncelle = new System.Windows.Forms.Button();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtKitapKonusu = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cbKitaplar = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtKitapId = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
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
            this.groupBox1.Controls.Add(this.dtpYayinTarihi);
            this.groupBox1.Controls.Add(this.btnKitapGuncelle);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.txtKitapKonusu);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtKitapAdi);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1195, 541);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // txtYazarId
            // 
            this.txtYazarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarId.Location = new System.Drawing.Point(268, 286);
            this.txtYazarId.Name = "txtYazarId";
            this.txtYazarId.Size = new System.Drawing.Size(909, 45);
            this.txtYazarId.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(6, 286);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 39);
            this.label6.TabIndex = 6;
            this.label6.Text = "Yazar Id:";
            // 
            // cbYazarlar
            // 
            this.cbYazarlar.FormattingEnabled = true;
            this.cbYazarlar.Location = new System.Drawing.Point(268, 234);
            this.cbYazarlar.Name = "cbYazarlar";
            this.cbYazarlar.Size = new System.Drawing.Size(909, 46);
            this.cbYazarlar.TabIndex = 5;
            this.cbYazarlar.SelectionChangeCommitted += new System.EventHandler(this.cbYazarlar_SelectionChangeCommitted);
            // 
            // dtpYayinTarihi
            // 
            this.dtpYayinTarihi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dtpYayinTarihi.Location = new System.Drawing.Point(268, 183);
            this.dtpYayinTarihi.Name = "dtpYayinTarihi";
            this.dtpYayinTarihi.Size = new System.Drawing.Size(909, 45);
            this.dtpYayinTarihi.TabIndex = 4;
            // 
            // btnKitapGuncelle
            // 
            this.btnKitapGuncelle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitapGuncelle.Location = new System.Drawing.Point(268, 455);
            this.btnKitapGuncelle.Name = "btnKitapGuncelle";
            this.btnKitapGuncelle.Size = new System.Drawing.Size(909, 55);
            this.btnKitapGuncelle.TabIndex = 3;
            this.btnKitapGuncelle.Text = "Kitap Güncelle";
            this.btnKitapGuncelle.UseVisualStyleBackColor = true;
            this.btnKitapGuncelle.Click += new System.EventHandler(this.btnKitapGuncelle_Click);
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYayinEvi.Location = new System.Drawing.Point(268, 132);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(909, 45);
            this.txtYayinEvi.TabIndex = 2;
            // 
            // txtKitapKonusu
            // 
            this.txtKitapKonusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapKonusu.Location = new System.Drawing.Point(268, 81);
            this.txtKitapKonusu.Name = "txtKitapKonusu";
            this.txtKitapKonusu.Size = new System.Drawing.Size(909, 45);
            this.txtKitapKonusu.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(6, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "Yazarı:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(6, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 39);
            this.label4.TabIndex = 0;
            this.label4.Text = "Yayın Tarihi:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(6, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(168, 39);
            this.label3.TabIndex = 0;
            this.label3.Text = "Yayın Evi:";
            // 
            // txtKitapAdi
            // 
            this.txtKitapAdi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapAdi.Location = new System.Drawing.Point(268, 30);
            this.txtKitapAdi.Name = "txtKitapAdi";
            this.txtKitapAdi.Size = new System.Drawing.Size(909, 45);
            this.txtKitapAdi.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(6, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 39);
            this.label2.TabIndex = 0;
            this.label2.Text = "Kitap Konusu:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kitap Adı:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(6, 341);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 39);
            this.label7.TabIndex = 0;
            this.label7.Text = "Kitap:";
            // 
            // cbKitaplar
            // 
            this.cbKitaplar.FormattingEnabled = true;
            this.cbKitaplar.Location = new System.Drawing.Point(268, 341);
            this.cbKitaplar.Name = "cbKitaplar";
            this.cbKitaplar.Size = new System.Drawing.Size(909, 46);
            this.cbKitaplar.TabIndex = 5;
            this.cbKitaplar.SelectionChangeCommitted += new System.EventHandler(this.cbKitaplar_SelectionChangeCommitted);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(6, 393);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(142, 39);
            this.label8.TabIndex = 6;
            this.label8.Text = "Kitap Id:";
            // 
            // txtKitapId
            // 
            this.txtKitapId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapId.Location = new System.Drawing.Point(268, 393);
            this.txtKitapId.Name = "txtKitapId";
            this.txtKitapId.Size = new System.Drawing.Size(909, 45);
            this.txtKitapId.TabIndex = 7;
            // 
            // frmKitapGuncelle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(1219, 580);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKitapGuncelle";
            this.Text = "frmKitapGuncelle";
            this.Load += new System.EventHandler(this.frmKitapGuncelle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtYazarId;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbYazarlar;
        private System.Windows.Forms.DateTimePicker dtpYayinTarihi;
        private System.Windows.Forms.Button btnKitapGuncelle;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtKitapKonusu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKitapId;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbKitaplar;
        private System.Windows.Forms.Label label7;
    }
}