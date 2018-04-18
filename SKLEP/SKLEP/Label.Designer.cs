namespace SKLEP
{
    partial class Label
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
            this.Procesor = new System.Windows.Forms.Label();
            this.textprocesor = new System.Windows.Forms.TextBox();
            this.Save = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Procesor
            // 
            this.Procesor.AutoSize = true;
            this.Procesor.Location = new System.Drawing.Point(22, 13);
            this.Procesor.Name = "Procesor";
            this.Procesor.Size = new System.Drawing.Size(49, 13);
            this.Procesor.TabIndex = 0;
            this.Procesor.Text = "Procesor";
            // 
            // textprocesor
            // 
            this.textprocesor.Location = new System.Drawing.Point(126, 13);
            this.textprocesor.Name = "textprocesor";
            this.textprocesor.Size = new System.Drawing.Size(100, 20);
            this.textprocesor.TabIndex = 1;
            // 
            // Save
            // 
            this.Save.Location = new System.Drawing.Point(126, 53);
            this.Save.Name = "Save";
            this.Save.Size = new System.Drawing.Size(75, 23);
            this.Save.TabIndex = 2;
            this.Save.Text = "zapisz";
            this.Save.UseVisualStyleBackColor = true;
            this.Save.Click += new System.EventHandler(this.Save_Click);
            // 
            // Label
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.Save);
            this.Controls.Add(this.textprocesor);
            this.Controls.Add(this.Procesor);
            this.Name = "Label";
            this.Text = "Label";
            this.Load += new System.EventHandler(this.Label_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Procesor;
        private System.Windows.Forms.TextBox textprocesor;
        private System.Windows.Forms.Button Save;
    }
}