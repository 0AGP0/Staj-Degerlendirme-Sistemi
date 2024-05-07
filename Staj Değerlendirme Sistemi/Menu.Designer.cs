namespace Staj_Değerlendirme_Sistemi
{
    partial class Menu
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
            this.lblName = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnKayıt = new System.Windows.Forms.Button();
            this.btnDeğerlendirme = new System.Windows.Forms.Button();
            this.btnCikis = new System.Windows.Forms.Button();
            this.btnOgrSil = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(138, 9);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(534, 112);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Başkent Üniversitesi Staj Değerlendirme Sistemi";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(314, 209);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(176, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Öğrenci Listesi";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnKayıt
            // 
            this.btnKayıt.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnKayıt.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKayıt.ForeColor = System.Drawing.Color.Black;
            this.btnKayıt.Location = new System.Drawing.Point(422, 294);
            this.btnKayıt.Name = "btnKayıt";
            this.btnKayıt.Size = new System.Drawing.Size(176, 58);
            this.btnKayıt.TabIndex = 3;
            this.btnKayıt.Text = "Öğrenci Kayıt";
            this.btnKayıt.UseVisualStyleBackColor = false;
            this.btnKayıt.Click += new System.EventHandler(this.btnKayıt_Click);
            // 
            // btnDeğerlendirme
            // 
            this.btnDeğerlendirme.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnDeğerlendirme.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDeğerlendirme.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnDeğerlendirme.ForeColor = System.Drawing.Color.Black;
            this.btnDeğerlendirme.Location = new System.Drawing.Point(314, 124);
            this.btnDeğerlendirme.Name = "btnDeğerlendirme";
            this.btnDeğerlendirme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnDeğerlendirme.Size = new System.Drawing.Size(176, 58);
            this.btnDeğerlendirme.TabIndex = 4;
            this.btnDeğerlendirme.Text = "Staj Değerlendirme";
            this.btnDeğerlendirme.UseVisualStyleBackColor = false;
            this.btnDeğerlendirme.Click += new System.EventHandler(this.btnDeğerlendirme_Click);
            // 
            // btnCikis
            // 
            this.btnCikis.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnCikis.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnCikis.ForeColor = System.Drawing.Color.Black;
            this.btnCikis.Location = new System.Drawing.Point(314, 378);
            this.btnCikis.Name = "btnCikis";
            this.btnCikis.Size = new System.Drawing.Size(176, 58);
            this.btnCikis.TabIndex = 5;
            this.btnCikis.Text = "Kapat";
            this.btnCikis.UseVisualStyleBackColor = false;
            this.btnCikis.Click += new System.EventHandler(this.btnCikis_Click);
            // 
            // btnOgrSil
            // 
            this.btnOgrSil.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnOgrSil.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnOgrSil.ForeColor = System.Drawing.Color.Black;
            this.btnOgrSil.Location = new System.Drawing.Point(210, 294);
            this.btnOgrSil.Name = "btnOgrSil";
            this.btnOgrSil.Size = new System.Drawing.Size(176, 58);
            this.btnOgrSil.TabIndex = 6;
            this.btnOgrSil.Text = "Öğrenci Sil";
            this.btnOgrSil.UseVisualStyleBackColor = false;
            this.btnOgrSil.Click += new System.EventHandler(this.btnOgrSil_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Staj_Değerlendirme_Sistemi.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.btnOgrSil);
            this.Controls.Add(this.btnCikis);
            this.Controls.Add(this.btnDeğerlendirme);
            this.Controls.Add(this.btnKayıt);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblName);
            this.Name = "Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu";
            this.Load += new System.EventHandler(this.Menu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnKayıt;
        private System.Windows.Forms.Button btnDeğerlendirme;
        private System.Windows.Forms.Button btnCikis;
        private System.Windows.Forms.Button btnOgrSil;
    }
}