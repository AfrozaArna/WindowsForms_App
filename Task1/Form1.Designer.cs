namespace task1
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
            textName = new TextBox();
            label2 = new Label();
            TextEmail = new TextBox();
            label3 = new Label();
            TextContact = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(150, 66);
            label1.Name = "label1";
            label1.Size = new Size(68, 25);
            label1.TabIndex = 0;
            label1.Text = "Name :";
            // 
            // textName
            // 
            textName.Location = new Point(249, 66);
            textName.Name = "textName";
            textName.PlaceholderText = "Enter Name";
            textName.Size = new Size(150, 31);
            textName.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(150, 135);
            label2.Name = "label2";
            label2.Size = new Size(63, 25);
            label2.TabIndex = 2;
            label2.Text = "Email :";
            // 
            // TextEmail
            // 
            TextEmail.Location = new Point(249, 135);
            TextEmail.Name = "TextEmail";
            TextEmail.PlaceholderText = "Enter Email";
            TextEmail.Size = new Size(150, 31);
            TextEmail.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(154, 221);
            label3.Name = "label3";
            label3.Size = new Size(82, 25);
            label3.TabIndex = 4;
            label3.Text = "Contact :";
            // 
            // TextContact
            // 
            TextContact.Location = new Point(249, 221);
            TextContact.Name = "TextContact";
            TextContact.PlaceholderText = "Enter Contact";
            TextContact.Size = new Size(150, 31);
            TextContact.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(194, 325);
            button1.Name = "button1";
            button1.Size = new Size(112, 34);
            button1.TabIndex = 6;
            button1.Text = "Save";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Save_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(TextContact);
            Controls.Add(label3);
            Controls.Add(TextEmail);
            Controls.Add(label2);
            Controls.Add(textName);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textName;
        private Label label2;
        private TextBox TextEmail;
        private Label label3;
        private TextBox TextContact;
        private Button button1;
    }
}