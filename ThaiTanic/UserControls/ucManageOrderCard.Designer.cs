
namespace ThaiTanic.UserControls
{
    partial class ucManageOrderCard
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.cbOrderStatus = new Guna.UI2.WinForms.Guna2ComboBox();
            this.lblTotalCost = new System.Windows.Forms.Label();
            this.lblOrderDate = new System.Windows.Forms.Label();
            this.lblItemCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.cbOrderStatus);
            this.guna2Panel1.Controls.Add(this.lblTotalCost);
            this.guna2Panel1.Controls.Add(this.lblOrderDate);
            this.guna2Panel1.Controls.Add(this.lblItemCount);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.lblOrderNumber);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(988, 83);
            this.guna2Panel1.TabIndex = 0;
            // 
            // cbOrderStatus
            // 
            this.cbOrderStatus.BackColor = System.Drawing.Color.Transparent;
            this.cbOrderStatus.BorderRadius = 10;
            this.cbOrderStatus.BorderThickness = 0;
            this.cbOrderStatus.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbOrderStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbOrderStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.cbOrderStatus.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrderStatus.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.cbOrderStatus.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Bold);
            this.cbOrderStatus.ForeColor = System.Drawing.Color.White;
            this.cbOrderStatus.ItemHeight = 30;
            this.cbOrderStatus.ItemsAppearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.cbOrderStatus.ItemsAppearance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.cbOrderStatus.ItemsAppearance.SelectedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.cbOrderStatus.ItemsAppearance.SelectedForeColor = System.Drawing.Color.White;
            this.cbOrderStatus.Location = new System.Drawing.Point(813, 38);
            this.cbOrderStatus.Name = "cbOrderStatus";
            this.cbOrderStatus.Size = new System.Drawing.Size(145, 36);
            this.cbOrderStatus.TabIndex = 18;
            this.cbOrderStatus.SelectedIndexChanged += new System.EventHandler(this.cbOrderStatus_SelectedIndexChanged);
            // 
            // lblTotalCost
            // 
            this.lblTotalCost.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalCost.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalCost.ForeColor = System.Drawing.Color.White;
            this.lblTotalCost.Location = new System.Drawing.Point(661, 6);
            this.lblTotalCost.Name = "lblTotalCost";
            this.lblTotalCost.Size = new System.Drawing.Size(297, 25);
            this.lblTotalCost.TabIndex = 10;
            this.lblTotalCost.Text = "369.69";
            this.lblTotalCost.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblOrderDate
            // 
            this.lblOrderDate.AutoSize = true;
            this.lblOrderDate.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblOrderDate.Location = new System.Drawing.Point(33, 58);
            this.lblOrderDate.Name = "lblOrderDate";
            this.lblOrderDate.Size = new System.Drawing.Size(154, 17);
            this.lblOrderDate.TabIndex = 9;
            this.lblOrderDate.Text = "June 3, 2023 11:28 am";
            // 
            // lblItemCount
            // 
            this.lblItemCount.AutoSize = true;
            this.lblItemCount.BackColor = System.Drawing.Color.Transparent;
            this.lblItemCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.lblItemCount.Location = new System.Drawing.Point(132, 37);
            this.lblItemCount.Name = "lblItemCount";
            this.lblItemCount.Size = new System.Drawing.Size(16, 17);
            this.lblItemCount.TabIndex = 8;
            this.lblItemCount.Text = "4";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(117)))), ((int)(((byte)(117)))));
            this.label2.Location = new System.Drawing.Point(33, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "Items ordered:";
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.ForeColor = System.Drawing.Color.White;
            this.lblOrderNumber.Location = new System.Drawing.Point(114, 7);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(65, 24);
            this.lblOrderNumber.TabIndex = 6;
            this.lblOrderNumber.Text = "13123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(30, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 24);
            this.label1.TabIndex = 5;
            this.label1.Text = "Order: # ";
            // 
            // ucManageOrderCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "ucManageOrderCard";
            this.Size = new System.Drawing.Size(988, 83);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblOrderDate;
        private System.Windows.Forms.Label lblItemCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblOrderNumber;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCost;
        private Guna.UI2.WinForms.Guna2ComboBox cbOrderStatus;
    }
}
