using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//_---------------------------------
using KatmanliMimari.DTO;
using KatmanliMimari.BLL;
using KatmanliMimari.DAL;
namespace KatmanliMimari.UI.Yazarlar
{
    public partial class frmYazarEkle : Form
    {
        public frmYazarEkle()
        {
            InitializeComponent();
        }

        private void btnYazarEkle_Click(object sender, EventArgs e)
        {
            try
            {
                YazarDTO yazar = new YazarDTO()
                {
                    YazarAd = txtYazarAdi.Text,
                    YazarSoyad = txtYazarSoyadi.Text,
                     Ozgecmis = txtOzgecmis.Text
                    
                };

                YazarRepository.YazarEkle(yazar);

                

                DialogResult dr = MessageBox.Show("Yazar Başarıyla Eklenmiştir. Yeni Yazar Eklemek ister Misiniz ?", "Ekleme bildirimi!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Temizle()
        {
            txtYazarAdi.Clear();
            txtYazarSoyadi.Clear();
            txtOzgecmis.Clear();
        }
    }
}
