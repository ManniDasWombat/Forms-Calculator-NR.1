namespace Taschenrechner
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.box_rechnung = new System.Windows.Forms.TextBox();
            this.b_geteilt = new System.Windows.Forms.Button();
            this.b_mal = new System.Windows.Forms.Button();
            this.b_ergebnis = new System.Windows.Forms.Button();
            this.b_minus = new System.Windows.Forms.Button();
            this.b_zahl9 = new System.Windows.Forms.Button();
            this.b_zahl8 = new System.Windows.Forms.Button();
            this.b_zahl7 = new System.Windows.Forms.Button();
            this.b_zahl6 = new System.Windows.Forms.Button();
            this.b_zahl5 = new System.Windows.Forms.Button();
            this.b_zahl4 = new System.Windows.Forms.Button();
            this.b_zahl3 = new System.Windows.Forms.Button();
            this.b_zahl2 = new System.Windows.Forms.Button();
            this.b_zahl1 = new System.Windows.Forms.Button();
            this.b_plus = new System.Windows.Forms.Button();
            this.b_zahl10 = new System.Windows.Forms.Button();
            this.b_clear = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.b_delete = new System.Windows.Forms.Button();
            this.b_komma = new System.Windows.Forms.Button();
            this.b_prozent = new System.Windows.Forms.Button();
            this.box_prozent = new System.Windows.Forms.TextBox();
            this.box_ergebnis = new System.Windows.Forms.TextBox();
            this.label_zahl3 = new System.Windows.Forms.Label();
            this.label_zahlx = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // box_rechnung
            // 
            this.box_rechnung.BackColor = System.Drawing.Color.White;
            this.box_rechnung.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_rechnung.Location = new System.Drawing.Point(31, 17);
            this.box_rechnung.Name = "box_rechnung";
            this.box_rechnung.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.box_rechnung.Size = new System.Drawing.Size(506, 44);
            this.box_rechnung.TabIndex = 39;
            // 
            // b_geteilt
            // 
            this.b_geteilt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_geteilt.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_geteilt.Location = new System.Drawing.Point(428, 243);
            this.b_geteilt.Name = "b_geteilt";
            this.b_geteilt.Size = new System.Drawing.Size(109, 63);
            this.b_geteilt.TabIndex = 38;
            this.b_geteilt.Text = ":";
            this.b_geteilt.UseVisualStyleBackColor = false;
            this.b_geteilt.Click += new System.EventHandler(this.b_geteilt_Click);
            // 
            // b_mal
            // 
            this.b_mal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_mal.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_mal.Location = new System.Drawing.Point(313, 243);
            this.b_mal.Name = "b_mal";
            this.b_mal.Size = new System.Drawing.Size(109, 63);
            this.b_mal.TabIndex = 37;
            this.b_mal.Text = "*";
            this.b_mal.UseVisualStyleBackColor = false;
            this.b_mal.Click += new System.EventHandler(this.b_mal_Click);
            // 
            // b_ergebnis
            // 
            this.b_ergebnis.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.b_ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_ergebnis.Location = new System.Drawing.Point(428, 315);
            this.b_ergebnis.Name = "b_ergebnis";
            this.b_ergebnis.Size = new System.Drawing.Size(109, 129);
            this.b_ergebnis.TabIndex = 36;
            this.b_ergebnis.Text = "=";
            this.b_ergebnis.UseVisualStyleBackColor = false;
            this.b_ergebnis.Click += new System.EventHandler(this.b_ergebnis_Click);
            // 
            // b_minus
            // 
            this.b_minus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_minus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_minus.Location = new System.Drawing.Point(428, 174);
            this.b_minus.Name = "b_minus";
            this.b_minus.Size = new System.Drawing.Size(109, 63);
            this.b_minus.TabIndex = 35;
            this.b_minus.Text = "-";
            this.b_minus.UseVisualStyleBackColor = false;
            this.b_minus.Click += new System.EventHandler(this.b_minus_Click);
            // 
            // b_zahl9
            // 
            this.b_zahl9.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl9.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl9.Location = new System.Drawing.Point(174, 159);
            this.b_zahl9.Name = "b_zahl9";
            this.b_zahl9.Size = new System.Drawing.Size(70, 63);
            this.b_zahl9.TabIndex = 34;
            this.b_zahl9.Text = "9";
            this.b_zahl9.UseVisualStyleBackColor = false;
            this.b_zahl9.Click += new System.EventHandler(this.b_zahl9_Click);
            // 
            // b_zahl8
            // 
            this.b_zahl8.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl8.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl8.Location = new System.Drawing.Point(98, 159);
            this.b_zahl8.Name = "b_zahl8";
            this.b_zahl8.Size = new System.Drawing.Size(70, 63);
            this.b_zahl8.TabIndex = 33;
            this.b_zahl8.Text = "8";
            this.b_zahl8.UseVisualStyleBackColor = false;
            this.b_zahl8.Click += new System.EventHandler(this.b_zahl8_Click);
            // 
            // b_zahl7
            // 
            this.b_zahl7.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl7.Location = new System.Drawing.Point(22, 159);
            this.b_zahl7.Name = "b_zahl7";
            this.b_zahl7.Size = new System.Drawing.Size(70, 63);
            this.b_zahl7.TabIndex = 32;
            this.b_zahl7.Text = "7";
            this.b_zahl7.UseVisualStyleBackColor = false;
            this.b_zahl7.Click += new System.EventHandler(this.b_zahl7_Click);
            // 
            // b_zahl6
            // 
            this.b_zahl6.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl6.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl6.Location = new System.Drawing.Point(174, 87);
            this.b_zahl6.Name = "b_zahl6";
            this.b_zahl6.Size = new System.Drawing.Size(70, 63);
            this.b_zahl6.TabIndex = 31;
            this.b_zahl6.Text = "6";
            this.b_zahl6.UseVisualStyleBackColor = false;
            this.b_zahl6.Click += new System.EventHandler(this.b_zahl6_Click);
            // 
            // b_zahl5
            // 
            this.b_zahl5.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl5.Location = new System.Drawing.Point(98, 87);
            this.b_zahl5.Name = "b_zahl5";
            this.b_zahl5.Size = new System.Drawing.Size(70, 63);
            this.b_zahl5.TabIndex = 30;
            this.b_zahl5.Text = "5";
            this.b_zahl5.UseVisualStyleBackColor = false;
            this.b_zahl5.Click += new System.EventHandler(this.b_zahl5_Click);
            // 
            // b_zahl4
            // 
            this.b_zahl4.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl4.Location = new System.Drawing.Point(22, 87);
            this.b_zahl4.Name = "b_zahl4";
            this.b_zahl4.Size = new System.Drawing.Size(70, 63);
            this.b_zahl4.TabIndex = 29;
            this.b_zahl4.Text = "4";
            this.b_zahl4.UseVisualStyleBackColor = false;
            this.b_zahl4.Click += new System.EventHandler(this.b_zahl4_Click);
            // 
            // b_zahl3
            // 
            this.b_zahl3.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl3.Location = new System.Drawing.Point(174, 18);
            this.b_zahl3.Name = "b_zahl3";
            this.b_zahl3.Size = new System.Drawing.Size(70, 63);
            this.b_zahl3.TabIndex = 28;
            this.b_zahl3.Text = "3";
            this.b_zahl3.UseVisualStyleBackColor = false;
            this.b_zahl3.Click += new System.EventHandler(this.b_zahl3_Click);
            // 
            // b_zahl2
            // 
            this.b_zahl2.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl2.Location = new System.Drawing.Point(98, 18);
            this.b_zahl2.Name = "b_zahl2";
            this.b_zahl2.Size = new System.Drawing.Size(70, 63);
            this.b_zahl2.TabIndex = 27;
            this.b_zahl2.Text = "2";
            this.b_zahl2.UseVisualStyleBackColor = false;
            this.b_zahl2.Click += new System.EventHandler(this.b_zahl2_Click);
            // 
            // b_zahl1
            // 
            this.b_zahl1.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl1.Location = new System.Drawing.Point(22, 18);
            this.b_zahl1.Name = "b_zahl1";
            this.b_zahl1.Size = new System.Drawing.Size(70, 63);
            this.b_zahl1.TabIndex = 26;
            this.b_zahl1.Text = "1";
            this.b_zahl1.UseVisualStyleBackColor = false;
            this.b_zahl1.Click += new System.EventHandler(this.b_zahl1_Click);
            // 
            // b_plus
            // 
            this.b_plus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.b_plus.CausesValidation = false;
            this.b_plus.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_plus.Location = new System.Drawing.Point(313, 174);
            this.b_plus.Name = "b_plus";
            this.b_plus.Size = new System.Drawing.Size(109, 63);
            this.b_plus.TabIndex = 25;
            this.b_plus.Text = "+";
            this.b_plus.UseVisualStyleBackColor = false;
            this.b_plus.Click += new System.EventHandler(this.b_plus_Click);
            // 
            // b_zahl10
            // 
            this.b_zahl10.BackColor = System.Drawing.Color.Yellow;
            this.b_zahl10.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_zahl10.Location = new System.Drawing.Point(98, 227);
            this.b_zahl10.Name = "b_zahl10";
            this.b_zahl10.Size = new System.Drawing.Size(70, 60);
            this.b_zahl10.TabIndex = 24;
            this.b_zahl10.Text = "0";
            this.b_zahl10.UseVisualStyleBackColor = false;
            this.b_zahl10.Click += new System.EventHandler(this.b_zahl10_Click);
            // 
            // b_clear
            // 
            this.b_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.b_clear.Location = new System.Drawing.Point(313, 371);
            this.b_clear.Name = "b_clear";
            this.b_clear.Size = new System.Drawing.Size(109, 73);
            this.b_clear.TabIndex = 45;
            this.b_clear.Text = "C L E A R";
            this.b_clear.UseVisualStyleBackColor = false;
            this.b_clear.Click += new System.EventHandler(this.b_clear_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.b_delete);
            this.groupBox1.Controls.Add(this.b_komma);
            this.groupBox1.Controls.Add(this.b_zahl9);
            this.groupBox1.Controls.Add(this.b_zahl8);
            this.groupBox1.Controls.Add(this.b_zahl7);
            this.groupBox1.Controls.Add(this.b_zahl6);
            this.groupBox1.Controls.Add(this.b_zahl5);
            this.groupBox1.Controls.Add(this.b_zahl4);
            this.groupBox1.Controls.Add(this.b_zahl3);
            this.groupBox1.Controls.Add(this.b_zahl2);
            this.groupBox1.Controls.Add(this.b_zahl1);
            this.groupBox1.Controls.Add(this.b_zahl10);
            this.groupBox1.Location = new System.Drawing.Point(18, 156);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(268, 304);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Numpad";
            // 
            // b_delete
            // 
            this.b_delete.BackColor = System.Drawing.Color.Yellow;
            this.b_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_delete.Location = new System.Drawing.Point(22, 227);
            this.b_delete.Name = "b_delete";
            this.b_delete.Size = new System.Drawing.Size(70, 60);
            this.b_delete.TabIndex = 36;
            this.b_delete.Text = "DELETE";
            this.b_delete.UseVisualStyleBackColor = false;
            this.b_delete.Click += new System.EventHandler(this.b_delete_Click);
            // 
            // b_komma
            // 
            this.b_komma.BackColor = System.Drawing.Color.Yellow;
            this.b_komma.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_komma.Location = new System.Drawing.Point(174, 227);
            this.b_komma.Name = "b_komma";
            this.b_komma.Size = new System.Drawing.Size(70, 60);
            this.b_komma.TabIndex = 35;
            this.b_komma.Text = ",";
            this.b_komma.UseVisualStyleBackColor = false;
            this.b_komma.Click += new System.EventHandler(this.b_komma_Click);
            // 
            // b_prozent
            // 
            this.b_prozent.BackColor = System.Drawing.Color.Green;
            this.b_prozent.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b_prozent.Location = new System.Drawing.Point(381, 318);
            this.b_prozent.Name = "b_prozent";
            this.b_prozent.Size = new System.Drawing.Size(41, 47);
            this.b_prozent.TabIndex = 36;
            this.b_prozent.Text = "%";
            this.b_prozent.UseVisualStyleBackColor = false;
            this.b_prozent.Click += new System.EventHandler(this.b_prozent_Click);
            // 
            // box_prozent
            // 
            this.box_prozent.BackColor = System.Drawing.Color.Green;
            this.box_prozent.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_prozent.Location = new System.Drawing.Point(313, 318);
            this.box_prozent.Name = "box_prozent";
            this.box_prozent.Size = new System.Drawing.Size(62, 47);
            this.box_prozent.TabIndex = 47;
            this.box_prozent.Text = "100";
            // 
            // box_ergebnis
            // 
            this.box_ergebnis.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.box_ergebnis.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_ergebnis.Location = new System.Drawing.Point(313, 83);
            this.box_ergebnis.Name = "box_ergebnis";
            this.box_ergebnis.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.box_ergebnis.Size = new System.Drawing.Size(224, 44);
            this.box_ergebnis.TabIndex = 48;
            this.box_ergebnis.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label_zahl3
            // 
            this.label_zahl3.AutoSize = true;
            this.label_zahl3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_zahl3.Location = new System.Drawing.Point(521, 142);
            this.label_zahl3.Name = "label_zahl3";
            this.label_zahl3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label_zahl3.Size = new System.Drawing.Size(16, 16);
            this.label_zahl3.TabIndex = 49;
            this.label_zahl3.Text = "0";
            this.label_zahl3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label_zahlx
            // 
            this.label_zahlx.AutoSize = true;
            this.label_zahlx.Location = new System.Drawing.Point(40, 83);
            this.label_zahlx.Name = "label_zahlx";
            this.label_zahlx.Size = new System.Drawing.Size(68, 13);
            this.label_zahlx.TabIndex = 50;
            this.label_zahlx.Text = "aktuelle Zahl";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(313, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 16);
            this.label2.TabIndex = 51;
            this.label2.Text = "Letztes Ergebnis";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(567, 470);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label_zahlx);
            this.Controls.Add(this.label_zahl3);
            this.Controls.Add(this.box_ergebnis);
            this.Controls.Add(this.box_prozent);
            this.Controls.Add(this.b_prozent);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.b_clear);
            this.Controls.Add(this.box_rechnung);
            this.Controls.Add(this.b_geteilt);
            this.Controls.Add(this.b_mal);
            this.Controls.Add(this.b_ergebnis);
            this.Controls.Add(this.b_minus);
            this.Controls.Add(this.b_plus);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.Text = "Taschenrechner Extended 3000";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.TextBox box_rechnung;
        internal System.Windows.Forms.Button b_geteilt;
        internal System.Windows.Forms.Button b_mal;
        internal System.Windows.Forms.Button b_ergebnis;
        internal System.Windows.Forms.Button b_minus;
        internal System.Windows.Forms.Button b_zahl9;
        internal System.Windows.Forms.Button b_zahl8;
        internal System.Windows.Forms.Button b_zahl7;
        internal System.Windows.Forms.Button b_zahl6;
        internal System.Windows.Forms.Button b_zahl5;
        internal System.Windows.Forms.Button b_zahl4;
        internal System.Windows.Forms.Button b_zahl3;
        internal System.Windows.Forms.Button b_zahl2;
        internal System.Windows.Forms.Button b_zahl1;
        internal System.Windows.Forms.Button b_plus;
        internal System.Windows.Forms.Button b_zahl10;
        private System.Windows.Forms.Button b_clear;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button b_komma;
        internal System.Windows.Forms.Button b_prozent;
        private System.Windows.Forms.TextBox box_prozent;
        internal System.Windows.Forms.TextBox box_ergebnis;
        internal System.Windows.Forms.Button b_delete;
        private System.Windows.Forms.Label label_zahl3;
        private System.Windows.Forms.Label label_zahlx;
        private System.Windows.Forms.Label label2;
    }
}

