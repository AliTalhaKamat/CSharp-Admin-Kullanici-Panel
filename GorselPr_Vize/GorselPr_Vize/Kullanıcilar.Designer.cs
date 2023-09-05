
namespace GorselPr_Vize
{
    partial class Frm_users
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
            this.TextAd = new System.Windows.Forms.TextBox();
            this.TextSifre = new System.Windows.Forms.TextBox();
            this.Btn_ekle = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TextAd
            // 
            this.TextAd.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextAd.Location = new System.Drawing.Point(124, 45);
            this.TextAd.Margin = new System.Windows.Forms.Padding(2);
            this.TextAd.Name = "TextAd";
            this.TextAd.Size = new System.Drawing.Size(116, 22);
            this.TextAd.TabIndex = 0;
            this.TextAd.TextChanged += new System.EventHandler(this.TextAd_TextChanged);
            // 
            // TextSifre
            // 
            this.TextSifre.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextSifre.Location = new System.Drawing.Point(124, 80);
            this.TextSifre.Margin = new System.Windows.Forms.Padding(2);
            this.TextSifre.Name = "TextSifre";
            this.TextSifre.Size = new System.Drawing.Size(116, 22);
            this.TextSifre.TabIndex = 1;
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_ekle.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ekle.Location = new System.Drawing.Point(87, 128);
            this.Btn_ekle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(153, 39);
            this.Btn_ekle.TabIndex = 2;
            this.Btn_ekle.Text = "EKLE";
            this.Btn_ekle.UseVisualStyleBackColor = false;
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(18, 50);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "KULLANICI ADI";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(68, 83);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "ŞİFRE";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(110, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 34);
            this.button1.TabIndex = 5;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_users
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::GorselPr_Vize.Properties.Resources.soft_bg;
            this.ClientSize = new System.Drawing.Size(292, 248);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn_ekle);
            this.Controls.Add(this.TextSifre);
            this.Controls.Add(this.TextAd);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_users";
            this.Text = "Kullanıcı Ekle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextAd;
        private System.Windows.Forms.TextBox TextSifre;
        private System.Windows.Forms.Button Btn_ekle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
    }
}