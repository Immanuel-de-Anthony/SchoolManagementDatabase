
namespace SchoolManagementDB
{
    partial class Form1
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
            this.label2 = new System.Windows.Forms.Label();
            this.query1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Query3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 236);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Status";
            // 
            // query1
            // 
            this.query1.Location = new System.Drawing.Point(87, 36);
            this.query1.Name = "query1";
            this.query1.Size = new System.Drawing.Size(75, 23);
            this.query1.TabIndex = 1;
            this.query1.Text = "Linq Query";
            this.query1.UseVisualStyleBackColor = true;
            this.query1.Click += new System.EventHandler(this.query1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(213, 76);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(240, 150);
            this.dataGridView1.TabIndex = 2;
            // 
            // Query3
            // 
            this.Query3.Location = new System.Drawing.Point(522, 36);
            this.Query3.Name = "Query3";
            this.Query3.Size = new System.Drawing.Size(75, 23);
            this.Query3.TabIndex = 3;
            this.Query3.Text = "Total Fee";
            this.Query3.UseVisualStyleBackColor = true;
            this.Query3.Click += new System.EventHandler(this.Query3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(275, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(129, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Student Details";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(665, 261);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Query3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.query1);
            this.Controls.Add(this.label2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button query1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Query3;
        private System.Windows.Forms.Button button2;
    }
}

