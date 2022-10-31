namespace Form_tehtävä_4
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
            this.SyntymaAikaDT = new System.Windows.Forms.DateTimePicker();
            this.vuodetLB = new System.Windows.Forms.Label();
            this.KuukaudetLB = new System.Windows.Forms.Label();
            this.PäivätLB = new System.Windows.Forms.Label();
            this.TunnitLB = new System.Windows.Forms.Label();
            this.MinuutitLB = new System.Windows.Forms.Label();
            this.SekunnitLB = new System.Windows.Forms.Label();
            this.LaskeBT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SyntymaAikaDT
            // 
            this.SyntymaAikaDT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SyntymaAikaDT.Location = new System.Drawing.Point(12, 12);
            this.SyntymaAikaDT.Name = "SyntymaAikaDT";
            this.SyntymaAikaDT.Size = new System.Drawing.Size(351, 36);
            this.SyntymaAikaDT.TabIndex = 0;
            // 
            // vuodetLB
            // 
            this.vuodetLB.AutoSize = true;
            this.vuodetLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.vuodetLB.Location = new System.Drawing.Point(12, 72);
            this.vuodetLB.Name = "vuodetLB";
            this.vuodetLB.Size = new System.Drawing.Size(43, 30);
            this.vuodetLB.TabIndex = 1;
            this.vuodetLB.Text = "xxx";
            this.vuodetLB.Visible = false;
            // 
            // KuukaudetLB
            // 
            this.KuukaudetLB.AutoSize = true;
            this.KuukaudetLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.KuukaudetLB.Location = new System.Drawing.Point(12, 102);
            this.KuukaudetLB.Name = "KuukaudetLB";
            this.KuukaudetLB.Size = new System.Drawing.Size(43, 30);
            this.KuukaudetLB.TabIndex = 2;
            this.KuukaudetLB.Text = "xxx";
            this.KuukaudetLB.Visible = false;
            // 
            // PäivätLB
            // 
            this.PäivätLB.AutoSize = true;
            this.PäivätLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.PäivätLB.Location = new System.Drawing.Point(12, 132);
            this.PäivätLB.Name = "PäivätLB";
            this.PäivätLB.Size = new System.Drawing.Size(43, 30);
            this.PäivätLB.TabIndex = 3;
            this.PäivätLB.Text = "xxx";
            this.PäivätLB.Visible = false;
            // 
            // TunnitLB
            // 
            this.TunnitLB.AutoSize = true;
            this.TunnitLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.TunnitLB.Location = new System.Drawing.Point(149, 72);
            this.TunnitLB.Name = "TunnitLB";
            this.TunnitLB.Size = new System.Drawing.Size(43, 30);
            this.TunnitLB.TabIndex = 4;
            this.TunnitLB.Text = "xxx";
            this.TunnitLB.Visible = false;
            // 
            // MinuutitLB
            // 
            this.MinuutitLB.AutoSize = true;
            this.MinuutitLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.MinuutitLB.Location = new System.Drawing.Point(149, 102);
            this.MinuutitLB.Name = "MinuutitLB";
            this.MinuutitLB.Size = new System.Drawing.Size(43, 30);
            this.MinuutitLB.TabIndex = 5;
            this.MinuutitLB.Text = "xxx";
            this.MinuutitLB.Visible = false;
            // 
            // SekunnitLB
            // 
            this.SekunnitLB.AutoSize = true;
            this.SekunnitLB.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.SekunnitLB.Location = new System.Drawing.Point(149, 132);
            this.SekunnitLB.Name = "SekunnitLB";
            this.SekunnitLB.Size = new System.Drawing.Size(43, 30);
            this.SekunnitLB.TabIndex = 6;
            this.SekunnitLB.Text = "xxx";
            this.SekunnitLB.Visible = false;
            // 
            // LaskeBT
            // 
            this.LaskeBT.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LaskeBT.Location = new System.Drawing.Point(385, 12);
            this.LaskeBT.Name = "LaskeBT";
            this.LaskeBT.Size = new System.Drawing.Size(133, 47);
            this.LaskeBT.TabIndex = 7;
            this.LaskeBT.Text = "Laske";
            this.LaskeBT.UseVisualStyleBackColor = true;
            this.LaskeBT.Click += new System.EventHandler(this.LaskeBT_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LaskeBT);
            this.Controls.Add(this.SekunnitLB);
            this.Controls.Add(this.MinuutitLB);
            this.Controls.Add(this.TunnitLB);
            this.Controls.Add(this.PäivätLB);
            this.Controls.Add(this.KuukaudetLB);
            this.Controls.Add(this.vuodetLB);
            this.Controls.Add(this.SyntymaAikaDT);
            this.Name = "Form1";
            this.Text = "Ikälaskuri";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DateTimePicker SyntymaAikaDT;
        private Label vuodetLB;
        private Label KuukaudetLB;
        private Label PäivätLB;
        private Label TunnitLB;
        private Label MinuutitLB;
        private Label SekunnitLB;
        private Button LaskeBT;
    }
}