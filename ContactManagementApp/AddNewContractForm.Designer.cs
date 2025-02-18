
namespace ContactManagementApp
{
    partial class AddNewContractForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.m_nameTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.m_durationTxt = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.m_btnOk = new System.Windows.Forms.Button();
            this.m_btnCancel = new System.Windows.Forms.Button();
            this.m_SigningDtPicker = new System.Windows.Forms.DateTimePicker();
            this.m_TypeCbx = new System.Windows.Forms.ComboBox();
            this.m_ExpirationDtPicker = new System.Windows.Forms.DateTimePicker();
            this.m_lblErrorMsg = new System.Windows.Forms.Label();
            this.m_statusCbx = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.m_statusCbx);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.m_ExpirationDtPicker);
            this.panel1.Controls.Add(this.m_TypeCbx);
            this.panel1.Controls.Add(this.m_SigningDtPicker);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.m_durationTxt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.m_nameTxt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(448, 227);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name";
            // 
            // m_nameTxt
            // 
            this.m_nameTxt.Location = new System.Drawing.Point(131, 12);
            this.m_nameTxt.Name = "m_nameTxt";
            this.m_nameTxt.Size = new System.Drawing.Size(277, 20);
            this.m_nameTxt.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Signing date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Type";
            // 
            // m_durationTxt
            // 
            this.m_durationTxt.Location = new System.Drawing.Point(131, 163);
            this.m_durationTxt.Name = "m_durationTxt";
            this.m_durationTxt.Size = new System.Drawing.Size(277, 20);
            this.m_durationTxt.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 166);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Duration";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 198);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Expiration date";
            // 
            // m_btnOk
            // 
            this.m_btnOk.Location = new System.Drawing.Point(143, 289);
            this.m_btnOk.Name = "m_btnOk";
            this.m_btnOk.Size = new System.Drawing.Size(75, 23);
            this.m_btnOk.TabIndex = 1;
            this.m_btnOk.Text = "Save";
            this.m_btnOk.UseVisualStyleBackColor = true;
            this.m_btnOk.Click += new System.EventHandler(this.m_btnOk_Click);
            // 
            // m_btnCancel
            // 
            this.m_btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.m_btnCancel.Location = new System.Drawing.Point(249, 289);
            this.m_btnCancel.Name = "m_btnCancel";
            this.m_btnCancel.Size = new System.Drawing.Size(75, 23);
            this.m_btnCancel.TabIndex = 2;
            this.m_btnCancel.Text = "Cancel";
            this.m_btnCancel.UseVisualStyleBackColor = true;
            this.m_btnCancel.Click += new System.EventHandler(this.m_btnCancel_Click);
            // 
            // m_SigningDtPicker
            // 
            this.m_SigningDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_SigningDtPicker.Location = new System.Drawing.Point(131, 48);
            this.m_SigningDtPicker.Name = "m_SigningDtPicker";
            this.m_SigningDtPicker.Size = new System.Drawing.Size(277, 20);
            this.m_SigningDtPicker.TabIndex = 10;
            // 
            // m_TypeCbx
            // 
            this.m_TypeCbx.FormattingEnabled = true;
            this.m_TypeCbx.Location = new System.Drawing.Point(131, 86);
            this.m_TypeCbx.Name = "m_TypeCbx";
            this.m_TypeCbx.Size = new System.Drawing.Size(277, 21);
            this.m_TypeCbx.TabIndex = 11;
            // 
            // m_ExpirationDtPicker
            // 
            this.m_ExpirationDtPicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.m_ExpirationDtPicker.Location = new System.Drawing.Point(131, 198);
            this.m_ExpirationDtPicker.Name = "m_ExpirationDtPicker";
            this.m_ExpirationDtPicker.Size = new System.Drawing.Size(277, 20);
            this.m_ExpirationDtPicker.TabIndex = 12;
            // 
            // m_lblErrorMsg
            // 
            this.m_lblErrorMsg.AutoSize = true;
            this.m_lblErrorMsg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.m_lblErrorMsg.ForeColor = System.Drawing.Color.Red;
            this.m_lblErrorMsg.Location = new System.Drawing.Point(30, 263);
            this.m_lblErrorMsg.Name = "m_lblErrorMsg";
            this.m_lblErrorMsg.Size = new System.Drawing.Size(0, 13);
            this.m_lblErrorMsg.TabIndex = 3;
            // 
            // m_statusCbx
            // 
            this.m_statusCbx.FormattingEnabled = true;
            this.m_statusCbx.Location = new System.Drawing.Point(131, 125);
            this.m_statusCbx.Name = "m_statusCbx";
            this.m_statusCbx.Size = new System.Drawing.Size(277, 21);
            this.m_statusCbx.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 128);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Status";
            // 
            // AddNewContractForm
            // 
            this.AcceptButton = this.m_btnOk;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.m_btnCancel;
            this.ClientSize = new System.Drawing.Size(473, 324);
            this.Controls.Add(this.m_lblErrorMsg);
            this.Controls.Add(this.m_btnCancel);
            this.Controls.Add(this.m_btnOk);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddNewContractForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Add new contract";
            this.Load += new System.EventHandler(this.AddNewContractForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker m_ExpirationDtPicker;
        private System.Windows.Forms.ComboBox m_TypeCbx;
        private System.Windows.Forms.DateTimePicker m_SigningDtPicker;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox m_durationTxt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox m_nameTxt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button m_btnOk;
        private System.Windows.Forms.Button m_btnCancel;
        private System.Windows.Forms.Label m_lblErrorMsg;
        private System.Windows.Forms.ComboBox m_statusCbx;
        private System.Windows.Forms.Label label6;
    }
}