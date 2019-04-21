using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KatmanliMimari.DTO;
using KatmanliMimari.BLL;
using KatmanliMimari.DAL;
namespace KatmanliMimari.UI.Kitaplar
{
    public partial class frmKitapEkle : Form
    {
        public frmKitapEkle()
        {
            InitializeComponent();
        }

        private void frmKitapEkle_Load(object sender, EventArgs e)
        {
            cbYazarlar.DataSource = YazarRepository.TumYazarlar();
        }

        private void btnKitapEkle_Click(object sender, EventArgs e)
        {
            try
            {
                KitapDTO kitap = new KitapDTO()
                {
                    KitapAd = txtKitapAdi.Text,
                    KitapKonu = txtKitapKonusu.Text,
                    YayinEv = txtYayinEvi.Text,
                    YayinTarih = dtpYayinTarihi.Value,
                    YazarID = Convert.ToInt32(txtYazarId.Text)
                };

                KitapRepository.KitapEkle(kitap);

                DialogResult dr = MessageBox.Show("Kitap Başarıyla Eklenmiştir. Yeni Kitap Eklemek ister Misiniz ?", "Ekleme bildirimi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dr == DialogResult.Yes)
                {
                    Temizle();
                }
                else
                {
                    frmMain frm = new frmMain();
                    this.Close();
                    frm.Show();
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Temizle()
        {
            txtKitapAdi.Clear();
            txtKitapKonusu.Clear();
            txtYayinEvi.Clear();
            txtYazarId.Clear();
        }

        private void cbYazarlar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            YazarDTO secilenYazar = cbYazarlar.SelectedItem as YazarDTO;
            txtYazarId.Text = secilenYazar.YazarID.ToString();
        }
    }
}
