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
namespace KatmanliMimari.UI.Yazarlar
{
    public partial class frmYazarGuncelle : Form
    {
        public frmYazarGuncelle()
        {
            InitializeComponent();
        }

        private void frmYazarGuncelle_Load(object sender, EventArgs e)
        {
            cbGuncelYazarAdi.DataSource = YazarRepository.TumYazarlar();
            
        }

        private void cbGuncelYazarAdi_SelectionChangeCommitted(object sender, EventArgs e)
        {
            YazarDTO secilenYazar = cbGuncelYazarAdi.SelectedItem as YazarDTO;

            txtGuncelAdi.Text = secilenYazar.YazarAd;
            txtGuncelSoyadi.Text = secilenYazar.YazarSoyad;
            txtOzgecmis.Text = secilenYazar.Ozgecmis;
            txtYazarId.Text = secilenYazar.YazarID.ToString();
        }

        private void btnYazarGuncelle_Click(object sender, EventArgs e)
        {
            YazarDTO guncelYazar = new YazarDTO
            {
                YazarID = Convert.ToInt32(txtYazarId.Text),
                YazarAd = txtGuncelAdi.Text,
                YazarSoyad = txtGuncelSoyadi.Text,
                Ozgecmis = txtOzgecmis.Text
            };

            YazarRepository.YazarGuncelle(guncelYazar);

            MessageBox.Show("Yazar başarıyla güncellenmiştir.");

            frmMain frm = new frmMain();
            this.Close();
            frm.Show();
        }
    }
}
