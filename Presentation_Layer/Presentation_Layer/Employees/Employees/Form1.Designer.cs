
namespace Employees
{
    partial class FrmEmployees
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
            this.DbGridEmployees = new System.Windows.Forms.DataGridView();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnSLA = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridEmployees)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridEmployees
            // 
            this.DbGridEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridEmployees.Location = new System.Drawing.Point(12, 97);
            this.DbGridEmployees.Name = "DbGridEmployees";
            this.DbGridEmployees.RowTemplate.Height = 25;
            this.DbGridEmployees.Size = new System.Drawing.Size(776, 341);
            this.DbGridEmployees.TabIndex = 0;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(12, 68);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxSearch.TabIndex = 1;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(157, 12);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(128, 23);
            this.BtnJobs.TabIndex = 2;
            this.BtnJobs.Text = "View Client Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(157, 68);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(128, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "View Client History";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(298, 67);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "View Client Package";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // BtnSLA
            // 
            this.BtnSLA.Location = new System.Drawing.Point(298, 12);
            this.BtnSLA.Name = "BtnSLA";
            this.BtnSLA.Size = new System.Drawing.Size(128, 23);
            this.BtnSLA.TabIndex = 5;
            this.BtnSLA.Text = "View Client SLA";
            this.BtnSLA.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(443, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(128, 23);
            this.BtnAdd.TabIndex = 6;
            this.BtnAdd.Text = "Add Client";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(443, 67);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(128, 23);
            this.BtnDelete.TabIndex = 7;
            this.BtnDelete.Text = "Delete Client";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmEmployees
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnSLA);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.BtnJobs);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DbGridEmployees);
            this.Name = "FrmEmployees";
            this.Text = "Employees";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridEmployees)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridEmployees;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button BtnSLA;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
    }
}

