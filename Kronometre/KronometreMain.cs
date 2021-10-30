using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kronometre
{
    public partial class FormKronometre : Form
    {
        //Kerem Zayim Tarafından Yapılmıştır!
        //Tasima Islemi
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();
        //
        public FormKronometre()
        {
            InitializeComponent();
        }

        private void FormKronometre_Load(object sender, EventArgs e)
        {
            btnBaslatDurdur.Text = "Baslat";
        }

        //Exit Butonu
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TasimaIslemi(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }
        int salise = 0, saniye = 0, dakika = 0, saat = 0;
        private void timerSaat_Tick(object sender, EventArgs e)
        {
            saat++;
            lblSaat.Text = Convert.ToString(saat + ":");
            if (saat == 24)
            {
                saat = 0;
            }
        }

        private void timerDakika_Tick(object sender, EventArgs e)
        {
            dakika++;
            lblDakika.Text = Convert.ToString(dakika);
            if (dakika == 60)
            {
                dakika = 0;
            }
        }

        private void timerSaniye_Tick(object sender, EventArgs e)
        {
            saniye++;
            lblSaniye.Text = Convert.ToString(saniye + ":");
            if (saniye == 60)
            {
                saniye = 0;
            }
        }

        private void timerSalise_Tick(object sender, EventArgs e)
        {
            salise++;
            lblSalise.Text = Convert.ToString(salise);
            if (salise == 100)
            {
                salise = 0;
            }
        }

        private void btnBaslatDurdur_Click(object sender, EventArgs e)
        {
            if (btnBaslatDurdur.Text == "Baslat")
            {
                btnBaslatDurdur.Text = "Durdur";
                timerSalise.Enabled = true;
                timerSaniye.Enabled = true;
                timerDakika.Enabled = true;
                timerSaat.Enabled = true;


            }
            else if (btnBaslatDurdur.Text == "Durdur")
            {
                btnBaslatDurdur.Text = "Baslat";
                timerSalise.Enabled = false;
                timerSaniye.Enabled = false;
                timerDakika.Enabled = false;
                timerSaat.Enabled = false;
            }
        }

        private void btnSifirla_Click(object sender, EventArgs e)
        {
            btnBaslatDurdur.Text = "Baslat";
            timerSalise.Enabled = false;
            timerSaniye.Enabled = false;
            timerDakika.Enabled = false;
            timerSaat.Enabled = false;

            salise = 0;
            saniye = 0;
            dakika = 0;
            saat = 0;

            lblSalise.Text = "00";
            lblSaniye.Text = "00:";
            lblDakika.Text = "00:";
            lblSaat.Text = "00:";
        }
    }
}
