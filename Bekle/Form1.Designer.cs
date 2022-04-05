namespace Bekle
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
            this.components = new System.ComponentModel.Container();
            this.btnBaslat = new System.Windows.Forms.Button();
            this.txtBeklemeSuresi = new System.Windows.Forms.TextBox();
            this.lblBekle = new System.Windows.Forms.Label();
            this.lblDosyaYolu = new System.Windows.Forms.Label();
            this.txtDosyaYolu = new System.Windows.Forms.TextBox();
            this.btnAyarKaydet = new System.Windows.Forms.Button();
            this.tmrBekle = new System.Windows.Forms.Timer(this.components);
            this.lblBeklemeSuresi = new System.Windows.Forms.Label();
            this.cbOtoBaslat = new System.Windows.Forms.CheckBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.chYapYapma = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnBaslat
            // 
            this.btnBaslat.Location = new System.Drawing.Point(66, 67);
            this.btnBaslat.Name = "btnBaslat";
            this.btnBaslat.Size = new System.Drawing.Size(104, 34);
            this.btnBaslat.TabIndex = 0;
            this.btnBaslat.Text = "Başlat";
            this.btnBaslat.UseVisualStyleBackColor = true;
            this.btnBaslat.Click += new System.EventHandler(this.btnBaslat_Click);
            // 
            // txtBeklemeSuresi
            // 
            this.txtBeklemeSuresi.Location = new System.Drawing.Point(98, 12);
            this.txtBeklemeSuresi.Name = "txtBeklemeSuresi";
            this.txtBeklemeSuresi.Size = new System.Drawing.Size(100, 20);
            this.txtBeklemeSuresi.TabIndex = 1;
            this.txtBeklemeSuresi.Text = "10";
            // 
            // lblBekle
            // 
            this.lblBekle.AutoSize = true;
            this.lblBekle.Location = new System.Drawing.Point(12, 15);
            this.lblBekle.Name = "lblBekle";
            this.lblBekle.Size = new System.Drawing.Size(80, 13);
            this.lblBekle.TabIndex = 2;
            this.lblBekle.Text = "Bekleme Süresi";
            // 
            // lblDosyaYolu
            // 
            this.lblDosyaYolu.AutoSize = true;
            this.lblDosyaYolu.Location = new System.Drawing.Point(12, 39);
            this.lblDosyaYolu.Name = "lblDosyaYolu";
            this.lblDosyaYolu.Size = new System.Drawing.Size(61, 13);
            this.lblDosyaYolu.TabIndex = 3;
            this.lblDosyaYolu.Text = "Dosya Yolu";
            // 
            // txtDosyaYolu
            // 
            this.txtDosyaYolu.Location = new System.Drawing.Point(98, 36);
            this.txtDosyaYolu.Name = "txtDosyaYolu";
            this.txtDosyaYolu.Size = new System.Drawing.Size(198, 20);
            this.txtDosyaYolu.TabIndex = 4;
            this.txtDosyaYolu.Text = "C:\\app\\RuntimeBroker.exe";
            // 
            // btnAyarKaydet
            // 
            this.btnAyarKaydet.Location = new System.Drawing.Point(192, 70);
            this.btnAyarKaydet.Name = "btnAyarKaydet";
            this.btnAyarKaydet.Size = new System.Drawing.Size(104, 31);
            this.btnAyarKaydet.TabIndex = 5;
            this.btnAyarKaydet.Text = "Ayar Kaydet";
            this.btnAyarKaydet.UseVisualStyleBackColor = true;
            this.btnAyarKaydet.Click += new System.EventHandler(this.btnAyarKaydet_Click);
            // 
            // tmrBekle
            // 
            this.tmrBekle.Interval = 600;
            this.tmrBekle.Tick += new System.EventHandler(this.tmrBekle_Tick);
            // 
            // lblBeklemeSuresi
            // 
            this.lblBeklemeSuresi.AutoSize = true;
            this.lblBeklemeSuresi.Location = new System.Drawing.Point(252, 19);
            this.lblBeklemeSuresi.Name = "lblBeklemeSuresi";
            this.lblBeklemeSuresi.Size = new System.Drawing.Size(13, 13);
            this.lblBeklemeSuresi.TabIndex = 6;
            this.lblBeklemeSuresi.Text = "0";
            // 
            // cbOtoBaslat
            // 
            this.cbOtoBaslat.AutoSize = true;
            this.cbOtoBaslat.Location = new System.Drawing.Point(302, 38);
            this.cbOtoBaslat.Name = "cbOtoBaslat";
            this.cbOtoBaslat.Size = new System.Drawing.Size(75, 17);
            this.cbOtoBaslat.TabIndex = 7;
            this.cbOtoBaslat.Text = "Oto Baslat";
            this.cbOtoBaslat.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(302, 70);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(56, 30);
            this.listBox1.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(7, 78);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(53, 29);
            this.button1.TabIndex = 9;
            this.button1.Text = "Yap";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chYapYapma
            // 
            this.chYapYapma.AutoSize = true;
            this.chYapYapma.Location = new System.Drawing.Point(255, 102);
            this.chYapYapma.Name = "chYapYapma";
            this.chYapYapma.Size = new System.Drawing.Size(81, 17);
            this.chYapYapma.TabIndex = 10;
            this.chYapYapma.Text = "Yap Yapma";
            this.chYapYapma.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 131);
            this.Controls.Add(this.chYapYapma);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.cbOtoBaslat);
            this.Controls.Add(this.lblBeklemeSuresi);
            this.Controls.Add(this.btnAyarKaydet);
            this.Controls.Add(this.txtDosyaYolu);
            this.Controls.Add(this.lblDosyaYolu);
            this.Controls.Add(this.lblBekle);
            this.Controls.Add(this.txtBeklemeSuresi);
            this.Controls.Add(this.btnBaslat);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.btnBaslat_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBaslat;
        private System.Windows.Forms.TextBox txtBeklemeSuresi;
        private System.Windows.Forms.Label lblBekle;
        private System.Windows.Forms.Label lblDosyaYolu;
        private System.Windows.Forms.TextBox txtDosyaYolu;
        private System.Windows.Forms.Button btnAyarKaydet;
        private System.Windows.Forms.Label lblBeklemeSuresi;
        private System.Windows.Forms.CheckBox cbOtoBaslat;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer tmrBekle;
        private System.Windows.Forms.CheckBox chYapYapma;
    }
}

