namespace FinalProject
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
            this.my = new System.Windows.Forms.RadioButton();
            this.postgre = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.lbl3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(234, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hoşgeldiniz";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Lütfen Veritabanı Seçiniz";
            // 
            // my
            // 
            this.my.AutoSize = true;
            this.my.Location = new System.Drawing.Point(237, 116);
            this.my.Name = "my";
            this.my.Size = new System.Drawing.Size(60, 17);
            this.my.TabIndex = 0;
            this.my.TabStop = true;
            this.my.Text = "MySQL";
            this.my.UseVisualStyleBackColor = true;
            // 
            // postgre
            // 
            this.postgre.AutoSize = true;
            this.postgre.Location = new System.Drawing.Point(361, 116);
            this.postgre.Name = "postgre";
            this.postgre.Size = new System.Drawing.Size(82, 17);
            this.postgre.TabIndex = 0;
            this.postgre.TabStop = true;
            this.postgre.Text = "PostgreSQL";
            this.postgre.UseVisualStyleBackColor = true;
            this.postgre.CheckedChanged += new System.EventHandler(this.postgre_CheckedChanged);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(283, 181);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Giriş";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(264, 150);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(0, 13);
            this.lbl3.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 450);
            this.Controls.Add(this.lbl3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.postgre);
            this.Controls.Add(this.my);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton my;
        private System.Windows.Forms.RadioButton postgre;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lbl3;
    }
}

