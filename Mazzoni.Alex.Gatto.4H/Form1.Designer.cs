namespace Mazzoni.Alex.Gatto._4H
{
    partial class Form1
    {
        /// <summary>
        /// Variabile di progettazione necessaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Pulire le risorse in uso.
        /// </summary>
        /// <param name="disposing">ha valore true se le risorse gestite devono essere eliminate, false in caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Codice generato da Progettazione Windows Form

        /// <summary>
        /// Metodo necessario per il supporto della finestra di progettazione. Non modificare
        /// il contenuto del metodo con l'editor di codice.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblStampa = new System.Windows.Forms.Label();
            this.btnCalcola = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblStampa
            // 
            this.lblStampa.AutoSize = true;
            this.lblStampa.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.lblStampa.Location = new System.Drawing.Point(12, 9);
            this.lblStampa.Name = "lblStampa";
            this.lblStampa.Size = new System.Drawing.Size(83, 13);
            this.lblStampa.TabIndex = 0;
            this.lblStampa.Text = "Creazione Gatto";
            // 
            // btnCalcola
            // 
            this.btnCalcola.Location = new System.Drawing.Point(12, 33);
            this.btnCalcola.Name = "btnCalcola";
            this.btnCalcola.Size = new System.Drawing.Size(360, 38);
            this.btnCalcola.TabIndex = 1;
            this.btnCalcola.Text = "Disegna il gatto";
            this.btnCalcola.UseVisualStyleBackColor = true;
            this.btnCalcola.Click += new System.EventHandler(this.btnCalcola_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(101, 4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(271, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Disegna Quaderno A4 Guida";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 561);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btnCalcola);
            this.Controls.Add(this.lblStampa);
            this.Name = "Form1";
            this.Text = "Gatto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStampa;
        private System.Windows.Forms.Button btnCalcola;
        private System.Windows.Forms.Button button3;
    }
}

