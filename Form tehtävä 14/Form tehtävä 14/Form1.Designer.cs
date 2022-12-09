
namespace Form_tehtävä_14
{
    partial class DiaryForm
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
            this.SyottoTB = new System.Windows.Forms.TextBox();
            this.TallennaBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyottoTB
            // 
            this.SyottoTB.Location = new System.Drawing.Point(12, 12);
            this.SyottoTB.MaximumSize = new System.Drawing.Size(700, 500);
            this.SyottoTB.Multiline = true;
            this.SyottoTB.Name = "SyottoTB";
            this.SyottoTB.Size = new System.Drawing.Size(560, 200);
            this.SyottoTB.TabIndex = 0;
            // 
            // TallennaBT
            // 
            this.TallennaBT.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TallennaBT.Location = new System.Drawing.Point(12, 218);
            this.TallennaBT.Name = "TallennaBT";
            this.TallennaBT.Size = new System.Drawing.Size(559, 70);
            this.TallennaBT.TabIndex = 1;
            this.TallennaBT.Text = "Tallenna päiväkirja";
            this.TallennaBT.UseVisualStyleBackColor = true;
            this.TallennaBT.Click += new System.EventHandler(this.TallennaBT_Click);
            // 
            // DiaryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 296);
            this.Controls.Add(this.TallennaBT);
            this.Controls.Add(this.SyottoTB);
            this.Name = "DiaryForm";
            this.Text = "Päiväkirja / Arttu Mäkelä";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox SyottoTB;
        private System.Windows.Forms.Button TallennaBT;
    }
}

