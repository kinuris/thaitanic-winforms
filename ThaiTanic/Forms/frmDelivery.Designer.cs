
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
            this.pnlOrders = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOrderedItems = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearch = new Guna.UI2.WinForms.Guna2TextBox();
            this.ucOrderItemCard1 = new ThaiTanic.UserControls.ucOrderItemCard();
            this.ucOrderItemCard2 = new ThaiTanic.UserControls.ucOrderItemCard();
            this.ucOrderItemCard3 = new ThaiTanic.UserControls.ucOrderItemCard();
            this.ucOrderItemCard4 = new ThaiTanic.UserControls.ucOrderItemCard();
            this.lblOrderNumber = new System.Windows.Forms.Label();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Button2 = new Guna.UI2.WinForms.Guna2Button();
            this.btnPrevious = new Guna.UI2.WinForms.Guna2Button();
            this.btnNext = new Guna.UI2.WinForms.Guna2Button();
            this.pnlCustomerDetails = new Guna.UI2.WinForms.Guna2Panel();
            this.pnlOrderSummary = new Guna.UI2.WinForms.Guna2Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSubtotal = new System.Windows.Forms.Label();
            this.lblVat = new System.Windows.Forms.Label();
            this.lblShippingFee = new System.Windows.Forms.Label();
            this.lblTotal = new System.Windows.Forms.Label();
            this.btnPrint = new Guna.UI2.WinForms.Guna2Button();
            this.pnlButtonTabs.SuspendLayout();
            this.pnlSearch.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.pnlOrderedItems.SuspendLayout();
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
            // pnlOrders
            // 
            this.pnlOrders.Location = new System.Drawing.Point(0, 104);
            this.pnlOrders.Name = "pnlOrders";
            this.pnlOrders.Padding = new System.Windows.Forms.Padding(26, 10, 0, 0);
            this.pnlOrders.Size = new System.Drawing.Size(794, 398);
            this.pnlOrders.TabIndex = 2;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderRadius = 10;
            this.guna2Panel1.Controls.Add(this.guna2Button2);
            this.guna2Panel1.Controls.Add(this.guna2Button1);
            this.guna2Panel1.Controls.Add(this.lblOrderNumber);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.pnlOrderedItems);
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.guna2Panel1.Location = new System.Drawing.Point(796, 118);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(307, 357);
            this.guna2Panel1.TabIndex = 3;
            // 
            // pnlOrderedItems
            // 
            this.pnlOrderedItems.BackColor = System.Drawing.Color.Transparent;
            this.pnlOrderedItems.Controls.Add(this.ucOrderItemCard1);
            this.pnlOrderedItems.Controls.Add(this.ucOrderItemCard2);
            this.pnlOrderedItems.Controls.Add(this.ucOrderItemCard3);
            this.pnlOrderedItems.Controls.Add(this.ucOrderItemCard4);
            this.pnlOrderedItems.Location = new System.Drawing.Point(8, 30);
            this.pnlOrderedItems.Name = "pnlOrderedItems";
            this.pnlOrderedItems.Size = new System.Drawing.Size(290, 278);
            this.pnlOrderedItems.TabIndex = 0;
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
            this.txtSearch.Location = new System.Drawing.Point(31, 12);
            this.txtSearch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(144)))), ((int)(((byte)(139)))), ((int)(((byte)(139)))));
            this.txtSearch.PlaceholderText = "Look for your Orders here by searching the Order ID or Product name";
            this.txtSearch.SelectedText = "";
            this.txtSearch.Size = new System.Drawing.Size(1072, 42);
            this.txtSearch.TabIndex = 0;
            // 
            // ucOrderItemCard1
            // 
            this.ucOrderItemCard1.BackColor = System.Drawing.Color.Transparent;
            this.ucOrderItemCard1.Location = new System.Drawing.Point(3, 3);
            this.ucOrderItemCard1.Name = "ucOrderItemCard1";
            this.ucOrderItemCard1.Size = new System.Drawing.Size(284, 63);
            this.ucOrderItemCard1.TabIndex = 0;
            // 
            // ucOrderItemCard2
            // 
            this.ucOrderItemCard2.BackColor = System.Drawing.Color.Transparent;
            this.ucOrderItemCard2.Location = new System.Drawing.Point(3, 72);
            this.ucOrderItemCard2.Name = "ucOrderItemCard2";
            this.ucOrderItemCard2.Size = new System.Drawing.Size(284, 63);
            this.ucOrderItemCard2.TabIndex = 1;
            // 
            // ucOrderItemCard3
            // 
            this.ucOrderItemCard3.BackColor = System.Drawing.Color.Transparent;
            this.ucOrderItemCard3.Location = new System.Drawing.Point(3, 141);
            this.ucOrderItemCard3.Name = "ucOrderItemCard3";
            this.ucOrderItemCard3.Size = new System.Drawing.Size(284, 63);
            this.ucOrderItemCard3.TabIndex = 2;
            // 
            // ucOrderItemCard4
            // 
            this.ucOrderItemCard4.BackColor = System.Drawing.Color.Transparent;
            this.ucOrderItemCard4.Location = new System.Drawing.Point(3, 210);
            this.ucOrderItemCard4.Name = "ucOrderItemCard4";
            this.ucOrderItemCard4.Size = new System.Drawing.Size(284, 63);
            this.ucOrderItemCard4.TabIndex = 3;
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
            // guna2Button1
            // 
            this.guna2Button1.BorderRadius = 5;
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(11, 318);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(26, 26);
            this.guna2Button1.TabIndex = 3;
            // 
            // guna2Button2
            // 
            this.guna2Button2.BorderRadius = 5;
            this.guna2Button2.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button2.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button2.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button2.ForeColor = System.Drawing.Color.White;
            this.guna2Button2.Location = new System.Drawing.Point(89, 318);
            this.guna2Button2.Name = "guna2Button2";
            this.guna2Button2.Size = new System.Drawing.Size(26, 26);
            this.guna2Button2.TabIndex = 4;
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
            this.btnPrevious.Location = new System.Drawing.Point(31, 506);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(100, 35);
            this.btnPrevious.TabIndex = 5;
            this.btnPrevious.Text = "Previous";
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
            this.btnNext.Location = new System.Drawing.Point(670, 506);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(100, 35);
            this.btnNext.TabIndex = 6;
            this.btnNext.Text = "Next";
            // 
            // pnlCustomerDetails
            // 
            this.pnlCustomerDetails.BackColor = System.Drawing.Color.Transparent;
            this.pnlCustomerDetails.BorderRadius = 10;
            this.pnlCustomerDetails.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(42)))), ((int)(((byte)(59)))));
            this.pnlCustomerDetails.Location = new System.Drawing.Point(31, 547);
            this.pnlCustomerDetails.Name = "pnlCustomerDetails";
            this.pnlCustomerDetails.Size = new System.Drawing.Size(736, 209);
            this.pnlCustomerDetails.TabIndex = 7;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label3.Location = new System.Drawing.Point(12, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "ITEMS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(98)))), ((int)(((byte)(98)))), ((int)(((byte)(103)))));
            this.label4.Location = new System.Drawing.Point(12, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "VAT";
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
            // lblShippingFee
            // 
            this.lblShippingFee.AutoSize = true;
            this.lblShippingFee.BackColor = System.Drawing.Color.Transparent;
            this.lblShippingFee.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblShippingFee.ForeColor = System.Drawing.Color.White;
            this.lblShippingFee.Location = new System.Drawing.Point(178, 67);
            this.lblShippingFee.Name = "lblShippingFee";
            this.lblShippingFee.Size = new System.Drawing.Size(73, 17);
            this.lblShippingFee.TabIndex = 8;
            this.lblShippingFee.Text = "₱ 369.60";
            this.lblShippingFee.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            // btnPrint
            // 
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
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(31)))), ((int)(((byte)(44)))));
            this.ClientSize = new System.Drawing.Size(1134, 768);
            this.Controls.Add(this.pnlOrderSummary);
            this.Controls.Add(this.pnlCustomerDetails);
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.btnPrevious);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.pnlOrders);
            this.Controls.Add(this.pnlSearch);
            this.Controls.Add(this.pnlButtonTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmDelivery";
            this.Text = "frmDelivery";
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.pnlButtonTabs.ResumeLayout(false);
            this.pnlSearch.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.pnlOrderedItems.ResumeLayout(false);
            this.pnlOrderSummary.ResumeLayout(false);
            this.pnlOrderSummary.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.ResumeLayout(false);

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
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.FlowLayoutPanel pnlOrderedItems;
        private UserControls.ucOrderItemCard ucOrderItemCard1;
        private UserControls.ucOrderItemCard ucOrderItemCard2;
        private UserControls.ucOrderItemCard ucOrderItemCard3;
        private UserControls.ucOrderItemCard ucOrderItemCard4;
        private Guna.UI2.WinForms.Guna2Button guna2Button2;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
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
    }
}