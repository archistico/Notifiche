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
    public partial class frmConfigurazione : Form
    {
        string pathConfigurazione = "configurazione_notifiche.json";
        string pathSveglie = "sveglie_notifiche.json";

        Configurazione configurazione = new Configurazione();
        Sveglie sveglie = new Sveglie();

        DateTime inizio = DateTime.Now;

        public frmConfigurazione()
        {
            InitializeComponent();
        }

        private void LanciaNotifica(string titolo, string testo)
        {
            new ToastContentBuilder()
                .AddText($"Sono le {DateTime.Now.ToString("HH:mm")} - {titolo}")
                .AddText(testo)
                .AddButton(new ToastButton().SetContent("OK"))
                .Show(toast =>
                {
                    toast.ExpirationTime = DateTime.Now.AddSeconds(10);
                })
                ;
        }

        private void btnSalva_Click(object sender, EventArgs e)
        {
            inizio = DateTime.Now;

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
            this.WindowState = FormWindowState.Minimized;

            if (File.Exists(pathConfigurazione))
            {
                string conf_json = File.ReadAllText(pathConfigurazione);
                configurazione = JsonSerializer.Deserialize<Configurazione>(conf_json);

                tbxTitolo.Text = configurazione.Titolo;
                tbxTesto.Text = configurazione.Testo;
                nudMinuti.Value = configurazione.Minuti;
            }

            if (File.Exists(pathSveglie))
            {
                string sveglie_json = File.ReadAllText(pathSveglie);
                sveglie = JsonSerializer.Deserialize<Sveglie>(sveglie_json);
            }

            RiazzeraSveglie(sveglie);
            AggiornaDGV();

            configurazione.Minuti = (int)nudMinuti.Value;
            configurazione.Titolo = tbxTitolo.Text;
            configurazione.Testo = tbxTesto.Text;

            nudSvegliaOra.Value = DateTime.Now.Hour;
            nudSvegliaMinuto.Value = DateTime.Now.Minute;

            timer1.Enabled = true;
        }

        private void RiazzeraSveglie(Sveglie s)
        {
            foreach(Sveglia el in s.lista)
            {
                el.Eseguita = false;
            }
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

            if (this.WindowState == FormWindowState.Normal)
            {
                nudSvegliaOra.Value = DateTime.Now.Hour;
                nudSvegliaMinuto.Value = DateTime.Now.Minute;
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
            // Controlla notifiche ripetute

            DateTime ora = DateTime.Now;
            int diffInSeconds = (int)(ora - inizio).TotalSeconds;

            DateTime scadenza = inizio.AddMinutes(configurazione.Minuti);

            string testo = $"Mancano {(scadenza - ora).TotalMinutes.ToString("N1")} minuti alla notifica";
            tsManca.Text = testo;
            notifyIcon1.Text = $"Notifiche - {testo}";

            if (diffInSeconds >= (configurazione.Minuti * 60))
            {
                LanciaNotifica(tbxTitolo.Text, tbxTesto.Text);
                inizio = DateTime.Now;
            }

            // Controlla sveglia
            foreach (Sveglia el in sveglie.lista)
            {
                if (ora.Hour == el.Ora && ora.Minute == el.Minuti && el.Eseguita == false)
                {
                    el.Eseguita = true;
                    LanciaNotifica(el.Titolo, el.Testo);
                }
            }

            // Cambia orario
            lblData.Text = ora.ToString("dddd").ToUpper() + " " + ora.ToString("dd/MM/yyyy HH:mm:ss");
        }

        private void btnSalvaSveglia_Click(object sender, EventArgs e)
        {
            Sveglia sveglia = new Sveglia()
            {
                Ora = (int)nudSvegliaOra.Value,
                Minuti = (int)nudSvegliaMinuto.Value,
                Titolo = tbxSvegliaTitolo.Text,
                Testo = tbxSvegliaTesto.Text,
                Eseguita = false
            };            

            sveglie.lista.Add(sveglia);

            SalvaSveglie();
            AggiornaDGV();
        }

        private void SalvaSveglie()
        {
            if(sveglie.lista.Count >= 0)
            {
                string sveglie_json = JsonSerializer.Serialize(sveglie);
                using (StreamWriter writer = new StreamWriter(pathSveglie))
                {
                    writer.WriteLine(sveglie_json);
                }
            }            
        }

        private void AggiornaDGV()
        {
            dgv.Columns.Clear();
            dgv.DataSource = null;

            if (sveglie.lista.Count == 0) return;

            dgv.DataSource = sveglie.lista;

            dgv.AlternatingRowsDefaultCellStyle.BackColor = Color.WhiteSmoke;
            dgv.MultiSelect = false;

            int indice = 0;

            dgv.Columns["Ora"].DisplayIndex = indice;
            dgv.Columns["Ora"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Ora"].Width = 50;
            dgv.Columns["Ora"].HeaderText = "Ora";

            indice++;
            dgv.Columns["Minuti"].DisplayIndex = indice;
            dgv.Columns["Minuti"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Minuti"].Width = 50;
            dgv.Columns["Minuti"].HeaderText = "Minuti";

            indice++;
            dgv.Columns["Titolo"].DisplayIndex = indice;
            dgv.Columns["Titolo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Titolo"].Width = 155;
            dgv.Columns["Titolo"].HeaderText = "Titolo";

            indice++;
            dgv.Columns["Testo"].DisplayIndex = indice;
            dgv.Columns["Testo"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgv.Columns["Testo"].MinimumWidth = 200;
            dgv.Columns["Testo"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns["Testo"].HeaderText = "Testo";

            indice++;
            dgv.Columns["Eseguita"].DisplayIndex = indice;
            dgv.Columns["Eseguita"].Visible = false;

            var deleteButtonColumn = new DataGridViewImageColumn();
            deleteButtonColumn.Name = "Canc";
            deleteButtonColumn.Width = 35;
            deleteButtonColumn.Image = NotifichePause.Properties.Resources.cancella;

            dgv.Columns.Add(deleteButtonColumn);

            indice++;
            dgv.Columns["Canc"].DisplayIndex = indice;
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dgv.Columns.Contains("Canc") == false)
                return;

            // se lo metto dopo la cancellazione della riga mi da errore
            if (!e.ColumnIndex.Equals(dgv.Columns["Canc"].Index))
            {
                Sveglia s = sveglie.lista.ElementAt(e.RowIndex);
                nudSvegliaOra.Value = s.Ora;
                nudSvegliaMinuto.Value = s.Minuti;
                tbxSvegliaTitolo.Text = s.Titolo;
                tbxSvegliaTesto.Text = s.Testo;
            }

            if (e.ColumnIndex.Equals(dgv.Columns["Canc"].Index))
            {
                if (sveglie.lista.Count > 0)
                {
                  sveglie.lista.RemoveAt(e.RowIndex);

                  SalvaSveglie();
                  AggiornaDGV();
                }                
            }           

        }

        private void btnEsci_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
