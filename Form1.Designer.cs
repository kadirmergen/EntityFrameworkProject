namespace EntityFrameworkProject
{
    partial class Form1
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
            this.buttonProductTransactions = new System.Windows.Forms.Button();
            this.buttonCustomerTransactions = new System.Windows.Forms.Button();
            this.buttonOrders = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonProductTransactions
            // 
            this.buttonProductTransactions.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.buttonProductTransactions.Location = new System.Drawing.Point(102, 96);
            this.buttonProductTransactions.Name = "buttonProductTransactions";
            this.buttonProductTransactions.Size = new System.Drawing.Size(143, 72);
            this.buttonProductTransactions.TabIndex = 0;
            this.buttonProductTransactions.Text = "Product Transactions";
            this.buttonProductTransactions.UseVisualStyleBackColor = false;
            this.buttonProductTransactions.Click += new System.EventHandler(this.buttonProductTransactions_Click);
            // 
            // buttonCustomerTransactions
            // 
            this.buttonCustomerTransactions.BackColor = System.Drawing.Color.PaleGreen;
            this.buttonCustomerTransactions.Location = new System.Drawing.Point(309, 96);
            this.buttonCustomerTransactions.Name = "buttonCustomerTransactions";
            this.buttonCustomerTransactions.Size = new System.Drawing.Size(143, 72);
            this.buttonCustomerTransactions.TabIndex = 1;
            this.buttonCustomerTransactions.Text = "Customer Transactions";
            this.buttonCustomerTransactions.UseVisualStyleBackColor = false;
            this.buttonCustomerTransactions.Click += new System.EventHandler(this.buttonCustomerTransactions_Click);
            // 
            // buttonOrders
            // 
            this.buttonOrders.BackColor = System.Drawing.Color.RosyBrown;
            this.buttonOrders.Location = new System.Drawing.Point(532, 96);
            this.buttonOrders.Name = "buttonOrders";
            this.buttonOrders.Size = new System.Drawing.Size(143, 72);
            this.buttonOrders.TabIndex = 2;
            this.buttonOrders.Text = "Orders";
            this.buttonOrders.UseVisualStyleBackColor = false;
            this.buttonOrders.Click += new System.EventHandler(this.buttonOrders_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(779, 242);
            this.Controls.Add(this.buttonOrders);
            this.Controls.Add(this.buttonCustomerTransactions);
            this.Controls.Add(this.buttonProductTransactions);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonProductTransactions;
        private System.Windows.Forms.Button buttonCustomerTransactions;
        private System.Windows.Forms.Button buttonOrders;
    }
}

