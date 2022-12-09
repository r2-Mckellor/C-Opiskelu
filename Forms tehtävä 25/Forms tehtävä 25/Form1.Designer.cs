
namespace Forms_tehtävä_25
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PeliValikkoCB = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AloitaBT = new System.Windows.Forms.Button();
            this.KuusiPL = new System.Windows.Forms.Panel();
            this.Kortti1BT = new System.Windows.Forms.Button();
            this.Kortti2BT = new System.Windows.Forms.Button();
            this.Kortti3BT = new System.Windows.Forms.Button();
            this.Kortti4BT = new System.Windows.Forms.Button();
            this.Kortti5BT = new System.Windows.Forms.Button();
            this.Kortti6BT = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.KuusiPL.SuspendLayout();
            this.SuspendLayout();
            // 
            // PeliValikkoCB
            // 
            this.PeliValikkoCB.FormattingEnabled = true;
            this.PeliValikkoCB.Items.AddRange(new object[] {
            "6x6",
            "12x12",
            "24x24"});
            this.PeliValikkoCB.Location = new System.Drawing.Point(365, 252);
            this.PeliValikkoCB.Name = "PeliValikkoCB";
            this.PeliValikkoCB.Size = new System.Drawing.Size(232, 23);
            this.PeliValikkoCB.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(268, 116);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(468, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tervetuloa muistipeliin!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(365, 234);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Valitse pelimuoto:";
            // 
            // AloitaBT
            // 
            this.AloitaBT.Location = new System.Drawing.Point(522, 281);
            this.AloitaBT.Name = "AloitaBT";
            this.AloitaBT.Size = new System.Drawing.Size(75, 23);
            this.AloitaBT.TabIndex = 3;
            this.AloitaBT.Text = "Aloita";
            this.AloitaBT.UseVisualStyleBackColor = true;
            // 
            // KuusiPL
            // 
            this.KuusiPL.Controls.Add(this.button8);
            this.KuusiPL.Controls.Add(this.button7);
            this.KuusiPL.Controls.Add(this.button6);
            this.KuusiPL.Controls.Add(this.Kortti6BT);
            this.KuusiPL.Controls.Add(this.Kortti5BT);
            this.KuusiPL.Controls.Add(this.Kortti4BT);
            this.KuusiPL.Controls.Add(this.Kortti3BT);
            this.KuusiPL.Controls.Add(this.Kortti2BT);
            this.KuusiPL.Controls.Add(this.Kortti1BT);
            this.KuusiPL.Dock = System.Windows.Forms.DockStyle.Fill;
            this.KuusiPL.Location = new System.Drawing.Point(0, 0);
            this.KuusiPL.Name = "KuusiPL";
            this.KuusiPL.Size = new System.Drawing.Size(1005, 609);
            this.KuusiPL.TabIndex = 4;
            // 
            // Kortti1BT
            // 
            this.Kortti1BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti1BT.BackgroundImage")));
            this.Kortti1BT.FlatAppearance.BorderSize = 0;
            this.Kortti1BT.Location = new System.Drawing.Point(254, 12);
            this.Kortti1BT.Name = "Kortti1BT";
            this.Kortti1BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti1BT.TabIndex = 0;
            this.Kortti1BT.UseVisualStyleBackColor = true;
            // 
            // Kortti2BT
            // 
            this.Kortti2BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti2BT.BackgroundImage")));
            this.Kortti2BT.FlatAppearance.BorderSize = 0;
            this.Kortti2BT.Location = new System.Drawing.Point(444, 12);
            this.Kortti2BT.Name = "Kortti2BT";
            this.Kortti2BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti2BT.TabIndex = 1;
            this.Kortti2BT.UseVisualStyleBackColor = true;
            // 
            // Kortti3BT
            // 
            this.Kortti3BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti3BT.BackgroundImage")));
            this.Kortti3BT.FlatAppearance.BorderSize = 0;
            this.Kortti3BT.Location = new System.Drawing.Point(637, 12);
            this.Kortti3BT.Name = "Kortti3BT";
            this.Kortti3BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti3BT.TabIndex = 2;
            this.Kortti3BT.UseVisualStyleBackColor = true;
            // 
            // Kortti4BT
            // 
            this.Kortti4BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti4BT.BackgroundImage")));
            this.Kortti4BT.FlatAppearance.BorderSize = 0;
            this.Kortti4BT.Location = new System.Drawing.Point(254, 212);
            this.Kortti4BT.Name = "Kortti4BT";
            this.Kortti4BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti4BT.TabIndex = 3;
            this.Kortti4BT.UseVisualStyleBackColor = true;
            // 
            // Kortti5BT
            // 
            this.Kortti5BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti5BT.BackgroundImage")));
            this.Kortti5BT.FlatAppearance.BorderSize = 0;
            this.Kortti5BT.Location = new System.Drawing.Point(444, 212);
            this.Kortti5BT.Name = "Kortti5BT";
            this.Kortti5BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti5BT.TabIndex = 4;
            this.Kortti5BT.UseVisualStyleBackColor = true;
            // 
            // Kortti6BT
            // 
            this.Kortti6BT.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Kortti6BT.BackgroundImage")));
            this.Kortti6BT.FlatAppearance.BorderSize = 0;
            this.Kortti6BT.Location = new System.Drawing.Point(637, 212);
            this.Kortti6BT.Name = "Kortti6BT";
            this.Kortti6BT.Size = new System.Drawing.Size(122, 174);
            this.Kortti6BT.TabIndex = 5;
            this.Kortti6BT.UseVisualStyleBackColor = true;
            // 
            // button6
            // 
            this.button6.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button6.BackgroundImage")));
            this.button6.FlatAppearance.BorderSize = 0;
            this.button6.Location = new System.Drawing.Point(254, 413);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(122, 174);
            this.button6.TabIndex = 6;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button7.BackgroundImage")));
            this.button7.FlatAppearance.BorderSize = 0;
            this.button7.Location = new System.Drawing.Point(444, 413);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(122, 174);
            this.button7.TabIndex = 7;
            this.button7.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button8.BackgroundImage")));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.Location = new System.Drawing.Point(637, 413);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(122, 174);
            this.button8.TabIndex = 8;
            this.button8.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1005, 609);
            this.Controls.Add(this.KuusiPL);
            this.Controls.Add(this.AloitaBT);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.PeliValikkoCB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.KuusiPL.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox PeliValikkoCB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button AloitaBT;
        private System.Windows.Forms.Panel KuusiPL;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button Kortti6BT;
        private System.Windows.Forms.Button Kortti5BT;
        private System.Windows.Forms.Button Kortti4BT;
        private System.Windows.Forms.Button Kortti3BT;
        private System.Windows.Forms.Button Kortti2BT;
        private System.Windows.Forms.Button Kortti1BT;
    }
}

