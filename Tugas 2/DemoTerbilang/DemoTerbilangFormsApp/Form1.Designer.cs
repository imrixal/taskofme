namespace DemoTerbilangFormsApp
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textNominal = new System.Windows.Forms.TextBox();
            this.cekBtn = new System.Windows.Forms.Button();
            this.hasilBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nominal";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Terbilang";
            // 
            // textNominal
            // 
            this.textNominal.Location = new System.Drawing.Point(74, 12);
            this.textNominal.Name = "textNominal";
            this.textNominal.Size = new System.Drawing.Size(135, 20);
            this.textNominal.TabIndex = 2;
            // 
            // cekBtn
            // 
            this.cekBtn.Location = new System.Drawing.Point(232, 10);
            this.cekBtn.Name = "cekBtn";
            this.cekBtn.Size = new System.Drawing.Size(91, 23);
            this.cekBtn.TabIndex = 3;
            this.cekBtn.Text = "Cek Terbilang";
            this.cekBtn.UseVisualStyleBackColor = true;
            this.cekBtn.Click += new System.EventHandler(this.cekBtn_Click);
            // 
            // hasilBox
            // 
            this.hasilBox.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.hasilBox.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.hasilBox.FormattingEnabled = true;
            this.hasilBox.Location = new System.Drawing.Point(74, 47);
            this.hasilBox.Name = "hasilBox";
            this.hasilBox.Size = new System.Drawing.Size(842, 95);
            this.hasilBox.TabIndex = 4;
            this.hasilBox.SelectedIndexChanged += new System.EventHandler(this.hasilBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(933, 161);
            this.Controls.Add(this.hasilBox);
            this.Controls.Add(this.cekBtn);
            this.Controls.Add(this.textNominal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Demo Terbilang";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textNominal;
        private System.Windows.Forms.Button cekBtn;
        private System.Windows.Forms.ListBox hasilBox;
    }
}

