
namespace Calls
{
    partial class FrmCalls
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
            this.DbGridCalls = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.BtnLogs = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridCalls
            // 
            this.DbGridCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridCalls.Location = new System.Drawing.Point(12, 118);
            this.DbGridCalls.Name = "DbGridCalls";
            this.DbGridCalls.RowTemplate.Height = 25;
            this.DbGridCalls.Size = new System.Drawing.Size(776, 320);
            this.DbGridCalls.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 1;
            // 
            // BtnLogs
            // 
            this.BtnLogs.Location = new System.Drawing.Point(157, 12);
            this.BtnLogs.Name = "BtnLogs";
            this.BtnLogs.Size = new System.Drawing.Size(75, 23);
            this.BtnLogs.TabIndex = 2;
            this.BtnLogs.Text = "Logs";
            this.BtnLogs.UseVisualStyleBackColor = true;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(157, 88);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(75, 23);
            this.BtnJobs.TabIndex = 3;
            this.BtnJobs.Text = "Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(278, 88);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(75, 23);
            this.BtnDelete.TabIndex = 4;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmCalls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnJobs);
            this.Controls.Add(this.BtnLogs);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.DbGridCalls);
            this.Name = "FrmCalls";
            this.Text = "Calls";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridCalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridCalls;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button BtnLogs;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button BtnDelete;
    }
}

