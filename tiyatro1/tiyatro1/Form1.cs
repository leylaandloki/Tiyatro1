using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tiyatro1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatro tiyatro;
        List<Tiyatro> tiyatrolist = new List<Tiyatro>();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatrolist.Add(new Tiyatro (1, "Güle Ağıt",  120, new DateTime(2023, 12, 19), "Harbiye Muhsin Ertuğrul Sahnesi",110.30,false));
            tiyatrolist.Add(new Tiyatro(2, "Komik Para", 140, new DateTime(2023, 12, 30), "Harbiye Cemil Topuzlu Açıkhava Tiyatrosu", 114.30, true));
            dgvTiyatro.DataSource=tiyatrolist.ToList();
        }

        private void dgvTiyatro_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtOyunId.Text = dgvTiyatro.CurrentRow.Cells["id"].Value.ToString();
            cmbOyunAdi.Text = dgvTiyatro.CurrentRow.Cells["oyunad"].Value.ToString();
            nduSure.Value = (int)dgvTiyatro.CurrentRow.Cells["oyunsuresi"].Value;
            dtpTarih.Value = (DateTime)dgvTiyatro.CurrentRow.Cells["oyuntarihi"].Value;
            cmbSahne.Text = dgvTiyatro.CurrentRow.Cells["sahne"].Value.ToString();
            txtFiyat.Text = dgvTiyatro.CurrentRow.Cells["fiyat"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvTiyatro.CurrentRow.Cells["muzikal"].Value;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtOyunId.Text);
            string oyunAdi=cmbOyunAdi.Text;
            int sure = Convert.ToInt32(nduSure.Value);
            DateTime tarih=dtpTarih.Value;
            string sahne=cmbSahne.Text;
            double fiyat= Convert.ToDouble(txtFiyat.Text);
            bool muzikal=chkMuzikal.Checked;

            Tiyatro yenitiyatro1 = new Tiyatro (id, oyunAdi, sure, tarih, sahne,fiyat ,muzikal);
            tiyatrolist.Add (yenitiyatro1);
            dgvTiyatro.DataSource=tiyatrolist.ToList();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir=dgvTiyatro.SelectedRows[0];
            Tiyatro secilentiyatro=secilensatir.DataBoundItem as Tiyatro;
            DialogResult result = MessageBox.Show("Secilen Tiyatro Silinsin mi?", "Tiyatro Sil", MessageBoxButtons.YesNo,MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                tiyatrolist.Remove(secilentiyatro);
            }
            dgvTiyatro.DataSource = tiyatrolist.ToList();
        }

        private void btnGuncele_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilensatir=dgvTiyatro.SelectedRows[0];
            Tiyatro secilentiyatro=secilensatir.DataBoundItem as Tiyatro ;
            int id = Convert.ToInt32(txtOyunId.Text);
            string oyunAdi = cmbOyunAdi.Text;
            int sure = Convert.ToInt32(nduSure.Value);
            DateTime tarih = dtpTarih.Value;
            string sahne = cmbSahne.Text;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            bool muzikal = chkMuzikal.Checked;
            secilentiyatro.Id = id;
            secilentiyatro.Oyunad=oyunAdi;
            secilentiyatro.Oyunsuresi=sure;
            secilentiyatro.Oyuntarihi=tarih;
            secilentiyatro.Sahne=sahne;
            secilentiyatro.Fiyat=fiyat;
            secilentiyatro.Muzikal=muzikal;
            dgvTiyatro.DataSource = null;
            dgvTiyatro.DataSource = tiyatrolist.ToList();
        }
    }
}
