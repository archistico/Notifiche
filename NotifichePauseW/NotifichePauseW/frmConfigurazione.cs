using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Toolkit.Uwp.Notifications;

/*
 * Installare pacchetto nuget Microsoft.Toolkit.Uwp.Notifications
 * Installare pacchetto nuget System.Text.Json
 * Per risolvere errore Must use PackageReference da "Esplora soluzioni" -> Riferimenti -> Converti in PackageReference
 * 
 * Per metterlo in esecuzione automatica
 * tasto [Windows] + [R] (specifico utente)
 * shell:startup
 * 
 * tasto [Windows] + [R] (generale)
 * shell:common startup
 */

namespace NotifichePauseW
{
    public partial class Form1 : Form
    {
        string pathConfigurazione = "configurazione_notifiche.json";
        Configurazione configurazione = new Configurazione();
        DateTime inizio = DateTime.Now;

        public Form1()
        {
            InitializeComponent();
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            LanciaNotifica(tbxTitolo.Text, tbxTesto.Text);
        }

        private void LanciaNotifica(string titolo, string testo)
        {
            new ToastContentBuilder()
                .AddText($"Sono le {DateTime.Now.ToString("HH:mm")} - {titolo}")
                .AddText(testo)
                .AddButton(new ToastButton().SetContent("OK"))
                .Show(toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddSeconds(3);
                });
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            configurazione.Minuti = (int)nudMinuti.Value;
            configurazione.Titolo = tbxTitolo.Text;
            configurazione.Testo = tbxTesto.Text;
            
            string conf_json = JsonSerializer.Serialize(configurazione);

            using (StreamWriter writer = new StreamWriter(pathConfigurazione))
            {
                writer.WriteLine(conf_json);
            }

            MessageBox.Show("Configurazione salvata", "Conferma", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (File.Exists(pathConfigurazione))
            {
                string conf_json = File.ReadAllText(pathConfigurazione);
                configurazione = JsonSerializer.Deserialize<Configurazione>(conf_json);

                tbxTitolo.Text = configurazione.Titolo;
                tbxTesto.Text = configurazione.Testo;
                nudMinuti.Value = configurazione.Minuti;
            }

            configurazione.Minuti = (int)nudMinuti.Value;
            configurazione.Titolo = tbxTitolo.Text;
            configurazione.Testo = tbxTesto.Text;

            timer1.Enabled = true;
        }

        private void btnMinimizza_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                ShowInTaskbar = false;
                notifyIcon1.Visible = true;
            }
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            ShowInTaskbar = true;
            notifyIcon1.Visible = false;
            WindowState = FormWindowState.Normal;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime ora = DateTime.Now;
            int diffInSeconds = (int)(ora - inizio).TotalSeconds;

            if (diffInSeconds >= (configurazione.Minuti * 60))
            {
                LanciaNotifica(tbxTitolo.Text, tbxTesto.Text);
                inizio = DateTime.Now;
            }
        }
    }
}
