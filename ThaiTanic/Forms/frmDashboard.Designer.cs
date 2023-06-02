
namespace ThaiTanic.Forms
{
    partial class frmDashboard
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
            this.pnlNavigationPane = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ImageButton1 = new Guna.UI2.WinForms.Guna2ImageButton();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.btnMenu = new Guna.UI2.WinForms.Guna2Button();
            this.btnDelivery = new Guna.UI2.WinForms.Guna2Button();
            this.btnAccount = new Guna.UI2.WinForms.Guna2Button();
            this.btnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.pnlNavigationPane.SuspendLayout();
            this.pnlContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlNavigationPane
            // 
            this.pnlNavigationPane.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.pnlNavigationPane.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(36)))), ((int)(((byte)(51)))));
            this.pnlNavigationPane.Controls.Add(this.btnLogout);
            this.pnlNavigationPane.Controls.Add(this.btnAccount);
            this.pnlNavigationPane.Controls.Add(this.btnDelivery);
            this.pnlNavigationPane.Controls.Add(this.btnMenu);
            this.pnlNavigationPane.Controls.Add(this.guna2PictureBox1);
            this.pnlNavigationPane.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlNavigationPane.Location = new System.Drawing.Point(0, 0);
            this.pnlNavigationPane.Name = "pnlNavigationPane";
            this.pnlNavigationPane.Size = new System.Drawing.Size(232, 768);
            this.pnlNavigationPane.TabIndex = 0;
            // 
            // pnlContainer
            // 
            this.pnlContainer.Controls.Add(this.guna2ImageButton1);
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(232, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(1134, 768);
            this.pnlContainer.TabIndex = 1;
            // 
            // guna2ImageButton1
            // 
            this.guna2ImageButton1.CheckedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.HoverState.Image = global::ThaiTanic.Properties.Resources.btn_close;
            this.guna2ImageButton1.HoverState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Image = global::ThaiTanic.Properties.Resources.btn_close;
            this.guna2ImageButton1.ImageOffset = new System.Drawing.Point(0, 0);
            this.guna2ImageButton1.ImageRotate = 0F;
            this.guna2ImageButton1.ImageSize = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.Location = new System.Drawing.Point(1074, 4);
            this.guna2ImageButton1.Name = "guna2ImageButton1";
            this.guna2ImageButton1.PressedState.ImageSize = new System.Drawing.Size(64, 64);
            this.guna2ImageButton1.Size = new System.Drawing.Size(55, 55);
            this.guna2ImageButton1.TabIndex = 0;
            this.guna2ImageButton1.Click += new System.EventHandler(this.guna2ImageButton1_Click);
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = global::ThaiTanic.Properties.Resources.Logo_1;
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(24, 28);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(184, 122);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.guna2PictureBox1.TabIndex = 0;
            this.guna2PictureBox1.TabStop = false;
            // 
            // btnMenu
            // 
            this.btnMenu.BorderRadius = 10;
            this.btnMenu.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnMenu.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnMenu.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnMenu.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.btnMenu.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnMenu.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnMenu.Location = new System.Drawing.Point(17, 216);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(196, 42);
            this.btnMenu.TabIndex = 1;
            this.btnMenu.Text = "Menu";
            this.btnMenu.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnDelivery
            // 
            this.btnDelivery.BorderRadius = 10;
            this.btnDelivery.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnDelivery.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnDelivery.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnDelivery.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.btnDelivery.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnDelivery.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnDelivery.Location = new System.Drawing.Point(17, 267);
            this.btnDelivery.Name = "btnDelivery";
            this.btnDelivery.Size = new System.Drawing.Size(196, 42);
            this.btnDelivery.TabIndex = 2;
            this.btnDelivery.Text = "Delivery";
            this.btnDelivery.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnAccount
            // 
            this.btnAccount.BorderRadius = 10;
            this.btnAccount.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAccount.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAccount.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAccount.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.btnAccount.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnAccount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnAccount.Location = new System.Drawing.Point(17, 318);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Size = new System.Drawing.Size(196, 42);
            this.btnAccount.TabIndex = 3;
            this.btnAccount.Text = "Account";
            this.btnAccount.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnLogout
            // 
            this.btnLogout.BorderRadius = 10;
            this.btnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.btnLogout.Location = new System.Drawing.Point(17, 369);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(196, 42);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // frmDashboard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1366, 768);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.pnlNavigationPane);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1366, 768);
            this.MinimizeBox = false;
            this.Name = "frmDashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.pnlNavigationPane.ResumeLayout(false);
            this.pnlNavigationPane.PerformLayout();
            this.pnlContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlNavigationPane;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2Panel pnlContainer;
        private Guna.UI2.WinForms.Guna2ImageButton guna2ImageButton1;
        private Guna.UI2.WinForms.Guna2Button btnMenu;
        private Guna.UI2.WinForms.Guna2Button btnLogout;
        private Guna.UI2.WinForms.Guna2Button btnAccount;
        private Guna.UI2.WinForms.Guna2Button btnDelivery;
    }
}