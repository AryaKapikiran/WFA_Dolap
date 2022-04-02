using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFA_Dolap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        List<Urun> urunler = new List<Urun>();

        decimal kdvliToplam;
        private void Form1_Load(object sender, EventArgs e)
        {
            /*
             uygulama açıldığında;
 3 adet ayakkabı
 3 adet tshirt
 3 adet pantolon
 3 adet mont

tanımlayarak ilgili list boxlarda özellikleri ile listeleyin. Kullanıcı listbox içerisinde tanımlı olan item'a çift tıkladıktan sonra lstSepet'e seçili olan item özellikleri ile eklensin ve toplam tutar'a ilgili ürünün fiyatı dahil edilsin.

alışverişi tamamla butonuna basıldıktan sonra lstSepet içerisinde bulunan itemlar listview içerisinde göserilsin ve lstSepet temizlensin.

listboxlar içerisinde fiyatlar kdv hariç sepete eklenildiğinde kdv dahil olarak hem gösterilecek hem de hesaplanacak.
             */
         //Pantolon
            Pantolon pantolon1 = new Pantolon();
            pantolon1.Marka = "Lewis";
            pantolon1.Model = "Jean";
            pantolon1.Renk = "Lacivert";
            pantolon1.Beden = 32;
            pantolon1.Fiyat = 120;
            pantolon1.Kategori = "Pantolon";

            Pantolon pantolon2 = new Pantolon();
            pantolon2.Marka = "Lc Waikiki";
            pantolon2.Model = "Kumaş";
            pantolon2.Renk = "Bej";
            pantolon2.Beden = 33;
            pantolon2.Fiyat = 35;
            pantolon2.Kategori = "Pantolon";

            Pantolon pantolon3 = new Pantolon();
            pantolon3.Marka = "Mavi";
            pantolon3.Model = "Stretch Skinny";
            pantolon3.Renk = "Beyaz";
            pantolon3.Beden = 34;
            pantolon3.Fiyat = 100;
            pantolon3.Kategori = "Pantolon";
            //Tişört
            Tişört tshirt1 = new Tişört();
            tshirt1.Marka = "Pull&Bear";
            tshirt1.Model = "V yaka";
            tshirt1.Renk = "Kahverengi";
            tshirt1.Beden = "M";
            tshirt1.Fiyat = 50;
            tshirt1.Kategori = "Tişört";

            Tişört tshirt2 = new Tişört();
            tshirt2.Marka = "H&M";
            tshirt2.Model = "Crop";
            tshirt2.Renk = "Siyah";
            tshirt2.Beden = "XS";
            tshirt2.Fiyat = 80;
            tshirt2.Kategori = "Tişört";

            Tişört tshirt3 = new Tişört();
            tshirt3.Marka = "Bershka";
            tshirt3.Model = "Oversize T-shirt";
            tshirt3.Renk = "Karışık Renk";
            tshirt3.Beden = "XL";
            tshirt3.Fiyat = 99;
            tshirt3.Kategori = "Tişört";

            //Mont 

            Mont mont1 = new Mont();
            mont1.Marka = "Moncler";
            mont1.Model = "Şişme Mont";
            mont1.Renk = "Siyah";
            mont1.Beden = "M";
            mont1.Fiyat = 25000;
            mont1.Kategori = "Mont";

            Mont mont2 = new Mont();
            mont2.Marka = "NorthFace";
            mont2.Model = "Kayak Montu";
            mont2.Renk = "Çok Renkli";
            mont2.Beden = "L";
            mont2.Fiyat = 2000;
            mont2.Kategori = "Mont";


            Mont mont3 = new Mont();
            mont3.Marka = "Columbia";
            mont3.Model = "Yağmurluk";
            mont3.Renk = "Sarı";
            mont3.Beden = "S";
            mont3.Fiyat = 1000;
            mont3.Kategori = "Mont";

            //Ayakkabı

            Ayakkabi ayakkabi1 = new Ayakkabi();
            ayakkabi1.Marka = "Divarse";
            ayakkabi1.Model = "Spor/Günlük";
            ayakkabi1.Renk = "Krem";
            ayakkabi1.Numara = 45;
            ayakkabi1.Fiyat = 200;
            ayakkabi1.Kategori = "Ayakkabı";

            Ayakkabi ayakkabi2 = new Ayakkabi();
            ayakkabi2.Marka = "Derimod";
            ayakkabi2.Model = "Köseli";
            ayakkabi2.Renk = "Kahverengi";
            ayakkabi2.Numara = 42;
            ayakkabi2.Fiyat = 300;
            ayakkabi2.Kategori = "Ayakkabı";

            Ayakkabi ayakkabi3 = new Ayakkabi();
            ayakkabi3.Marka = "Adidas";
            ayakkabi3.Model = "Koşu";
            ayakkabi3.Renk = "Beyaz";
            ayakkabi3.Numara = 39;
            ayakkabi3.Fiyat = 150;
            ayakkabi3.Kategori = "Ayakkabı";

            //Urunlerin ListBoxta gosterilmesi
            urunler.Add(pantolon1);
            urunler.Add(pantolon2);
            urunler.Add(pantolon3);
            urunler.Add(tshirt1);
            urunler.Add(tshirt2);
            urunler.Add(tshirt3);
            urunler.Add(mont1);
            urunler.Add(mont2);
            urunler.Add(mont3);
            urunler.Add(ayakkabi1);
            urunler.Add(ayakkabi2);
            urunler.Add(ayakkabi3);

            foreach (Urun urun in urunler)
            {
                if (urun is Pantolon)
                {
                    Pantolon pantolon = (Pantolon)urun;
                  
                    lstPantolon.Items.Add(pantolon);
                }
               else if (urun is Tişört)
                {
                    Tişört tshirt = (Tişört)urun;
                   
                    lstTshirt.Items.Add(tshirt);

                }

               else if (urun is Mont)
                {
                    Mont mont = (Mont)urun;
                    
                    lstMont.Items.Add(mont);

                }
               else if (urun is Ayakkabi)
                {
                    Ayakkabi ayakkabi = (Ayakkabi)urun;
                    lstAyakkabi.Items.Add(ayakkabi);

                }
            }





        }

        //double click event
        decimal toplamtutar;
        private void lstAyakkabi_DoubleClick(object sender, EventArgs e)
        {
            Ayakkabi seciliayakkabi = (Ayakkabi)lstAyakkabi.SelectedItem;
            lstSepet.Items.Add(seciliayakkabi);
            toplamtutar += seciliayakkabi.Fiyat;
            lblToplamTutar.Text =toplamtutar.ToString("C2");
        }

        private void lstTshirt_DoubleClick(object sender, EventArgs e)
        {
            Tişört secilitshirt = (Tişört)lstTshirt.SelectedItem;
            lstSepet.Items.Add(secilitshirt);
            toplamtutar += secilitshirt.Fiyat;
            lblToplamTutar.Text = toplamtutar.ToString("C2");

        }

        private void lstMont_DoubleClick(object sender, EventArgs e)
        {

            Mont secilimont = (Mont)lstMont.SelectedItem;
            lstSepet.Items.Add(secilimont);
            toplamtutar += secilimont.Fiyat;
            lblToplamTutar.Text = toplamtutar.ToString("C2");

        }

        private void lstPantolon_DoubleClick(object sender, EventArgs e)
        {
            Pantolon secilipantolon = (Pantolon)lstPantolon.SelectedItem;
            lstSepet.Items.Add(secilipantolon);
            toplamtutar += secilipantolon.Fiyat;
            lblToplamTutar.Text = toplamtutar.ToString("C2");

        }
        //listview a aktarma
        private void button1_Click(object sender, EventArgs e)
        {
         

            foreach (Urun urun in lstSepet.Items)
            {
                if (urun is Pantolon)
                { 
                    ListViewItem lvi = new ListViewItem();
                    Pantolon pantolon = (Pantolon)urun;
                    lvi.Text = pantolon.Marka;
                    lvi.SubItems.Add(pantolon.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(pantolon.KDVfiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    kdvliToplam += pantolon.KDVfiyat;
                    label3.Text = kdvliToplam.ToString("C2");

                }
               else if (urun is Ayakkabi)
                {
                    ListViewItem lvi = new ListViewItem();
                    Ayakkabi ayakkabi = (Ayakkabi)urun;
                    lvi.Text = ayakkabi.Marka;
                    lvi.SubItems.Add(ayakkabi.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(ayakkabi.KDVfiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    kdvliToplam += ayakkabi.KDVfiyat;
                    label3.Text = kdvliToplam.ToString("C2");


                }

                else if (urun is Mont)
                {
                    ListViewItem lvi = new ListViewItem();
                    Mont mont = (Mont)urun;
                    lvi.Text = mont.Marka;
                    lvi.SubItems.Add(mont.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(mont.KDVfiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    kdvliToplam += mont.KDVfiyat;
                    label3.Text = kdvliToplam.ToString("C2");


                }

                else if (urun is Tişört)
                {
                    ListViewItem lvi = new ListViewItem();
                    Tişört tişört = (Tişört)urun;
                    lvi.Text = tişört.Marka;
                    lvi.SubItems.Add(tişört.Kategori);
                    lvi.SubItems.Add(DateTime.Now.ToString());
                    lvi.SubItems.Add(tişört.KDVfiyat.ToString("C2"));
                    listView1.Items.Add(lvi);
                    kdvliToplam += tişört.KDVfiyat;
                    label3.Text = kdvliToplam.ToString("C2");


                }
            }

            lstSepet.Items.Clear();
            toplamtutar = 0;
            lblToplamTutar.Text = toplamtutar.ToString("C2");
            lstPantolon.SelectedItem = null;
            lstMont.SelectedItem = null;
            lstTshirt.SelectedItem = null;
            lstAyakkabi.SelectedItem = null;

          
        }
    }
}
