﻿namespace SKLEP
{
    partial class GridLaptopy
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
            this.gridVIew = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridVIew)).BeginInit();
            this.SuspendLayout();
            // 
            // gridVIew
            // 
            this.gridVIew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVIew.Location = new System.Drawing.Point(27, 27);
            this.gridVIew.Name = "gridVIew";
            this.gridVIew.Size = new System.Drawing.Size(690, 375);
            this.gridVIew.TabIndex = 0;
            this.gridVIew.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.gridVIew_RowHeaderMouseDoubleClick);
            // 
            // GridLaptopy
            // 
            this.ClientSize = new System.Drawing.Size(729, 414);
            this.Controls.Add(this.gridVIew);
            this.Name = "GridLaptopy";
            this.Text = "GridLaptopy";
            this.Load += new System.EventHandler(this.GridLaptopy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridVIew)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gridVIew;
    }
}