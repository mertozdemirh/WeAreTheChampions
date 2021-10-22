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

        private void button6_Click(object sender, EventArgs e)
        {
            TakimOlustur();
            

        }
    }
}
