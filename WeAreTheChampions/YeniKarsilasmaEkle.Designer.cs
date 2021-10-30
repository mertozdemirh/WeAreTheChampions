
namespace WeAreTheChampions
{
    partial class YeniKarsilasmaEkle
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
            this.cboTakim1Karsilasma = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cboTakim2Karsilasma = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudTakim1Skor = new System.Windows.Forms.NumericUpDown();
            this.nudTakim2Skor = new System.Windows.Forms.NumericUpDown();
            this.btnMacSonucu = new System.Windows.Forms.Button();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim1Skor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim2Skor)).BeginInit();
            this.SuspendLayout();
            // 
            // cboTakim1Karsilasma
            // 
            this.cboTakim1Karsilasma.DisplayMember = "TeamName";
            this.cboTakim1Karsilasma.FormattingEnabled = true;
            this.cboTakim1Karsilasma.Location = new System.Drawing.Point(83, 72);
            this.cboTakim1Karsilasma.Name = "cboTakim1Karsilasma";
            this.cboTakim1Karsilasma.Size = new System.Drawing.Size(181, 24);
            this.cboTakim1Karsilasma.TabIndex = 0;
            this.cboTakim1Karsilasma.ValueMember = "Id";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(354, 75);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Vs.";
            // 
            // cboTakim2Karsilasma
            // 
            this.cboTakim2Karsilasma.DisplayMember = "TeamName";
            this.cboTakim2Karsilasma.FormattingEnabled = true;
            this.cboTakim2Karsilasma.Location = new System.Drawing.Point(484, 72);
            this.cboTakim2Karsilasma.Name = "cboTakim2Karsilasma";
            this.cboTakim2Karsilasma.Size = new System.Drawing.Size(167, 24);
            this.cboTakim2Karsilasma.TabIndex = 2;
            this.cboTakim2Karsilasma.ValueMember = "Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Takım1:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "Takım2:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(354, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 17);
            this.label4.TabIndex = 5;
            this.label4.Text = "Skor:";
            // 
            // nudTakim1Skor
            // 
            this.nudTakim1Skor.Location = new System.Drawing.Point(204, 177);
            this.nudTakim1Skor.Name = "nudTakim1Skor";
            this.nudTakim1Skor.Size = new System.Drawing.Size(60, 22);
            this.nudTakim1Skor.TabIndex = 6;
            // 
            // nudTakim2Skor
            // 
            this.nudTakim2Skor.Location = new System.Drawing.Point(487, 177);
            this.nudTakim2Skor.Name = "nudTakim2Skor";
            this.nudTakim2Skor.Size = new System.Drawing.Size(58, 22);
            this.nudTakim2Skor.TabIndex = 7;
            // 
            // btnMacSonucu
            // 
            this.btnMacSonucu.Location = new System.Drawing.Point(303, 286);
            this.btnMacSonucu.Name = "btnMacSonucu";
            this.btnMacSonucu.Size = new System.Drawing.Size(157, 59);
            this.btnMacSonucu.TabIndex = 8;
            this.btnMacSonucu.Text = "Mac Sonucunu Girin:";
            this.btnMacSonucu.UseVisualStyleBackColor = true;
            this.btnMacSonucu.Click += new System.EventHandler(this.btnMacSonucu_Click);
            // 
            // dtpTarih
            // 
            this.dtpTarih.Location = new System.Drawing.Point(267, 119);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(218, 22);
            this.dtpTarih.TabIndex = 9;
            // 
            // YeniKarsilasmaEkle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.btnMacSonucu);
            this.Controls.Add(this.nudTakim2Skor);
            this.Controls.Add(this.nudTakim1Skor);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cboTakim2Karsilasma);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboTakim1Karsilasma);
            this.Name = "YeniKarsilasmaEkle";
            this.Text = "YeniKarsilasmaEkle";
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim1Skor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudTakim2Skor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboTakim1Karsilasma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboTakim2Karsilasma;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudTakim1Skor;
        private System.Windows.Forms.NumericUpDown nudTakim2Skor;
        private System.Windows.Forms.Button btnMacSonucu;
        private System.Windows.Forms.DateTimePicker dtpTarih;
    }
}