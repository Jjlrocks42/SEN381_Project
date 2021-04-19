
namespace Calls
{
    partial class Employees
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
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnPackage = new System.Windows.Forms.Button();
            this.BtnSla = new System.Windows.Forms.Button();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.DbGridEmployees = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(164, 91);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(123, 23);
            this.BtnHistory.TabIndex = 0;
            this.BtnHistory.Text = "View Client History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(489, 34);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(123, 23);
            this.BtnAdd.TabIndex = 1;
            this.BtnAdd.Text = "Add Client";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(164, 34);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(123, 23);
            this.BtnJobs.TabIndex = 2;
            this.BtnJobs.Text = "View Client Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(489, 91);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(123, 23);
            this.BtnDelete.TabIndex = 3;
            this.BtnDelete.Text = "Delete Client";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnPackage
            // 
            this.BtnPackage.Location = new System.Drawing.Point(325, 91);
            this.BtnPackage.Name = "BtnPackage";
            this.BtnPackage.Size = new System.Drawing.Size(123, 23);
            this.BtnPackage.TabIndex = 4;
            this.BtnPackage.Text = "View Client Package";
            this.BtnPackage.UseVisualStyleBackColor = true;
            // 
            // BtnSla
            // 
            this.BtnSla.Location = new System.Drawing.Point(325, 34);
            this.BtnSla.Name = "BtnSla";
            this.BtnSla.Size = new System.Drawing.Size(123, 23);
            this.BtnSla.TabIndex = 5;
            this.BtnSla.Text = "View Client SLA";
            this.BtnSla.UseVisualStyleBackColor = true;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 92);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(123, 23);
            this.TxtSearch.TabIndex = 6;
            // 
            // DbGridEmployees
            // 
            this.DbGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridEmployees.Location = new System.Drawing.Point(12, 122);
            this.DbGridEmployees.Name = "DbGridEmployees";
            this.DbGridEmployees.RowTemplate.Height = 25;
            this.DbGridEmployees.Size = new System.Drawing.Size(776, 307);
            this.DbGridEmployees.TabIndex = 7;
            // 
            // Employees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DbGridEmployees);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnSla);
            this.Controls.Add(this.BtnPackage);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnJobs);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnHistory);
            this.Name = "Employees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnPackage;
        private System.Windows.Forms.Button BtnSla;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.DataGridView DbGridEmployees;
    }
}