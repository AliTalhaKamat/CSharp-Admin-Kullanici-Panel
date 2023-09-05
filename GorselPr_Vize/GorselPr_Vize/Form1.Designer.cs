
namespace GorselPr_Vize
{
    partial class Frm_giris
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextAd = new System.Windows.Forms.TextBox();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_giris = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAd
            // 
            this.TextAd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextAd.Location = new System.Drawing.Point(75, 97);
            this.TextAd.Name = "TextAd";
            this.TextAd.Size = new System.Drawing.Size(157, 26);
            this.TextAd.TabIndex = 0;
            // 
            // TextSifre
            // 
            this.TextSifre.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextSifre.Location = new System.Drawing.Point(75, 168);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.PasswordChar = '*';
            this.TextSifre.Size = new System.Drawing.Size(157, 26);
            this.TextSifre.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(86, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(118, 135);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 18);
            this.label2.TabIndex = 3;
            this.label2.Text = "ŞİFRE";
            // 
            // Btn_giris
            // 
            this.Btn_giris.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_giris.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_giris.Location = new System.Drawing.Point(75, 230);
            this.Btn_giris.Name = "Btn_giris";
            this.Btn_giris.Size = new System.Drawing.Size(157, 43);
            this.Btn_giris.TabIndex = 4;
            this.Btn_giris.Text = "GİRİŞ YAP";
            this.Btn_giris.UseVisualStyleBackColor = false;
            this.Btn_giris.Click += new System.EventHandler(this.Btn_giris_Click);
            // 
            // Frm_giris
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.BackgroundImage = global::GorselPr_Vize.Properties.Resources.soft_bg;
            this.ClientSize = new System.Drawing.Size(299, 323);
            this.Controls.Add(this.Btn_giris);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.TextAd);
            this.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Name = "Frm_giris";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Giriş Paneli";
            this.Load += new System.EventHandler(this.Frm_giris_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAd;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_giris;
    }
}

