
namespace ThaiTanic.UserControls
{
    partial class ucCategoryCard
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblCategoryName = new System.Windows.Forms.Label();
            this.pnlBackground = new Guna.UI2.WinForms.Guna2Panel();
            this.lblCount = new System.Windows.Forms.Label();
            this.pnlBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCategoryName
            // 
            this.lblCategoryName.AutoSize = true;
            this.lblCategoryName.Font = new System.Drawing.Font("Corbel", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryName.Location = new System.Drawing.Point(3, 24);
            this.lblCategoryName.Name = "lblCategoryName";
            this.lblCategoryName.Size = new System.Drawing.Size(115, 32);
            this.lblCategoryName.TabIndex = 0;
            this.lblCategoryName.Text = "Category";
            // 
            // pnlBackground
            // 
            this.pnlBackground.BackColor = System.Drawing.Color.Transparent;
            this.pnlBackground.BorderRadius = 5;
            this.pnlBackground.Controls.Add(this.lblCount);
            this.pnlBackground.Controls.Add(this.lblCategoryName);
            this.pnlBackground.FillColor = System.Drawing.Color.MediumAquamarine;
            this.pnlBackground.Location = new System.Drawing.Point(3, 3);
            this.pnlBackground.Name = "pnlBackground";
            this.pnlBackground.Size = new System.Drawing.Size(180, 99);
            this.pnlBackground.TabIndex = 1;
            // 
            // lblCount
            // 
            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCount.Location = new System.Drawing.Point(6, 56);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(62, 15);
            this.lblCount.TabIndex = 1;
            this.lblCount.Text = "13 Items";
            // 
            // ucCategoryCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.pnlBackground);
            this.Name = "ucCategoryCard";
            this.Size = new System.Drawing.Size(187, 105);
            this.pnlBackground.ResumeLayout(false);
            this.pnlBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblCategoryName;
        private Guna.UI2.WinForms.Guna2Panel pnlBackground;
        private System.Windows.Forms.Label lblCount;
    }
}
