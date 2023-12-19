namespace tiyatro1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.chkMuzikal = new System.Windows.Forms.CheckBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.cmbSahne = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOyunId = new System.Windows.Forms.TextBox();
            this.nduSure = new System.Windows.Forms.NumericUpDown();
            this.cmbOyunAdi = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtFiyat = new System.Windows.Forms.TextBox();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGuncele = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dgvTiyatro = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.nduSure)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).BeginInit();
            this.SuspendLayout();
            // 
            // chkMuzikal
            // 
            this.chkMuzikal.AutoSize = true;
            this.chkMuzikal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.chkMuzikal.Location = new System.Drawing.Point(691, 48);
            this.chkMuzikal.Name = "chkMuzikal";
            this.chkMuzikal.Size = new System.Drawing.Size(92, 28);
            this.chkMuzikal.TabIndex = 0;
            this.chkMuzikal.Text = "Müzikal";
            this.chkMuzikal.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnEkle.Image = global::tiyatro1.Properties.Resources._002_diskette;
            this.btnEkle.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnEkle.Location = new System.Drawing.Point(266, 159);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(153, 56);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // cmbSahne
            // 
            this.cmbSahne.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbSahne.FormattingEnabled = true;
            this.cmbSahne.Items.AddRange(new object[] {
            "Beylikdüzü Fatih Sultan Mehmet Kültür Sanat Merkezi Rasim Öztekin Sahnesi",
            "Fatih Reşat Nuri Sahnesi",
            "Gaziosmanpaşa Ferih Egemen Çocuk Tiyatrosu Sahnesi",
            "Gaziosmanpaşa Sahnesi",
            "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu",
            "Harbiye Muhsin Ertuğrul Sahnesi"});
            this.cmbSahne.Location = new System.Drawing.Point(459, 72);
            this.cmbSahne.Name = "cmbSahne";
            this.cmbSahne.Size = new System.Drawing.Size(199, 28);
            this.cmbSahne.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(46, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Oyun İd";
            // 
            // txtOyunId
            // 
            this.txtOyunId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtOyunId.Location = new System.Drawing.Point(128, 35);
            this.txtOyunId.Name = "txtOyunId";
            this.txtOyunId.Size = new System.Drawing.Size(200, 26);
            this.txtOyunId.TabIndex = 4;
            // 
            // nduSure
            // 
            this.nduSure.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.nduSure.Location = new System.Drawing.Point(128, 113);
            this.nduSure.Maximum = new decimal(new int[] {
            360,
            0,
            0,
            0});
            this.nduSure.Name = "nduSure";
            this.nduSure.Size = new System.Drawing.Size(198, 26);
            this.nduSure.TabIndex = 5;
            // 
            // cmbOyunAdi
            // 
            this.cmbOyunAdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.cmbOyunAdi.FormattingEnabled = true;
            this.cmbOyunAdi.Items.AddRange(new object[] {
            "Gül\'e Ağıt",
            "İfigenya",
            "Komik Para",
            "Çingene Boksör",
            "Fosforlu Cevriye",
            "Cadı Kazanı",
            "Gidiş Dönüş Moskova (Retro)",
            "Oscar"});
            this.cmbOyunAdi.Location = new System.Drawing.Point(126, 72);
            this.cmbOyunAdi.Name = "cmbOyunAdi";
            this.cmbOyunAdi.Size = new System.Drawing.Size(199, 28);
            this.cmbOyunAdi.TabIndex = 6;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.dtpTarih.Location = new System.Drawing.Point(461, 33);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 26);
            this.dtpTarih.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(33, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "Oyun Adı";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(0, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 24);
            this.label3.TabIndex = 9;
            this.label3.Text = "Oyun   Süresi";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(343, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 24);
            this.label4.TabIndex = 10;
            this.label4.Text = "Oyun  Tarihi";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label5.Location = new System.Drawing.Point(389, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 24);
            this.label5.TabIndex = 11;
            this.label5.Text = "Sahne";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label6.Location = new System.Drawing.Point(405, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "Fiyat";
            // 
            // txtFiyat
            // 
            this.txtFiyat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtFiyat.Location = new System.Drawing.Point(462, 112);
            this.txtFiyat.Name = "txtFiyat";
            this.txtFiyat.Size = new System.Drawing.Size(200, 26);
            this.txtFiyat.TabIndex = 13;
            // 
            // btnSil
            // 
            this.btnSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSil.Image = global::tiyatro1.Properties.Resources._003_bin;
            this.btnSil.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnSil.Location = new System.Drawing.Point(425, 159);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(153, 56);
            this.btnSil.TabIndex = 14;
            this.btnSil.Text = "Sil";
            this.btnSil.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnGuncele
            // 
            this.btnGuncele.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGuncele.Image = global::tiyatro1.Properties.Resources._001_refresh;
            this.btnGuncele.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btnGuncele.Location = new System.Drawing.Point(584, 159);
            this.btnGuncele.Name = "btnGuncele";
            this.btnGuncele.Size = new System.Drawing.Size(153, 56);
            this.btnGuncele.TabIndex = 15;
            this.btnGuncele.Text = "Güncele";
            this.btnGuncele.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnGuncele.UseVisualStyleBackColor = true;
            this.btnGuncele.Click += new System.EventHandler(this.btnGuncele_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtOyunId);
            this.groupBox1.Controls.Add(this.btnGuncele);
            this.groupBox1.Controls.Add(this.chkMuzikal);
            this.groupBox1.Controls.Add(this.btnSil);
            this.groupBox1.Controls.Add(this.btnEkle);
            this.groupBox1.Controls.Add(this.txtFiyat);
            this.groupBox1.Controls.Add(this.cmbSahne);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.nduSure);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.cmbOyunAdi);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpTarih);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(3, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(794, 238);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // dgvTiyatro
            // 
            this.dgvTiyatro.AllowUserToAddRows = false;
            this.dgvTiyatro.AllowUserToDeleteRows = false;
            this.dgvTiyatro.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTiyatro.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTiyatro.Location = new System.Drawing.Point(3, 233);
            this.dgvTiyatro.Name = "dgvTiyatro";
            this.dgvTiyatro.ReadOnly = true;
            this.dgvTiyatro.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTiyatro.Size = new System.Drawing.Size(794, 217);
            this.dgvTiyatro.TabIndex = 17;
            this.dgvTiyatro.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTiyatro_CellEnter);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTiyatro);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nduSure)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTiyatro)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.CheckBox chkMuzikal;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.ComboBox cmbSahne;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOyunId;
        private System.Windows.Forms.NumericUpDown nduSure;
        private System.Windows.Forms.ComboBox cmbOyunAdi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtFiyat;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGuncele;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dgvTiyatro;
    }
}

