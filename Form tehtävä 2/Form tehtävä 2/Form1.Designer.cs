﻿namespace Form_tehtävä_2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.OtsikkoLB = new System.Windows.Forms.Label();
            this.ViestiTB = new System.Windows.Forms.TextBox();
            this.TulostusLB = new System.Windows.Forms.Label();
            this.TulostaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // OtsikkoLB
            // 
            this.OtsikkoLB.AutoSize = true;
            this.OtsikkoLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.OtsikkoLB.Location = new System.Drawing.Point(12, 9);
            this.OtsikkoLB.Name = "OtsikkoLB";
            this.OtsikkoLB.Size = new System.Drawing.Size(293, 35);
            this.OtsikkoLB.TabIndex = 0;
            this.OtsikkoLB.Text = "Anna tulostettava teksti";
            // 
            // ViestiTB
            // 
            this.ViestiTB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ViestiTB.Location = new System.Drawing.Point(311, 8);
            this.ViestiTB.Name = "ViestiTB";
            this.ViestiTB.Size = new System.Drawing.Size(477, 36);
            this.ViestiTB.TabIndex = 1;
            // 
            // TulostusLB
            // 
            this.TulostusLB.AutoSize = true;
            this.TulostusLB.Font = new System.Drawing.Font("Segoe Script", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TulostusLB.Location = new System.Drawing.Point(12, 49);
            this.TulostusLB.Name = "TulostusLB";
            this.TulostusLB.Size = new System.Drawing.Size(76, 35);
            this.TulostusLB.TabIndex = 2;
            this.TulostusLB.Text = "xxxx";
            this.TulostusLB.Visible = false;
            this.TulostusLB.Click += new System.EventHandler(this.TulostaBT_Click);
            // 
            // TulostaBT
            // 
            this.TulostaBT.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TulostaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TulostaBT.Location = new System.Drawing.Point(560, 50);
            this.TulostaBT.Name = "TulostaBT";
            this.TulostaBT.Size = new System.Drawing.Size(228, 34);
            this.TulostaBT.TabIndex = 3;
            this.TulostaBT.Text = "Tulosta teksti";
            this.TulostaBT.UseVisualStyleBackColor = true;
            this.TulostaBT.Click += new System.EventHandler(this.TulostaBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(800, 93);
            this.Controls.Add(this.TulostaBT);
            this.Controls.Add(this.TulostusLB);
            this.Controls.Add(this.ViestiTB);
            this.Controls.Add(this.OtsikkoLB);
            this.ForeColor = System.Drawing.Color.MintCream;
            this.Name = "Form1";
            this.Text = "Harjoitus 2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label OtsikkoLB;
        private TextBox ViestiTB;
        private Label TulostusLB;
        private Button TulostaBT;
    }
}