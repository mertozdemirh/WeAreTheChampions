using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeAreTheChampions.models;

namespace WeAreTheChampions
{
    public partial class Form1 : Form
    {
        WeAreTheChampionsContext db = new WeAreTheChampionsContext();
        public Form1()
        {
            InitializeComponent();
            lblRenk.Width = 64;
            lblRenk.Height = 64;
            cboRenk1.DataSource = db.Colors.ToList();
            cboRenk2.DataSource = db.Colors.ToList();
            cboTakimlar.DataSource = db.Teams.ToList();
            cboTakimFiltrele.DataSource = db.Teams.ToList();
            
        }

        private void KisileriListele()
        {
            dgvOyuncular.Rows.Clear();

            foreach (var item in db.Players)
            {
                dgvOyuncular.Rows.Add(item.PlayerName);
            }
        }

        private void TakimOlustur()
        {            
            Team team = new Team();

            if (txtTakimEkle.Text =="")
            {
                return;
            }
            team.TeamName = txtTakimEkle.Text;
            team.Colors.Add((models.Color)cboRenk1.SelectedItem);
            team.Colors.Add((models.Color)cboRenk2.SelectedItem);

            //lblRenk1.BackColor = System.Drawing.Color.FromArgb(new models.Color() { Red, Blue, Green });

            db.Teams.Add(team);
            lstMevcutTakimlar.Items.Add(team.TeamName);
            db.SaveChanges();
 
        }

        private void RengiOlustur()
        {
            if (txtRenkAdi.Text == "")
            {
                return;
            }
            db.Colors.Add(new models.Color()
            {
                ColorName = txtRenkAdi.Text.Trim(),
                Red = (byte)nudKirmizi.Value,
                Green = (byte)nudYesil.Value,
                Blue = (byte)nudMavi.Value
            });
            db.SaveChanges();
        }

        private void btnRengiOlustur_Click(object sender, EventArgs e)
        {
            RengiOlustur();
            lblRenk.BackColor = System.Drawing.Color.FromArgb((byte)nudKirmizi.Value, (byte)nudYesil.Value, (byte)nudMavi.Value);
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            TakimOlustur();
        }


        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (cboTakimlar.SelectedIndex<0 || txtOyuncuAdi.Text=="")
            {
                MessageBox.Show("Lütfen tüm alanları doldurunuz");
                return;
            }
            string oyuncuAdi = txtOyuncuAdi.Text.Trim();
            var takim = cboTakimlar.SelectedIndex + 1;

            db.Players.Add(new Player()
            {
                PlayerName = oyuncuAdi,
                TeamId = takim
            });
            db.SaveChanges();
            KisileriListele();
        }

        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {
            string seciliSatir = dgvOyuncular.CurrentRow.Cells[0].Value.ToString();
            var sil = db.Players.Where(x => x.PlayerName == seciliSatir).FirstOrDefault();
            db.Players.Remove(sil);
            db.SaveChanges();
            KisileriListele();
        }

        private void cboTakimFiltrele_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvFiltre.Rows.Clear();
            int id = 0;
            string takim = "";
            foreach (var item in db.Teams)
            {
                if (cboTakimFiltrele.Text == item.TeamName)
                {
                    id = item.Id;
                    takim = item.TeamName;
                }            
            }
            foreach (var item in db.Players)
            { 
                if (id == item.TeamId)
                {
                    dgvFiltre.Rows.Add(item.PlayerName);
                }
            }
        }
    }
}
