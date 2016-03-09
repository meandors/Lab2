namespace JP_lab2_03_2016
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
            this.tbPath = new System.Windows.Forms.TextBox();
            this.bPrzegladaj = new System.Windows.Forms.Button();
            this.bOdczyt = new System.Windows.Forms.Button();
            this.bZapis = new System.Windows.Forms.Button();
            this.rbPlik = new System.Windows.Forms.RadioButton();
            this.rbPamiec = new System.Windows.Forms.RadioButton();
            this.cbSzyfrowanie = new System.Windows.Forms.CheckBox();
            this.cbKompresja = new System.Windows.Forms.CheckBox();
            this.tbResult = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // tbPath
            // 
            this.tbPath.Location = new System.Drawing.Point(118, 12);
            this.tbPath.Name = "tbPath";
            this.tbPath.Size = new System.Drawing.Size(327, 20);
            this.tbPath.TabIndex = 0;
            this.tbPath.Text = "C:\\";
            // 
            // bPrzegladaj
            // 
            this.bPrzegladaj.Location = new System.Drawing.Point(451, 12);
            this.bPrzegladaj.Name = "bPrzegladaj";
            this.bPrzegladaj.Size = new System.Drawing.Size(75, 23);
            this.bPrzegladaj.TabIndex = 1;
            this.bPrzegladaj.Text = "Przegladaj";
            this.bPrzegladaj.UseVisualStyleBackColor = true;
            this.bPrzegladaj.Click += new System.EventHandler(this.bPrzegladaj_Click);
            // 
            // bOdczyt
            // 
            this.bOdczyt.Location = new System.Drawing.Point(451, 41);
            this.bOdczyt.Name = "bOdczyt";
            this.bOdczyt.Size = new System.Drawing.Size(75, 23);
            this.bOdczyt.TabIndex = 2;
            this.bOdczyt.Text = "Odczyt";
            this.bOdczyt.UseVisualStyleBackColor = true;
            this.bOdczyt.Click += new System.EventHandler(this.bOdczyt_Click);
            // 
            // bZapis
            // 
            this.bZapis.Location = new System.Drawing.Point(451, 70);
            this.bZapis.Name = "bZapis";
            this.bZapis.Size = new System.Drawing.Size(75, 23);
            this.bZapis.TabIndex = 3;
            this.bZapis.Text = "Zapis";
            this.bZapis.UseVisualStyleBackColor = true;
            this.bZapis.Click += new System.EventHandler(this.bZapis_Click);
            // 
            // rbPlik
            // 
            this.rbPlik.AutoSize = true;
            this.rbPlik.Checked = true;
            this.rbPlik.Location = new System.Drawing.Point(27, 15);
            this.rbPlik.Name = "rbPlik";
            this.rbPlik.Size = new System.Drawing.Size(42, 17);
            this.rbPlik.TabIndex = 4;
            this.rbPlik.TabStop = true;
            this.rbPlik.Text = "Plik";
            this.rbPlik.UseVisualStyleBackColor = true;
            // 
            // rbPamiec
            // 
            this.rbPamiec.AutoSize = true;
            this.rbPamiec.Location = new System.Drawing.Point(27, 38);
            this.rbPamiec.Name = "rbPamiec";
            this.rbPamiec.Size = new System.Drawing.Size(60, 17);
            this.rbPamiec.TabIndex = 5;
            this.rbPamiec.Text = "Pamięć";
            this.rbPamiec.UseVisualStyleBackColor = true;
            // 
            // cbSzyfrowanie
            // 
            this.cbSzyfrowanie.AutoSize = true;
            this.cbSzyfrowanie.Location = new System.Drawing.Point(36, 86);
            this.cbSzyfrowanie.Name = "cbSzyfrowanie";
            this.cbSzyfrowanie.Size = new System.Drawing.Size(83, 17);
            this.cbSzyfrowanie.TabIndex = 6;
            this.cbSzyfrowanie.Text = "Szyfrowanie";
            this.cbSzyfrowanie.UseVisualStyleBackColor = true;
            // 
            // cbKompresja
            // 
            this.cbKompresja.AutoSize = true;
            this.cbKompresja.Location = new System.Drawing.Point(122, 86);
            this.cbKompresja.Name = "cbKompresja";
            this.cbKompresja.Size = new System.Drawing.Size(75, 17);
            this.cbKompresja.TabIndex = 7;
            this.cbKompresja.Text = "Kompresja";
            this.cbKompresja.UseVisualStyleBackColor = true;
            // 
            // tbResult
            // 
            this.tbResult.Location = new System.Drawing.Point(36, 109);
            this.tbResult.Multiline = true;
            this.tbResult.Name = "tbResult";
            this.tbResult.Size = new System.Drawing.Size(409, 93);
            this.tbResult.TabIndex = 8;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(542, 229);
            this.Controls.Add(this.tbResult);
            this.Controls.Add(this.cbKompresja);
            this.Controls.Add(this.cbSzyfrowanie);
            this.Controls.Add(this.rbPamiec);
            this.Controls.Add(this.rbPlik);
            this.Controls.Add(this.bZapis);
            this.Controls.Add(this.bOdczyt);
            this.Controls.Add(this.bPrzegladaj);
            this.Controls.Add(this.tbPath);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Strumienie";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbPath;
        private System.Windows.Forms.Button bPrzegladaj;
        private System.Windows.Forms.Button bOdczyt;
        private System.Windows.Forms.Button bZapis;
        private System.Windows.Forms.RadioButton rbPlik;
        private System.Windows.Forms.RadioButton rbPamiec;
        private System.Windows.Forms.CheckBox cbSzyfrowanie;
        private System.Windows.Forms.CheckBox cbKompresja;
        private System.Windows.Forms.TextBox tbResult;
    }
}

