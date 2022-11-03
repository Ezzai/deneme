using Siniflarim;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        List<Yemek> yemeklerim = new List<Yemek>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_YemekEkle_Click(object sender, EventArgs e)
        {
            Yemek yemek = new Yemek();
            yemek.Id = Convert.ToInt32(tbx_Id.Text);
            yemek.Ad = tbx_Ad.Text;
            yemek.Fiyat = Convert.ToInt32(tbx_Fiyat.Text);
            yemek.KategoriId = Convert.ToInt32(tbx_yemekKategoriId.Text);

            yemeklerim.Add(yemek);

            // yemeklerim listesine git, nerede sana gönderdiğim yemek.KategoriId verisine göre kategoriId'leri tek tek gez nerde yemek.KategoriId'sine eşitlenirse o verileri bana ToList()' kullanarak listeye oluştur ve gönder
            var yemeklerV2 = yemeklerim.Where(c => c.KategoriId == yemek.KategoriId).ToList();

            // yemeklerim listesine git, nerede sana gönderdiğim yemek'in adı varsa o veriyi bana geri döndür.
            var yemekV4 = yemeklerim.Where(c => c.Ad == yemek.Ad).SingleOrDefault();
            //var yemekV4 = yemeklerim.Where(c => c.Ad == yemek.Ad).FirstOrDefault();

            //listbox'a veri ekliyoruz
            listBox1.Items.Add("yemeğin idsi:" + yemek.Id +" "+ "yemegin adi: " + yemek.Ad + " " + "yemeğin fiyatı: " + yemek.Fiyat + " " + "yemegin kategori ıdsi: "+ yemek.KategoriId);
            // label'a yazdırmak için
            lbl_yazdir.Text = "yemeğin idsi:" + yemek.Id + " " + "yemegin adi: " + yemek.Ad + " " + "yemeğin fiyatı: " + yemek.Fiyat + " " + "yemegin kategori ıdsi: " + yemek.KategoriId;

            if (yemeklerim.Count > 3)
            {
                ListeyiYazdir();
            }
        }


        // Where, FirstorDefault, SingleOrDefault(), ToList()

        private void btn_kategoriEkle_Click(object sender, EventArgs e)
        {

        }


        public void ListeyiYazdir()
        {
            // yemeklerim.Count ==> listedeki yemeklerin (nesnelerin) sayısı kadar for'u devam ettirecek
            for (int i = 0; i < yemeklerim.Count; i++)
            {
                // yemekler listesindeki her bir yemeği tek tek dolaşarak onlara ait olan verileri teker teker yazdırıyoruz.
                lbl_yazdir.Text += "yemeğin idsi:" + yemeklerim[i].Id + " " + "yemegin adi: " + yemeklerim[i].Ad + " " + "yemeğin fiyatı: " + yemeklerim[i].Fiyat + " " + "yemegin kategori ıdsi: " + yemeklerim[i].KategoriId;
            }
        }
    }
}
