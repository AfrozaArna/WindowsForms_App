﻿namespace Task2
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
            textName = new TextBox();
            textEmail = new TextBox();
            textContact = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(229, 91);
            label1.Name = "label1";
            label1.Size = new Size(59, 25);
            label1.TabIndex = 0;
            label1.Text = "Name";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(229, 153);
            label2.Name = "label2";
            label2.Size = new Size(54, 25);
            label2.TabIndex = 1;
            label2.Text = "Email";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 225);
            label3.Name = "label3";
            label3.Size = new Size(73, 25);
            label3.TabIndex = 2;
            label3.Text = "Contact";
            // 
            // textBox1
            // 
            textName.Location = new Point(336, 91);
            textName.Name = "textBox1";
            textName.PlaceholderText = "Enter Name";
            textName.Size = new Size(150, 31);
            textName.TabIndex = 3;
            // 
            // textBox2
            // 
            textEmail.Location = new Point(336, 153);
            textEmail.Name = "textBox2";
            textEmail.PlaceholderText = "Enter Email";
            textEmail.Size = new Size(150, 31);
            textEmail.TabIndex = 4;
            // 
            // textBox3
            // 
            textContact.Location = new Point(336, 225);
            textContact.Name = "textBox3";
            textContact.PlaceholderText = "Enter Contact";
            textContact.Size = new Size(150, 31);
            textContact.TabIndex = 5;
            // 
            // button1
            // 
            button1.Location = new Point(295, 319);
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
            Controls.Add(textName);
            Controls.Add(textEmail);
            Controls.Add(textContact);
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
        private TextBox textName;
        private TextBox textEmail;
        private TextBox textContact;
        private Button button1;
    }
}