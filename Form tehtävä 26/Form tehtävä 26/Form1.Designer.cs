
namespace Form_tehtävä_26
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DoneCB = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.PriorityGB = new System.Windows.Forms.GroupBox();
            this.NecessaryRB = new System.Windows.Forms.RadioButton();
            this.PernsonalRB = new System.Windows.Forms.RadioButton();
            this.KalenteriDT = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.AskarreTB = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.PriorityGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1029, 568);
            this.panel1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column3,
            this.Column2,
            this.DoneCB});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.SystemColors.ControlDarkDark;
            this.dataGridView1.Location = new System.Drawing.Point(0, 98);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(1029, 470);
            this.dataGridView1.TabIndex = 4;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Column1.DataPropertyName = "AskarreTB";
            this.Column1.FillWeight = 200F;
            this.Column1.Frozen = true;
            this.Column1.HeaderText = "Description";
            this.Column1.Name = "Column1";
            this.Column1.Width = 687;
            // 
            // Column3
            // 
            this.Column3.Frozen = true;
            this.Column3.HeaderText = "Priority";
            this.Column3.Name = "Column3";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Kalenteri";
            this.Column2.Frozen = true;
            this.Column2.HeaderText = "End date";
            this.Column2.Name = "Column2";
            // 
            // DoneCB
            // 
            this.DoneCB.HeaderText = "Done";
            this.DoneCB.Name = "DoneCB";
            this.DoneCB.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.PriorityGB);
            this.panel3.Controls.Add(this.KalenteriDT);
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.AskarreTB);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1029, 98);
            this.panel3.TabIndex = 3;
            // 
            // PriorityGB
            // 
            this.PriorityGB.Controls.Add(this.NecessaryRB);
            this.PriorityGB.Controls.Add(this.PernsonalRB);
            this.PriorityGB.Location = new System.Drawing.Point(715, 40);
            this.PriorityGB.Name = "PriorityGB";
            this.PriorityGB.Size = new System.Drawing.Size(200, 52);
            this.PriorityGB.TabIndex = 12;
            this.PriorityGB.TabStop = false;
            this.PriorityGB.Text = "Priority";
            // 
            // NecessaryRB
            // 
            this.NecessaryRB.AutoSize = true;
            this.NecessaryRB.Location = new System.Drawing.Point(116, 22);
            this.NecessaryRB.Name = "NecessaryRB";
            this.NecessaryRB.Size = new System.Drawing.Size(78, 19);
            this.NecessaryRB.TabIndex = 11;
            this.NecessaryRB.TabStop = true;
            this.NecessaryRB.Text = "Necessary";
            this.NecessaryRB.UseVisualStyleBackColor = true;
            // 
            // PernsonalRB
            // 
            this.PernsonalRB.AutoSize = true;
            this.PernsonalRB.Location = new System.Drawing.Point(6, 22);
            this.PernsonalRB.Name = "PernsonalRB";
            this.PernsonalRB.Size = new System.Drawing.Size(70, 19);
            this.PernsonalRB.TabIndex = 10;
            this.PernsonalRB.TabStop = true;
            this.PernsonalRB.Text = "Personal";
            this.PernsonalRB.UseVisualStyleBackColor = true;
            // 
            // KalenteriDT
            // 
            this.KalenteriDT.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.KalenteriDT.Location = new System.Drawing.Point(216, 48);
            this.KalenteriDT.Name = "KalenteriDT";
            this.KalenteriDT.Size = new System.Drawing.Size(200, 23);
            this.KalenteriDT.TabIndex = 13;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(803, 11);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "Delete selected";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(722, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add task";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(135, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 15);
            this.label1.TabIndex = 3;
            this.label1.Text = "Add a task";
            // 
            // AskarreTB
            // 
            this.AskarreTB.Location = new System.Drawing.Point(216, 12);
            this.AskarreTB.Name = "AskarreTB";
            this.AskarreTB.Size = new System.Drawing.Size(441, 23);
            this.AskarreTB.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1029, 568);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "ToDoList / Arttu Mäkelä";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.PriorityGB.ResumeLayout(false);
            this.PriorityGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton NecessaryRB;
        private System.Windows.Forms.RadioButton PernsonalRB;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox AskarreTB;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox PriorityGB;
        private System.Windows.Forms.DateTimePicker KalenteriDT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn DoneCB;
    }
}

