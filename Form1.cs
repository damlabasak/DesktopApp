using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Restaurant
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        private List<Masa> Masalar = new List<Masa>();
        private List<Urun> Urunler = new List<Urun>();
        private List<UrunHareket> UrunHareketleri = new List<UrunHareket>();
        private string seciliMasa;

        public Form1()
        {
            InitializeComponent();
            Urunler.Add(new Urun { Id = 1, UrunKodu = "1", UrunAdi = "Çorba", Birimi = "Porsiyon", Fiyat = 6.99 });
            Urunler.Add(new Urun { Id = 2, UrunKodu = "2", UrunAdi = "Hamburger", Birimi = "Porsiyon", Fiyat = 24.99 });
            Urunler.Add(new Urun { Id = 3, UrunKodu = "3", UrunAdi = "Adana Kebap", Birimi = "Porsiyon", Fiyat = 34.99 });
            Urunler.Add(new Urun { Id = 4, UrunKodu = "4", UrunAdi = "Urfa Kebap", Birimi = "Porsiyon", Fiyat = 34.99 });
            Urunler.Add(new Urun { Id = 5, UrunKodu = "5", UrunAdi = "Pizza", Birimi = "Adet", Fiyat = 24.99 });
            Urunler.Add(new Urun { Id = 6, UrunKodu = "6", UrunAdi = "Makarna", Birimi = "Porsiyon", Fiyat = 24.99 });
            Urunler.Add(new Urun { Id = 7, UrunKodu = "7", UrunAdi = "Salata", Birimi = "Porsiyon", Fiyat = 19.99 });
            Urunler.Add(new Urun { Id = 8, UrunKodu = "8", UrunAdi = "Sütlaç", Birimi = "Porsiyon", Fiyat = 14.99 });
            Urunler.Add(new Urun { Id = 9, UrunKodu = "9", UrunAdi = "Baklava", Birimi = "Kilo", Fiyat = 89.99 });
            Urunler.Add(new Urun { Id = 10, UrunKodu = "10", UrunAdi = "Dondurma", Birimi = "Top", Fiyat = 2.99 });

            Masalar.Add(new Masa { Id = 1, MasaKodu = "1", MasaAdi = "Masa-1" });
            Masalar.Add(new Masa { Id = 2, MasaKodu = "2", MasaAdi = "Masa-2" });
            Masalar.Add(new Masa { Id = 3, MasaKodu = "3", MasaAdi = "Masa-3" });
            Masalar.Add(new Masa { Id = 4, MasaKodu = "4", MasaAdi = "Masa-4" });
            Masalar.Add(new Masa { Id = 5, MasaKodu = "5", MasaAdi = "Masa-5" });
            Masalar.Add(new Masa { Id = 6, MasaKodu = "6", MasaAdi = "Masa-6" });
            Masalar.Add(new Masa { Id = 7, MasaKodu = "7", MasaAdi = "Masa-7" });
            Masalar.Add(new Masa { Id = 8, MasaKodu = "8", MasaAdi = "Masa-8" });
            Masalar.Add(new Masa { Id = 9, MasaKodu = "9", MasaAdi = "Masa-9" });
            Masalar.Add(new Masa { Id = 10, MasaKodu = "10", MasaAdi = "Masa-10" });

            ButonOlustur();

            gridControl1.DataSource = UrunHareketleri;
            

        }

        private void ButonOlustur()
        {
            foreach (var masa in Masalar)
            {
                SimpleButton masaButton = new SimpleButton
                {
                    Name = masa.MasaKodu,
                    Text = masa.MasaAdi,
                    Height = 80,
                    Width = 80,
                    ButtonStyle = BorderStyles.Flat,
                    Appearance = { BackColor = Color.Green}

                };

                flowMasa.Controls.Add(masaButton);
                masaButton.Click += masa_Click;

            }

            foreach (var Urun in Urunler)
            {
                SimpleButton UrunButton = new SimpleButton
                {
                    Name = Urun.UrunKodu,
                    Text = Urun.UrunAdi,
                    Height = 80,
                    Width = 80

                };

                flowUrunler.Controls.Add(UrunButton);
                UrunButton.Click += Urun_Click;

            }

        }

        private void Urun_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            Urun urun = Urunler.SingleOrDefault(c => c.UrunKodu == buton.Name);
            Masalar.SingleOrDefault(c => c.MasaKodu == seciliMasa).Hareketler.Add(new UrunHareket { 
            
                UrunKodu=urun.UrunKodu,
                UrunAdi = urun.UrunAdi,
                Birimi = urun.Birimi,
                Fiyat = urun.Fiyat,
                Miktar=1
            });
            gridView1.RefreshData();
            SimpleButton butonMasa = (SimpleButton)flowMasa.Controls.Find(seciliMasa, true).SingleOrDefault();
            butonMasa.Appearance.BackColor = Color.Red;
            txtToplam.Value = Convert.ToDecimal(cToplam.SummaryItem.SummaryValue);
        }

        private void masa_Click(object sender, EventArgs e)
        {
            SimpleButton buton = (SimpleButton)sender;
            Masa masa = Masalar.SingleOrDefault(c => c.MasaKodu == buton.Name);

            if (masa.Hareketler == null)
            {
                masa.Hareketler = new List<UrunHareket>();
            }

            seciliMasa = masa.MasaKodu;
            gridControl1.DataSource = masa.Hareketler;
            txtToplam.Value = Convert.ToDecimal(cToplam.SummaryItem.SummaryValue);
        }

        private void btnOde_Click(object sender, EventArgs e)
        {
            SimpleButton butonMasa = (SimpleButton)flowMasa.Controls.Find(seciliMasa, true).SingleOrDefault();
            butonMasa.Appearance.BackColor = Color.Green;
            var masa=Masalar.SingleOrDefault(c => c.MasaKodu == butonMasa.Name);
            masa.Hareketler = new List<UrunHareket>();
            gridControl1.DataSource = masa.Hareketler;
            txtToplam.Value = 0;
        }
    }
}
