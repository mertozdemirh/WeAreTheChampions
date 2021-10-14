
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
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvKarsilasmalar = new System.Windows.Forms.DataGridView();
            this.btnSecileniSil = new System.Windows.Forms.Button();
            this.btnSecileniDuzenle = new System.Windows.Forms.Button();
            this.btnYeniKarsilasma = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(-1, 12);
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
            this.tabPage1.Text = "Takimlar";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(781, 397);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Renkler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(781, 397);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Oyuncular";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // dgvKarsilasmalar
            // 
            this.dgvKarsilasmalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvKarsilasmalar.Location = new System.Drawing.Point(17, 49);
            this.dgvKarsilasmalar.Name = "dgvKarsilasmalar";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "We Are The Champions 1.0";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKarsilasmalar)).EndInit();
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
    }
}

