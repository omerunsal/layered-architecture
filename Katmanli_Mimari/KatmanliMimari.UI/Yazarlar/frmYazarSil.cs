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
    public partial class frmYazarSil : Form
    {
        public frmYazarSil()
        {
            InitializeComponent();
        }

        private void frmYazarSil_Load(object sender, EventArgs e)
        {
            YazarListele();
        }

        private void YazarListele()
        {
            lstwYazarSil.Items.Clear();

            List<YazarDTO> yazarListele = YazarRepository.TumYazarlar();

            foreach (YazarDTO yl in yazarListele)
            {
                ListViewItem li = new ListViewItem();

                li.Tag = yl;
                li.Text = yl.YazarID.ToString();
                li.SubItems.Add(yl.YazarAd);
                li.SubItems.Add(yl.YazarSoyad);
                li.SubItems.Add(yl.Ozgecmis);

                lstwYazarSil.Items.Add(li);
            }
        }

        private void btnYazarSil_Click(object sender, EventArgs e)
        {
            if (lstwYazarSil.SelectedItems.Count>0)
            {
                YazarRepository.YazarSil((YazarDTO)lstwYazarSil.SelectedItems[0].Tag);

                MessageBox.Show("Yazar başarıyla silinmiştir.");

                YazarListele();
            }
            else
            {
                MessageBox.Show("Lütfen silmek istediğiniz yazarı seçiniz!");
            }
        }
    }
}
