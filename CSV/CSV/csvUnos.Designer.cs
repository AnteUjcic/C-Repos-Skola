
namespace CSV
{
    partial class csvUnos
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
            this.txtUnosIme = new System.Windows.Forms.TextBox();
            this.txtUnosPrezime = new System.Windows.Forms.TextBox();
            this.txtUnosEmail = new System.Windows.Forms.TextBox();
            this.txtUnosRazred = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtUnosIme
            // 
            this.txtUnosIme.Location = new System.Drawing.Point(43, 39);
            this.txtUnosIme.Name = "txtUnosIme";
            this.txtUnosIme.Size = new System.Drawing.Size(165, 23);
            this.txtUnosIme.TabIndex = 0;
            // 
            // txtUnosPrezime
            // 
            this.txtUnosPrezime.Location = new System.Drawing.Point(42, 83);
            this.txtUnosPrezime.Name = "txtUnosPrezime";
            this.txtUnosPrezime.Size = new System.Drawing.Size(165, 23);
            this.txtUnosPrezime.TabIndex = 1;
            // 
            // txtUnosEmail
            // 
            this.txtUnosEmail.Location = new System.Drawing.Point(42, 127);
            this.txtUnosEmail.Name = "txtUnosEmail";
            this.txtUnosEmail.Size = new System.Drawing.Size(165, 23);
            this.txtUnosEmail.TabIndex = 2;
            // 
            // txtUnosRazred
            // 
            this.txtUnosRazred.Location = new System.Drawing.Point(42, 171);
            this.txtUnosRazred.Name = "txtUnosRazred";
            this.txtUnosRazred.Size = new System.Drawing.Size(165, 23);
            this.txtUnosRazred.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ime";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(42, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "Prezime";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(42, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 15);
            this.label3.TabIndex = 6;
            this.label3.Text = "E-Mail";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(42, 153);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 15);
            this.label4.TabIndex = 7;
            this.label4.Text = "Razred";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(43, 213);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 43);
            this.button1.TabIndex = 8;
            this.button1.Text = "Unos";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(43, 262);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "Zavrsi";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // csvUnos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtUnosRazred);
            this.Controls.Add(this.txtUnosEmail);
            this.Controls.Add(this.txtUnosPrezime);
            this.Controls.Add(this.txtUnosIme);
            this.Name = "csvUnos";
            this.Text = "csvUnos";
            this.Load += new System.EventHandler(this.csvUnos_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnosIme;
        private System.Windows.Forms.TextBox txtUnosPrezime;
        private System.Windows.Forms.TextBox txtUnosEmail;
        private System.Windows.Forms.TextBox txtUnosRazred;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt;
    }
}