using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//----------------------------
using KatmanliMimari.BLL; //controller
using KatmanliMimari.DAL; //model
using KatmanliMimari.DTO; //transfer


namespace KatmanliMimari.UI // View - Presentation - UI
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }
        KutuphaneDBEntities db = new KutuphaneDBEntities();
        private void frmMain_Load(object sender, EventArgs e)
        {
            YazarlariGetir();  
        }

        private void YazarlariGetir()
        {
            cbYazar.DataSource = db.Yazarlars.Select
            (
                y => new
            {
                y.YazarId,
                YazarAdiSoyadi = y.YazarAd + " " + y.YazarSoyad
            }).ToList();

            cbYazar.DisplayMember = "YazarAdiSoyadi";
            cbYazar.ValueMember = "YazarId";
        }

        private void cbYazar_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int yazarId = (int)cbYazar.SelectedValue;

            KitaplariGetir(yazarId);
            toolStripStatusLabelDurum.Text = lstKitaplar.Items.Count + " adet kitap listelenmiştir.";
        }
       
        private void KitaplariGetir(int yazarId)
        {
            lstKitaplar.DataSource = db.Kitaplars.Where(k => k.YazarId == yazarId).Select(x => new
            {
                x.KitapId,
                x.KitapAdı
            }).ToList();
            lstKitaplar.DisplayMember = "KitapAdı";
            lstKitaplar.ValueMember = "KitapId";
        }

        #region YazarYavru
        private void ekleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazarlar.frmYazarEkle ye = new Yazarlar.frmYazarEkle();
            ye.Show();
            this.Hide();

        }

        private void güncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazarlar.frmYazarGuncelle gg = new Yazarlar.frmYazarGuncelle();
            gg.Show();
            this.Hide();
        }

        private void silToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Yazarlar.frmYazarSil ys = new Yazarlar.frmYazarSil();
            ys.Show();
            this.Hide();
        }

        #endregion

        #region KitapYavru
        private void ekleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitaplar.frmKitapEkle ke = new Kitaplar.frmKitapEkle();
            ke.Show();
            this.Hide();
        }

        private void güncelleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitaplar.frmKitapGuncelle kg = new Kitaplar.frmKitapGuncelle();
            kg.Show();
            this.Hide();
        }

        private void silToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Kitaplar.frmKitapSil ks = new Kitaplar.frmKitapSil();
            ks.Show();
            this.Hide();
        } 
        #endregion
    }
}
