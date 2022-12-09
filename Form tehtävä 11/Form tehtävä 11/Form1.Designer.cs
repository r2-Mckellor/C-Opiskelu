
namespace Form_tehtävä_11
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
            this.Noppa02PB = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.HeitaBT = new System.Windows.Forms.Button();
            this.Noppa01PB = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).BeginInit();
            this.SuspendLayout();
            // 
            // Noppa02PB
            // 
            this.Noppa02PB.Image = global::Form_tehtävä_11.Properties.Resources.rollingDice;
            this.Noppa02PB.Location = new System.Drawing.Point(204, 65);
            this.Noppa02PB.Name = "Noppa02PB";
            this.Noppa02PB.Size = new System.Drawing.Size(151, 149);
            this.Noppa02PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa02PB.TabIndex = 2;
            this.Noppa02PB.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 48);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nopan Heitto";
            // 
            // HeitaBT
            // 
            this.HeitaBT.Font = new System.Drawing.Font("Segoe UI", 27F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.HeitaBT.Location = new System.Drawing.Point(12, 220);
            this.HeitaBT.Name = "HeitaBT";
            this.HeitaBT.Size = new System.Drawing.Size(343, 70);
            this.HeitaBT.TabIndex = 4;
            this.HeitaBT.Text = "Heitä";
            this.HeitaBT.UseVisualStyleBackColor = true;
            this.HeitaBT.Click += new System.EventHandler(this.HeitaBT_Click);
            // 
            // Noppa01PB
            // 
            this.Noppa01PB.Image = global::Form_tehtävä_11.Properties.Resources.rollingDice;
            this.Noppa01PB.Location = new System.Drawing.Point(12, 65);
            this.Noppa01PB.Name = "Noppa01PB";
            this.Noppa01PB.Size = new System.Drawing.Size(151, 149);
            this.Noppa01PB.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Noppa01PB.TabIndex = 5;
            this.Noppa01PB.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 302);
            this.Controls.Add(this.Noppa01PB);
            this.Controls.Add(this.HeitaBT);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Noppa02PB);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.Noppa02PB)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Noppa01PB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox Noppa02PB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button HeitaBT;
        private System.Windows.Forms.PictureBox Noppa01PB;
    }
}

