
namespace WeAreTheChampions
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dgvKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.btnSecileniDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.lblRenk = new System.Windows.Forms.Label();
            this.txtRenkAdi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.btnRengiOlustur = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.nudMavi = new System.Windows.Forms.NumericUpDown();
            this.nudYesil = new System.Windows.Forms.NumericUpDown();
            this.nudKirmizi = new System.Windows.Forms.NumericUpDown();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblRenk2 = new System.Windows.Forms.Label();
            this.lblRenk1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.cboRenk2 = new System.Windows.Forms.ComboBox();
            this.cboRenk1 = new System.Windows.Forms.ComboBox();
            this.btnCikart = new System.Windows.Forms.Button();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lstMevcutTakimlar = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTakimEkle = new System.Windows.Forms.TextBox();
            this.txtOyuncuAdi = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.cboTakimlar = new System.Windows.Forms.ComboBox();
            this.dgvOyuncular = new System.Windows.Forms.DataGridView();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.btnOyuncuSil = new System.Windows.Forms.Button();
            this.label15 = new System.Windows.Forms.Label();
            this.cboTakimFiltrele = new System.Windows.Forms.ComboBox();
            this.dgvFiltre = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMavi)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYesil)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKirmizi)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltre)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(3, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(789, 426);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.dgvKarsilasmalar);
            this.tabPage1.Controls.Add(this.btnSecileniSil);
            this.tabPage1.Controls.Add(this.btnSecileniDuzenle);
            this.tabPage1.Controls.Add(this.btnYeniKarsilasma);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(781, 397);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Karşılasma Ekranı";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dgvKarsilasmalar
            // 
            this.dgvKarsilasmalar.AllowUserToAddRows = false;
            this.dgvKarsilasmalar.AllowUserToDeleteRows = false;
            this.dgvKarsilasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarsilasmalar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvKarsilasmalar.Location = new System.Drawing.Point(17, 49);
            this.dgvKarsilasmalar.Name = "dgvKarsilasmalar";
            this.dgvKarsilasmalar.ReadOnly = true;
            this.dgvKarsilasmalar.RowHeadersWidth = 51;
            this.dgvKarsilasmalar.RowTemplate.Height = 24;
            this.dgvKarsilasmalar.Size = new System.Drawing.Size(751, 295);
            this.dgvKarsilasmalar.TabIndex = 9;
            // 
            // btnSecileniSil
            // 
            this.btnSecileniSil.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecileniSil.Location = new System.Drawing.Point(523, 350);
            this.btnSecileniSil.Name = "btnSecileniSil";
            this.btnSecileniSil.Size = new System.Drawing.Size(243, 41);
            this.btnSecileniSil.TabIndex = 8;
            this.btnSecileniSil.Text = "Seçileni Sil";
            this.btnSecileniSil.UseVisualStyleBackColor = true;
            // 
            // btnSecileniDuzenle
            // 
            this.btnSecileniDuzenle.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnSecileniDuzenle.Location = new System.Drawing.Point(17, 350);
            this.btnSecileniDuzenle.Name = "btnSecileniDuzenle";
            this.btnSecileniDuzenle.Size = new System.Drawing.Size(205, 41);
            this.btnSecileniDuzenle.TabIndex = 7;
            this.btnSecileniDuzenle.Text = "Secileni Düzenle";
            this.btnSecileniDuzenle.UseVisualStyleBackColor = true;
            // 
            // btnYeniKarsilasma
            // 
            this.btnYeniKarsilasma.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnYeniKarsilasma.Location = new System.Drawing.Point(372, 6);
            this.btnYeniKarsilasma.Name = "btnYeniKarsilasma";
            this.btnYeniKarsilasma.Size = new System.Drawing.Size(394, 37);
            this.btnYeniKarsilasma.TabIndex = 6;
            this.btnYeniKarsilasma.Text = "Yeni Karşılaşma Ekle";
            this.btnYeniKarsilasma.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Karşılaşmalar:";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.lblRenk);
            this.tabPage2.Controls.Add(this.txtRenkAdi);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.btnRengiOlustur);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.nudMavi);
            this.tabPage2.Controls.Add(this.nudYesil);
            this.tabPage2.Controls.Add(this.nudKirmizi);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Renkler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // lblRenk
            // 
            this.lblRenk.AutoSize = true;
            this.lblRenk.Location = new System.Drawing.Point(378, 49);
            this.lblRenk.Name = "lblRenk";
            this.lblRenk.Size = new System.Drawing.Size(50, 17);
            this.lblRenk.TabIndex = 9;
            this.lblRenk.Text = "lblrenk";
            // 
            // txtRenkAdi
            // 
            this.txtRenkAdi.Location = new System.Drawing.Point(18, 49);
            this.txtRenkAdi.Name = "txtRenkAdi";
            this.txtRenkAdi.Size = new System.Drawing.Size(196, 22);
            this.txtRenkAdi.TabIndex = 8;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(15, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(199, 17);
            this.label7.TabIndex = 7;
            this.label7.Text = "Oluşacak Rengin Adını Giriniz:";
            // 
            // btnRengiOlustur
            // 
            this.btnRengiOlustur.Location = new System.Drawing.Point(6, 268);
            this.btnRengiOlustur.Name = "btnRengiOlustur";
            this.btnRengiOlustur.Size = new System.Drawing.Size(228, 42);
            this.btnRengiOlustur.TabIndex = 6;
            this.btnRengiOlustur.Text = "Rengi Oluştur";
            this.btnRengiOlustur.UseVisualStyleBackColor = true;
            this.btnRengiOlustur.Click += new System.EventHandler(this.btnRengiOlustur_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 211);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Mavi:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Yesil:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 103);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Kırmızı:";
            // 
            // nudMavi
            // 
            this.nudMavi.Location = new System.Drawing.Point(104, 211);
            this.nudMavi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudMavi.Name = "nudMavi";
            this.nudMavi.Size = new System.Drawing.Size(120, 22);
            this.nudMavi.TabIndex = 2;
            // 
            // nudYesil
            // 
            this.nudYesil.Location = new System.Drawing.Point(104, 157);
            this.nudYesil.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudYesil.Name = "nudYesil";
            this.nudYesil.Size = new System.Drawing.Size(120, 22);
            this.nudYesil.TabIndex = 1;
            // 
            // nudKirmizi
            // 
            this.nudKirmizi.Location = new System.Drawing.Point(104, 103);
            this.nudKirmizi.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.nudKirmizi.Name = "nudKirmizi";
            this.nudKirmizi.Size = new System.Drawing.Size(120, 22);
            this.nudKirmizi.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.dgvFiltre);
            this.tabPage3.Controls.Add(this.cboTakimFiltrele);
            this.tabPage3.Controls.Add(this.label15);
            this.tabPage3.Controls.Add(this.btnOyuncuSil);
            this.tabPage3.Controls.Add(this.btnOyuncuEkle);
            this.tabPage3.Controls.Add(this.dgvOyuncular);
            this.tabPage3.Controls.Add(this.cboTakimlar);
            this.tabPage3.Controls.Add(this.label14);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.txtOyuncuAdi);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Oyuncular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.lblRenk2);
            this.tabPage4.Controls.Add(this.lblRenk1);
            this.tabPage4.Controls.Add(this.label10);
            this.tabPage4.Controls.Add(this.label9);
            this.tabPage4.Controls.Add(this.label8);
            this.tabPage4.Controls.Add(this.cboRenk2);
            this.tabPage4.Controls.Add(this.cboRenk1);
            this.tabPage4.Controls.Add(this.btnCikart);
            this.tabPage4.Controls.Add(this.btnTakimEkle);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.lstMevcutTakimlar);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.txtTakimEkle);
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(781, 397);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Takımlar";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblRenk2
            // 
            this.lblRenk2.AutoSize = true;
            this.lblRenk2.Location = new System.Drawing.Point(684, 76);
            this.lblRenk2.Name = "lblRenk2";
            this.lblRenk2.Size = new System.Drawing.Size(49, 17);
            this.lblRenk2.TabIndex = 12;
            this.lblRenk2.Text = "Renk2";
            // 
            // lblRenk1
            // 
            this.lblRenk1.AutoSize = true;
            this.lblRenk1.Location = new System.Drawing.Point(596, 76);
            this.lblRenk1.Name = "lblRenk1";
            this.lblRenk1.Size = new System.Drawing.Size(49, 17);
            this.lblRenk1.TabIndex = 11;
            this.lblRenk1.Text = "Renk1";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(593, 35);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 17);
            this.label10.TabIndex = 10;
            this.label10.Text = "Takım Renkleri";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 156);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 17);
            this.label9.TabIndex = 9;
            this.label9.Text = "Renk2:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(41, 102);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(53, 17);
            this.label8.TabIndex = 8;
            this.label8.Text = "Renk1:";
            // 
            // cboRenk2
            // 
            this.cboRenk2.DisplayMember = "ColorName";
            this.cboRenk2.FormattingEnabled = true;
            this.cboRenk2.Location = new System.Drawing.Point(41, 182);
            this.cboRenk2.Name = "cboRenk2";
            this.cboRenk2.Size = new System.Drawing.Size(180, 24);
            this.cboRenk2.TabIndex = 7;
            this.cboRenk2.ValueMember = "Id";
            // 
            // cboRenk1
            // 
            this.cboRenk1.DisplayMember = "ColorName";
            this.cboRenk1.FormattingEnabled = true;
            this.cboRenk1.Location = new System.Drawing.Point(41, 125);
            this.cboRenk1.Name = "cboRenk1";
            this.cboRenk1.Size = new System.Drawing.Size(180, 24);
            this.cboRenk1.TabIndex = 6;
            this.cboRenk1.ValueMember = "Id";
            // 
            // btnCikart
            // 
            this.btnCikart.Location = new System.Drawing.Point(135, 234);
            this.btnCikart.Name = "btnCikart";
            this.btnCikart.Size = new System.Drawing.Size(86, 56);
            this.btnCikart.TabIndex = 5;
            this.btnCikart.Text = "Cıkart";
            this.btnCikart.UseVisualStyleBackColor = true;
            // 
            // btnTakimEkle
            // 
            this.btnTakimEkle.Location = new System.Drawing.Point(42, 234);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(87, 56);
            this.btnTakimEkle.TabIndex = 4;
            this.btnTakimEkle.Text = "Ekle";
            this.btnTakimEkle.UseVisualStyleBackColor = true;
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(254, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "Ligteki Takımlar:";
            // 
            // lstMevcutTakimlar
            // 
            this.lstMevcutTakimlar.FormattingEnabled = true;
            this.lstMevcutTakimlar.ItemHeight = 16;
            this.lstMevcutTakimlar.Location = new System.Drawing.Point(257, 55);
            this.lstMevcutTakimlar.Name = "lstMevcutTakimlar";
            this.lstMevcutTakimlar.Size = new System.Drawing.Size(301, 292);
            this.lstMevcutTakimlar.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Takım Ekle:";
            // 
            // txtTakimEkle
            // 
            this.txtTakimEkle.Location = new System.Drawing.Point(41, 72);
            this.txtTakimEkle.Name = "txtTakimEkle";
            this.txtTakimEkle.Size = new System.Drawing.Size(180, 22);
            this.txtTakimEkle.TabIndex = 0;
            // 
            // txtOyuncuAdi
            // 
            this.txtOyuncuAdi.Location = new System.Drawing.Point(60, 49);
            this.txtOyuncuAdi.Name = "txtOyuncuAdi";
            this.txtOyuncuAdi.Size = new System.Drawing.Size(190, 22);
            this.txtOyuncuAdi.TabIndex = 0;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(60, 26);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(85, 17);
            this.label13.TabIndex = 1;
            this.label13.Text = "Oyuncu Adı:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(57, 91);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 17);
            this.label14.TabIndex = 2;
            this.label14.Text = "Takım Adı:";
            // 
            // cboTakimlar
            // 
            this.cboTakimlar.DisplayMember = "TeamName";
            this.cboTakimlar.FormattingEnabled = true;
            this.cboTakimlar.Location = new System.Drawing.Point(60, 111);
            this.cboTakimlar.Name = "cboTakimlar";
            this.cboTakimlar.Size = new System.Drawing.Size(187, 24);
            this.cboTakimlar.TabIndex = 3;
            this.cboTakimlar.ValueMember = "Id";
            // 
            // dgvOyuncular
            // 
            this.dgvOyuncular.AllowUserToAddRows = false;
            this.dgvOyuncular.AllowUserToDeleteRows = false;
            this.dgvOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOyuncular.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            this.dgvOyuncular.Location = new System.Drawing.Point(332, 6);
            this.dgvOyuncular.Name = "dgvOyuncular";
            this.dgvOyuncular.ReadOnly = true;
            this.dgvOyuncular.RowHeadersWidth = 51;
            this.dgvOyuncular.RowTemplate.Height = 24;
            this.dgvOyuncular.Size = new System.Drawing.Size(416, 193);
            this.dgvOyuncular.TabIndex = 4;
            // 
            // btnOyuncuEkle
            // 
            this.btnOyuncuEkle.Location = new System.Drawing.Point(56, 159);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(107, 31);
            this.btnOyuncuEkle.TabIndex = 5;
            this.btnOyuncuEkle.Text = "EKLE";
            this.btnOyuncuEkle.UseVisualStyleBackColor = true;
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);
            // 
            // btnOyuncuSil
            // 
            this.btnOyuncuSil.Location = new System.Drawing.Point(169, 159);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(78, 30);
            this.btnOyuncuSil.TabIndex = 6;
            this.btnOyuncuSil.Text = "SİL";
            this.btnOyuncuSil.UseVisualStyleBackColor = true;
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(63, 238);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(96, 17);
            this.label15.TabIndex = 7;
            this.label15.Text = "Takım Filtrele:";
            // 
            // cboTakimFiltrele
            // 
            this.cboTakimFiltrele.DisplayMember = "TeamName";
            this.cboTakimFiltrele.FormattingEnabled = true;
            this.cboTakimFiltrele.Location = new System.Drawing.Point(66, 277);
            this.cboTakimFiltrele.Name = "cboTakimFiltrele";
            this.cboTakimFiltrele.Size = new System.Drawing.Size(181, 24);
            this.cboTakimFiltrele.TabIndex = 8;
            this.cboTakimFiltrele.ValueMember = "Id";
            this.cboTakimFiltrele.SelectedIndexChanged += new System.EventHandler(this.cboTakimFiltrele_SelectedIndexChanged);
            // 
            // dgvFiltre
            // 
            this.dgvFiltre.AllowUserToAddRows = false;
            this.dgvFiltre.AllowUserToDeleteRows = false;
            this.dgvFiltre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFiltre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2});
            this.dgvFiltre.Location = new System.Drawing.Point(332, 205);
            this.dgvFiltre.Name = "dgvFiltre";
            this.dgvFiltre.ReadOnly = true;
            this.dgvFiltre.RowHeadersWidth = 51;
            this.dgvFiltre.RowTemplate.Height = 24;
            this.dgvFiltre.Size = new System.Drawing.Size(416, 176);
            this.dgvFiltre.TabIndex = 9;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "PlayerName";
            this.Column1.HeaderText = "Oyuncu Adi";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 125;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PlayerName";
            this.Column2.HeaderText = "Takımlara Gore Filtrele";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 125;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Team1Id";
            this.Column3.HeaderText = "Takım1";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 125;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "Team2Id";
            this.Column4.HeaderText = "Takım2";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 125;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TarihText";
            this.Column5.HeaderText = "Tarih";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Width = 125;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "SaatText";
            this.Column6.HeaderText = "Saat";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            this.Column6.Width = 125;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Result";
            this.Column7.HeaderText = "Sonuc";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            this.Column7.Width = 125;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1017, 520);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "We Are The Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudMavi)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudYesil)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudKirmizi)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOyuncular)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFiltre)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dgvKarsilasmalar;
        private System.Windows.Forms.Button btnSecileniSil;
        private System.Windows.Forms.Button btnSecileniDuzenle;
        private System.Windows.Forms.Button btnYeniKarsilasma;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox lstMevcutTakimlar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTakimEkle;
        private System.Windows.Forms.Button btnCikart;
        private System.Windows.Forms.Button btnRengiOlustur;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown nudMavi;
        private System.Windows.Forms.NumericUpDown nudYesil;
        private System.Windows.Forms.NumericUpDown nudKirmizi;
        private System.Windows.Forms.TextBox txtRenkAdi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblRenk;
        private System.Windows.Forms.ComboBox cboRenk1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboRenk2;
        private System.Windows.Forms.Label lblRenk2;
        private System.Windows.Forms.Label lblRenk1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvOyuncular;
        private System.Windows.Forms.ComboBox cboTakimlar;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtOyuncuAdi;
        private System.Windows.Forms.Button btnOyuncuSil;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.DataGridView dgvFiltre;
        private System.Windows.Forms.ComboBox cboTakimFiltrele;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

