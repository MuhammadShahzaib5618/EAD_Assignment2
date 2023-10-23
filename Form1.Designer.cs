namespace WindowsFormsApp1
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
            this.submitBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fName = new System.Windows.Forms.TextBox();
            this.lName = new System.Windows.Forms.TextBox();
            this.courseBox = new System.Windows.Forms.ComboBox();
            this.checkbox = new System.Windows.Forms.CheckBox();
            this.result = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // submitBTN
            // 
            this.submitBTN.Location = new System.Drawing.Point(103, 335);
            this.submitBTN.Name = "submitBTN";
            this.submitBTN.Size = new System.Drawing.Size(93, 39);
            this.submitBTN.TabIndex = 0;
            this.submitBTN.Text = "Submit";
            this.submitBTN.UseVisualStyleBackColor = true;
            this.submitBTN.Click += new System.EventHandler(this.submitBTN_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "First Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(61, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(61, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Course";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // fName
            // 
            this.fName.Location = new System.Drawing.Point(69, 62);
            this.fName.Name = "fName";
            this.fName.Size = new System.Drawing.Size(284, 31);
            this.fName.TabIndex = 5;
            // 
            // lName
            // 
            this.lName.Location = new System.Drawing.Point(66, 153);
            this.lName.Name = "lName";
            this.lName.Size = new System.Drawing.Size(348, 31);
            this.lName.TabIndex = 6;
            // 
            // courseBox
            // 
            this.courseBox.FormattingEnabled = true;
            this.courseBox.Items.AddRange(new object[] {
            "Program",
            "EAD ",
            "Engineering"});
            this.courseBox.Location = new System.Drawing.Point(66, 243);
            this.courseBox.Name = "courseBox";
            this.courseBox.Size = new System.Drawing.Size(284, 33);
            this.courseBox.TabIndex = 7;
            // 
            // checkbox
            // 
            this.checkbox.AutoSize = true;
            this.checkbox.Location = new System.Drawing.Point(69, 300);
            this.checkbox.Name = "checkbox";
            this.checkbox.Size = new System.Drawing.Size(230, 29);
            this.checkbox.TabIndex = 8;
            this.checkbox.Text = "Pre Requisite Clear";
            this.checkbox.UseVisualStyleBackColor = true;
            // 
            // result
            // 
            this.result.Location = new System.Drawing.Point(66, 416);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(646, 134);
            this.result.TabIndex = 9;
            this.result.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.result);
            this.Controls.Add(this.checkbox);
            this.Controls.Add(this.courseBox);
            this.Controls.Add(this.lName);
            this.Controls.Add(this.fName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.submitBTN);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button submitBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox fName;
        private System.Windows.Forms.TextBox lName;
        private System.Windows.Forms.ComboBox courseBox;
        private System.Windows.Forms.CheckBox checkbox;
        private System.Windows.Forms.RichTextBox result;
    }
}

