
namespace Calls
{
    partial class Clients
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
            this.DbGridClients = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDetails = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridClients
            // 
            this.DbGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridClients.Location = new System.Drawing.Point(12, 101);
            this.DbGridClients.Name = "DbGridClients";
            this.DbGridClients.RowTemplate.Height = 25;
            this.DbGridClients.Size = new System.Drawing.Size(776, 307);
            this.DbGridClients.TabIndex = 15;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 72);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtSearch.TabIndex = 14;
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(240, 13);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(96, 23);
            this.BtnHistory.TabIndex = 13;
            this.BtnHistory.Text = "View History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            // 
            // BtnContracts
            // 
            this.BtnContracts.Location = new System.Drawing.Point(240, 71);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Size = new System.Drawing.Size(96, 23);
            this.BtnContracts.TabIndex = 12;
            this.BtnContracts.Text = "View Contracts";
            this.BtnContracts.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(342, 71);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(96, 23);
            this.BtnDelete.TabIndex = 11;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(138, 13);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(96, 23);
            this.BtnJobs.TabIndex = 10;
            this.BtnJobs.Text = "View Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(342, 13);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(96, 23);
            this.BtnAdd.TabIndex = 9;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDetails
            // 
            this.BtnDetails.Location = new System.Drawing.Point(138, 71);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.Size = new System.Drawing.Size(96, 23);
            this.BtnDetails.TabIndex = 8;
            this.BtnDetails.Text = "View Details";
            this.BtnDetails.UseVisualStyleBackColor = true;
            // 
            // Clients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 450);
            this.Controls.Add(this.DbGridClients);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnContracts);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnJobs);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnDetails);
            this.Name = "Clients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbGridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridClients;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnContracts;
        private System.Windows.Forms.Button BtnDelete;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDetails;
    }
}