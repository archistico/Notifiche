namespace NotifichePauseW
{
    partial class frmConfigurazione
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConfigurazione));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.nudMinuti = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbxTitolo = new System.Windows.Forms.TextBox();
            this.tbxTesto = new System.Windows.Forms.TextBox();
            this.btnSalva = new System.Windows.Forms.Button();
            this.btnMinimizza = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.tsManca = new System.Windows.Forms.ToolStripStatusLabel();
            this.nudSvegliaOra = new System.Windows.Forms.NumericUpDown();
            this.nudSvegliaMinuto = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tbxSvegliaTitolo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tbxSvegliaTesto = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSalvaSveglia = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSvegliaOra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSvegliaMinuto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Notifiche ripetute";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(104, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Minuti tra le notifiche";
            // 
            // nudMinuti
            // 
            this.nudMinuti.Location = new System.Drawing.Point(16, 84);
            this.nudMinuti.Maximum = new decimal(new int[] {
            480,
            0,
            0,
            0});
            this.nudMinuti.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudMinuti.Name = "nudMinuti";
            this.nudMinuti.Size = new System.Drawing.Size(100, 20);
            this.nudMinuti.TabIndex = 3;
            this.nudMinuti.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(122, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Titolo notifica";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(364, 68);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Testo notifica";
            // 
            // tbxTitolo
            // 
            this.tbxTitolo.Location = new System.Drawing.Point(125, 84);
            this.tbxTitolo.Name = "tbxTitolo";
            this.tbxTitolo.Size = new System.Drawing.Size(235, 20);
            this.tbxTitolo.TabIndex = 6;
            // 
            // tbxTesto
            // 
            this.tbxTesto.Location = new System.Drawing.Point(367, 84);
            this.tbxTesto.Name = "tbxTesto";
            this.tbxTesto.Size = new System.Drawing.Size(235, 20);
            this.tbxTesto.TabIndex = 7;
            // 
            // btnSalva
            // 
            this.btnSalva.Image = global::NotifichePause.Properties.Resources.salva;
            this.btnSalva.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalva.Location = new System.Drawing.Point(608, 76);
            this.btnSalva.Name = "btnSalva";
            this.btnSalva.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSalva.Size = new System.Drawing.Size(78, 33);
            this.btnSalva.TabIndex = 8;
            this.btnSalva.Text = "Salva";
            this.btnSalva.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalva.UseVisualStyleBackColor = true;
            this.btnSalva.Click += new System.EventHandler(this.btnSalva_Click);
            // 
            // btnMinimizza
            // 
            this.btnMinimizza.Image = global::NotifichePause.Properties.Resources.minimizza;
            this.btnMinimizza.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMinimizza.Location = new System.Drawing.Point(598, 10);
            this.btnMinimizza.Name = "btnMinimizza";
            this.btnMinimizza.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnMinimizza.Size = new System.Drawing.Size(88, 33);
            this.btnMinimizza.TabIndex = 9;
            this.btnMinimizza.Text = "Riduci";
            this.btnMinimizza.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMinimizza.UseVisualStyleBackColor = true;
            this.btnMinimizza.Click += new System.EventHandler(this.btnMinimizza_Click);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon1.Icon")));
            this.notifyIcon1.Text = "Notifiche pause";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseDoubleClick);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsManca});
            this.statusStrip1.Location = new System.Drawing.Point(0, 377);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(700, 22);
            this.statusStrip1.SizingGrip = false;
            this.statusStrip1.TabIndex = 10;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // tsManca
            // 
            this.tsManca.Name = "tsManca";
            this.tsManca.Size = new System.Drawing.Size(12, 17);
            this.tsManca.Text = "-";
            // 
            // nudSvegliaOra
            // 
            this.nudSvegliaOra.Location = new System.Drawing.Point(17, 169);
            this.nudSvegliaOra.Maximum = new decimal(new int[] {
            23,
            0,
            0,
            0});
            this.nudSvegliaOra.Name = "nudSvegliaOra";
            this.nudSvegliaOra.Size = new System.Drawing.Size(48, 20);
            this.nudSvegliaOra.TabIndex = 11;
            // 
            // nudSvegliaMinuto
            // 
            this.nudSvegliaMinuto.Location = new System.Drawing.Point(71, 169);
            this.nudSvegliaMinuto.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudSvegliaMinuto.Name = "nudSvegliaMinuto";
            this.nudSvegliaMinuto.Size = new System.Drawing.Size(48, 20);
            this.nudSvegliaMinuto.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 153);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(24, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Ora";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(68, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Minuto";
            // 
            // tbxSvegliaTitolo
            // 
            this.tbxSvegliaTitolo.Location = new System.Drawing.Point(126, 168);
            this.tbxSvegliaTitolo.Name = "tbxSvegliaTitolo";
            this.tbxSvegliaTitolo.Size = new System.Drawing.Size(150, 20);
            this.tbxSvegliaTitolo.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(123, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Titolo notifica";
            // 
            // tbxSvegliaTesto
            // 
            this.tbxSvegliaTesto.Location = new System.Drawing.Point(282, 168);
            this.tbxSvegliaTesto.Name = "tbxSvegliaTesto";
            this.tbxSvegliaTesto.Size = new System.Drawing.Size(320, 20);
            this.tbxSvegliaTesto.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(280, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Testo notifica";
            // 
            // dgv
            // 
            this.dgv.AllowUserToAddRows = false;
            this.dgv.AllowUserToDeleteRows = false;
            this.dgv.AllowUserToResizeColumns = false;
            this.dgv.AllowUserToResizeRows = false;
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Location = new System.Drawing.Point(17, 197);
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowHeadersVisible = false;
            this.dgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv.Size = new System.Drawing.Size(585, 163);
            this.dgv.TabIndex = 19;
            this.dgv.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_CellClick);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(13, 127);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(67, 20);
            this.label9.TabIndex = 20;
            this.label9.Text = "Sveglie";
            // 
            // btnSalvaSveglia
            // 
            this.btnSalvaSveglia.Image = global::NotifichePause.Properties.Resources.salva;
            this.btnSalvaSveglia.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalvaSveglia.Location = new System.Drawing.Point(608, 161);
            this.btnSalvaSveglia.Name = "btnSalvaSveglia";
            this.btnSalvaSveglia.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.btnSalvaSveglia.Size = new System.Drawing.Size(78, 33);
            this.btnSalvaSveglia.TabIndex = 21;
            this.btnSalvaSveglia.Text = "Salva";
            this.btnSalvaSveglia.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalvaSveglia.UseVisualStyleBackColor = true;
            this.btnSalvaSveglia.Click += new System.EventHandler(this.btnSalvaSveglia_Click);
            // 
            // frmConfigurazione
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 399);
            this.Controls.Add(this.btnSalvaSveglia);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgv);
            this.Controls.Add(this.tbxSvegliaTesto);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.tbxSvegliaTitolo);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nudSvegliaMinuto);
            this.Controls.Add(this.nudSvegliaOra);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnMinimizza);
            this.Controls.Add(this.btnSalva);
            this.Controls.Add(this.tbxTesto);
            this.Controls.Add(this.tbxTitolo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nudMinuti);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmConfigurazione";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notifiche";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudMinuti)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudSvegliaOra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudSvegliaMinuto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown nudMinuti;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbxTitolo;
        private System.Windows.Forms.TextBox tbxTesto;
        private System.Windows.Forms.Button btnSalva;
        private System.Windows.Forms.Button btnMinimizza;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel tsManca;
        private System.Windows.Forms.NumericUpDown nudSvegliaOra;
        private System.Windows.Forms.NumericUpDown nudSvegliaMinuto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbxSvegliaTitolo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbxSvegliaTesto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnSalvaSveglia;
    }
}

