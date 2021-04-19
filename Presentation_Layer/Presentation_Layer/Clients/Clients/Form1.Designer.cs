
namespace Clients
{
    partial class FrmClients
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
            this.DbGridClients = new System.Windows.Forms.DataGridView();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            this.BtnDetails = new System.Windows.Forms.Button();
            this.BtnJobs = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.BtnContracts = new System.Windows.Forms.Button();
            this.BtnAdd = new System.Windows.Forms.Button();
            this.BtnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridClients)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridClients
            // 
            this.DbGridClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridClients.Location = new System.Drawing.Point(12, 102);
            this.DbGridClients.Name = "DbGridClients";
            this.DbGridClients.RowTemplate.Height = 25;
            this.DbGridClients.Size = new System.Drawing.Size(776, 336);
            this.DbGridClients.TabIndex = 0;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(12, 73);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxSearch.TabIndex = 1;
            this.TxtBoxSearch.TextChanged += new System.EventHandler(this.TxtBoxSearch_TextChanged);
            // 
            // BtnDetails
            // 
            this.BtnDetails.Location = new System.Drawing.Point(143, 12);
            this.BtnDetails.Name = "BtnDetails";
            this.BtnDetails.Size = new System.Drawing.Size(110, 23);
            this.BtnDetails.TabIndex = 3;
            this.BtnDetails.Text = "View Details";
            this.BtnDetails.UseVisualStyleBackColor = true;
            // 
            // BtnJobs
            // 
            this.BtnJobs.Location = new System.Drawing.Point(143, 72);
            this.BtnJobs.Name = "BtnJobs";
            this.BtnJobs.Size = new System.Drawing.Size(110, 23);
            this.BtnJobs.TabIndex = 4;
            this.BtnJobs.Text = "View Jobs";
            this.BtnJobs.UseVisualStyleBackColor = true;
            this.BtnJobs.Click += new System.EventHandler(this.BtnJobs_Click);
            // 
            // BtnHistory
            // 
            this.BtnHistory.Location = new System.Drawing.Point(287, 12);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(110, 23);
            this.BtnHistory.TabIndex = 5;
            this.BtnHistory.Text = "View History";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.button4_Click);
            // 
            // BtnContracts
            // 
            this.BtnContracts.Location = new System.Drawing.Point(287, 72);
            this.BtnContracts.Name = "BtnContracts";
            this.BtnContracts.Size = new System.Drawing.Size(110, 23);
            this.BtnContracts.TabIndex = 6;
            this.BtnContracts.Text = "View Contracts";
            this.BtnContracts.UseVisualStyleBackColor = true;
            // 
            // BtnAdd
            // 
            this.BtnAdd.Location = new System.Drawing.Point(418, 12);
            this.BtnAdd.Name = "BtnAdd";
            this.BtnAdd.Size = new System.Drawing.Size(110, 23);
            this.BtnAdd.TabIndex = 7;
            this.BtnAdd.Text = "Add";
            this.BtnAdd.UseVisualStyleBackColor = true;
            // 
            // BtnDelete
            // 
            this.BtnDelete.Location = new System.Drawing.Point(418, 72);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(110, 23);
            this.BtnDelete.TabIndex = 8;
            this.BtnDelete.Text = "Delete";
            this.BtnDelete.UseVisualStyleBackColor = true;
            // 
            // FrmClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.BtnAdd);
            this.Controls.Add(this.BtnContracts);
            this.Controls.Add(this.BtnHistory);
            this.Controls.Add(this.BtnJobs);
            this.Controls.Add(this.BtnDetails);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.DbGridClients);
            this.Name = "FrmClients";
            this.Text = "Clients";
            this.Load += new System.EventHandler(this.FrmClients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbGridClients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridClients;
        private System.Windows.Forms.TextBox TxtBoxSearch;
        private System.Windows.Forms.Button BtnDetails;
        private System.Windows.Forms.Button BtnJobs;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.Button BtnContracts;
        private System.Windows.Forms.Button BtnAdd;
        private System.Windows.Forms.Button BtnDelete;
    }
}

