using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SystemIOWindowsFormApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Global alan

        VeriIslemleri veriIslemleri = new VeriIslemleri();
        Personel secilenPersonel = null;

        private void Form1_Load(object sender, EventArgs e)
        {
            btnPersonelGetir.Click += new EventHandler(btnPersonelGetir_Click);

            listBoxPersoneller.DoubleClick += new EventHandler(listBoxPersoneller_DoubleClick);

            btnKaydet.Click += new EventHandler(btnPersonelKaydet_Click);

            foreach (var item in this.Controls)
            {
                var theItem = item.GetType();
                if (theItem.Name == "GroupBox" && ((GroupBox)item).Name== "groupBoxPersonelDetay")
                {
                    foreach (var subitems in ((GroupBox)item).Controls)
                    {
                        if (subitems is TextBox)
                        {
                            ((TextBox)subitems).ReadOnly = true;
                        }
                    }
                }
            }
        }

        private void btnPersonelKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                //dosyaYolu
                if (secilenPersonel != null)
                {
                    string kayitOlduguYolBilgisi = string.Empty;
                    bool kontrol =
                    veriIslemleri.PersoneliKaydet("C:\\NetworkAkademi", secilenPersonel,out kayitOlduguYolBilgisi);
                    if (kontrol)
                    {
                        MessageBox.Show($"{secilenPersonel.ToString()} bilgisayara kaydoldu.. \n" +
                            $"Yol: {kayitOlduguYolBilgisi}");
                    }
                    else
                    {
                        MessageBox.Show($"HATA: {secilenPersonel.ToString()} bilgisayara kayıt olamadı...");
                    }
                }
                else
                {
                    MessageBox.Show("Lütfen listeden personel seçiniz...");
                    //temizlik textler ve listbox
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void listBoxPersoneller_DoubleClick(object sender, EventArgs e)
        {
           secilenPersonel = listBoxPersoneller.SelectedItem as Personel;

            txtAd.Text = secilenPersonel.Isim;
            txtSoyad.Text = secilenPersonel.Soyisim;
            txtEmail.Text = secilenPersonel.Email;
            txtFirma.Text = secilenPersonel.Firma;
            txtUlke.Text = secilenPersonel.Ulke;
        }

        private void btnPersonelGetir_Click(object sender, EventArgs e)
        {
            //FakeData'dan 5 personel aldık.
           listBoxPersoneller.DataSource = veriIslemleri.Personellerigetir();
        }
    }
}
