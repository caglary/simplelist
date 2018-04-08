using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ciftciler
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           
        }
        BusinessLogicalLayer.BLL bll = new BusinessLogicalLayer.BLL();


        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
            listeGetir();
        }

        private void btn_ListeGetir_Click(object sender, EventArgs e)
        {
            listeGetir();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int secilendeger = e.RowIndex;
                lbl_ID.Text = dataGridView1.Rows[secilendeger].Cells[0].Value.ToString();
                mtb_DosyaNumarasi.Text = dataGridView1.Rows[secilendeger].Cells[1].Value.ToString();
                mtb_TCNumarasi.Text = dataGridView1.Rows[secilendeger].Cells[2].Value.ToString();
                txt_Isim.Text = dataGridView1.Rows[secilendeger].Cells[3].Value.ToString();
                txt_Soyisim.Text = dataGridView1.Rows[secilendeger].Cells[4].Value.ToString();
                cmb_Mahalle.Text = dataGridView1.Rows[secilendeger].Cells[5].Value.ToString();
                lbl_Tarih.Text = dataGridView1.Rows[secilendeger].Cells[6].Value.ToString().Substring(0, 8);
                RichTxt_Aciklama.Text = dataGridView1.Rows[secilendeger].Cells[7].Value.ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btn_Temizle_Click(object sender, EventArgs e)
        {

            temizle();

        }

        public void temizle()
        {
            lbl_ID.Text = "";
            mtb_DosyaNumarasi.Text = "";
            mtb_TCNumarasi.Text = "";
            txt_Isim.Text = "";
            txt_Soyisim.Text = "";
            cmb_Mahalle.Text = "";
            lbl_Tarih.Text = DateTime.Now.ToShortDateString();
            RichTxt_Aciklama.Text = "";

        }

        public void listeGetir()
        {
            bll = new BusinessLogicalLayer.BLL();

            dataGridView1.DataSource = bll.Listele();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(RichTxt_Aciklama.Text)&& 
                string.IsNullOrEmpty(mtb_DosyaNumarasi.Text) &&
                string.IsNullOrEmpty(txt_Isim.Text) &&
                string.IsNullOrEmpty(cmb_Mahalle.Text) &&
                string.IsNullOrEmpty(txt_Soyisim.Text) &&
                string.IsNullOrEmpty(mtb_TCNumarasi.Text) )
            MessageBox.Show("Alanları eksiksiz doldurunuz.");

            else
            {
                bll.KayitEkle(new Kayitlar()
                {
                    Aciklama = RichTxt_Aciklama.Text.ToUpper(),
                    DosyaNumarasi = Convert.ToInt16(mtb_DosyaNumarasi.Text),
                    Isim = txt_Isim.Text.ToUpper(),
                    Mahalle = cmb_Mahalle.Text.ToUpper(),
                    Soyisim = txt_Soyisim.Text.ToUpper(),
                    Tarih = lbl_Tarih.Text,
                    Tc = mtb_TCNumarasi.Text

                });
                listeGetir();
            }

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text=="---" || string.IsNullOrEmpty(lbl_ID.Text) )
                MessageBox.Show("Tablodan bir kayıt seçiniz.");
            else
            {
                bll.KayitDuzenle(new Entities.Kayitlar()
                {
                    ID = Guid.Parse(lbl_ID.Text),
                    Aciklama = RichTxt_Aciklama.Text,
                    DosyaNumarasi = Convert.ToInt16(mtb_DosyaNumarasi.Text),
                    Isim = txt_Isim.Text,
                    Mahalle = cmb_Mahalle.Text,
                    Soyisim = txt_Soyisim.Text,
                    Tarih = lbl_Tarih.Text,
                    Tc = mtb_TCNumarasi.Text



                });
                listeGetir();
            }
            

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (lbl_ID.Text == "---" || string.IsNullOrEmpty(lbl_ID.Text))
                MessageBox.Show("Tablodan bir kayıt seçiniz.");
            else
            {

                bll.KayitSil(new Entities.Kayitlar()
                {
                    ID = Guid.Parse(lbl_ID.Text),
                });

                listeGetir();
            }
        }

        private void mtb_DosyaNumarasi_Click(object sender, EventArgs e)
        {
            mtb_DosyaNumarasi.Select(0,0);
        }

        private void mtb_TCNumarasi_Click(object sender, EventArgs e)
        {
            mtb_TCNumarasi.Select(0, 0);
        }
    }
}
