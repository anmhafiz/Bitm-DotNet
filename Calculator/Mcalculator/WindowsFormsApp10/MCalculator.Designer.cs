namespace WindowsFormsApp10
{
    partial class MCalculator
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.firstNumberTextBox = new System.Windows.Forms.TextBox();
            this.secondNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.Add = new System.Windows.Forms.Button();
            this.substractTextBox = new System.Windows.Forms.Button();
            this.multipicationTextBox = new System.Windows.Forms.Button();
            this.divisionTextBox = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(124, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "First Number";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(124, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Second Number";
            // 
            // firstNumberTextBox
            // 
            this.firstNumberTextBox.Location = new System.Drawing.Point(255, 50);
            this.firstNumberTextBox.Name = "firstNumberTextBox";
            this.firstNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.firstNumberTextBox.TabIndex = 2;
            // 
            // secondNumberTextBox
            // 
            this.secondNumberTextBox.Location = new System.Drawing.Point(255, 113);
            this.secondNumberTextBox.Name = "secondNumberTextBox";
            this.secondNumberTextBox.Size = new System.Drawing.Size(100, 20);
            this.secondNumberTextBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(134, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Result";
            // 
            // resultTextBox
            // 
            this.resultTextBox.Location = new System.Drawing.Point(255, 188);
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.Size = new System.Drawing.Size(100, 20);
            this.resultTextBox.TabIndex = 5;
            // 
            // Add
            // 
            this.Add.Location = new System.Drawing.Point(114, 266);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(75, 23);
            this.Add.TabIndex = 6;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = true;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // substractTextBox
            // 
            this.substractTextBox.Location = new System.Drawing.Point(236, 266);
            this.substractTextBox.Name = "substractTextBox";
            this.substractTextBox.Size = new System.Drawing.Size(75, 23);
            this.substractTextBox.TabIndex = 7;
            this.substractTextBox.Text = "Substract";
            this.substractTextBox.UseVisualStyleBackColor = true;
            this.substractTextBox.Click += new System.EventHandler(this.substractTextBox_Click);
            // 
            // multipicationTextBox
            // 
            this.multipicationTextBox.Location = new System.Drawing.Point(378, 266);
            this.multipicationTextBox.Name = "multipicationTextBox";
            this.multipicationTextBox.Size = new System.Drawing.Size(75, 23);
            this.multipicationTextBox.TabIndex = 8;
            this.multipicationTextBox.Text = "Multipication";
            this.multipicationTextBox.UseVisualStyleBackColor = true;
            this.multipicationTextBox.Click += new System.EventHandler(this.multipicationTextBox_Click);
            // 
            // divisionTextBox
            // 
            this.divisionTextBox.Location = new System.Drawing.Point(535, 266);
            this.divisionTextBox.Name = "divisionTextBox";
            this.divisionTextBox.Size = new System.Drawing.Size(75, 23);
            this.divisionTextBox.TabIndex = 9;
            this.divisionTextBox.Text = "Division";
            this.divisionTextBox.UseVisualStyleBackColor = true;
            this.divisionTextBox.Click += new System.EventHandler(this.divisionTextBox_Click);
            // 
            // MCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.divisionTextBox);
            this.Controls.Add(this.multipicationTextBox);
            this.Controls.Add(this.substractTextBox);
            this.Controls.Add(this.Add);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.secondNumberTextBox);
            this.Controls.Add(this.firstNumberTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "MCalculator";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox firstNumberTextBox;
        private System.Windows.Forms.TextBox secondNumberTextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.Button substractTextBox;
        private System.Windows.Forms.Button multipicationTextBox;
        private System.Windows.Forms.Button divisionTextBox;
    }
}

