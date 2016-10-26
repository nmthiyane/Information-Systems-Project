namespace PoppelProject.PresentationLayer
{
    partial class PickingListForm
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
            this.orderItemsListView = new System.Windows.Forms.ListView();
            this.doneButton = new System.Windows.Forms.Button();
            this.backButton = new System.Windows.Forms.Button();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.okButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.CustomerAddressTextBox = new System.Windows.Forms.Label();
            this.CustomerNameTextBox = new System.Windows.Forms.Label();
            this.CustomerIDTextBox = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.orderDateTextBox = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // orderItemsListView
            // 
            this.orderItemsListView.Location = new System.Drawing.Point(6, 13);
            this.orderItemsListView.Name = "orderItemsListView";
            this.orderItemsListView.Size = new System.Drawing.Size(410, 194);
            this.orderItemsListView.TabIndex = 0;
            this.orderItemsListView.UseCompatibleStateImageBehavior = false;
            // 
            // doneButton
            // 
            this.doneButton.Location = new System.Drawing.Point(342, 403);
            this.doneButton.Name = "doneButton";
            this.doneButton.Size = new System.Drawing.Size(86, 33);
            this.doneButton.TabIndex = 1;
            this.doneButton.Text = "Done";
            this.doneButton.UseVisualStyleBackColor = true;
            this.doneButton.Click += new System.EventHandler(this.doneButton_Click);
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(227, 403);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(86, 33);
            this.backButton.TabIndex = 2;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(211, 26);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(144, 21);
            this.ordersComboBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Please Select Order";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.orderItemsListView);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Location = new System.Drawing.Point(12, 160);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(425, 213);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Listing of order items";
            // 
            // okButton
            // 
            this.okButton.Location = new System.Drawing.Point(390, 26);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(38, 23);
            this.okButton.TabIndex = 6;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = true;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(22, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Order Date:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(22, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Customer Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(22, 81);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Customer ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(22, 129);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Delivery Address:";
            // 
            // CustomerAddressTextBox
            // 
            this.CustomerAddressTextBox.AutoSize = true;
            this.CustomerAddressTextBox.Location = new System.Drawing.Point(208, 129);
            this.CustomerAddressTextBox.Name = "CustomerAddressTextBox";
            this.CustomerAddressTextBox.Size = new System.Drawing.Size(35, 13);
            this.CustomerAddressTextBox.TabIndex = 11;
            this.CustomerAddressTextBox.Text = "label6";
            // 
            // CustomerNameTextBox
            // 
            this.CustomerNameTextBox.AutoSize = true;
            this.CustomerNameTextBox.Location = new System.Drawing.Point(211, 103);
            this.CustomerNameTextBox.Name = "CustomerNameTextBox";
            this.CustomerNameTextBox.Size = new System.Drawing.Size(35, 13);
            this.CustomerNameTextBox.TabIndex = 12;
            this.CustomerNameTextBox.Text = "label7";
            // 
            // CustomerIDTextBox
            // 
            this.CustomerIDTextBox.AutoSize = true;
            this.CustomerIDTextBox.Location = new System.Drawing.Point(211, 81);
            this.CustomerIDTextBox.Name = "CustomerIDTextBox";
            this.CustomerIDTextBox.Size = new System.Drawing.Size(35, 13);
            this.CustomerIDTextBox.TabIndex = 13;
            this.CustomerIDTextBox.Text = "label8";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(205, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "label9";
            // 
            // orderDateTextBox
            // 
            this.orderDateTextBox.AutoSize = true;
            this.orderDateTextBox.Location = new System.Drawing.Point(211, 59);
            this.orderDateTextBox.Name = "orderDateTextBox";
            this.orderDateTextBox.Size = new System.Drawing.Size(41, 13);
            this.orderDateTextBox.TabIndex = 15;
            this.orderDateTextBox.Text = "label10";
            // 
            // PickingListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(469, 467);
            this.Controls.Add(this.orderDateTextBox);
            this.Controls.Add(this.CustomerIDTextBox);
            this.Controls.Add(this.CustomerNameTextBox);
            this.Controls.Add(this.CustomerAddressTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ordersComboBox);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.doneButton);
            this.Name = "PickingListForm";
            this.Text = "Picking List";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.PickingListForm_FormClosed);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView orderItemsListView;
        private System.Windows.Forms.Button doneButton;
        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label CustomerAddressTextBox;
        private System.Windows.Forms.Label CustomerNameTextBox;
        private System.Windows.Forms.Label CustomerIDTextBox;
        private System.Windows.Forms.Label orderDateTextBox;
    }
}