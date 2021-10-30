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
    public partial class YeniKarsilasmaEkle : Form
    {
        private readonly WeAreTheChampionsContext db;

        public YeniKarsilasmaEkle(WeAreTheChampionsContext db)
        {
            InitializeComponent();
            this.db = db;
            cboTakim1Karsilasma.DataSource = db.Teams.ToList();
            cboTakim2Karsilasma.DataSource = db.Teams.ToList();
            VerileriYukle();
           
        }


        private void VerileriYukle()
        {
            int id = 1;
            int takim1Id = 0;
            int takim2Id = 0;
            string tarih = "";
            int score1 = 0;
            int score2 = 0;            
            string takimAdi1 = "";
            string takimAdi2 = "";
            


            foreach (var item in db.Matches)
            {
                if (id ==item.Id)
                {
                    takim1Id = item.Team1Id;
                    takim2Id = item.Team2Id;
                    tarih = item.MatchTime.ToString();
                    score1 = item.Score1;
                    score2 = item.Score2;
                    
                }
                id++;
            }
            foreach (var item in db.Teams)
            {
                if (takim1Id==item.Id)
                {
                    takimAdi1 = item.TeamName;
                }
                else if (takim2Id == item.Id)
                {
                    takimAdi2 = item.TeamName;
                }
            }
            db.SaveChanges();
        }

        private void btnMacSonucu_Click(object sender, EventArgs e)
        {
            int a = 0;
            int b = 0;
            int result = 0;

            foreach (var item in db.Teams)
            {
                if (cboTakim1Karsilasma.Text == item.TeamName)
                {
                    a = item.Id;
                }
                if (cboTakim2Karsilasma.Text == item.TeamName)
                {
                    b = item.Id;
                }
            }
            if (nudTakim1Skor.Value == nudTakim2Skor.Value)
            {
                result = 0;
            }
            else if (nudTakim1Skor.Value > nudTakim2Skor.Value)
            {
                result = 1;
            }
            else if (nudTakim1Skor.Value < nudTakim2Skor.Value)
            {
                result = 2;
            }
            Match mac = new Match();
            mac.MatchTime = dtpTarih.Value;
            mac.Team1Id = a;
            mac.Team2Id = b;
            mac.Score1 = (int) nudTakim1Skor.Value;
            mac.Score2 = (int)nudTakim2Skor.Value;
            mac.Result = (Result?)result;

            db.Matches.Add(mac);
            db.SaveChanges();
            VerileriYukle();
            this.Close();

        }
    }
}
