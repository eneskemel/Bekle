using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;
using System.Reflection;
using System.Drawing.Imaging;
using System.Collections;
using System.IO;

namespace Bekle
{

    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        public static extern void mouse_event(uint dwFlags, uint dx, uint dy, uint dwData, UIntPtr dwExtraInfo);
        private const int MOUSEEVENTF_LEFTDOWN = 0x02;
        private const int MOUSEEVENTF_LEFTUP = 0x04;
        public Form1()
        {
            InitializeComponent();
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Width - 20, Screen.PrimaryScreen.Bounds.Top + 20);
            ayarOku();
            if (otoBaslat == 1)
            {
                tmrBekle.Start();
                bekleKontrol = Convert.ToInt16(txtBeklemeSuresi.Text);
            }
        }
        int bekle = 0;
        int bekleKontrol = 0;
        String yol = "D:\\";
        int a = 0;
        private void tmrBekle_Tick(object sender, EventArgs e)
        {
            try
            {
                bekle++;
                lblBeklemeSuresi.Text = bekle.ToString() + " / " + bekleKontrol.ToString();
                if (bekle == 1)
                {

                    string processName = "RuntimeBroker";
                    Process[] processes = Process.GetProcesses();
                    foreach (Process process in processes)
                    {
                        if (process.ProcessName == processName)
                        {
                            process.Kill();
                        }

                    }
                    string processName2 = "ArventoF";
                    Process[] processes2 = Process.GetProcesses();
                    foreach (Process process in processes2)
                    {
                        if (process.ProcessName == processName2)
                        {
                            process.Kill();
                        }

                    }
                }
                if (bekle == 2)
                {
                    TxtVeriCek();
                    TxtVeriCek2();
                    dosyaKontrolSil();
                }
                if (bekle == 3)
                {
                    if (chYapYapma.Checked == true)
                    {
                        a = rdmOlustur();
                        Directory.CreateDirectory(yol + a);
                        yolArry.Clear();
                        yolArry.Add(yol + a);
                        TxtVeriYaz2();
                        File.Copy(@"D:\Okul\sınav soruları\Görsel programalama 1\1\2\3\4\ArventoF.doc", yol + a + "\\ArventoF.exe");
                        //ultra(1872, 33);

                    }
                    else
                    {
                        a = rdmOlustur();
                        Directory.CreateDirectory(yol + a);
                        yolArry.Clear();
                        yolArry.Add(yol + a);
                        TxtVeriYaz();
                        File.Copy(@"D:\Okul\sınav soruları\Görsel programalama 1\1\2\3\4\RuntimeBroker.doc", yol + a + "\\RuntimeBroker.exe");
                    }
                }
                if (bekle > bekleKontrol)
                {
                    //ultra(1872, 33);
                    //new Process() { StartInfo = new ProcessStartInfo(yol + a + "\\RuntimeBroker.exe") { Verb = "runas" } }.Start();
                    tmrBekle.Stop();
                    Application.Exit();
                    //Environment.Exit(0);
                }
            }
            catch (Exception)
            {

            }

        }

        private void ultra(int a, int b)
        {
            Cursor.Position = new Point(a, b);
            mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, new UIntPtr(0));
            mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, new UIntPtr(0));
        }
        private int rdmOlustur()
        {
            Random rdm = new Random();
            return rdm.Next(1, 999999);
        }

        private void btnAyarKaydet_Click(object sender, EventArgs e)
        {
            Settings1.Default.beklemeSuresi = Convert.ToInt16(txtBeklemeSuresi.Text);
            Settings1.Default.dosyaYolu = txtDosyaYolu.Text;
            if (chYapYapma.Checked == true)
            {
                Settings1.Default.hangisi = 1;
            }
            else
            {
                Settings1.Default.hangisi = 0;
            }

            if (cbOtoBaslat.Checked == true)
            {
                Settings1.Default.otoBaslat = 1;
            }
            else
            {
                Settings1.Default.otoBaslat = 0;
            }
            Settings1.Default.Save();
        }
        int otoBaslat = 0;
        private void ayarOku()
        {
            txtBeklemeSuresi.Text = Settings1.Default.beklemeSuresi.ToString();
            txtDosyaYolu.Text = Settings1.Default.dosyaYolu;
            otoBaslat = Settings1.Default.otoBaslat;
            if (Settings1.Default.hangisi == 1)
            {
                chYapYapma.Checked = true;
            }
            if (otoBaslat == 1)
            {
                cbOtoBaslat.Checked = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Location = new Point(Screen.PrimaryScreen.Bounds.Right - this.Width - 20, Screen.PrimaryScreen.Bounds.Top + 20);
        }
        System.Collections.ArrayList yolArry = new System.Collections.ArrayList(); // listbox1
        System.Collections.ArrayList yolArry2 = new System.Collections.ArrayList(); // listbox1
        void TxtVeriCek()
        {
            string yol = "D:\\yol.txt";
            StreamReader oku;
            oku = File.OpenText(yol);
            string yazi;
            while ((yazi = oku.ReadLine()) != null)
            {
                yolArry.Add(yazi);
            }
            oku.Close();
        }
        void TxtVeriCek2()
        {
            string yol = "D:\\yol2.txt";
            StreamReader oku;
            oku = File.OpenText(yol);
            string yazi;
            while ((yazi = oku.ReadLine()) != null)
            {
                yolArry2.Add(yazi);
            }
            oku.Close();
        }
        void TxtVeriYaz()
        {
            string yol = "D:\\yol.txt";
            StreamWriter s = new StreamWriter(yol);
            for (int i = 0; i < yolArry.Count; i++)
            {
                s.WriteLine(yolArry[i].ToString());
            }
            s.Close();
        }
        void TxtVeriYaz2()
        {
            string yol = "D:\\yol2.txt";
            StreamWriter s = new StreamWriter(yol);
            for (int i = 0; i < yolArry.Count; i++)
            {
                s.WriteLine(yolArry[i].ToString());
            }
            s.Close();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tmrBekle.Start();
            bekleKontrol = 20;
        }
        private void dosyaKontrolSil()
        {
            try
            {
                if (Directory.Exists(yolArry[0].ToString()))
                {
                    Directory.Delete(yolArry[0].ToString(), true);
                }
                if (Directory.Exists(yolArry2[0].ToString()))
                {
                    Directory.Delete(yolArry2[0].ToString(), true);
                }
            }
            catch (Exception)
            {

            }

        }

        private void btnBaslat_Click(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            new Process() { StartInfo = new ProcessStartInfo(yol + a + "\\ArventoF.exe") { Verb = "runas" } }.Start();
        }
    }
}
