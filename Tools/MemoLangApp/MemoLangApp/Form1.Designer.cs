namespace MemoLangApp
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            panel1 = new Panel();
            txtFilePath = new Button();
            textBox1 = new TextBox();
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            Date = new DataGridViewTextBoxColumn();
            Grammar = new DataGridViewTextBoxColumn();
            Connection = new DataGridViewTextBoxColumn();
            Meaning = new DataGridViewTextBoxColumn();
            Sample = new DataGridViewTextBoxColumn();
            Others = new DataGridViewTextBoxColumn();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(txtFilePath);
            panel1.Controls.Add(textBox1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(813, 34);
            panel1.TabIndex = 0;
            // 
            // txtFilePath
            // 
            txtFilePath.Location = new Point(713, 6);
            txtFilePath.Name = "txtFilePath";
            txtFilePath.Size = new Size(90, 23);
            txtFilePath.TabIndex = 2;
            txtFilePath.Text = "select file";
            txtFilePath.UseVisualStyleBackColor = true;
            txtFilePath.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(7, 6);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(698, 23);
            textBox1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Dock = DockStyle.Fill;
            panel2.Location = new Point(0, 34);
            panel2.Name = "panel2";
            panel2.Size = new Size(813, 416);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.AccessibleRole = AccessibleRole.None;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { Date, Grammar, Connection, Meaning, Sample, Others });
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Yu Gothic UI", 9F);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(0, 0);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(813, 416);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            // 
            // Date
            // 
            Date.DataPropertyName = "Date";
            Date.HeaderText = "日付";
            Date.Name = "Date";
            Date.Width = 90;
            // 
            // Grammar
            // 
            Grammar.DataPropertyName = "Grammar";
            Grammar.HeaderText = "文法";
            Grammar.Name = "Grammar";
            Grammar.Width = 150;
            // 
            // Connection
            // 
            Connection.DataPropertyName = "Connection";
            Connection.HeaderText = "接続";
            Connection.Name = "Connection";
            Connection.Width = 150;
            // 
            // Meaning
            // 
            Meaning.DataPropertyName = "Meaning";
            Meaning.HeaderText = "意味";
            Meaning.Name = "Meaning";
            Meaning.Width = 200;
            // 
            // Sample
            // 
            Sample.DataPropertyName = "Sample";
            Sample.HeaderText = "例文";
            Sample.Name = "Sample";
            Sample.Width = 300;
            // 
            // Others
            // 
            Others.DataPropertyName = "Others";
            Others.HeaderText = "その他";
            Others.Name = "Others";
            Others.Width = 300;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 450);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button txtFilePath;
        private TextBox textBox1;
        private Panel panel2;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Date;
        private DataGridViewTextBoxColumn Grammar;
        private DataGridViewTextBoxColumn Connection;
        private DataGridViewTextBoxColumn Meaning;
        private DataGridViewTextBoxColumn Sample;
        private DataGridViewTextBoxColumn Others;
    }
}
