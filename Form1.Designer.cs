namespace NumberToWords
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
            this.tb_angka = new System.Windows.Forms.TextBox();
            this.btn_konv = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_terbilang = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tb_angka
            // 
            this.tb_angka.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_angka.Location = new System.Drawing.Point(19, 41);
            this.tb_angka.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tb_angka.Name = "tb_angka";
            this.tb_angka.Size = new System.Drawing.Size(320, 41);
            this.tb_angka.TabIndex = 0;
            // 
            // btn_konv
            // 
            this.btn_konv.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_konv.Location = new System.Drawing.Point(345, 41);
            this.btn_konv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_konv.Name = "btn_konv";
            this.btn_konv.Size = new System.Drawing.Size(133, 43);
            this.btn_konv.TabIndex = 1;
            this.btn_konv.Text = "Konversi";
            this.btn_konv.UseVisualStyleBackColor = true;
            this.btn_konv.Click += new System.EventHandler(this.btn_konv_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Masukkan angka (tanpa titik/koma)";
            // 
            // lbl_terbilang
            // 
            this.lbl_terbilang.AutoSize = true;
            this.lbl_terbilang.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_terbilang.Location = new System.Drawing.Point(13, 103);
            this.lbl_terbilang.Name = "lbl_terbilang";
            this.lbl_terbilang.Size = new System.Drawing.Size(117, 29);
            this.lbl_terbilang.TabIndex = 3;
            this.lbl_terbilang.Text = "Terbilang";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(781, 153);
            this.Controls.Add(this.lbl_terbilang);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_konv);
            this.Controls.Add(this.tb_angka);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Konversi Angka ke Huruf";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_angka;
        private System.Windows.Forms.Button btn_konv;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_terbilang;
    }
}

