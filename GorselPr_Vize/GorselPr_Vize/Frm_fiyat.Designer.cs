
namespace GorselPr_Vize
{
    partial class Frm_fiyat
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ComboUrun = new System.Windows.Forms.ComboBox();
            this.TextFiyat = new System.Windows.Forms.TextBox();
            this.Btn_guncelle = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(17, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(226, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Fiyatı Değiştirilecek Ürün ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(142, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Yeni Fİyatı";
            // 
            // ComboUrun
            // 
            this.ComboUrun.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.ComboUrun.FormattingEnabled = true;
            this.ComboUrun.Location = new System.Drawing.Point(261, 49);
            this.ComboUrun.Margin = new System.Windows.Forms.Padding(2);
            this.ComboUrun.Name = "ComboUrun";
            this.ComboUrun.Size = new System.Drawing.Size(166, 24);
            this.ComboUrun.TabIndex = 2;
            this.ComboUrun.SelectedIndexChanged += new System.EventHandler(this.ComboUrun_SelectedIndexChanged);
            // 
            // TextFiyat
            // 
            this.TextFiyat.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.TextFiyat.Location = new System.Drawing.Point(261, 91);
            this.TextFiyat.Margin = new System.Windows.Forms.Padding(2);
            this.TextFiyat.Name = "TextFiyat";
            this.TextFiyat.Size = new System.Drawing.Size(166, 22);
            this.TextFiyat.TabIndex = 3;
            // 
            // Btn_guncelle
            // 
            this.Btn_guncelle.BackColor = System.Drawing.Color.LightCoral;
            this.Btn_guncelle.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Btn_guncelle.Location = new System.Drawing.Point(146, 145);
            this.Btn_guncelle.Margin = new System.Windows.Forms.Padding(2);
            this.Btn_guncelle.Name = "Btn_guncelle";
            this.Btn_guncelle.Size = new System.Drawing.Size(251, 68);
            this.Btn_guncelle.TabIndex = 4;
            this.Btn_guncelle.Text = "GÜNCELLE";
            this.Btn_guncelle.UseVisualStyleBackColor = false;
            this.Btn_guncelle.Click += new System.EventHandler(this.Btn_guncelle_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightCoral;
            this.button1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.Location = new System.Drawing.Point(218, 217);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 57);
            this.button1.TabIndex = 5;
            this.button1.Text = "ÇIKIŞ";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_fiyat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightCoral;
            this.BackgroundImage = global::GorselPr_Vize.Properties.Resources.soft_bg;
            this.ClientSize = new System.Drawing.Size(521, 297);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Btn_guncelle);
            this.Controls.Add(this.TextFiyat);
            this.Controls.Add(this.ComboUrun);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_fiyat";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ürün Fiyatı Güncelle";
            this.Load += new System.EventHandler(this.Frm_fiyat_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox ComboUrun;
        private System.Windows.Forms.TextBox TextFiyat;
        private System.Windows.Forms.Button Btn_guncelle;
        private System.Windows.Forms.Button button1;
    }
}