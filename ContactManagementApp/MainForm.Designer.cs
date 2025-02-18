
namespace ContactManagementApp
{
    partial class MainForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.ContractTab = new System.Windows.Forms.TabPage();
            this.EmployesTab = new System.Windows.Forms.TabPage();
            this.SearchTxt = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.ContractsDgv = new System.Windows.Forms.DataGridView();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.m_contractName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_StatusCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ContractTypeCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_SigningDateCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_DurationCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.m_ExpirationDateCln = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1.SuspendLayout();
            this.ContractTab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsDgv)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.ContractTab);
            this.tabControl1.Controls.Add(this.EmployesTab);
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(957, 522);
            this.tabControl1.TabIndex = 0;
            // 
            // ContractTab
            // 
            this.ContractTab.Controls.Add(this.EditBtn);
            this.ContractTab.Controls.Add(this.DeleteBtn);
            this.ContractTab.Controls.Add(this.AddBtn);
            this.ContractTab.Controls.Add(this.ContractsDgv);
            this.ContractTab.Controls.Add(this.SearchBtn);
            this.ContractTab.Controls.Add(this.SearchTxt);
            this.ContractTab.Location = new System.Drawing.Point(4, 22);
            this.ContractTab.Name = "ContractTab";
            this.ContractTab.Padding = new System.Windows.Forms.Padding(3);
            this.ContractTab.Size = new System.Drawing.Size(949, 496);
            this.ContractTab.TabIndex = 0;
            this.ContractTab.Text = "Contracts";
            this.ContractTab.UseVisualStyleBackColor = true;
            this.ContractTab.Click += new System.EventHandler(this.ContractTab_Click);
            // 
            // EmployesTab
            // 
            this.EmployesTab.Location = new System.Drawing.Point(4, 22);
            this.EmployesTab.Name = "EmployesTab";
            this.EmployesTab.Padding = new System.Windows.Forms.Padding(3);
            this.EmployesTab.Size = new System.Drawing.Size(1056, 496);
            this.EmployesTab.TabIndex = 1;
            this.EmployesTab.Text = "Employees";
            this.EmployesTab.UseVisualStyleBackColor = true;
            // 
            // SearchTxt
            // 
            this.SearchTxt.Location = new System.Drawing.Point(25, 19);
            this.SearchTxt.Name = "SearchTxt";
            this.SearchTxt.Size = new System.Drawing.Size(436, 20);
            this.SearchTxt.TabIndex = 0;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(504, 17);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(75, 23);
            this.SearchBtn.TabIndex = 1;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click);
            // 
            // ContractsDgv
            // 
            this.ContractsDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ContractsDgv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.m_contractName,
            this.m_StatusCln,
            this.m_ContractTypeCln,
            this.m_SigningDateCln,
            this.m_DurationCln,
            this.m_ExpirationDateCln});
            this.ContractsDgv.Location = new System.Drawing.Point(25, 59);
            this.ContractsDgv.MultiSelect = false;
            this.ContractsDgv.Name = "ContractsDgv";
            this.ContractsDgv.RowHeadersVisible = false;
            this.ContractsDgv.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ContractsDgv.Size = new System.Drawing.Size(806, 420);
            this.ContractsDgv.TabIndex = 2;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(853, 88);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(75, 23);
            this.AddBtn.TabIndex = 3;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(853, 170);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(75, 23);
            this.DeleteBtn.TabIndex = 4;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(853, 130);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(75, 23);
            this.EditBtn.TabIndex = 5;
            this.EditBtn.Text = "Update";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // m_contractName
            // 
            this.m_contractName.HeaderText = "Contract Name";
            this.m_contractName.Name = "m_contractName";
            this.m_contractName.Width = 300;
            // 
            // m_StatusCln
            // 
            this.m_StatusCln.HeaderText = "Status";
            this.m_StatusCln.Name = "m_StatusCln";
            // 
            // m_ContractTypeCln
            // 
            this.m_ContractTypeCln.HeaderText = "Contract Type";
            this.m_ContractTypeCln.Name = "m_ContractTypeCln";
            // 
            // m_SigningDateCln
            // 
            this.m_SigningDateCln.HeaderText = "Signing Date";
            this.m_SigningDateCln.Name = "m_SigningDateCln";
            // 
            // m_DurationCln
            // 
            this.m_DurationCln.HeaderText = "Duration";
            this.m_DurationCln.Name = "m_DurationCln";
            // 
            // m_ExpirationDateCln
            // 
            this.m_ExpirationDateCln.HeaderText = "Expiration Date";
            this.m_ExpirationDateCln.Name = "m_ExpirationDateCln";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 527);
            this.Controls.Add(this.tabControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.ShowIcon = false;
            this.Text = "Contract Management application";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.ContractTab.ResumeLayout(false);
            this.ContractTab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ContractsDgv)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage ContractTab;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.TextBox SearchTxt;
        private System.Windows.Forms.TabPage EmployesTab;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.DataGridView ContractsDgv;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_contractName;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_StatusCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ContractTypeCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_SigningDateCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_DurationCln;
        private System.Windows.Forms.DataGridViewTextBoxColumn m_ExpirationDateCln;
    }
}