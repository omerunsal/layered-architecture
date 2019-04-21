namespace KatmanliMimari.UI.Kitaplar
{
    partial class frmKitapEkle
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
            this.btnKitapEkle = new System.Windows.Forms.Button();
            this.txtYayinEvi = new System.Windows.Forms.TextBox();
            this.txtKitapKonusu = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKitapAdi = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpYayinTarihi = new System.Windows.Forms.DateTimePicker();
            this.cbYazarlar = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYazarId = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.txtYazarId);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cbYazarlar);
            this.groupBox1.Controls.Add(this.dtpYayinTarihi);
            this.groupBox1.Controls.Add(this.btnKitapEkle);
            this.groupBox1.Controls.Add(this.txtYayinEvi);
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
            this.groupBox1.Size = new System.Drawing.Size(1026, 438);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // btnKitapEkle
            // 
            this.btnKitapEkle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnKitapEkle.Location = new System.Drawing.Point(268, 349);
            this.btnKitapEkle.Name = "btnKitapEkle";
            this.btnKitapEkle.Size = new System.Drawing.Size(740, 55);
            this.btnKitapEkle.TabIndex = 3;
            this.btnKitapEkle.Text = "Kitap Ekle";
            this.btnKitapEkle.UseVisualStyleBackColor = true;
            this.btnKitapEkle.Click += new System.EventHandler(this.btnKitapEkle_Click);
            // 
            // txtYayinEvi
            // 
            this.txtYayinEvi.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYayinEvi.Location = new System.Drawing.Point(268, 132);
            this.txtYayinEvi.Name = "txtYayinEvi";
            this.txtYayinEvi.Size = new System.Drawing.Size(740, 45);
            this.txtYayinEvi.TabIndex = 2;
            // 
            // txtKitapKonusu
            // 
            this.txtKitapKonusu.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtKitapKonusu.Location = new System.Drawing.Point(268, 81);
            this.txtKitapKonusu.Name = "txtKitapKonusu";
            this.txtKitapKonusu.Size = new System.Drawing.Size(740, 45);
            this.txtKitapKonusu.TabIndex = 1;
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
            this.txtKitapAdi.Size = new System.Drawing.Size(740, 45);
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
            // dtpYayinTarihi
            // 
            this.dtpYayinTarihi.Location = new System.Drawing.Point(268, 183);
            this.dtpYayinTarihi.Name = "dtpYayinTarihi";
            this.dtpYayinTarihi.Size = new System.Drawing.Size(740, 45);
            this.dtpYayinTarihi.TabIndex = 4;
            // 
            // cbYazarlar
            // 
            this.cbYazarlar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cbYazarlar.FormattingEnabled = true;
            this.cbYazarlar.Location = new System.Drawing.Point(268, 234);
            this.cbYazarlar.Name = "cbYazarlar";
            this.cbYazarlar.Size = new System.Drawing.Size(740, 46);
            this.cbYazarlar.TabIndex = 5;
            this.cbYazarlar.SelectionChangeCommitted += new System.EventHandler(this.cbYazarlar_SelectionChangeCommitted);
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
            // txtYazarId
            // 
            this.txtYazarId.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYazarId.Location = new System.Drawing.Point(268, 286);
            this.txtYazarId.Name = "txtYazarId";
            this.txtYazarId.Size = new System.Drawing.Size(740, 45);
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
            // frmKitapEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(1050, 461);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmKitapEkle";
            this.Text = "Kitap Ekle";
            this.Load += new System.EventHandler(this.frmKitapEkle_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbYazarlar;
        private System.Windows.Forms.DateTimePicker dtpYayinTarihi;
        private System.Windows.Forms.Button btnKitapEkle;
        private System.Windows.Forms.TextBox txtYayinEvi;
        private System.Windows.Forms.TextBox txtKitapKonusu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKitapAdi;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYazarId;
        private System.Windows.Forms.Label label6;
    }
}