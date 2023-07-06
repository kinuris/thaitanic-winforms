
namespace ThaiTanic.Forms
{
    partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.pnlButtonTabs = new Guna.UI2.WinForms.Guna2Panel();
            this.btnCanceled = new Guna.UI2.WinForms.Guna2Button();
            this.btnCompleted = new Guna.UI2.WinForms.Guna2Button();
            this.btnToReceive = new Guna.UI2.WinForms.Guna2Button();
            this.btnToShip = new Guna.UI2.WinForms.Guna2Button();
            this.btnToPay = new Guna.UI2.WinForms.Guna2Button();
            this.btnAll = new Guna.UI2.WinForms.Guna2Button();
            this.pnlSearch = new Guna.UI2.WinForms.Guna2Panel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.pnlOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.pnlOrderItems = new Guna.UI2.WinForms.Guna2Panel();
            this.lblItemPageIndicator = new System.Windows.Forms.Label();
            this.btnItemsPageForward = new Guna.UI2.WinForms.Guna2Button();
            this.btnItemsPageBackward = new Guna.UI2.WinForms.Guna2Button();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOrderedBatch = new System.Windows.Forms.FlowLayoutPanel();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCustomerDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2PictureBox4 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox2 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.guna2PictureBox1 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.lblPostalCodeBrgyProvince = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCity = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCountry = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPaymentMethod = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblPhoneNumber = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblEmail = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.lblCustomerName = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2Shapes1 = new Guna.UI2.WinForms.Guna2Shapes();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOrderSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotal = new System.Windows.Forms.Label();
            this.lblShippingFee = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblOrderPage = new System.Windows.Forms.Label();
            this.lblAddressLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.pnlButtonTabs.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.pnlOrderItems.SuspendLayout();
            this.pnlCustomerDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).BeginInit();
            this.pnlOrderSummary.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlButtonTabs
            // 
            this.pnlButtonTabs.BackColor = System.Drawing.Color.Transparent;
            this.pnlButtonTabs.Controls.Add(this.btnCanceled);
            this.pnlButtonTabs.Controls.Add(this.btnCompleted);
            this.pnlButtonTabs.Controls.Add(this.btnToReceive);
            this.pnlButtonTabs.Controls.Add(this.btnToShip);
            this.pnlButtonTabs.Controls.Add(this.btnToPay);
            this.pnlButtonTabs.Controls.Add(this.btnAll);
            this.pnlButtonTabs.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlButtonTabs.Location = new System.Drawing.Point(0, 0);
            this.pnlButtonTabs.Name = "pnlButtonTabs";
            this.pnlButtonTabs.Size = new System.Drawing.Size(1134, 45);
            this.pnlButtonTabs.TabIndex = 0;
            // 
            // btnCanceled
            // 
            this.btnCanceled.BorderColor = System.Drawing.Color.White;
            this.btnCanceled.BorderThickness = 1;
            this.btnCanceled.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceled.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCanceled.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCanceled.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCanceled.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnCanceled.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCanceled.ForeColor = System.Drawing.Color.White;
            this.btnCanceled.Location = new System.Drawing.Point(945, 0);
            this.btnCanceled.Name = "btnCanceled";
            this.btnCanceled.Size = new System.Drawing.Size(189, 45);
            this.btnCanceled.TabIndex = 5;
            this.btnCanceled.Text = "Canceled";
            this.btnCanceled.Click += new System.EventHandler(this.btnCanceled_Click);
            // 
            // btnCompleted
            // 
            this.btnCompleted.BorderColor = System.Drawing.Color.White;
            this.btnCompleted.BorderThickness = 1;
            this.btnCompleted.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCompleted.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCompleted.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCompleted.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnCompleted.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnCompleted.ForeColor = System.Drawing.Color.White;
            this.btnCompleted.Location = new System.Drawing.Point(756, 0);
            this.btnCompleted.Name = "btnCompleted";
            this.btnCompleted.Size = new System.Drawing.Size(189, 45);
            this.btnCompleted.TabIndex = 4;
            this.btnCompleted.Text = "Completed";
            this.btnCompleted.Click += new System.EventHandler(this.btnCompleted_Click);
            // 
            // btnToReceive
            // 
            this.btnToReceive.BorderColor = System.Drawing.Color.White;
            this.btnToReceive.BorderThickness = 1;
            this.btnToReceive.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToReceive.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToReceive.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToReceive.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToReceive.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnToReceive.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnToReceive.ForeColor = System.Drawing.Color.White;
            this.btnToReceive.Location = new System.Drawing.Point(567, 0);
            this.btnToReceive.Name = "btnToReceive";
            this.btnToReceive.Size = new System.Drawing.Size(189, 45);
            this.btnToReceive.TabIndex = 3;
            this.btnToReceive.Text = "To Receive";
            this.btnToReceive.Click += new System.EventHandler(this.btnToReceive_Click);
            // 
            // btnToShip
            // 
            this.btnToShip.BorderColor = System.Drawing.Color.White;
            this.btnToShip.BorderThickness = 1;
            this.btnToShip.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToShip.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToShip.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToShip.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToShip.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnToShip.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnToShip.ForeColor = System.Drawing.Color.White;
            this.btnToShip.Location = new System.Drawing.Point(378, 0);
            this.btnToShip.Name = "btnToShip";
            this.btnToShip.Size = new System.Drawing.Size(189, 45);
            this.btnToShip.TabIndex = 2;
            this.btnToShip.Text = "To Ship";
            this.btnToShip.Click += new System.EventHandler(this.btnToShip_Click);
            // 
            // btnToPay
            // 
            this.btnToPay.BorderColor = System.Drawing.Color.White;
            this.btnToPay.BorderThickness = 1;
            this.btnToPay.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnToPay.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnToPay.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnToPay.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnToPay.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnToPay.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnToPay.ForeColor = System.Drawing.Color.White;
            this.btnToPay.Location = new System.Drawing.Point(189, 0);
            this.btnToPay.Name = "btnToPay";
            this.btnToPay.Size = new System.Drawing.Size(189, 45);
            this.btnToPay.TabIndex = 1;
            this.btnToPay.Text = "To Pay";
            this.btnToPay.Click += new System.EventHandler(this.btnToPay_Click);
            // 
            // btnAll
            // 
            this.btnAll.BorderColor = System.Drawing.Color.White;
            this.btnAll.BorderThickness = 1;
            this.btnAll.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAll.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAll.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAll.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(32)))), ((int)(((byte)(65)))));
            this.btnAll.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold);
            this.btnAll.ForeColor = System.Drawing.Color.White;
            this.btnAll.Location = new System.Drawing.Point(0, 0);
            this.btnAll.Name = "btnAll";
            this.btnAll.Size = new System.Drawing.Size(189, 45);
            this.btnAll.TabIndex = 0;
            this.btnAll.Text = "All";
            this.btnAll.Click += new System.EventHandler(this.btnAll_Click);
            // 
            // pnlSearch
            // 
            this.pnlSearch.BackColor = System.Drawing.Color.Transparent;
            this.pnlSearch.Controls.Add(this.txtSearch);
            this.pnlSearch.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlSearch.Location = new System.Drawing.Point(0, 45);
            this.pnlSearch.Name = "pnlSearch";
            this.pnlSearch.Size = new System.Drawing.Size(1134, 62);
            this.pnlSearch.TabIndex = 1;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderColor = System.Drawing.Color.Silver;
            this.txtSearch.BorderRadius = 10;
            this.txtSearch.BorderThickness = 0;
            this.txtSearch.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearch.DefaultText = "";
            this.txtSearch.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearch.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearch.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.txtSearch.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.txtSearch.ForeColor = System.Drawing.Color.White;
            this.txtSearch.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearch.IconLeft = ((System.Drawing.Image)(resources.GetObject("txtSearch.IconLeft")));
            this.txtSearch.IconLeftOffset = new System.Drawing.Point(5, 0);
            this.txtSearch.IconLeftSize = new System.Drawing.Size(36, 36);
            this.txtSearch.Location = new System.Drawing.Point(31, 16);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtSearch.PlaceholderText = "Look for your Orders here by searching the Order ID or Product name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1072, 42);
            this.txtSearch.TabIndex = 0;
            // 
            // pnlOrders
            // 
            this.pnlOrders.Location = new System.Drawing.Point(0, 104);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Padding = new System.Windows.Forms.Padding(26, 10, 0, 0);
            this.pnlOrders.Size = new System.Drawing.Size(794, 398);
            this.pnlOrders.TabIndex = 2;
            // 
            // pnlOrderItems
            // 
            this.pnlOrderItems.BorderRadius = 10;
            this.pnlOrderItems.Controls.Add(this.lblItemPageIndicator);
            this.pnlOrderItems.Controls.Add(this.btnItemsPageForward);
            this.pnlOrderItems.Controls.Add(this.btnItemsPageBackward);
            this.pnlOrderItems.Controls.Add(this.lblOrderNumber);
            this.pnlOrderItems.Controls.Add(this.label1);
            this.pnlOrderItems.Controls.Add(this.pnlOrderedBatch);
            this.pnlOrderItems.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnlOrderItems.Location = new System.Drawing.Point(796, 118);
            this.pnlOrderItems.Name = "pnlOrderItems";
            this.pnlOrderItems.Size = new System.Drawing.Size(307, 357);
            this.pnlOrderItems.TabIndex = 3;
            // 
            // lblItemPageIndicator
            // 
            this.lblItemPageIndicator.AutoSize = true;
            this.lblItemPageIndicator.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.lblItemPageIndicator.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblItemPageIndicator.ForeColor = System.Drawing.Color.White;
            this.lblItemPageIndicator.Location = new System.Drawing.Point(44, 320);
            this.lblItemPageIndicator.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblItemPageIndicator.Name = "lblItemPageIndicator";
            this.lblItemPageIndicator.Size = new System.Drawing.Size(45, 24);
            this.lblItemPageIndicator.TabIndex = 17;
            this.lblItemPageIndicator.Text = "1 / 1";
            // 
            // btnItemsPageForward
            // 
            this.btnItemsPageForward.BorderRadius = 5;
            this.btnItemsPageForward.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsPageForward.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsPageForward.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItemsPageForward.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItemsPageForward.FillColor = System.Drawing.Color.Gray;
            this.btnItemsPageForward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnItemsPageForward.ForeColor = System.Drawing.Color.White;
            this.btnItemsPageForward.Image = global::ThaiTanic.Properties.Resources.btn_forward;
            this.btnItemsPageForward.ImageSize = new System.Drawing.Size(15, 15);
            this.btnItemsPageForward.Location = new System.Drawing.Point(93, 318);
            this.btnItemsPageForward.Name = "btnItemsPageForward";
            this.btnItemsPageForward.Size = new System.Drawing.Size(26, 26);
            this.btnItemsPageForward.TabIndex = 4;
            this.btnItemsPageForward.Click += new System.EventHandler(this.btnItemsPageForward_Click);
            // 
            // btnItemsPageBackward
            // 
            this.btnItemsPageBackward.BorderRadius = 5;
            this.btnItemsPageBackward.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsPageBackward.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnItemsPageBackward.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnItemsPageBackward.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnItemsPageBackward.FillColor = System.Drawing.Color.Gray;
            this.btnItemsPageBackward.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnItemsPageBackward.ForeColor = System.Drawing.Color.White;
            this.btnItemsPageBackward.Image = global::ThaiTanic.Properties.Resources.btn_back;
            this.btnItemsPageBackward.ImageSize = new System.Drawing.Size(15, 15);
            this.btnItemsPageBackward.Location = new System.Drawing.Point(14, 318);
            this.btnItemsPageBackward.Name = "btnItemsPageBackward";
            this.btnItemsPageBackward.Size = new System.Drawing.Size(26, 26);
            this.btnItemsPageBackward.TabIndex = 3;
            this.btnItemsPageBackward.Click += new System.EventHandler(this.btnItemsPageBackward_Click);
            // 
            // lblOrderNumber
            // 
            this.lblOrderNumber.AutoSize = true;
            this.lblOrderNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblOrderNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.lblOrderNumber.Location = new System.Drawing.Point(68, 9);
            this.lblOrderNumber.Name = "lblOrderNumber";
            this.lblOrderNumber.Size = new System.Drawing.Size(47, 15);
            this.lblOrderNumber.TabIndex = 2;
            this.lblOrderNumber.Text = "13123";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order: #";
            // 
            // pnlOrderedBatch
            // 
            this.pnlOrderedBatch.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderedBatch.Location = new System.Drawing.Point(8, 30);
            this.pnlOrderedBatch.Name = "pnlOrderedBatch";
            this.pnlOrderedBatch.Size = new System.Drawing.Size(290, 278);
            this.pnlOrderedBatch.TabIndex = 0;
            // 
            // btnPrevious
            // 
            this.btnPrevious.BackColor = System.Drawing.Color.Transparent;
            this.btnPrevious.BorderRadius = 5;
            this.btnPrevious.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrevious.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrevious.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrevious.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.btnPrevious.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnPrevious.ForeColor = System.Drawing.Color.White;
            this.btnPrevious.Location = new System.Drawing.Point(31, 513);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 35);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.BackColor = System.Drawing.Color.Transparent;
            this.btnNext.BorderRadius = 5;
            this.btnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(140)))), ((int)(((byte)(233)))));
            this.btnNext.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.btnNext.ForeColor = System.Drawing.Color.White;
            this.btnNext.Location = new System.Drawing.Point(667, 513);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomerDetails.BorderRadius = 10;
            this.pnlCustomerDetails.Controls.Add(this.lblAddressLabel);
            this.pnlCustomerDetails.Controls.Add(this.guna2PictureBox4);
            this.pnlCustomerDetails.Controls.Add(this.guna2PictureBox3);
            this.pnlCustomerDetails.Controls.Add(this.guna2PictureBox2);
            this.pnlCustomerDetails.Controls.Add(this.guna2PictureBox1);
            this.pnlCustomerDetails.Controls.Add(this.lblPostalCodeBrgyProvince);
            this.pnlCustomerDetails.Controls.Add(this.lblCity);
            this.pnlCustomerDetails.Controls.Add(this.lblCountry);
            this.pnlCustomerDetails.Controls.Add(this.lblPaymentMethod);
            this.pnlCustomerDetails.Controls.Add(this.lblPhoneNumber);
            this.pnlCustomerDetails.Controls.Add(this.lblEmail);
            this.pnlCustomerDetails.Controls.Add(this.lblCustomerName);
            this.pnlCustomerDetails.Controls.Add(this.guna2Shapes1);
            this.pnlCustomerDetails.Controls.Add(this.label7);
            this.pnlCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnlCustomerDetails.Location = new System.Drawing.Point(31, 558);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(736, 196);
            this.pnlCustomerDetails.TabIndex = 7;
            // 
            // guna2PictureBox4
            // 
            this.guna2PictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox4.Image")));
            this.guna2PictureBox4.ImageRotate = 0F;
            this.guna2PictureBox4.Location = new System.Drawing.Point(36, 154);
            this.guna2PictureBox4.Name = "guna2PictureBox4";
            this.guna2PictureBox4.Size = new System.Drawing.Size(21, 21);
            this.guna2PictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox4.TabIndex = 16;
            this.guna2PictureBox4.TabStop = false;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox3.Image")));
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(34, 123);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 15;
            this.guna2PictureBox3.TabStop = false;
            // 
            // guna2PictureBox2
            // 
            this.guna2PictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox2.Image")));
            this.guna2PictureBox2.ImageRotate = 0F;
            this.guna2PictureBox2.Location = new System.Drawing.Point(35, 90);
            this.guna2PictureBox2.Name = "guna2PictureBox2";
            this.guna2PictureBox2.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox2.TabIndex = 14;
            this.guna2PictureBox2.TabStop = false;
            // 
            // guna2PictureBox1
            // 
            this.guna2PictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("guna2PictureBox1.Image")));
            this.guna2PictureBox1.ImageRotate = 0F;
            this.guna2PictureBox1.Location = new System.Drawing.Point(36, 57);
            this.guna2PictureBox1.Name = "guna2PictureBox1";
            this.guna2PictureBox1.Size = new System.Drawing.Size(20, 20);
            this.guna2PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox1.TabIndex = 13;
            this.guna2PictureBox1.TabStop = false;
            // 
            // lblPostalCodeBrgyProvince
            // 
            this.lblPostalCodeBrgyProvince.BackColor = System.Drawing.Color.Transparent;
            this.lblPostalCodeBrgyProvince.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPostalCodeBrgyProvince.ForeColor = System.Drawing.Color.White;
            this.lblPostalCodeBrgyProvince.Location = new System.Drawing.Point(428, 124);
            this.lblPostalCodeBrgyProvince.Name = "lblPostalCodeBrgyProvince";
            this.lblPostalCodeBrgyProvince.Size = new System.Drawing.Size(3, 2);
            this.lblPostalCodeBrgyProvince.TabIndex = 9;
            this.lblPostalCodeBrgyProvince.Text = null;
            // 
            // lblCity
            // 
            this.lblCity.BackColor = System.Drawing.Color.Transparent;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.ForeColor = System.Drawing.Color.White;
            this.lblCity.Location = new System.Drawing.Point(428, 91);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(3, 2);
            this.lblCity.TabIndex = 8;
            this.lblCity.Text = null;
            // 
            // lblCountry
            // 
            this.lblCountry.BackColor = System.Drawing.Color.Transparent;
            this.lblCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCountry.ForeColor = System.Drawing.Color.White;
            this.lblCountry.Location = new System.Drawing.Point(428, 60);
            this.lblCountry.Name = "lblCountry";
            this.lblCountry.Size = new System.Drawing.Size(69, 18);
            this.lblCountry.TabIndex = 7;
            this.lblCountry.Text = "Philippines";
            // 
            // lblPaymentMethod
            // 
            this.lblPaymentMethod.BackColor = System.Drawing.Color.Transparent;
            this.lblPaymentMethod.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPaymentMethod.ForeColor = System.Drawing.Color.White;
            this.lblPaymentMethod.Location = new System.Drawing.Point(64, 154);
            this.lblPaymentMethod.Name = "lblPaymentMethod";
            this.lblPaymentMethod.Size = new System.Drawing.Size(70, 18);
            this.lblPaymentMethod.TabIndex = 6;
            this.lblPaymentMethod.Text = "Credit Card";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.BackColor = System.Drawing.Color.Transparent;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.White;
            this.lblPhoneNumber.Location = new System.Drawing.Point(61, 124);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(97, 18);
            this.lblPhoneNumber.TabIndex = 5;
            this.lblPhoneNumber.Text = "+63 9661564480";
            // 
            // lblEmail
            // 
            this.lblEmail.BackColor = System.Drawing.Color.Transparent;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.White;
            this.lblEmail.Location = new System.Drawing.Point(63, 91);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(148, 18);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "Charlesgay@gmail.com";
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.BackColor = System.Drawing.Color.Transparent;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.ForeColor = System.Drawing.Color.White;
            this.lblCustomerName.Location = new System.Drawing.Point(63, 60);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(111, 18);
            this.lblCustomerName.TabIndex = 3;
            this.lblCustomerName.Text = "Charles Gayetano";
            // 
            // guna2Shapes1
            // 
            this.guna2Shapes1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(76)))), ((int)(((byte)(81)))));
            this.guna2Shapes1.LineThickness = 2;
            this.guna2Shapes1.Location = new System.Drawing.Point(-57, 41);
            this.guna2Shapes1.Name = "guna2Shapes1";
            this.guna2Shapes1.PolygonSkip = 1;
            this.guna2Shapes1.Rotate = 0F;
            this.guna2Shapes1.Shape = Guna.UI2.WinForms.Enums.ShapeType.Line;
            this.guna2Shapes1.Size = new System.Drawing.Size(849, 10);
            this.guna2Shapes1.TabIndex = 2;
            this.guna2Shapes1.Text = "guna2Shapes1";
            this.guna2Shapes1.Zoom = 80;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(30, 10);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(213, 29);
            this.label7.TabIndex = 1;
            this.label7.Text = "Customer Details";
            // 
            // pnlOrderSummary
            // 
            this.pnlOrderSummary.BorderRadius = 10;
            this.pnlOrderSummary.Controls.Add(this.btnPrint);
            this.pnlOrderSummary.Controls.Add(this.guna2Panel2);
            this.pnlOrderSummary.Controls.Add(this.label2);
            this.pnlOrderSummary.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnlOrderSummary.Location = new System.Drawing.Point(796, 491);
            this.pnlOrderSummary.Name = "pnlOrderSummary";
            this.pnlOrderSummary.Size = new System.Drawing.Size(307, 265);
            this.pnlOrderSummary.TabIndex = 5;
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.btnPrint.BorderRadius = 20;
            this.btnPrint.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnPrint.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnPrint.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnPrint.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.btnPrint.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.btnPrint.ForeColor = System.Drawing.Color.Black;
            this.btnPrint.Location = new System.Drawing.Point(63, 206);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(180, 45);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "Print Receipt";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2Panel2.BorderColor = System.Drawing.Color.White;
            this.guna2Panel2.BorderRadius = 5;
            this.guna2Panel2.BorderThickness = 1;
            this.guna2Panel2.Controls.Add(this.lblTotal);
            this.guna2Panel2.Controls.Add(this.lblShippingFee);
            this.guna2Panel2.Controls.Add(this.lblVat);
            this.guna2Panel2.Controls.Add(this.lblSubtotal);
            this.guna2Panel2.Controls.Add(this.label6);
            this.guna2Panel2.Controls.Add(this.label5);
            this.guna2Panel2.Controls.Add(this.label4);
            this.guna2Panel2.Controls.Add(this.label3);
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.guna2Panel2.Location = new System.Drawing.Point(12, 56);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(282, 124);
            this.guna2Panel2.TabIndex = 1;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.BackColor = System.Drawing.Color.Transparent;
            this.lblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotal.ForeColor = System.Drawing.Color.White;
            this.lblTotal.Location = new System.Drawing.Point(178, 94);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(73, 17);
            this.lblTotal.TabIndex = 9;
            this.lblTotal.Text = "₱ 369.60";
            this.lblTotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblShippingFee
            // 
            this.lblShippingFee.AutoSize = true;
            this.lblShippingFee.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingFee.ForeColor = System.Drawing.Color.White;
            this.lblShippingFee.Location = new System.Drawing.Point(178, 67);
            this.lblShippingFee.Name = "lblShippingFee";
            this.lblShippingFee.Size = new System.Drawing.Size(64, 17);
            this.lblShippingFee.TabIndex = 8;
            this.lblShippingFee.Text = "₱ 50.00";
            this.lblShippingFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblVat
            // 
            this.lblVat.AutoSize = true;
            this.lblVat.BackColor = System.Drawing.Color.Transparent;
            this.lblVat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVat.ForeColor = System.Drawing.Color.White;
            this.lblVat.Location = new System.Drawing.Point(178, 40);
            this.lblVat.Name = "lblVat";
            this.lblVat.Size = new System.Drawing.Size(73, 17);
            this.lblVat.TabIndex = 7;
            this.lblVat.Text = "₱ 369.60";
            this.lblVat.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblSubtotal
            // 
            this.lblSubtotal.AutoSize = true;
            this.lblSubtotal.BackColor = System.Drawing.Color.Transparent;
            this.lblSubtotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubtotal.ForeColor = System.Drawing.Color.White;
            this.lblSubtotal.Location = new System.Drawing.Point(178, 13);
            this.lblSubtotal.Name = "lblSubtotal";
            this.lblSubtotal.Size = new System.Drawing.Size(73, 17);
            this.lblSubtotal.TabIndex = 6;
            this.lblSubtotal.Text = "₱ 369.60";
            this.lblSubtotal.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label6.Location = new System.Drawing.Point(12, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label5.Location = new System.Drawing.Point(12, 67);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Shipping Fee";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "VAT (12%)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Items";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(34, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(239, 29);
            this.label2.TabIndex = 0;
            this.label2.Text = "ORDER SUMMARY";
            // 
            // lblOrderPage
            // 
            this.lblOrderPage.AutoSize = true;
            this.lblOrderPage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.lblOrderPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrderPage.ForeColor = System.Drawing.Color.White;
            this.lblOrderPage.Location = new System.Drawing.Point(374, 518);
            this.lblOrderPage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOrderPage.Name = "lblOrderPage";
            this.lblOrderPage.Size = new System.Drawing.Size(45, 24);
            this.lblOrderPage.TabIndex = 18;
            this.lblOrderPage.Text = "1 / 1";
            // 
            // lblAddressLabel
            // 
            this.lblAddressLabel.BackColor = System.Drawing.Color.Transparent;
            this.lblAddressLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddressLabel.ForeColor = System.Drawing.Color.White;
            this.lblAddressLabel.Location = new System.Drawing.Point(428, 155);
            this.lblAddressLabel.Name = "lblAddressLabel";
            this.lblAddressLabel.Size = new System.Drawing.Size(3, 2);
            this.lblAddressLabel.TabIndex = 17;
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1134, 768);
            this.Controls.Add(this.lblOrderPage);
            this.Controls.Add(this.pnlOrderSummary);
            this.Controls.Add(this.pnlCustomerDetails);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.pnlOrderItems);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlButtonTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDelivery";
            this.Text = "frmDelivery";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.pnlButtonTabs.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.pnlOrderItems.ResumeLayout(false);
            this.pnlOrderItems.PerformLayout();
            this.pnlCustomerDetails.ResumeLayout(false);
            this.pnlCustomerDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox1)).EndInit();
            this.pnlOrderSummary.ResumeLayout(false);
            this.pnlOrderSummary.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel pnlButtonTabs;
        private Guna.UI2.WinForms.Guna2Button btnCanceled;
        private Guna.UI2.WinForms.Guna2Button btnCompleted;
        private Guna.UI2.WinForms.Guna2Button btnToReceive;
        private Guna.UI2.WinForms.Guna2Button btnToShip;
        private Guna.UI2.WinForms.Guna2Button btnToPay;
        private Guna.UI2.WinForms.Guna2Button btnAll;
        private Guna.UI2.WinForms.Guna2Panel pnlSearch;
        private Guna.UI2.WinForms.Guna2TextBox txtSearch;
        private System.Windows.Forms.FlowLayoutPanel pnlOrders;
        private Guna.UI2.WinForms.Guna2Panel pnlOrderItems;
        private System.Windows.Forms.FlowLayoutPanel pnlOrderedBatch;
        private Guna.UI2.WinForms.Guna2Button btnItemsPageForward;
        private Guna.UI2.WinForms.Guna2Button btnItemsPageBackward;
        private System.Windows.Forms.Label lblOrderNumber;
        private Guna.UI2.WinForms.Guna2Button btnPrevious;
        private Guna.UI2.WinForms.Guna2Button btnNext;
        private Guna.UI2.WinForms.Guna2Panel pnlCustomerDetails;
        private Guna.UI2.WinForms.Guna2Panel pnlOrderSummary;
        private System.Windows.Forms.Label label2;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnPrint;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.Label lblShippingFee;
        private System.Windows.Forms.Label lblVat;
        private System.Windows.Forms.Label lblSubtotal;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblItemPageIndicator;
        private System.Windows.Forms.Label lblOrderPage;
        private Guna.UI2.WinForms.Guna2Shapes guna2Shapes1;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPaymentMethod;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPhoneNumber;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblEmail;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCustomerName;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox4;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox2;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox1;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblPostalCodeBrgyProvince;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCity;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblCountry;
        private Guna.UI2.WinForms.Guna2HtmlLabel lblAddressLabel;
    }
}