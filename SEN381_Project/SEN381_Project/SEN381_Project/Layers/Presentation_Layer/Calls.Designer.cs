
namespace Calls
{
    partial class Calls
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
            this.DbGridCalls = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnLogs = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridCalls)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridCalls
            // 
            this.DbGridCalls.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridCalls.Location = new System.Drawing.Point(12, 101);
            this.DbGridCalls.Name = "DbGridCalls";
            this.DbGridCalls.RowTemplate.Height = 25;
            this.DbGridCalls.Size = new System.Drawing.Size(776, 307);
            this.DbGridCalls.TabIndex = 15;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 72);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtSearch.TabIndex = 14;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(259, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(96, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete Call";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnLogs
            // 
            this.BtnLogs.Location = new System.Drawing.Point(138, 13);
            this.BtnLogs.Name = "BtnLogs";
            this.BtnLogs.Size = new System.Drawing.Size(96, 23);
            this.BtnLogs.TabIndex = 10;
            this.BtnLogs.Text = "View Logs";
            this.BtnLogs.UseVisualStyleBackColor = true;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(138, 71);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(96, 23);
            this.BtnJobs.TabIndex = 8;
            this.BtnJobs.Text = "View Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            // 
            // Calls
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DbGridCalls);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnLogs);
            this.Controls.Add(this.BtnJobs);
            this.Name = "Calls";
            this.Text = "Calls";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridCalls)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridCalls;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnLogs;
        private System.Windows.Forms.Button BtnJobs;
    }
}