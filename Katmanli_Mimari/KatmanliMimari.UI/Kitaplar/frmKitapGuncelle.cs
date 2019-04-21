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
    public partial class frmKitapGuncelle : Form
    {
        public frmKitapGuncelle()
        {
            InitializeComponent();
        }
        KutuphaneDBEntities db = new KutuphaneDBEntities();
        private void frmKitapGuncelle_Load(object sender, EventArgs e)
        {
            
            YazarlariGetir();

        }
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
                x.KitapAdı
            }).ToList();
            cbKitaplar.DisplayMember = "KitapAdı";
            cbKitaplar.ValueMember = "KitapId";
        }

        private void cbKitaplar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int kitapId = (int)cbKitaplar.SelectedValue;
            txtKitapId.Text = kitapId.ToString();

            txtKitapAdi.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).KitapAd;
            txtKitapKonusu.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).KitapKonu;
            txtYayinEvi.Text = KitapRepository.IDyeGoreKitapGetir(kitapId).YayinEv;
            dtpYayinTarihi.Text = (KitapRepository.IDyeGoreKitapGetir(kitapId).YayinTarih).ToString();

        }

        private void btnKitapGuncelle_Click(object sender, EventArgs e)
        {
            KitapDTO guncelKitap = new KitapDTO
            {
                KitapAd = txtKitapAdi.Text,
                KitapKonu = txtKitapKonusu.Text,
                YayinEv = txtYayinEvi.Text,
                YayinTarih = dtpYayinTarihi.Value,
                KitapID = Convert.ToInt32(txtKitapId.Text),
                YazarID = Convert.ToInt32(txtYazarId.Text)
            };

            KitapRepository.KitapGuncelle(guncelKitap);

            MessageBox.Show("Kitap başarıyla güncellenmiştir.");

            frmMain frm = new frmMain();
            this.Close();
            frm.Show();
        }
    }
}
