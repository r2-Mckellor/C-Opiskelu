﻿
namespace Forms_tehtävä_23
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKanta = new System.Windows.Forms.TextBox();
            this.txtKorkeus = new System.Windows.Forms.TextBox();
            this.txtAla = new System.Windows.Forms.TextBox();
            this.btnLaske = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Kanta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Korkeus";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ala";
            // 
            // txtKanta
            // 
            this.txtKanta.Location = new System.Drawing.Point(126, 9);
            this.txtKanta.Name = "txtKanta";
            this.txtKanta.Size = new System.Drawing.Size(275, 23);
            this.txtKanta.TabIndex = 3;
            // 
            // txtKorkeus
            // 
            this.txtKorkeus.Location = new System.Drawing.Point(126, 44);
            this.txtKorkeus.Name = "txtKorkeus";
            this.txtKorkeus.Size = new System.Drawing.Size(275, 23);
            this.txtKorkeus.TabIndex = 4;
            // 
            // txtAla
            // 
            this.txtAla.Location = new System.Drawing.Point(126, 82);
            this.txtAla.Name = "txtAla";
            this.txtAla.Size = new System.Drawing.Size(275, 23);
            this.txtAla.TabIndex = 5;
            // 
            // btnLaske
            // 
            this.btnLaske.Location = new System.Drawing.Point(12, 120);
            this.btnLaske.Name = "btnLaske";
            this.btnLaske.Size = new System.Drawing.Size(389, 23);
            this.btnLaske.TabIndex = 6;
            this.btnLaske.Text = "Laske ala";
            this.btnLaske.UseVisualStyleBackColor = true;
            this.btnLaske.Click += new System.EventHandler(this.btnLaske_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(416, 158);
            this.Controls.Add(this.btnLaske);
            this.Controls.Add(this.txtAla);
            this.Controls.Add(this.txtKorkeus);
            this.Controls.Add(this.txtKanta);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "cSuorakaide / Arttu Mäkelä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKanta;
        private System.Windows.Forms.TextBox txtKorkeus;
        private System.Windows.Forms.TextBox txtAla;
        private System.Windows.Forms.Button btnLaske;
    }
}

