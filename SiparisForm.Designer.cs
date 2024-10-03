namespace EntityFrameworkProject
{
    partial class SiparisForm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxOrderId = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBoxQuantity = new System.Windows.Forms.TextBox();
            this.comboBoxCustomerId = new System.Windows.Forms.ComboBox();
            this.comboBoxProductId = new System.Windows.Forms.ComboBox();
            this.buttonListForAll = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonUpdate = new System.Windows.Forms.Button();
            this.buttonClearAllTextBox = new System.Windows.Forms.Button();
            this.buttonCustomerSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.labelNumberOfOrders = new System.Windows.Forms.Label();
            this.buttonProductSearch = new System.Windows.Forms.Button();
            this.buttonDateSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 23);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 277);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 326);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Order Id:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(82, 355);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 381);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Customer Id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(81, 408);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Product Id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(82, 432);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Quantity:";
            // 
            // textBoxOrderId
            // 
            this.textBoxOrderId.Enabled = false;
            this.textBoxOrderId.Location = new System.Drawing.Point(171, 323);
            this.textBoxOrderId.Name = "textBoxOrderId";
            this.textBoxOrderId.Size = new System.Drawing.Size(100, 20);
            this.textBoxOrderId.TabIndex = 6;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(171, 352);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 7;
            // 
            // textBoxQuantity
            // 
            this.textBoxQuantity.Location = new System.Drawing.Point(171, 432);
            this.textBoxQuantity.Name = "textBoxQuantity";
            this.textBoxQuantity.Size = new System.Drawing.Size(100, 20);
            this.textBoxQuantity.TabIndex = 8;
            // 
            // comboBoxCustomerId
            // 
            this.comboBoxCustomerId.FormattingEnabled = true;
            this.comboBoxCustomerId.Location = new System.Drawing.Point(171, 378);
            this.comboBoxCustomerId.Name = "comboBoxCustomerId";
            this.comboBoxCustomerId.Size = new System.Drawing.Size(298, 21);
            this.comboBoxCustomerId.TabIndex = 9;
            // 
            // comboBoxProductId
            // 
            this.comboBoxProductId.FormattingEnabled = true;
            this.comboBoxProductId.Location = new System.Drawing.Point(171, 405);
            this.comboBoxProductId.Name = "comboBoxProductId";
            this.comboBoxProductId.Size = new System.Drawing.Size(298, 21);
            this.comboBoxProductId.TabIndex = 10;
            // 
            // buttonListForAll
            // 
            this.buttonListForAll.Location = new System.Drawing.Point(564, 326);
            this.buttonListForAll.Name = "buttonListForAll";
            this.buttonListForAll.Size = new System.Drawing.Size(125, 23);
            this.buttonListForAll.TabIndex = 11;
            this.buttonListForAll.Text = "Show All Records";
            this.buttonListForAll.UseVisualStyleBackColor = true;
            this.buttonListForAll.Click += new System.EventHandler(this.buttonListForAll_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(564, 355);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(125, 23);
            this.buttonAdd.TabIndex = 12;
            this.buttonAdd.Text = "Add New Order";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(564, 384);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(125, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete an Order";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonUpdate
            // 
            this.buttonUpdate.Location = new System.Drawing.Point(564, 413);
            this.buttonUpdate.Name = "buttonUpdate";
            this.buttonUpdate.Size = new System.Drawing.Size(125, 23);
            this.buttonUpdate.TabIndex = 14;
            this.buttonUpdate.Text = "Update an Order";
            this.buttonUpdate.UseVisualStyleBackColor = true;
            this.buttonUpdate.Click += new System.EventHandler(this.buttonUpdate_Click);
            // 
            // buttonClearAllTextBox
            // 
            this.buttonClearAllTextBox.Location = new System.Drawing.Point(696, 323);
            this.buttonClearAllTextBox.Name = "buttonClearAllTextBox";
            this.buttonClearAllTextBox.Size = new System.Drawing.Size(75, 23);
            this.buttonClearAllTextBox.TabIndex = 15;
            this.buttonClearAllTextBox.Text = "Clear";
            this.buttonClearAllTextBox.UseVisualStyleBackColor = true;
            this.buttonClearAllTextBox.Click += new System.EventHandler(this.buttonClearAllTextBox_Click);
            // 
            // buttonCustomerSearch
            // 
            this.buttonCustomerSearch.Location = new System.Drawing.Point(475, 376);
            this.buttonCustomerSearch.Name = "buttonCustomerSearch";
            this.buttonCustomerSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonCustomerSearch.TabIndex = 16;
            this.buttonCustomerSearch.Text = "Search";
            this.buttonCustomerSearch.UseVisualStyleBackColor = true;
            this.buttonCustomerSearch.Click += new System.EventHandler(this.buttonCustomerSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "Number of Orders";
            // 
            // labelNumberOfOrders
            // 
            this.labelNumberOfOrders.AutoSize = true;
            this.labelNumberOfOrders.Location = new System.Drawing.Point(108, 303);
            this.labelNumberOfOrders.Name = "labelNumberOfOrders";
            this.labelNumberOfOrders.Size = new System.Drawing.Size(35, 13);
            this.labelNumberOfOrders.TabIndex = 18;
            this.labelNumberOfOrders.Text = "label7";
            // 
            // buttonProductSearch
            // 
            this.buttonProductSearch.Location = new System.Drawing.Point(475, 403);
            this.buttonProductSearch.Name = "buttonProductSearch";
            this.buttonProductSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonProductSearch.TabIndex = 19;
            this.buttonProductSearch.Text = "Search";
            this.buttonProductSearch.UseVisualStyleBackColor = true;
            this.buttonProductSearch.Click += new System.EventHandler(this.buttonProductSearch_Click);
            // 
            // buttonDateSearch
            // 
            this.buttonDateSearch.Location = new System.Drawing.Point(475, 350);
            this.buttonDateSearch.Name = "buttonDateSearch";
            this.buttonDateSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonDateSearch.TabIndex = 20;
            this.buttonDateSearch.Text = "Search";
            this.buttonDateSearch.UseVisualStyleBackColor = true;
            this.buttonDateSearch.Click += new System.EventHandler(this.buttonDateSearch_Click);
            // 
            // SiparisForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.RosyBrown;
            this.ClientSize = new System.Drawing.Size(800, 460);
            this.Controls.Add(this.buttonDateSearch);
            this.Controls.Add(this.buttonProductSearch);
            this.Controls.Add(this.labelNumberOfOrders);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.buttonCustomerSearch);
            this.Controls.Add(this.buttonClearAllTextBox);
            this.Controls.Add(this.buttonUpdate);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonListForAll);
            this.Controls.Add(this.comboBoxProductId);
            this.Controls.Add(this.comboBoxCustomerId);
            this.Controls.Add(this.textBoxQuantity);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.textBoxOrderId);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "SiparisForm";
            this.Text = "SiparisForm";
            this.Load += new System.EventHandler(this.SiparisForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxOrderId;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBoxQuantity;
        private System.Windows.Forms.ComboBox comboBoxCustomerId;
        private System.Windows.Forms.ComboBox comboBoxProductId;
        private System.Windows.Forms.Button buttonListForAll;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonUpdate;
        private System.Windows.Forms.Button buttonClearAllTextBox;
        private System.Windows.Forms.Button buttonCustomerSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label labelNumberOfOrders;
        private System.Windows.Forms.Button buttonProductSearch;
        private System.Windows.Forms.Button buttonDateSearch;
    }
}