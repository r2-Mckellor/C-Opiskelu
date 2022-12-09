
namespace Form_tehtävä_18
{
    partial class AvainhenkilotForm
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
            this.OppilaitoksetCB = new System.Windows.Forms.ComboBox();
            this.VastuuHloCB = new System.Windows.Forms.ComboBox();
            this.KatuosoiteLB = new System.Windows.Forms.Label();
            this.PostinumeroLb = new System.Windows.Forms.Label();
            this.PostioimipaikkaLB = new System.Windows.Forms.Label();
            this.PuhelinLB = new System.Windows.Forms.Label();
            this.TitteliLB = new System.Windows.Forms.Label();
            this.SijaintiLB = new System.Windows.Forms.Label();
            this.EmailLB = new System.Windows.Forms.Label();
            this.PhoneLB = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 23F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(397, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Oppilaitosten avainhenkilöt";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(165, 28);
            this.label2.TabIndex = 1;
            this.label2.Text = "Valitse oppilaitos:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(295, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(198, 28);
            this.label3.TabIndex = 2;
            this.label3.Text = "Valitse vastuuhenkilö:";
            // 
            // OppilaitoksetCB
            // 
            this.OppilaitoksetCB.FormattingEnabled = true;
            this.OppilaitoksetCB.Location = new System.Drawing.Point(12, 108);
            this.OppilaitoksetCB.Name = "OppilaitoksetCB";
            this.OppilaitoksetCB.Size = new System.Drawing.Size(165, 23);
            this.OppilaitoksetCB.TabIndex = 3;
            this.OppilaitoksetCB.SelectedIndexChanged += new System.EventHandler(this.OppilaitoksetCB_SelectedIndexChanged);
            // 
            // VastuuHloCB
            // 
            this.VastuuHloCB.FormattingEnabled = true;
            this.VastuuHloCB.Location = new System.Drawing.Point(295, 108);
            this.VastuuHloCB.Name = "VastuuHloCB";
            this.VastuuHloCB.Size = new System.Drawing.Size(198, 23);
            this.VastuuHloCB.TabIndex = 4;
            this.VastuuHloCB.SelectedIndexChanged += new System.EventHandler(this.VastuuHloCB_TextChanged);
            // 
            // KatuosoiteLB
            // 
            this.KatuosoiteLB.AutoSize = true;
            this.KatuosoiteLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KatuosoiteLB.Location = new System.Drawing.Point(12, 144);
            this.KatuosoiteLB.Name = "KatuosoiteLB";
            this.KatuosoiteLB.Size = new System.Drawing.Size(106, 28);
            this.KatuosoiteLB.TabIndex = 5;
            this.KatuosoiteLB.Text = "Katuosoite";
            // 
            // PostinumeroLb
            // 
            this.PostinumeroLb.AutoSize = true;
            this.PostinumeroLb.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostinumeroLb.Location = new System.Drawing.Point(12, 185);
            this.PostinumeroLb.Name = "PostinumeroLb";
            this.PostinumeroLb.Size = new System.Drawing.Size(122, 28);
            this.PostinumeroLb.TabIndex = 6;
            this.PostinumeroLb.Text = "Postinumero";
            // 
            // PostioimipaikkaLB
            // 
            this.PostioimipaikkaLB.AutoSize = true;
            this.PostioimipaikkaLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PostioimipaikkaLB.Location = new System.Drawing.Point(12, 226);
            this.PostioimipaikkaLB.Name = "PostioimipaikkaLB";
            this.PostioimipaikkaLB.Size = new System.Drawing.Size(157, 28);
            this.PostioimipaikkaLB.TabIndex = 7;
            this.PostioimipaikkaLB.Text = "Postitoimipaikka";
            // 
            // PuhelinLB
            // 
            this.PuhelinLB.AutoSize = true;
            this.PuhelinLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PuhelinLB.Location = new System.Drawing.Point(12, 267);
            this.PuhelinLB.Name = "PuhelinLB";
            this.PuhelinLB.Size = new System.Drawing.Size(144, 28);
            this.PuhelinLB.TabIndex = 8;
            this.PuhelinLB.Text = "Puhelinnumero";
            // 
            // TitteliLB
            // 
            this.TitteliLB.AutoSize = true;
            this.TitteliLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TitteliLB.Location = new System.Drawing.Point(295, 144);
            this.TitteliLB.Name = "TitteliLB";
            this.TitteliLB.Size = new System.Drawing.Size(61, 28);
            this.TitteliLB.TabIndex = 9;
            this.TitteliLB.Text = "Titteli";
            // 
            // SijaintiLB
            // 
            this.SijaintiLB.AutoSize = true;
            this.SijaintiLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SijaintiLB.Location = new System.Drawing.Point(295, 185);
            this.SijaintiLB.Name = "SijaintiLB";
            this.SijaintiLB.Size = new System.Drawing.Size(71, 28);
            this.SijaintiLB.TabIndex = 10;
            this.SijaintiLB.Text = "Sijainti";
            // 
            // EmailLB
            // 
            this.EmailLB.AutoSize = true;
            this.EmailLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EmailLB.Location = new System.Drawing.Point(295, 226);
            this.EmailLB.Name = "EmailLB";
            this.EmailLB.Size = new System.Drawing.Size(110, 28);
            this.EmailLB.TabIndex = 11;
            this.EmailLB.Text = "Sähköposti";
            // 
            // PhoneLB
            // 
            this.PhoneLB.AutoSize = true;
            this.PhoneLB.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PhoneLB.Location = new System.Drawing.Point(295, 267);
            this.PhoneLB.Name = "PhoneLB";
            this.PhoneLB.Size = new System.Drawing.Size(176, 28);
            this.PhoneLB.TabIndex = 12;
            this.PhoneLB.Text = "Työpuhelinnumero";
            // 
            // AvainhenkilotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 309);
            this.Controls.Add(this.PhoneLB);
            this.Controls.Add(this.EmailLB);
            this.Controls.Add(this.SijaintiLB);
            this.Controls.Add(this.TitteliLB);
            this.Controls.Add(this.PuhelinLB);
            this.Controls.Add(this.PostioimipaikkaLB);
            this.Controls.Add(this.PostinumeroLb);
            this.Controls.Add(this.KatuosoiteLB);
            this.Controls.Add(this.VastuuHloCB);
            this.Controls.Add(this.OppilaitoksetCB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "AvainhenkilotForm";
            this.Text = "Oppilaitosten avainhenkilöt / Arttu Mäkelä";
            this.Load += new System.EventHandler(this.AvainhenkilötForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox OppilaitoksetCB;
        private System.Windows.Forms.ComboBox VastuuHloCB;
        private System.Windows.Forms.Label KatuosoiteLB;
        private System.Windows.Forms.Label PostinumeroLb;
        private System.Windows.Forms.Label PostioimipaikkaLB;
        private System.Windows.Forms.Label PuhelinLB;
        private System.Windows.Forms.Label TitteliLB;
        private System.Windows.Forms.Label SijaintiLB;
        private System.Windows.Forms.Label EmailLB;
        private System.Windows.Forms.Label PhoneLB;
    }
}

