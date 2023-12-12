namespace Comp123_S1_Group1_L9
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
            this.pnlLastOrder = new System.Windows.Forms.Panel();
            this.lblResult = new System.Windows.Forms.Label();
            this.lblLastOrderTitle = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnEditCustomer = new System.Windows.Forms.Button();
            this.btnAddCustomer = new System.Windows.Forms.Button();
            this.lsbAllCustomers = new System.Windows.Forms.ListBox();
            this.lblCustomerHeading = new System.Windows.Forms.Label();
            this.pnlLastOrder.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlLastOrder
            // 
            this.pnlLastOrder.AutoScroll = true;
            this.pnlLastOrder.Controls.Add(this.lblResult);
            this.pnlLastOrder.Location = new System.Drawing.Point(397, 116);
            this.pnlLastOrder.Margin = new System.Windows.Forms.Padding(2);
            this.pnlLastOrder.Name = "pnlLastOrder";
            this.pnlLastOrder.Size = new System.Drawing.Size(730, 509);
            this.pnlLastOrder.TabIndex = 15;
            this.pnlLastOrder.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlLastOrder_Paint);
            // 
            // lblResult
            // 
            this.lblResult.AutoSize = true;
            this.lblResult.Location = new System.Drawing.Point(2, 0);
            this.lblResult.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(127, 20);
            this.lblResult.TabIndex = 0;
            this.lblResult.Text = "No Order Found.";
            // 
            // lblLastOrderTitle
            // 
            this.lblLastOrderTitle.AutoSize = true;
            this.lblLastOrderTitle.Location = new System.Drawing.Point(393, 72);
            this.lblLastOrderTitle.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblLastOrderTitle.Name = "lblLastOrderTitle";
            this.lblLastOrderTitle.Size = new System.Drawing.Size(88, 20);
            this.lblLastOrderTitle.TabIndex = 14;
            this.lblLastOrderTitle.Text = "Last Order:";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(45, 562);
            this.btnSave.Margin = new System.Windows.Forms.Padding(2);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(142, 38);
            this.btnSave.TabIndex = 13;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Location = new System.Drawing.Point(204, 458);
            this.btnAddOrder.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(142, 38);
            this.btnAddOrder.TabIndex = 12;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            this.btnAddOrder.Click += new System.EventHandler(this.btnAddOrder_Click);
            // 
            // btnEditCustomer
            // 
            this.btnEditCustomer.Location = new System.Drawing.Point(45, 458);
            this.btnEditCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnEditCustomer.Name = "btnEditCustomer";
            this.btnEditCustomer.Size = new System.Drawing.Size(142, 38);
            this.btnEditCustomer.TabIndex = 11;
            this.btnEditCustomer.Text = "Edit Customer";
            this.btnEditCustomer.UseVisualStyleBackColor = true;
            this.btnEditCustomer.Click += new System.EventHandler(this.btnEditCustomer_Click);
            // 
            // btnAddCustomer
            // 
            this.btnAddCustomer.Location = new System.Drawing.Point(204, 63);
            this.btnAddCustomer.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddCustomer.Name = "btnAddCustomer";
            this.btnAddCustomer.Size = new System.Drawing.Size(142, 38);
            this.btnAddCustomer.TabIndex = 10;
            this.btnAddCustomer.Text = "Add Customer";
            this.btnAddCustomer.UseVisualStyleBackColor = true;
            this.btnAddCustomer.Click += new System.EventHandler(this.btnAddCustomer_Click);
            // 
            // lsbAllCustomers
            // 
            this.lsbAllCustomers.FormattingEnabled = true;
            this.lsbAllCustomers.ItemHeight = 20;
            this.lsbAllCustomers.Location = new System.Drawing.Point(45, 125);
            this.lsbAllCustomers.Margin = new System.Windows.Forms.Padding(2);
            this.lsbAllCustomers.Name = "lsbAllCustomers";
            this.lsbAllCustomers.Size = new System.Drawing.Size(302, 304);
            this.lsbAllCustomers.TabIndex = 9;
            this.lsbAllCustomers.SelectedIndexChanged += new System.EventHandler(this.lsbAddedCustomers_SelectedIndexChanged);
            // 
            // lblCustomerHeading
            // 
            this.lblCustomerHeading.AutoSize = true;
            this.lblCustomerHeading.Location = new System.Drawing.Point(41, 72);
            this.lblCustomerHeading.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblCustomerHeading.Name = "lblCustomerHeading";
            this.lblCustomerHeading.Size = new System.Drawing.Size(86, 20);
            this.lblCustomerHeading.TabIndex = 8;
            this.lblCustomerHeading.Text = "Customers";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1196, 696);
            this.Controls.Add(this.pnlLastOrder);
            this.Controls.Add(this.lblLastOrderTitle);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.btnEditCustomer);
            this.Controls.Add(this.btnAddCustomer);
            this.Controls.Add(this.lsbAllCustomers);
            this.Controls.Add(this.lblCustomerHeading);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.pnlLastOrder.ResumeLayout(false);
            this.pnlLastOrder.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlLastOrder;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Label lblLastOrderTitle;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnEditCustomer;
        private System.Windows.Forms.Button btnAddCustomer;
        private System.Windows.Forms.ListBox lsbAllCustomers;
        private System.Windows.Forms.Label lblCustomerHeading;
    }
}