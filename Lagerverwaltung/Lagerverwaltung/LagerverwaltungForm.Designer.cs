namespace Lagerverwaltung
{
    partial class FormLagerverwaltung
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
            this.buttonKaufen = new System.Windows.Forms.Button();
            this.buttonUmlagern = new System.Windows.Forms.Button();
            this.buttonAuslagern = new System.Windows.Forms.Button();
            this.buttonBuchen = new System.Windows.Forms.Button();
            this.textBoxKaufen = new System.Windows.Forms.TextBox();
            this.textBoxUmlagern = new System.Windows.Forms.TextBox();
            this.textBoxAuslagern = new System.Windows.Forms.TextBox();
            this.textBoxBuchen = new System.Windows.Forms.TextBox();
            this.labelKoeln = new System.Windows.Forms.Label();
            this.labelKoelnBonn = new System.Windows.Forms.Label();
            this.labelLeverkusenKoeln = new System.Windows.Forms.Label();
            this.labelKoelnMenge = new System.Windows.Forms.Label();
            this.labelKoelnMenge2 = new System.Windows.Forms.Label();
            this.labelBonnMenge = new System.Windows.Forms.Label();
            this.labelMenge = new System.Windows.Forms.Label();
            this.labelLeverkusenMenge = new System.Windows.Forms.Label();
            this.labelKoelnMenge3 = new System.Windows.Forms.Label();
            this.labelGesamtmenge2 = new System.Windows.Forms.Label();
            this.labelGesamtmenge1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonKaufen
            // 
            this.buttonKaufen.Location = new System.Drawing.Point(13, 13);
            this.buttonKaufen.Name = "buttonKaufen";
            this.buttonKaufen.Size = new System.Drawing.Size(75, 23);
            this.buttonKaufen.TabIndex = 0;
            this.buttonKaufen.Text = "Kaufen";
            this.buttonKaufen.UseVisualStyleBackColor = true;
            this.buttonKaufen.Click += new System.EventHandler(this.buttonKaufen_Click);
            // 
            // buttonUmlagern
            // 
            this.buttonUmlagern.Location = new System.Drawing.Point(13, 42);
            this.buttonUmlagern.Name = "buttonUmlagern";
            this.buttonUmlagern.Size = new System.Drawing.Size(75, 23);
            this.buttonUmlagern.TabIndex = 1;
            this.buttonUmlagern.Text = "Umlagern";
            this.buttonUmlagern.UseVisualStyleBackColor = true;
            this.buttonUmlagern.Click += new System.EventHandler(this.buttonUmlagern_Click);
            // 
            // buttonAuslagern
            // 
            this.buttonAuslagern.Location = new System.Drawing.Point(13, 71);
            this.buttonAuslagern.Name = "buttonAuslagern";
            this.buttonAuslagern.Size = new System.Drawing.Size(75, 23);
            this.buttonAuslagern.TabIndex = 2;
            this.buttonAuslagern.Text = "Auslagern";
            this.buttonAuslagern.UseVisualStyleBackColor = true;
            this.buttonAuslagern.Click += new System.EventHandler(this.buttonAuslagern_Click);
            // 
            // buttonBuchen
            // 
            this.buttonBuchen.Location = new System.Drawing.Point(13, 101);
            this.buttonBuchen.Name = "buttonBuchen";
            this.buttonBuchen.Size = new System.Drawing.Size(75, 23);
            this.buttonBuchen.TabIndex = 3;
            this.buttonBuchen.Text = "Buchen";
            this.buttonBuchen.UseVisualStyleBackColor = true;
            this.buttonBuchen.Click += new System.EventHandler(this.buttonBuchen_Click);
            // 
            // textBoxKaufen
            // 
            this.textBoxKaufen.Location = new System.Drawing.Point(95, 13);
            this.textBoxKaufen.Name = "textBoxKaufen";
            this.textBoxKaufen.Size = new System.Drawing.Size(100, 20);
            this.textBoxKaufen.TabIndex = 4;
            // 
            // textBoxUmlagern
            // 
            this.textBoxUmlagern.Location = new System.Drawing.Point(95, 42);
            this.textBoxUmlagern.Name = "textBoxUmlagern";
            this.textBoxUmlagern.Size = new System.Drawing.Size(100, 20);
            this.textBoxUmlagern.TabIndex = 5;
            // 
            // textBoxAuslagern
            // 
            this.textBoxAuslagern.Location = new System.Drawing.Point(95, 69);
            this.textBoxAuslagern.Name = "textBoxAuslagern";
            this.textBoxAuslagern.Size = new System.Drawing.Size(100, 20);
            this.textBoxAuslagern.TabIndex = 6;
            // 
            // textBoxBuchen
            // 
            this.textBoxBuchen.Location = new System.Drawing.Point(95, 101);
            this.textBoxBuchen.Name = "textBoxBuchen";
            this.textBoxBuchen.ReadOnly = true;
            this.textBoxBuchen.Size = new System.Drawing.Size(100, 20);
            this.textBoxBuchen.TabIndex = 7;
            this.textBoxBuchen.Text = "500";
            // 
            // labelKoeln
            // 
            this.labelKoeln.AutoSize = true;
            this.labelKoeln.Location = new System.Drawing.Point(203, 19);
            this.labelKoeln.Name = "labelKoeln";
            this.labelKoeln.Size = new System.Drawing.Size(28, 13);
            this.labelKoeln.TabIndex = 8;
            this.labelKoeln.Text = "Köln";
            // 
            // labelKoelnBonn
            // 
            this.labelKoelnBonn.AutoSize = true;
            this.labelKoelnBonn.Location = new System.Drawing.Point(203, 48);
            this.labelKoelnBonn.Name = "labelKoelnBonn";
            this.labelKoelnBonn.Size = new System.Drawing.Size(68, 13);
            this.labelKoelnBonn.TabIndex = 9;
            this.labelKoelnBonn.Text = "Köln -> Bonn";
            // 
            // labelLeverkusenKoeln
            // 
            this.labelLeverkusenKoeln.AutoSize = true;
            this.labelLeverkusenKoeln.Location = new System.Drawing.Point(203, 75);
            this.labelLeverkusenKoeln.Name = "labelLeverkusenKoeln";
            this.labelLeverkusenKoeln.Size = new System.Drawing.Size(105, 13);
            this.labelLeverkusenKoeln.TabIndex = 10;
            this.labelLeverkusenKoeln.Text = "Leverkusen -> Koeln";
            // 
            // labelKoelnMenge
            // 
            this.labelKoelnMenge.AutoSize = true;
            this.labelKoelnMenge.Location = new System.Drawing.Point(326, 19);
            this.labelKoelnMenge.Name = "labelKoelnMenge";
            this.labelKoelnMenge.Size = new System.Drawing.Size(25, 13);
            this.labelKoelnMenge.TabIndex = 12;
            this.labelKoelnMenge.Text = "500";
            // 
            // labelKoelnMenge2
            // 
            this.labelKoelnMenge2.AutoSize = true;
            this.labelKoelnMenge2.Location = new System.Drawing.Point(326, 48);
            this.labelKoelnMenge2.Name = "labelKoelnMenge2";
            this.labelKoelnMenge2.Size = new System.Drawing.Size(31, 13);
            this.labelKoelnMenge2.TabIndex = 13;
            this.labelKoelnMenge2.Text = "6000";
            // 
            // labelBonnMenge
            // 
            this.labelBonnMenge.AutoSize = true;
            this.labelBonnMenge.Location = new System.Drawing.Point(396, 47);
            this.labelBonnMenge.Name = "labelBonnMenge";
            this.labelBonnMenge.Size = new System.Drawing.Size(31, 13);
            this.labelBonnMenge.TabIndex = 14;
            this.labelBonnMenge.Text = "8000";
            // 
            // labelMenge
            // 
            this.labelMenge.AutoSize = true;
            this.labelMenge.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMenge.Location = new System.Drawing.Point(202, -3);
            this.labelMenge.Name = "labelMenge";
            this.labelMenge.Size = new System.Drawing.Size(59, 15);
            this.labelMenge.TabIndex = 15;
            this.labelMenge.Text = "Mengen";
            // 
            // labelLeverkusenMenge
            // 
            this.labelLeverkusenMenge.AutoSize = true;
            this.labelLeverkusenMenge.Location = new System.Drawing.Point(326, 75);
            this.labelLeverkusenMenge.Name = "labelLeverkusenMenge";
            this.labelLeverkusenMenge.Size = new System.Drawing.Size(25, 13);
            this.labelLeverkusenMenge.TabIndex = 16;
            this.labelLeverkusenMenge.Text = "200";
            // 
            // labelKoelnMenge3
            // 
            this.labelKoelnMenge3.AutoSize = true;
            this.labelKoelnMenge3.Location = new System.Drawing.Point(399, 75);
            this.labelKoelnMenge3.Name = "labelKoelnMenge3";
            this.labelKoelnMenge3.Size = new System.Drawing.Size(25, 13);
            this.labelKoelnMenge3.TabIndex = 17;
            this.labelKoelnMenge3.Text = "500";
            // 
            // labelGesamtmenge2
            // 
            this.labelGesamtmenge2.AutoSize = true;
            this.labelGesamtmenge2.Location = new System.Drawing.Point(326, 108);
            this.labelGesamtmenge2.Name = "labelGesamtmenge2";
            this.labelGesamtmenge2.Size = new System.Drawing.Size(25, 13);
            this.labelGesamtmenge2.TabIndex = 18;
            this.labelGesamtmenge2.Text = "501";
            // 
            // labelGesamtmenge1
            // 
            this.labelGesamtmenge1.AutoSize = true;
            this.labelGesamtmenge1.Location = new System.Drawing.Point(203, 107);
            this.labelGesamtmenge1.Name = "labelGesamtmenge1";
            this.labelGesamtmenge1.Size = new System.Drawing.Size(78, 13);
            this.labelGesamtmenge1.TabIndex = 19;
            this.labelGesamtmenge1.Text = "Gesamtmenge:";
            // 
            // FormLagerverwaltung
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(436, 247);
            this.Controls.Add(this.labelGesamtmenge1);
            this.Controls.Add(this.labelGesamtmenge2);
            this.Controls.Add(this.labelKoelnMenge3);
            this.Controls.Add(this.labelLeverkusenMenge);
            this.Controls.Add(this.labelMenge);
            this.Controls.Add(this.labelBonnMenge);
            this.Controls.Add(this.labelKoelnMenge2);
            this.Controls.Add(this.labelKoelnMenge);
            this.Controls.Add(this.labelLeverkusenKoeln);
            this.Controls.Add(this.labelKoelnBonn);
            this.Controls.Add(this.labelKoeln);
            this.Controls.Add(this.textBoxBuchen);
            this.Controls.Add(this.textBoxAuslagern);
            this.Controls.Add(this.textBoxUmlagern);
            this.Controls.Add(this.textBoxKaufen);
            this.Controls.Add(this.buttonBuchen);
            this.Controls.Add(this.buttonAuslagern);
            this.Controls.Add(this.buttonUmlagern);
            this.Controls.Add(this.buttonKaufen);
            this.Name = "FormLagerverwaltung";
            this.Text = "Lagerverwaltung";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonKaufen;
        private System.Windows.Forms.Button buttonUmlagern;
        private System.Windows.Forms.Button buttonAuslagern;
        private System.Windows.Forms.Button buttonBuchen;
        private System.Windows.Forms.TextBox textBoxKaufen;
        private System.Windows.Forms.TextBox textBoxUmlagern;
        private System.Windows.Forms.TextBox textBoxAuslagern;
        private System.Windows.Forms.TextBox textBoxBuchen;
        private System.Windows.Forms.Label labelKoeln;
        private System.Windows.Forms.Label labelKoelnBonn;
        private System.Windows.Forms.Label labelLeverkusenKoeln;
        private System.Windows.Forms.Label labelKoelnMenge;
        private System.Windows.Forms.Label labelKoelnMenge2;
        private System.Windows.Forms.Label labelBonnMenge;
        private System.Windows.Forms.Label labelMenge;
        private System.Windows.Forms.Label labelLeverkusenMenge;
        private System.Windows.Forms.Label labelKoelnMenge3;
        private System.Windows.Forms.Label labelGesamtmenge2;
        private System.Windows.Forms.Label labelGesamtmenge1;
    }
}

