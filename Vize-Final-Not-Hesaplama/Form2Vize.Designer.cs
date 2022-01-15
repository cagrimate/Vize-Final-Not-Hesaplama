
namespace Vize_Final_Not_Hesaplama
{
    partial class Form2Vize
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
            this.lblVize1 = new System.Windows.Forms.Label();
            this.lblVize2 = new System.Windows.Forms.Label();
            this.lblFinal = new System.Windows.Forms.Label();
            this.lblOrt = new System.Windows.Forms.Label();
            this.txtVize1 = new System.Windows.Forms.TextBox();
            this.txtVize2 = new System.Windows.Forms.TextBox();
            this.txtFinal = new System.Windows.Forms.TextBox();
            this.txtOrt = new System.Windows.Forms.TextBox();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.txtSonuc = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblVize1
            // 
            this.lblVize1.AutoSize = true;
            this.lblVize1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVize1.Location = new System.Drawing.Point(139, 59);
            this.lblVize1.Name = "lblVize1";
            this.lblVize1.Size = new System.Drawing.Size(74, 20);
            this.lblVize1.TabIndex = 0;
            this.lblVize1.Text = "1. Vize :";
            // 
            // lblVize2
            // 
            this.lblVize2.AutoSize = true;
            this.lblVize2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblVize2.Location = new System.Drawing.Point(139, 98);
            this.lblVize2.Name = "lblVize2";
            this.lblVize2.Size = new System.Drawing.Size(74, 20);
            this.lblVize2.TabIndex = 0;
            this.lblVize2.Text = "2. Vize :";
            // 
            // lblFinal
            // 
            this.lblFinal.AutoSize = true;
            this.lblFinal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblFinal.Location = new System.Drawing.Point(139, 136);
            this.lblFinal.Name = "lblFinal";
            this.lblFinal.Size = new System.Drawing.Size(58, 20);
            this.lblFinal.TabIndex = 0;
            this.lblFinal.Text = "Final :";
            // 
            // lblOrt
            // 
            this.lblOrt.AutoSize = true;
            this.lblOrt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblOrt.Location = new System.Drawing.Point(139, 187);
            this.lblOrt.Name = "lblOrt";
            this.lblOrt.Size = new System.Drawing.Size(92, 20);
            this.lblOrt.TabIndex = 0;
            this.lblOrt.Text = "Ortalama :";
            // 
            // txtVize1
            // 
            this.txtVize1.Location = new System.Drawing.Point(272, 58);
            this.txtVize1.Name = "txtVize1";
            this.txtVize1.Size = new System.Drawing.Size(100, 20);
            this.txtVize1.TabIndex = 1;
            // 
            // txtVize2
            // 
            this.txtVize2.Location = new System.Drawing.Point(272, 100);
            this.txtVize2.Name = "txtVize2";
            this.txtVize2.Size = new System.Drawing.Size(100, 20);
            this.txtVize2.TabIndex = 1;
            // 
            // txtFinal
            // 
            this.txtFinal.Location = new System.Drawing.Point(272, 138);
            this.txtFinal.Name = "txtFinal";
            this.txtFinal.Size = new System.Drawing.Size(100, 20);
            this.txtFinal.TabIndex = 1;
            // 
            // txtOrt
            // 
            this.txtOrt.Enabled = false;
            this.txtOrt.Location = new System.Drawing.Point(272, 189);
            this.txtOrt.Name = "txtOrt";
            this.txtOrt.Size = new System.Drawing.Size(100, 20);
            this.txtOrt.TabIndex = 1;
            // 
            // btnHesapla
            // 
            this.btnHesapla.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnHesapla.Location = new System.Drawing.Point(272, 239);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(128, 60);
            this.btnHesapla.TabIndex = 2;
            this.btnHesapla.Text = "HESAPLA ";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // txtSonuc
            // 
            this.txtSonuc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.txtSonuc.Location = new System.Drawing.Point(455, 189);
            this.txtSonuc.Name = "txtSonuc";
            this.txtSonuc.Size = new System.Drawing.Size(324, 30);
            this.txtSonuc.TabIndex = 3;
            this.txtSonuc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Form2Vize
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtSonuc);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.txtOrt);
            this.Controls.Add(this.txtFinal);
            this.Controls.Add(this.txtVize2);
            this.Controls.Add(this.txtVize1);
            this.Controls.Add(this.lblOrt);
            this.Controls.Add(this.lblFinal);
            this.Controls.Add(this.lblVize2);
            this.Controls.Add(this.lblVize1);
            this.Name = "Form2Vize";
            this.Text = "Form2Vize";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVize1;
        private System.Windows.Forms.Label lblVize2;
        private System.Windows.Forms.Label lblFinal;
        private System.Windows.Forms.Label lblOrt;
        private System.Windows.Forms.TextBox txtVize1;
        private System.Windows.Forms.TextBox txtVize2;
        private System.Windows.Forms.TextBox txtFinal;
        private System.Windows.Forms.TextBox txtOrt;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.TextBox txtSonuc;
    }
}