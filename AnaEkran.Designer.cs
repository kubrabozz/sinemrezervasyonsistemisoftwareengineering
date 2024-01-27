namespace Sinema_Programı
{
    partial class AnaEkran
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AnaEkran));
            this.btnyonetici = new System.Windows.Forms.Button();
            this.btnkullanici = new System.Windows.Forms.Button();
            this.btncikis = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnyonetici
            // 
            this.btnyonetici.BackColor = System.Drawing.Color.Transparent;
            this.btnyonetici.BackgroundImage = global::Sinema_Programı.Properties.Resources.movie;
            this.btnyonetici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnyonetici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnyonetici.FlatAppearance.BorderSize = 0;
            this.btnyonetici.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnyonetici.Image = global::Sinema_Programı.Properties.Resources.indir__9_;
            this.btnyonetici.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnyonetici.Location = new System.Drawing.Point(247, 139);
            this.btnyonetici.Name = "btnyonetici";
            this.btnyonetici.Size = new System.Drawing.Size(237, 93);
            this.btnyonetici.TabIndex = 0;
            this.btnyonetici.Text = "Yönetici Girişi";
            this.btnyonetici.UseVisualStyleBackColor = false;
            this.btnyonetici.Click += new System.EventHandler(this.btnyonetici_Click);
            // 
            // btnkullanici
            // 
            this.btnkullanici.BackColor = System.Drawing.Color.Transparent;
            this.btnkullanici.BackgroundImage = global::Sinema_Programı.Properties.Resources.indir__10_;
            this.btnkullanici.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnkullanici.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnkullanici.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnkullanici.FlatAppearance.BorderSize = 0;
            this.btnkullanici.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkullanici.ForeColor = System.Drawing.Color.White;
            this.btnkullanici.Image = global::Sinema_Programı.Properties.Resources.indir__8_;
            this.btnkullanici.Location = new System.Drawing.Point(247, 28);
            this.btnkullanici.Name = "btnkullanici";
            this.btnkullanici.Size = new System.Drawing.Size(237, 105);
            this.btnkullanici.TabIndex = 1;
            this.btnkullanici.Text = "Kullanıcı Girişi";
            this.btnkullanici.UseVisualStyleBackColor = false;
            this.btnkullanici.Click += new System.EventHandler(this.btnkullanici_Click);
            // 
            // btncikis
            // 
            this.btncikis.BackColor = System.Drawing.Color.Crimson;
            this.btncikis.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btncikis.FlatAppearance.BorderSize = 0;
            this.btncikis.Font = new System.Drawing.Font("Showcard Gothic", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncikis.Image = ((System.Drawing.Image)(resources.GetObject("btncikis.Image")));
            this.btncikis.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btncikis.Location = new System.Drawing.Point(278, 238);
            this.btncikis.Name = "btncikis";
            this.btncikis.Size = new System.Drawing.Size(175, 46);
            this.btncikis.TabIndex = 2;
            this.btncikis.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btncikis.UseVisualStyleBackColor = false;
            this.btncikis.Click += new System.EventHandler(this.btncikis_Click);
            // 
            // AnaEkran
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HotTrack;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(701, 288);
            this.Controls.Add(this.btncikis);
            this.Controls.Add(this.btnyonetici);
            this.Controls.Add(this.btnkullanici);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(717, 327);
            this.MinimumSize = new System.Drawing.Size(717, 327);
            this.Name = "AnaEkran";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ANA EKRAN";
            this.TransparencyKey = System.Drawing.Color.Transparent;
            this.Load += new System.EventHandler(this.AnaEkran_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnyonetici;
        private System.Windows.Forms.Button btnkullanici;
        private System.Windows.Forms.Button btncikis;
    }
}