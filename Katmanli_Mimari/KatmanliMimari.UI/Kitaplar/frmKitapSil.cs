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
    public partial class frmKitapSil : Form
    {
        public frmKitapSil()
        {
            InitializeComponent();
        }

        private void frmKitapSil_Load(object sender, EventArgs e)
        {
            YazarlariGetir();

        }
        KutuphaneDBEntities db = new KutuphaneDBEntities();
        private void YazarlariGetir()
        {
            cbYazarlar.DataSource = db.Yazarlars.Select
            (
                y => new
                {
                    y.YazarId,
                    YazarAdiSoyadi = y.YazarAd + " " + y.YazarSoyad
                }).ToList();

            cbYazarlar.DisplayMember = "YazarAdiSoyadi";
            cbYazarlar.ValueMember = "YazarId";
        }

        private void cbYazarlar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int yazarId = (int)cbYazarlar.SelectedValue;
            txtYazarId.Text = yazarId.ToString();
            KitaplariGetir(yazarId);

            
        }

        private void KitaplariGetir(int yazarId)
        {
            cbKitaplar.DataSource = db.Kitaplars.Where(k => k.YazarId == yazarId).Select(x => new
            {
                x.KitapId,
                x.KitapAdı,
                x.KitapKonusu,
                x.Yayinevi,
                x.YayinTarihi,
                x.YazarId
                
            }).ToList();
            cbKitaplar.DisplayMember = "KitapAdı";
            cbKitaplar.ValueMember = "KitapId";

        }

        private void cbKitaplar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            try
            {
                //int kitapId = (int)cbKitaplar.SelectedValue;
                //txtKitapId.Text = kitapId.ToString();



                //txtKitapAdi.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).KitapAd;
                //txtKitapKonusu.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).KitapKonu;
                //txtYayinEvi.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).YayinEv;
                //dtpYayinTarihi.Text = (KitapRepository.IDyeGoreKitapGetir(kitapId).YayinTarih).ToString();

                Listele();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Listele()
        {
            lstwKitapSil.Items.Clear();

            List<KitapDTO> kitapListele = KitapRepository.TumKitaplar();

            foreach (KitapDTO ki in kitapListele)
            {
                ListViewItem li = new ListViewItem();

                li.Tag = ki;
                li.Text = ki.KitapID.ToString();
                li.SubItems.Add(ki.KitapAd);
                li.SubItems.Add(ki.YazarID.ToString());


                lstwKitapSil.Items.Add(li);
            }
        }

        private void btnKitapSil_Click(object sender, EventArgs e)
        {
            try
            {
                if (lstwKitapSil.SelectedItems.Count > 0)
                {
                    KitapRepository.KitapSil((KitapDTO)lstwKitapSil.SelectedItems[0].Tag);

                    MessageBox.Show("Kitap başarıyla silinmiştir.");

                    Listele();
                }
                else
                {
                    MessageBox.Show("Lütfen silmek istediğiniz yazarı seçiniz!");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Bağlı tablolardan veya başka bir sebepten silme gerçekleştirelemedi.");
            }
        }
    }
}
