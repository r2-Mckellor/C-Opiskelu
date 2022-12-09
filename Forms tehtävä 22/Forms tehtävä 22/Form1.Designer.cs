
namespace Forms_tehtävä_22
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
            this.lstMuunnos = new System.Windows.Forms.ListBox();
            this.btnSulje = new System.Windows.Forms.Button();
            this.lblEng = new System.Windows.Forms.Label();
            this.lblKan = new System.Windows.Forms.Label();
            this.txtEng = new System.Windows.Forms.TextBox();
            this.txtKan = new System.Windows.Forms.TextBox();
            this.grpSuunta = new System.Windows.Forms.GroupBox();
            this.rbnKan = new System.Windows.Forms.RadioButton();
            this.rbnEng = new System.Windows.Forms.RadioButton();
            this.grpSuunta.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstMuunnos
            // 
            this.lstMuunnos.AccessibleDescription = "";
            this.lstMuunnos.FormattingEnabled = true;
            this.lstMuunnos.ItemHeight = 15;
            this.lstMuunnos.Items.AddRange(new object[] {
            "Jalka to metri",
            "Tuuma to sentti",
            "Naula to kilo"});
            this.lstMuunnos.Location = new System.Drawing.Point(370, 12);
            this.lstMuunnos.Name = "lstMuunnos";
            this.lstMuunnos.Size = new System.Drawing.Size(202, 154);
            this.lstMuunnos.TabIndex = 0;
            this.lstMuunnos.Tag = "Jalka to metri";
            this.lstMuunnos.SelectedIndexChanged += new System.EventHandler(this.lstMuunnos_DoubleClick);
            // 
            // btnSulje
            // 
            this.btnSulje.Location = new System.Drawing.Point(370, 171);
            this.btnSulje.Name = "btnSulje";
            this.btnSulje.Size = new System.Drawing.Size(202, 45);
            this.btnSulje.TabIndex = 1;
            this.btnSulje.Text = "button1";
            this.btnSulje.UseVisualStyleBackColor = true;
            this.btnSulje.Click += new System.EventHandler(this.btnSulje_Click);
            // 
            // lblEng
            // 
            this.lblEng.AutoSize = true;
            this.lblEng.Location = new System.Drawing.Point(32, 22);
            this.lblEng.Name = "lblEng";
            this.lblEng.Size = new System.Drawing.Size(82, 15);
            this.lblEng.TabIndex = 2;
            this.lblEng.Text = "Englantilainen";
            // 
            // lblKan
            // 
            this.lblKan.AutoSize = true;
            this.lblKan.Location = new System.Drawing.Point(32, 59);
            this.lblKan.Name = "lblKan";
            this.lblKan.Size = new System.Drawing.Size(86, 15);
            this.lblKan.TabIndex = 3;
            this.lblKan.Text = "Kansainvälinen";
            // 
            // txtEng
            // 
            this.txtEng.Location = new System.Drawing.Point(153, 19);
            this.txtEng.Name = "txtEng";
            this.txtEng.Size = new System.Drawing.Size(211, 23);
            this.txtEng.TabIndex = 4;
            // 
            // txtKan
            // 
            this.txtKan.Location = new System.Drawing.Point(153, 56);
            this.txtKan.Name = "txtKan";
            this.txtKan.Size = new System.Drawing.Size(211, 23);
            this.txtKan.TabIndex = 5;
            // 
            // grpSuunta
            // 
            this.grpSuunta.Controls.Add(this.rbnKan);
            this.grpSuunta.Controls.Add(this.rbnEng);
            this.grpSuunta.Location = new System.Drawing.Point(32, 100);
            this.grpSuunta.Name = "grpSuunta";
            this.grpSuunta.Size = new System.Drawing.Size(332, 116);
            this.grpSuunta.TabIndex = 6;
            this.grpSuunta.TabStop = false;
            this.grpSuunta.Text = "Muunnossuunta";
            // 
            // rbnKan
            // 
            this.rbnKan.AutoSize = true;
            this.rbnKan.Location = new System.Drawing.Point(6, 81);
            this.rbnKan.Name = "rbnKan";
            this.rbnKan.Size = new System.Drawing.Size(89, 19);
            this.rbnKan.TabIndex = 1;
            this.rbnKan.Text = "Kan --> Eng";
            this.rbnKan.UseVisualStyleBackColor = true;
            this.rbnKan.CheckedChanged += new System.EventHandler(this.rbnKan_Click);
            // 
            // rbnEng
            // 
            this.rbnEng.AutoSize = true;
            this.rbnEng.Checked = true;
            this.rbnEng.Location = new System.Drawing.Point(6, 22);
            this.rbnEng.Name = "rbnEng";
            this.rbnEng.Size = new System.Drawing.Size(89, 19);
            this.rbnEng.TabIndex = 0;
            this.rbnEng.TabStop = true;
            this.rbnEng.Text = "Eng --> Kan";
            this.rbnEng.UseVisualStyleBackColor = true;
            this.rbnEng.CheckedChanged += new System.EventHandler(this.rbnEng_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 230);
            this.Controls.Add(this.grpSuunta);
            this.Controls.Add(this.txtKan);
            this.Controls.Add(this.txtEng);
            this.Controls.Add(this.lblKan);
            this.Controls.Add(this.lblEng);
            this.Controls.Add(this.btnSulje);
            this.Controls.Add(this.lstMuunnos);
            this.Name = "Form1";
            this.Text = "Form1";
            this.grpSuunta.ResumeLayout(false);
            this.grpSuunta.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstMuunnos;
        private System.Windows.Forms.Button btnSulje;
        private System.Windows.Forms.Label lblEng;
        private System.Windows.Forms.Label lblKan;
        private System.Windows.Forms.TextBox txtEng;
        private System.Windows.Forms.TextBox txtKan;
        private System.Windows.Forms.GroupBox grpSuunta;
        private System.Windows.Forms.RadioButton rbnKan;
        private System.Windows.Forms.RadioButton rbnEng;
    }
}

