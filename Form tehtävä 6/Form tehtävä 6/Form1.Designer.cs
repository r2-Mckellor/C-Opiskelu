namespace Form_tehtävä_6
{
    partial class SalasanaForm
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
            this.SalasanaPL = new System.Windows.Forms.Panel();
            this.SalasanaOikeinPL = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.VirheViestiLB = new System.Windows.Forms.Label();
            this.TarkistaBT = new System.Windows.Forms.Button();
            this.SalasanaTB = new System.Windows.Forms.TextBox();
            this.KayttajaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SalasanaPL.SuspendLayout();
            this.SalasanaOikeinPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // SalasanaPL
            // 
            this.SalasanaPL.BackColor = System.Drawing.Color.MidnightBlue;
            this.SalasanaPL.Controls.Add(this.SalasanaOikeinPL);
            this.SalasanaPL.Controls.Add(this.VirheViestiLB);
            this.SalasanaPL.Controls.Add(this.TarkistaBT);
            this.SalasanaPL.Controls.Add(this.SalasanaTB);
            this.SalasanaPL.Controls.Add(this.KayttajaTB);
            this.SalasanaPL.Controls.Add(this.label2);
            this.SalasanaPL.Controls.Add(this.label1);
            this.SalasanaPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaPL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaPL.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaPL.Name = "SalasanaPL";
            this.SalasanaPL.Size = new System.Drawing.Size(570, 184);
            this.SalasanaPL.TabIndex = 0;
            // 
            // SalasanaOikeinPL
            // 
            this.SalasanaOikeinPL.BackColor = System.Drawing.Color.DarkRed;
            this.SalasanaOikeinPL.Controls.Add(this.label3);
            this.SalasanaOikeinPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalasanaOikeinPL.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SalasanaOikeinPL.ForeColor = System.Drawing.Color.Gold;
            this.SalasanaOikeinPL.Location = new System.Drawing.Point(0, 0);
            this.SalasanaOikeinPL.Name = "SalasanaOikeinPL";
            this.SalasanaOikeinPL.Size = new System.Drawing.Size(570, 184);
            this.SalasanaOikeinPL.TabIndex = 0;
            this.SalasanaOikeinPL.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(549, 76);
            this.label3.TabIndex = 1;
            this.label3.Text = "Tervetuloa sivulleni";
            // 
            // VirheViestiLB
            // 
            this.VirheViestiLB.AutoSize = true;
            this.VirheViestiLB.Location = new System.Drawing.Point(12, 134);
            this.VirheViestiLB.Name = "VirheViestiLB";
            this.VirheViestiLB.Size = new System.Drawing.Size(70, 32);
            this.VirheViestiLB.TabIndex = 5;
            this.VirheViestiLB.Text = "Virhe";
            this.VirheViestiLB.Visible = false;
            // 
            // TarkistaBT
            // 
            this.TarkistaBT.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.TarkistaBT.Location = new System.Drawing.Point(444, 129);
            this.TarkistaBT.Name = "TarkistaBT";
            this.TarkistaBT.Size = new System.Drawing.Size(114, 43);
            this.TarkistaBT.TabIndex = 4;
            this.TarkistaBT.Text = "Tarkista";
            this.TarkistaBT.UseVisualStyleBackColor = true;
            this.TarkistaBT.Click += new System.EventHandler(this.TarkistaBT_Click);
            // 
            // SalasanaTB
            // 
            this.SalasanaTB.Location = new System.Drawing.Point(195, 57);
            this.SalasanaTB.Name = "SalasanaTB";
            this.SalasanaTB.Size = new System.Drawing.Size(278, 39);
            this.SalasanaTB.TabIndex = 3;
            // 
            // KayttajaTB
            // 
            this.KayttajaTB.Location = new System.Drawing.Point(195, 12);
            this.KayttajaTB.Name = "KayttajaTB";
            this.KayttajaTB.Size = new System.Drawing.Size(278, 39);
            this.KayttajaTB.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 32);
            this.label2.TabIndex = 1;
            this.label2.Text = "Salasana:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Käyttäjätunnus:";
            // 
            // SalasanaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 184);
            this.Controls.Add(this.SalasanaPL);
            this.Name = "SalasanaForm";
            this.Text = "Salasanan Tarkastus / Arttu Mäkelä";
            this.SalasanaPL.ResumeLayout(false);
            this.SalasanaPL.PerformLayout();
            this.SalasanaOikeinPL.ResumeLayout(false);
            this.SalasanaOikeinPL.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel SalasanaPL;
        private Label VirheViestiLB;
        private Button TarkistaBT;
        private TextBox SalasanaTB;
        private TextBox KayttajaTB;
        private Label label2;
        private Label label1;
        private Panel SalasanaOikeinPL;
        private Label label3;
    }
}