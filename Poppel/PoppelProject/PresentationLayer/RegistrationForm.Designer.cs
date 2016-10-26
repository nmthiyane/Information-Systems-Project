namespace PoppelProject
{
    partial class RegistrationForm
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
            this.backButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.newCustomerContainer = new System.Windows.Forms.GroupBox();
            this.dileveryAddressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.idNumberLabel = new System.Windows.Forms.Label();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.phoneLabel = new System.Windows.Forms.Label();
            this.IDNumberTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.registerLabel = new System.Windows.Forms.Label();
            this.newCustomerContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // backButton
            // 
            this.backButton.Location = new System.Drawing.Point(25, 369);
            this.backButton.Name = "backButton";
            this.backButton.Size = new System.Drawing.Size(75, 23);
            this.backButton.TabIndex = 12;
            this.backButton.Text = "Back";
            this.backButton.UseVisualStyleBackColor = true;
            this.backButton.Click += new System.EventHandler(this.backButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(236, 369);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(75, 23);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(132, 369);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // newCustomerContainer
            // 
            this.newCustomerContainer.Controls.Add(this.dileveryAddressTextBox);
            this.newCustomerContainer.Controls.Add(this.addressLabel);
            this.newCustomerContainer.Controls.Add(this.idNumberLabel);
            this.newCustomerContainer.Controls.Add(this.surnameLabel);
            this.newCustomerContainer.Controls.Add(this.nameLabel);
            this.newCustomerContainer.Controls.Add(this.phoneLabel);
            this.newCustomerContainer.Controls.Add(this.IDNumberTextBox);
            this.newCustomerContainer.Controls.Add(this.nameTextBox);
            this.newCustomerContainer.Controls.Add(this.phoneTextBox);
            this.newCustomerContainer.Controls.Add(this.surnameTextBox);
            this.newCustomerContainer.Location = new System.Drawing.Point(25, 49);
            this.newCustomerContainer.Name = "newCustomerContainer";
            this.newCustomerContainer.Size = new System.Drawing.Size(286, 291);
            this.newCustomerContainer.TabIndex = 13;
            this.newCustomerContainer.TabStop = false;
            // 
            // dileveryAddressTextBox
            // 
            this.dileveryAddressTextBox.Location = new System.Drawing.Point(48, 241);
            this.dileveryAddressTextBox.Name = "dileveryAddressTextBox";
            this.dileveryAddressTextBox.Size = new System.Drawing.Size(199, 20);
            this.dileveryAddressTextBox.TabIndex = 14;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(45, 225);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(92, 13);
            this.addressLabel.TabIndex = 13;
            this.addressLabel.Text = "Delivery Address :";
            // 
            // idNumberLabel
            // 
            this.idNumberLabel.AutoSize = true;
            this.idNumberLabel.Location = new System.Drawing.Point(45, 177);
            this.idNumberLabel.Name = "idNumberLabel";
            this.idNumberLabel.Size = new System.Drawing.Size(64, 13);
            this.idNumberLabel.TabIndex = 12;
            this.idNumberLabel.Text = "ID Number :";
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(45, 79);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(55, 13);
            this.surnameLabel.TabIndex = 12;
            this.surnameLabel.Text = "Surname :";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(45, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(41, 13);
            this.nameLabel.TabIndex = 10;
            this.nameLabel.Text = "Name :";
            // 
            // phoneLabel
            // 
            this.phoneLabel.AutoSize = true;
            this.phoneLabel.Location = new System.Drawing.Point(45, 129);
            this.phoneLabel.Name = "phoneLabel";
            this.phoneLabel.Size = new System.Drawing.Size(41, 13);
            this.phoneLabel.TabIndex = 9;
            this.phoneLabel.Text = "Phone:";
            // 
            // IDNumberTextBox
            // 
            this.IDNumberTextBox.Location = new System.Drawing.Point(48, 193);
            this.IDNumberTextBox.Name = "IDNumberTextBox";
            this.IDNumberTextBox.Size = new System.Drawing.Size(199, 20);
            this.IDNumberTextBox.TabIndex = 6;
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(48, 44);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(199, 20);
            this.nameTextBox.TabIndex = 5;
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.Location = new System.Drawing.Point(48, 145);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(199, 20);
            this.phoneTextBox.TabIndex = 4;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.Location = new System.Drawing.Point(48, 95);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(199, 20);
            this.surnameTextBox.TabIndex = 3;
            // 
            // registerLabel
            // 
            this.registerLabel.AutoSize = true;
            this.registerLabel.Location = new System.Drawing.Point(22, 22);
            this.registerLabel.Name = "registerLabel";
            this.registerLabel.Size = new System.Drawing.Size(115, 13);
            this.registerLabel.TabIndex = 14;
            this.registerLabel.Text = "Register new customer";
            // 
            // RegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 429);
            this.Controls.Add(this.registerLabel);
            this.Controls.Add(this.newCustomerContainer);
            this.Controls.Add(this.backButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.submitButton);
            this.Name = "RegistrationForm";
            this.Text = "Customer Registration";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RegistrationForm_FormClosed);
            this.newCustomerContainer.ResumeLayout(false);
            this.newCustomerContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.GroupBox newCustomerContainer;
        private System.Windows.Forms.TextBox dileveryAddressTextBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label idNumberLabel;
        private System.Windows.Forms.Label surnameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label phoneLabel;
        private System.Windows.Forms.TextBox IDNumberTextBox;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.Label registerLabel;
    }
}

