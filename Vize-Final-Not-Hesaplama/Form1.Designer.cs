
namespace Vize_Final_Not_Hesaplama
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
            this.btn2vize = new System.Windows.Forms.Button();
            this.btn3Vize = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn2vize
            // 
            this.btn2vize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn2vize.Location = new System.Drawing.Point(140, 144);
            this.btn2vize.Name = "btn2vize";
            this.btn2vize.Size = new System.Drawing.Size(154, 59);
            this.btn2vize.TabIndex = 0;
            this.btn2vize.Text = "2 vize 1 final Hesaplama";
            this.btn2vize.UseVisualStyleBackColor = true;
            this.btn2vize.Click += new System.EventHandler(this.btn2vize_Click);
            // 
            // btn3Vize
            // 
            this.btn3Vize.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btn3Vize.Location = new System.Drawing.Point(445, 144);
            this.btn3Vize.Name = "btn3Vize";
            this.btn3Vize.Size = new System.Drawing.Size(154, 59);
            this.btn3Vize.TabIndex = 0;
            this.btn3Vize.Text = "3 vize 1 final Hesaplama";
            this.btn3Vize.UseVisualStyleBackColor = true;
            this.btn3Vize.Click += new System.EventHandler(this.btn3Vize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3Vize);
            this.Controls.Add(this.btn2vize);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn2vize;
        private System.Windows.Forms.Button btn3Vize;
    }
}

