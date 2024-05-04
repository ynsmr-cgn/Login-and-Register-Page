namespace LoginPage
{
    partial class formGiris
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formGiris));
            this.lblHesapMerkezi = new System.Windows.Forms.Label();
            this.lblKullanici = new System.Windows.Forms.Label();
            this.txtboxKullanici = new System.Windows.Forms.TextBox();
            this.pictureClose = new System.Windows.Forms.PictureBox();
            this.pictureBehind = new System.Windows.Forms.PictureBox();
            this.txtboxSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnGiris = new System.Windows.Forms.Button();
            this.btnKayit = new System.Windows.Forms.Button();
            this.txtboxBackground = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBehind)).BeginInit();
            this.SuspendLayout();
            // 
            // lblHesapMerkezi
            // 
            this.lblHesapMerkezi.AutoSize = true;
            this.lblHesapMerkezi.BackColor = System.Drawing.Color.White;
            this.lblHesapMerkezi.Font = new System.Drawing.Font("Arial Rounded MT Bold", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHesapMerkezi.ForeColor = System.Drawing.Color.Purple;
            this.lblHesapMerkezi.Location = new System.Drawing.Point(27, 20);
            this.lblHesapMerkezi.Name = "lblHesapMerkezi";
            this.lblHesapMerkezi.Size = new System.Drawing.Size(232, 34);
            this.lblHesapMerkezi.TabIndex = 0;
            this.lblHesapMerkezi.Text = "Hesap Merkezi";
            this.lblHesapMerkezi.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblHesapMerkezi_MouseMove);
            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblKullanici.ForeColor = System.Drawing.Color.White;
            this.lblKullanici.Location = new System.Drawing.Point(52, 168);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(106, 20);
            this.lblKullanici.TabIndex = 1;
            this.lblKullanici.Text = "Kullanıcı Adı:";
            // 
            // txtboxKullanici
            // 
            this.txtboxKullanici.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxKullanici.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxKullanici.Location = new System.Drawing.Point(173, 166);
            this.txtboxKullanici.Name = "txtboxKullanici";
            this.txtboxKullanici.Size = new System.Drawing.Size(206, 27);
            this.txtboxKullanici.TabIndex = 2;
            // 
            // pictureClose
            // 
            this.pictureClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureClose.BackColor = System.Drawing.Color.White;
            this.pictureClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureClose.Image = ((System.Drawing.Image)(resources.GetObject("pictureClose.Image")));
            this.pictureClose.Location = new System.Drawing.Point(385, 12);
            this.pictureClose.Name = "pictureClose";
            this.pictureClose.Size = new System.Drawing.Size(43, 48);
            this.pictureClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureClose.TabIndex = 3;
            this.pictureClose.TabStop = false;
            this.pictureClose.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // pictureBehind
            // 
            this.pictureBehind.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBehind.BackColor = System.Drawing.Color.White;
            this.pictureBehind.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBehind.Image = ((System.Drawing.Image)(resources.GetObject("pictureBehind.Image")));
            this.pictureBehind.Location = new System.Drawing.Point(323, 12);
            this.pictureBehind.Name = "pictureBehind";
            this.pictureBehind.Size = new System.Drawing.Size(47, 48);
            this.pictureBehind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBehind.TabIndex = 4;
            this.pictureBehind.TabStop = false;
            this.pictureBehind.Click += new System.EventHandler(this.pictureBehind_Click);
            // 
            // txtboxSifre
            // 
            this.txtboxSifre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtboxSifre.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtboxSifre.Location = new System.Drawing.Point(173, 221);
            this.txtboxSifre.Name = "txtboxSifre";
            this.txtboxSifre.Size = new System.Drawing.Size(206, 27);
            this.txtboxSifre.TabIndex = 6;
            this.txtboxSifre.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(52, 223);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Şifre:";
            // 
            // btnGiris
            // 
            this.btnGiris.BackColor = System.Drawing.Color.SeaGreen;
            this.btnGiris.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGiris.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnGiris.FlatAppearance.BorderSize = 0;
            this.btnGiris.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Green;
            this.btnGiris.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnGiris.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGiris.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnGiris.ForeColor = System.Drawing.Color.White;
            this.btnGiris.Location = new System.Drawing.Point(223, 303);
            this.btnGiris.Name = "btnGiris";
            this.btnGiris.Size = new System.Drawing.Size(156, 60);
            this.btnGiris.TabIndex = 7;
            this.btnGiris.Text = "Giriş";
            this.btnGiris.UseVisualStyleBackColor = false;
            this.btnGiris.Click += new System.EventHandler(this.btnGiris_Click);
            // 
            // btnKayit
            // 
            this.btnKayit.BackColor = System.Drawing.Color.Orange;
            this.btnKayit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKayit.FlatAppearance.BorderColor = System.Drawing.Color.Purple;
            this.btnKayit.FlatAppearance.BorderSize = 0;
            this.btnKayit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Chocolate;
            this.btnKayit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.DarkOrange;
            this.btnKayit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnKayit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayit.ForeColor = System.Drawing.Color.White;
            this.btnKayit.Location = new System.Drawing.Point(56, 303);
            this.btnKayit.Name = "btnKayit";
            this.btnKayit.Size = new System.Drawing.Size(156, 60);
            this.btnKayit.TabIndex = 8;
            this.btnKayit.Text = "Kayıt Ol";
            this.btnKayit.UseVisualStyleBackColor = false;
            this.btnKayit.Click += new System.EventHandler(this.btnKayit_Click);
            // 
            // txtboxBackground
            // 
            this.txtboxBackground.BackColor = System.Drawing.Color.White;
            this.txtboxBackground.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtboxBackground.Cursor = System.Windows.Forms.Cursors.Default;
            this.txtboxBackground.Dock = System.Windows.Forms.DockStyle.Top;
            this.txtboxBackground.Location = new System.Drawing.Point(0, 0);
            this.txtboxBackground.MaxLength = 0;
            this.txtboxBackground.Multiline = true;
            this.txtboxBackground.Name = "txtboxBackground";
            this.txtboxBackground.ReadOnly = true;
            this.txtboxBackground.ShortcutsEnabled = false;
            this.txtboxBackground.Size = new System.Drawing.Size(440, 74);
            this.txtboxBackground.TabIndex = 32;
            this.txtboxBackground.TabStop = false;
            this.txtboxBackground.MouseMove += new System.Windows.Forms.MouseEventHandler(this.txtboxBackground_MouseMove);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(50, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 36);
            this.label2.TabIndex = 33;
            this.label2.Text = "Giriş Yap";
            // 
            // formGiris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(440, 423);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureClose);
            this.Controls.Add(this.pictureBehind);
            this.Controls.Add(this.btnKayit);
            this.Controls.Add(this.btnGiris);
            this.Controls.Add(this.txtboxSifre);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtboxKullanici);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.lblHesapMerkezi);
            this.Controls.Add(this.txtboxBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "formGiris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş";
            ((System.ComponentModel.ISupportInitialize)(this.pictureClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBehind)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblHesapMerkezi;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.TextBox txtboxKullanici;
        private System.Windows.Forms.PictureBox pictureClose;
        private System.Windows.Forms.PictureBox pictureBehind;
        private System.Windows.Forms.TextBox txtboxSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGiris;
        private System.Windows.Forms.Button btnKayit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtboxBackground;
    }
}

