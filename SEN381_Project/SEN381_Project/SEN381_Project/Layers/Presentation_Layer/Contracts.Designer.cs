
namespace Calls
{
    partial class Contracts
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
            this.DbGridContracts = new System.Windows.Forms.DataGridView();
            this.TxtSearch = new System.Windows.Forms.TextBox();
            this.BtnEnd = new System.Windows.Forms.Button();
            this.BtnPackage = new System.Windows.Forms.Button();
            this.BtnShow = new System.Windows.Forms.Button();
            this.BtnTrack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DbGridContracts)).BeginInit();
            this.SuspendLayout();
            // 
            // DbGridContracts
            // 
            this.DbGridContracts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DbGridContracts.Location = new System.Drawing.Point(12, 101);
            this.DbGridContracts.Name = "DbGridContracts";
            this.DbGridContracts.RowTemplate.Height = 25;
            this.DbGridContracts.Size = new System.Drawing.Size(776, 307);
            this.DbGridContracts.TabIndex = 15;
            // 
            // TxtSearch
            // 
            this.TxtSearch.Location = new System.Drawing.Point(12, 72);
            this.TxtSearch.Name = "TxtSearch";
            this.TxtSearch.Size = new System.Drawing.Size(100, 23);
            this.TxtSearch.TabIndex = 14;
            // 
            // BtnEnd
            // 
            this.BtnEnd.Location = new System.Drawing.Point(292, 13);
            this.BtnEnd.Name = "BtnEnd";
            this.BtnEnd.Size = new System.Drawing.Size(114, 23);
            this.BtnEnd.TabIndex = 13;
            this.BtnEnd.Text = "End Contract";
            this.BtnEnd.UseVisualStyleBackColor = true;
            // 
            // BtnPackage
            // 
            this.BtnPackage.Location = new System.Drawing.Point(292, 71);
            this.BtnPackage.Name = "BtnPackage";
            this.BtnPackage.Size = new System.Drawing.Size(114, 23);
            this.BtnPackage.TabIndex = 12;
            this.BtnPackage.Text = "Get Package";
            this.BtnPackage.UseVisualStyleBackColor = true;
            // 
            // BtnShow
            // 
            this.BtnShow.Location = new System.Drawing.Point(138, 13);
            this.BtnShow.Name = "BtnShow";
            this.BtnShow.Size = new System.Drawing.Size(114, 23);
            this.BtnShow.TabIndex = 10;
            this.BtnShow.Text = "Show Contracts";
            this.BtnShow.UseVisualStyleBackColor = true;
            this.BtnShow.Click += new System.EventHandler(this.BtnShow_Click);
            // 
            // BtnTrack
            // 
            this.BtnTrack.Location = new System.Drawing.Point(138, 71);
            this.BtnTrack.Name = "BtnTrack";
            this.BtnTrack.Size = new System.Drawing.Size(114, 23);
            this.BtnTrack.TabIndex = 8;
            this.BtnTrack.Text = "Track Preformance";
            this.BtnTrack.UseVisualStyleBackColor = true;
            // 
            // Contracts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.DbGridContracts);
            this.Controls.Add(this.TxtSearch);
            this.Controls.Add(this.BtnEnd);
            this.Controls.Add(this.BtnPackage);
            this.Controls.Add(this.BtnShow);
            this.Controls.Add(this.BtnTrack);
            this.Name = "Contracts";
            this.Text = "Contracts";
            this.Load += new System.EventHandler(this.Contracts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DbGridContracts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DbGridContracts;
        private System.Windows.Forms.TextBox TxtSearch;
        private System.Windows.Forms.Button BtnEnd;
        private System.Windows.Forms.Button BtnPackage;
        private System.Windows.Forms.Button BtnShow;
        private System.Windows.Forms.Button BtnTrack;
    }
}