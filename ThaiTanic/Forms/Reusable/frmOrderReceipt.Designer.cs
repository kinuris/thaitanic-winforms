namespace ThaiTanic.Forms.Reusable
{
    partial class frmOrderReceipt
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
            this.rprtReceipt = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // rprtReceipt
            // 
            this.rprtReceipt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rprtReceipt.LocalReport.ReportEmbeddedResource = "";
            this.rprtReceipt.Location = new System.Drawing.Point(0, 0);
            this.rprtReceipt.Name = "rprtReceipt";
            this.rprtReceipt.ServerReport.BearerToken = null;
            this.rprtReceipt.Size = new System.Drawing.Size(459, 730);
            this.rprtReceipt.TabIndex = 0;
            // 
            // frmOrderReceipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 730);
            this.Controls.Add(this.rprtReceipt);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "frmOrderReceipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Order Receipt";
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer rprtReceipt;
    }
}