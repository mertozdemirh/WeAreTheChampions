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
            dgvKarsilasmalar.AutoGenerateColumns = false;
            lblRenk.Width = 64;
            lblRenk.Height = 64;
            RenkleriListele();
            TakimlariListele();
            KarsilasmalariListele();
            TakimlariGoruntule();



        }

        private void KarsilasmalariListele()
        {
            //dgvKarsilasmalar.Rows.Clear();

            //foreach (var item in db.Matches)
            //{
            //    dgvKarsilasmalar.Rows.Add(item.Id, item.Team1, item.Team2, item.TarihText, item.Score1, item.Score2, item.Result);
            //}

            dgvKarsilasmalar.DataSource = db.Matches.ToList();
        }

        private void RenkleriListele()
        {
            cboRenk1.DataSource = db.Colors.ToList();
            cboRenk2.DataSource = db.Colors.ToList();
        }

        private void TakimlariListele()
        {
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

  
            var color1 = (models.Color)cboRenk1.SelectedItem;
            var color2 = (models.Color)cboRenk2.SelectedItem;

            lblRenk1.BackColor = System.Drawing.Color.FromArgb(color1.Red, color1.Green, color1.Blue);
            lblRenk2.BackColor = System.Drawing.Color.FromArgb(color2.Red, color2.Green, color2.Blue);

            db.Teams.Add(team);            
            db.SaveChanges();
            TakimlariGoruntule();
 
        }

        private void TakimlariGoruntule()
        {
            lstMevcutTakimlar.DataSource = db.Teams.ToList();
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
            RenkleriListele();
        }

        private void btnRengiOlustur_Click(object sender, EventArgs e)
        {
            RengiOlustur();
            lblRenk.BackColor = System.Drawing.Color.FromArgb((byte)nudKirmizi.Value, (byte)nudYesil.Value, (byte)nudMavi.Value);
        }

        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            TakimOlustur();
            TakimlariListele();            
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

        private void btnCikart_Click(object sender, EventArgs e)
        {
            int id = (int)lstMevcutTakimlar.SelectedValue;
            var sil = db.Teams.Where(x => x.Id == id).FirstOrDefault();
            db.Teams.Remove(sil);
            try
            {
                db.SaveChanges();
            }
            catch (Exception)
            {
                MessageBox.Show("Bu takımın çok derin bir gecmisi var silemezsiniz.");
                return;
            }
            
            TakimlariListele();
            TakimlariGoruntule();
        }

        private void btnYeniKarsilasma_Click(object sender, EventArgs e)
        {
            var frmKarsilastirma = new YeniKarsilasmaEkle(db);
            frmKarsilastirma.ShowDialog();

            KarsilasmalariListele();


        }

        private void btnSecileniSil_Click(object sender, EventArgs e)
        {
            if (dgvKarsilasmalar.SelectedRows.Count != 1)
            {
                return;
            }
            int id = ((Match) dgvKarsilasmalar.SelectedRows[0].DataBoundItem).Id;
            var sil = db.Matches.Where(x => x.Id == id).FirstOrDefault();

            if (dgvKarsilasmalar.Rows.Count>-1)
            {
                db.Matches.Remove(sil);
                db.SaveChanges();
            }
            KarsilasmalariListele();
            
        }

        //TODO: Takım çıkart, karşılaşma ekranını düzenle
    }
}
