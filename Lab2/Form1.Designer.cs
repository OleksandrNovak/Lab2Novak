namespace Lab2
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
            this.matrGridView1 = new System.Windows.Forms.DataGridView();
            this.matrGridView2 = new System.Windows.Forms.DataGridView();
            this.loadMatr1 = new System.Windows.Forms.Button();
            this.loadMatr2 = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.task1 = new System.Windows.Forms.Button();
            this.task2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.matrGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // matrGridView1
            // 
            this.matrGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrGridView1.Location = new System.Drawing.Point(12, 39);
            this.matrGridView1.Name = "matrGridView1";
            this.matrGridView1.RowHeadersWidth = 51;
            this.matrGridView1.RowTemplate.Height = 24;
            this.matrGridView1.Size = new System.Drawing.Size(545, 180);
            this.matrGridView1.TabIndex = 0;
            // 
            // matrGridView2
            // 
            this.matrGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.matrGridView2.Location = new System.Drawing.Point(12, 253);
            this.matrGridView2.Name = "matrGridView2";
            this.matrGridView2.RowHeadersWidth = 51;
            this.matrGridView2.RowTemplate.Height = 24;
            this.matrGridView2.Size = new System.Drawing.Size(545, 173);
            this.matrGridView2.TabIndex = 1;
            // 
            // loadMatr1
            // 
            this.loadMatr1.Location = new System.Drawing.Point(652, 62);
            this.loadMatr1.Name = "loadMatr1";
            this.loadMatr1.Size = new System.Drawing.Size(121, 23);
            this.loadMatr1.TabIndex = 2;
            this.loadMatr1.Text = "Матриця 1";
            this.loadMatr1.UseVisualStyleBackColor = true;
            this.loadMatr1.Click += new System.EventHandler(this.loadMatr1_Click);
            // 
            // loadMatr2
            // 
            this.loadMatr2.Location = new System.Drawing.Point(652, 104);
            this.loadMatr2.Name = "loadMatr2";
            this.loadMatr2.Size = new System.Drawing.Size(121, 23);
            this.loadMatr2.TabIndex = 3;
            this.loadMatr2.Text = "Матриця 2";
            this.loadMatr2.UseVisualStyleBackColor = true;
            this.loadMatr2.Click += new System.EventHandler(this.loadMatr2_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // task1
            // 
            this.task1.Location = new System.Drawing.Point(652, 153);
            this.task1.Name = "task1";
            this.task1.Size = new System.Drawing.Size(121, 23);
            this.task1.TabIndex = 4;
            this.task1.Text = "Завдання 1";
            this.task1.UseVisualStyleBackColor = true;
            this.task1.Click += new System.EventHandler(this.task1_Click);
            // 
            // task2
            // 
            this.task2.Location = new System.Drawing.Point(652, 196);
            this.task2.Name = "task2";
            this.task2.Size = new System.Drawing.Size(121, 23);
            this.task2.TabIndex = 5;
            this.task2.Text = "Завдання 2";
            this.task2.UseVisualStyleBackColor = true;
            this.task2.Click += new System.EventHandler(this.task2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.task2);
            this.Controls.Add(this.task1);
            this.Controls.Add(this.loadMatr2);
            this.Controls.Add(this.loadMatr1);
            this.Controls.Add(this.matrGridView2);
            this.Controls.Add(this.matrGridView1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.matrGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.matrGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView matrGridView1;
        private System.Windows.Forms.DataGridView matrGridView2;
        private System.Windows.Forms.Button loadMatr1;
        private System.Windows.Forms.Button loadMatr2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button task1;
        private System.Windows.Forms.Button task2;
    }
}

