namespace WindowsFormsApp1
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bntUp = new System.Windows.Forms.Button();
            this.txtWeight = new System.Windows.Forms.TextBox();
            this.txtReps = new System.Windows.Forms.TextBox();
            this.cmbSquat = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnIns = new System.Windows.Forms.Button();
            this.txtInsR = new System.Windows.Forms.TextBox();
            this.txtInsW = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.setDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.weightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.repsDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.squatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baza1DataSet = new WindowsFormsApp1.Baza1DataSet();
            this.squatTableAdapter = new WindowsFormsApp1.Baza1DataSetTableAdapters.SquatTableAdapter();
            this.baza1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.squatBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.ResBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // bntUp
            // 
            this.bntUp.Location = new System.Drawing.Point(12, 68);
            this.bntUp.Name = "bntUp";
            this.bntUp.Size = new System.Drawing.Size(100, 23);
            this.bntUp.TabIndex = 0;
            this.bntUp.Text = "Update Set";
            this.bntUp.UseVisualStyleBackColor = true;
            this.bntUp.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtWeight
            // 
            this.txtWeight.Location = new System.Drawing.Point(12, 12);
            this.txtWeight.Name = "txtWeight";
            this.txtWeight.Size = new System.Drawing.Size(100, 22);
            this.txtWeight.TabIndex = 1;
            this.txtWeight.Text = "Weight";
            // 
            // txtReps
            // 
            this.txtReps.Location = new System.Drawing.Point(12, 40);
            this.txtReps.Name = "txtReps";
            this.txtReps.Size = new System.Drawing.Size(100, 22);
            this.txtReps.TabIndex = 2;
            this.txtReps.Text = "Reps";
            // 
            // cmbSquat
            // 
            this.cmbSquat.FormattingEnabled = true;
            this.cmbSquat.Location = new System.Drawing.Point(119, 10);
            this.cmbSquat.Name = "cmbSquat";
            this.cmbSquat.Size = new System.Drawing.Size(121, 24);
            this.cmbSquat.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(247, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "Pick Set";
            // 
            // btnIns
            // 
            this.btnIns.Location = new System.Drawing.Point(118, 115);
            this.btnIns.Name = "btnIns";
            this.btnIns.Size = new System.Drawing.Size(121, 23);
            this.btnIns.TabIndex = 5;
            this.btnIns.Text = "Insert";
            this.btnIns.UseVisualStyleBackColor = true;
            this.btnIns.Click += new System.EventHandler(this.btnIns_Click);
            // 
            // txtInsR
            // 
            this.txtInsR.Location = new System.Drawing.Point(12, 143);
            this.txtInsR.Name = "txtInsR";
            this.txtInsR.Size = new System.Drawing.Size(100, 22);
            this.txtInsR.TabIndex = 6;
            this.txtInsR.Text = "Reps";
            // 
            // txtInsW
            // 
            this.txtInsW.Location = new System.Drawing.Point(12, 115);
            this.txtInsW.Name = "txtInsW";
            this.txtInsW.Size = new System.Drawing.Size(100, 22);
            this.txtInsW.TabIndex = 7;
            this.txtInsW.Text = "Weight";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleDescription = "";
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Aqua;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.setDataGridViewTextBoxColumn,
            this.weightDataGridViewTextBoxColumn,
            this.repsDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.squatBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(317, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(471, 152);
            this.dataGridView1.TabIndex = 8;
            // 
            // setDataGridViewTextBoxColumn
            // 
            this.setDataGridViewTextBoxColumn.DataPropertyName = "Set";
            this.setDataGridViewTextBoxColumn.HeaderText = "Set";
            this.setDataGridViewTextBoxColumn.Name = "setDataGridViewTextBoxColumn";
            this.setDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // weightDataGridViewTextBoxColumn
            // 
            this.weightDataGridViewTextBoxColumn.DataPropertyName = "Weight";
            this.weightDataGridViewTextBoxColumn.HeaderText = "Weight";
            this.weightDataGridViewTextBoxColumn.Name = "weightDataGridViewTextBoxColumn";
            this.weightDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // repsDataGridViewTextBoxColumn
            // 
            this.repsDataGridViewTextBoxColumn.DataPropertyName = "Reps";
            this.repsDataGridViewTextBoxColumn.HeaderText = "Reps";
            this.repsDataGridViewTextBoxColumn.Name = "repsDataGridViewTextBoxColumn";
            this.repsDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // squatBindingSource
            // 
            this.squatBindingSource.DataMember = "Squat";
            this.squatBindingSource.DataSource = this.baza1DataSet;
            // 
            // baza1DataSet
            // 
            this.baza1DataSet.DataSetName = "Baza1DataSet";
            this.baza1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // squatTableAdapter
            // 
            this.squatTableAdapter.ClearBeforeFill = true;
            // 
            // baza1DataSetBindingSource
            // 
            this.baza1DataSetBindingSource.DataSource = this.baza1DataSet;
            this.baza1DataSetBindingSource.Position = 0;
            // 
            // squatBindingSource1
            // 
            this.squatBindingSource1.DataMember = "Squat";
            this.squatBindingSource1.DataSource = this.baza1DataSetBindingSource;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(317, 171);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(423, 174);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 17);
            this.label2.TabIndex = 10;
            this.label2.Text = "Current Volume";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(550, 174);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 22);
            this.textBox2.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(656, 176);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 17);
            this.label3.TabIndex = 12;
            this.label3.Text = "Current Max Weight";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(317, 199);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(423, 202);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Threshold Volume";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(550, 202);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(656, 204);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 16;
            this.label5.Text = "Threshold Weight";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(314, 229);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "info";
            // 
            // ResBtn
            // 
            this.ResBtn.Location = new System.Drawing.Point(12, 204);
            this.ResBtn.Name = "ResBtn";
            this.ResBtn.Size = new System.Drawing.Size(227, 23);
            this.ResBtn.TabIndex = 18;
            this.ResBtn.Text = "Reset";
            this.ResBtn.UseVisualStyleBackColor = true;
            this.ResBtn.Click += new System.EventHandler(this.ResBtn_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 252);
            this.Controls.Add(this.ResBtn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtInsW);
            this.Controls.Add(this.txtInsR);
            this.Controls.Add(this.btnIns);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbSquat);
            this.Controls.Add(this.txtReps);
            this.Controls.Add(this.txtWeight);
            this.Controls.Add(this.bntUp);
            this.Name = "Form2";
            this.Text = "Squats";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baza1DataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.squatBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bntUp;
        private System.Windows.Forms.TextBox txtWeight;
        private System.Windows.Forms.TextBox txtReps;
        private System.Windows.Forms.ComboBox cmbSquat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnIns;
        private System.Windows.Forms.TextBox txtInsR;
        private System.Windows.Forms.TextBox txtInsW;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Baza1DataSet baza1DataSet;
        private System.Windows.Forms.BindingSource squatBindingSource;
        private Baza1DataSetTableAdapters.SquatTableAdapter squatTableAdapter;
        private System.Windows.Forms.BindingSource squatBindingSource1;
        private System.Windows.Forms.BindingSource baza1DataSetBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn setDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn weightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn repsDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button ResBtn;
    }
}