
namespace GorselPr_Vize
{
    partial class Frm_admin
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
            this.Btn_ekle = new System.Windows.Forms.Button();
            this.Btn_sil = new System.Windows.Forms.Button();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.Btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Btn_ekle
            // 
            this.Btn_ekle.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_ekle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_ekle.Location = new System.Drawing.Point(31, 39);
            this.Btn_ekle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_ekle.Name = "Btn_ekle";
            this.Btn_ekle.Size = new System.Drawing.Size(130, 94);
            this.Btn_ekle.TabIndex = 0;
            this.Btn_ekle.Text = "KULLANICI EKLE";
            this.Btn_ekle.UseVisualStyleBackColor = false;
            this.Btn_ekle.Click += new System.EventHandler(this.Btn_ekle_Click);
            // 
            // Btn_sil
            // 
            this.Btn_sil.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_sil.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_sil.Location = new System.Drawing.Point(183, 39);
            this.Btn_sil.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_sil.Name = "Btn_sil";
            this.Btn_sil.Size = new System.Drawing.Size(130, 94);
            this.Btn_sil.TabIndex = 1;
            this.Btn_sil.Text = "KULLANICI SİL";
            this.Btn_sil.UseVisualStyleBackColor = false;
            this.Btn_sil.Click += new System.EventHandler(this.Btn_sil_Click);
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_guncelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_guncelle.Location = new System.Drawing.Point(31, 166);
            this.Btn_guncelle.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(283, 94);
            this.Btn_guncelle.TabIndex = 2;
            this.Btn_guncelle.Text = "ÜRÜN FİYATI GÜNCELLE";
            this.Btn_guncelle.UseVisualStyleBackColor = false;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // Btn_exit
            // 
            this.Btn_exit.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_exit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_exit.Location = new System.Drawing.Point(31, 291);
            this.Btn_exit.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Btn_exit.Name = "Btn_exit";
            this.Btn_exit.Size = new System.Drawing.Size(283, 94);
            this.Btn_exit.TabIndex = 3;
            this.Btn_exit.Text = "ÇIKIŞ";
            this.Btn_exit.UseVisualStyleBackColor = false;
            this.Btn_exit.Click += new System.EventHandler(this.Btn_exit_Click);
            // 
            // Frm_admin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::GorselPr_Vize.Properties.Resources.soft_bg;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(349, 409);
            this.Controls.Add(this.Btn_exit);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.Btn_sil);
            this.Controls.Add(this.Btn_ekle);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Frm_admin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Paneli";
            this.TransparencyKey = System.Drawing.Color.LightGray;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_ekle;
        private System.Windows.Forms.Button Btn_sil;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Button Btn_exit;
    }
}