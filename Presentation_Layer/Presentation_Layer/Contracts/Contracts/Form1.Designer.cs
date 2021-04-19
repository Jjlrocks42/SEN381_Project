
namespace Contracts
{
    partial class FrmContracts
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
            this.DbGridContracts = new System.Windows.Forms.DataGridView();
            this.BtnContract = new System.Windows.Forms.Button();
            this.BtnPreformance = new System.Windows.Forms.Button();
            this.BtnEndContract = new System.Windows.Forms.Button();
            this.BtnPackage = new System.Windows.Forms.Button();
            this.TxtBoxSearch = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridContracts
            // 
            this.DbGridContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridContracts.Location = new System.Drawing.Point(12, 100);
            this.DbGridContracts.Name = "DbGridContracts";
            this.DbGridContracts.RowTemplate.Height = 25;
            this.DbGridContracts.Size = new System.Drawing.Size(776, 338);
            this.DbGridContracts.TabIndex = 0;
            // 
            // BtnContract
            // 
            this.BtnContract.Location = new System.Drawing.Point(245, 12);
            this.BtnContract.Name = "BtnContract";
            this.BtnContract.Size = new System.Drawing.Size(114, 23);
            this.BtnContract.TabIndex = 1;
            this.BtnContract.Text = "Show Contract";
            this.BtnContract.UseVisualStyleBackColor = true;
            // 
            // BtnPreformance
            // 
            this.BtnPreformance.Location = new System.Drawing.Point(245, 71);
            this.BtnPreformance.Name = "BtnPreformance";
            this.BtnPreformance.Size = new System.Drawing.Size(114, 23);
            this.BtnPreformance.TabIndex = 2;
            this.BtnPreformance.Text = "Track Preformance";
            this.BtnPreformance.UseVisualStyleBackColor = true;
            // 
            // BtnEndContract
            // 
            this.BtnEndContract.Location = new System.Drawing.Point(379, 12);
            this.BtnEndContract.Name = "BtnEndContract";
            this.BtnEndContract.Size = new System.Drawing.Size(114, 23);
            this.BtnEndContract.TabIndex = 3;
            this.BtnEndContract.Text = "End Contract";
            this.BtnEndContract.UseVisualStyleBackColor = true;
            // 
            // BtnPackage
            // 
            this.BtnPackage.Location = new System.Drawing.Point(379, 70);
            this.BtnPackage.Name = "BtnPackage";
            this.BtnPackage.Size = new System.Drawing.Size(114, 23);
            this.BtnPackage.TabIndex = 4;
            this.BtnPackage.Text = "Get Package";
            this.BtnPackage.UseVisualStyleBackColor = true;
            // 
            // TxtBoxSearch
            // 
            this.TxtBoxSearch.Location = new System.Drawing.Point(12, 71);
            this.TxtBoxSearch.Name = "TxtBoxSearch";
            this.TxtBoxSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtBoxSearch.TabIndex = 5;
            // 
            // FrmContracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.TxtBoxSearch);
            this.Controls.Add(this.BtnPackage);
            this.Controls.Add(this.BtnEndContract);
            this.Controls.Add(this.BtnPreformance);
            this.Controls.Add(this.BtnContract);
            this.Controls.Add(this.DbGridContracts);
            this.Name = "FrmContracts";
            this.Text = "Contracts";
            ((System.ComponentModel.ISupportInitialize)(this.DbGridContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridContracts;
        private System.Windows.Forms.Button BtnContract;
        private System.Windows.Forms.Button BtnPreformance;
        private System.Windows.Forms.Button BtnEndContract;
        private System.Windows.Forms.Button BtnPackage;
        private System.Windows.Forms.TextBox TxtBoxSearch;
    }
}

