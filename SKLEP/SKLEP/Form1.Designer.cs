namespace SKLEP
{
    partial class FormStart
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.Open_Laptopy = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Open_Laptopy
            // 
            this.Open_Laptopy.Location = new System.Drawing.Point(30, 34);
            this.Open_Laptopy.Name = "Open_Laptopy";
            this.Open_Laptopy.Size = new System.Drawing.Size(97, 34);
            this.Open_Laptopy.TabIndex = 0;
            this.Open_Laptopy.Text = "Laptopy";
            this.Open_Laptopy.UseVisualStyleBackColor = true;
            this.Open_Laptopy.Click += new System.EventHandler(this.Open_Laptopy_Click);
            // 
            // FormStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 540);
            this.Controls.Add(this.Open_Laptopy);
            this.Name = "FormStart";
            this.Text = "Formularz startowy";
            this.Load += new System.EventHandler(this.FormStart_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Open_Laptopy;
    }
}

