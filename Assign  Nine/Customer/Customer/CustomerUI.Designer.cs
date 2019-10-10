namespace Customer
{
    partial class CustomerUI
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
            this.components = new System.ComponentModel.Container();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.Contact = new System.Windows.Forms.Label();
            this.contactTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.lName = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.showButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.searchButton = new System.Windows.Forms.Button();
            this.Code = new System.Windows.Forms.Label();
            this.codeTextBox = new System.Windows.Forms.TextBox();
            this.District = new System.Windows.Forms.Label();
            this.districtComboBox = new System.Windows.Forms.ComboBox();
            this.cusBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.cusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerManagerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerRepositoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerManagerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // nameTextBox
            // 
            this.nameTextBox.Location = new System.Drawing.Point(250, 85);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(100, 20);
            this.nameTextBox.TabIndex = 1;
            // 
            // Contact
            // 
            this.Contact.AutoSize = true;
            this.Contact.Location = new System.Drawing.Point(82, 147);
            this.Contact.Name = "Contact";
            this.Contact.Size = new System.Drawing.Size(44, 13);
            this.Contact.TabIndex = 2;
            this.Contact.Text = "Contact";
            // 
            // contactTextBox
            // 
            this.contactTextBox.Location = new System.Drawing.Point(250, 140);
            this.contactTextBox.Name = "contactTextBox";
            this.contactTextBox.Size = new System.Drawing.Size(100, 20);
            this.contactTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(82, 206);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Address";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(250, 199);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(100, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(85, 288);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(75, 23);
            this.addButton.TabIndex = 6;
            this.addButton.Text = "Add";
            this.addButton.UseCompatibleTextRendering = true;
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // lName
            // 
            this.lName.AutoSize = true;
            this.lName.Location = new System.Drawing.Point(98, 91);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(35, 13);
            this.lName.TabIndex = 7;
            this.lName.Text = "Name";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(50, 344);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(465, 150);
            this.dataGridView.TabIndex = 8;
            // 
            // showButton
            // 
            this.showButton.Location = new System.Drawing.Point(214, 288);
            this.showButton.Name = "showButton";
            this.showButton.Size = new System.Drawing.Size(75, 23);
            this.showButton.TabIndex = 9;
            this.showButton.Text = "Show";
            this.showButton.UseCompatibleTextRendering = true;
            this.showButton.UseVisualStyleBackColor = true;
            this.showButton.Click += new System.EventHandler(this.showButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(329, 288);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(122, 23);
            this.deleteButton.TabIndex = 10;
            this.deleteButton.Text = "Delete wint Name";
            this.deleteButton.UseCompatibleTextRendering = true;
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(281, 218);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(8, 20);
            this.textBox1.TabIndex = 11;
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(250, 262);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(100, 20);
            this.searchTextBox.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(88, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Search Name";
            // 
            // searchButton
            // 
            this.searchButton.Location = new System.Drawing.Point(386, 223);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 15;
            this.searchButton.Text = "Search";
            this.searchButton.UseCompatibleTextRendering = true;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Code
            // 
            this.Code.AutoSize = true;
            this.Code.Location = new System.Drawing.Point(91, 49);
            this.Code.Name = "Code";
            this.Code.Size = new System.Drawing.Size(32, 13);
            this.Code.TabIndex = 16;
            this.Code.Text = "Code";
            // 
            // codeTextBox
            // 
            this.codeTextBox.Location = new System.Drawing.Point(250, 49);
            this.codeTextBox.Name = "codeTextBox";
            this.codeTextBox.Size = new System.Drawing.Size(100, 20);
            this.codeTextBox.TabIndex = 17;
            // 
            // District
            // 
            this.District.AutoSize = true;
            this.District.Location = new System.Drawing.Point(88, 233);
            this.District.Name = "District";
            this.District.Size = new System.Drawing.Size(39, 13);
            this.District.TabIndex = 18;
            this.District.Text = "District";
            // 
            // districtComboBox
            // 
            this.districtComboBox.DataSource = this.cusBindingSource1;
            this.districtComboBox.DisplayMember = "District";
            this.districtComboBox.FormattingEnabled = true;
            this.districtComboBox.Location = new System.Drawing.Point(250, 225);
            this.districtComboBox.Name = "districtComboBox";
            this.districtComboBox.Size = new System.Drawing.Size(121, 21);
            this.districtComboBox.TabIndex = 19;
            this.districtComboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // cusBindingSource1
            // 
            this.cusBindingSource1.DataSource = typeof(Customer.Model.Cus);
            // 
            // cusBindingSource
            // 
            this.cusBindingSource.DataSource = typeof(Customer.Model.Cus);
            // 
            // customerManagerBindingSource
            // 
            this.customerManagerBindingSource.DataSource = typeof(Customer.BLL.CustomerManager);
            // 
            // customerRepositoryBindingSource
            // 
            this.customerRepositoryBindingSource.DataSource = typeof(Customer.Repository.CustomerRepository);
            // 
            // CustomerUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 450);
            this.Controls.Add(this.districtComboBox);
            this.Controls.Add(this.District);
            this.Controls.Add(this.codeTextBox);
            this.Controls.Add(this.Code);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.showButton);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.contactTextBox);
            this.Controls.Add(this.Contact);
            this.Controls.Add(this.nameTextBox);
            this.Name = "CustomerUI";
            this.Text = "CustomerUi";
            this.Load += new System.EventHandler(this.CustomerUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerManagerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerRepositoryBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label Contact;
        private System.Windows.Forms.TextBox contactTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Label lName;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.Button showButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label Code;
        private System.Windows.Forms.TextBox codeTextBox;
        private System.Windows.Forms.Label District;
        private System.Windows.Forms.ComboBox districtComboBox;
        private System.Windows.Forms.BindingSource customerRepositoryBindingSource;
        private System.Windows.Forms.BindingSource customerManagerBindingSource;
        private System.Windows.Forms.BindingSource cusBindingSource;
        private System.Windows.Forms.BindingSource cusBindingSource1;
    }
}

