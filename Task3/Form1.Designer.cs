namespace Task3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textName = new TextBox();
            textEmail = new TextBox();
            textContact = new TextBox();
            textSearch = new TextBox();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(64, 147);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(64, 221);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 1;
            label2.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(64, 289);
            label3.Name = "label3";
            label3.Size = new Size(0, 25);
            label3.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(45, 295);
            label4.Name = "label4";
            label4.Size = new Size(82, 25);
            label4.TabIndex = 3;
            label4.Text = "Contact :";
            // 
            // textName
            // 
            textName.Location = new Point(147, 147);
            textName.Name = "textName";
            textName.PlaceholderText = "Enter Name";
            textName.Size = new Size(177, 31);
            textName.TabIndex = 4;
            // 
            // textEmail
            // 
            textEmail.Location = new Point(147, 221);
            textEmail.Name = "textEmail";
            textEmail.PlaceholderText = "Enter Email";
            textEmail.Size = new Size(177, 31);
            textEmail.TabIndex = 5;
            // 
            // textContact
            // 
            textContact.Location = new Point(147, 289);
            textContact.Name = "textContact";
            textContact.PlaceholderText = "Enter Contact";
            textContact.Size = new Size(177, 31);
            textContact.TabIndex = 6;
            // 
            // textBox4
            // 
            textSearch.Location = new Point(505, 68);
            textSearch.Name = "textBox4";
            textSearch.PlaceholderText = "Search Email";
            textSearch.Size = new Size(233, 31);
            textSearch.TabIndex = 7;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(573, 40);
            label5.Name = "label5";
            label5.Size = new Size(113, 25);
            label5.TabIndex = 8;
            label5.Text = "Search_Email";
            // 
            // button1
            // 
            button1.Location = new Point(167, 344);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 9;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save;
            // 
            // button2
            // 
            button2.Location = new Point(574, 124);
            button2.Name = "button2";
            button2.Size = new Size(112, 34);
            button2.TabIndex = 10;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += Search;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(textSearch);
            Controls.Add(textContact);
            Controls.Add(textEmail);
            Controls.Add(textName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textName;
        private TextBox textEmail;
        private TextBox textContact;
        private TextBox textSearch;
        private Label label5;
        private Button button1;
        private Button button2;
    }
}