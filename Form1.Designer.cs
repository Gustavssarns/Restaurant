namespace Restourant
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
            button1 = new Button();
            button2 = new Button();
            username = new TextBox();
            password = new TextBox();
            confirmpassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(487, 344);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 0;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(355, 344);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 1;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // username
            // 
            username.Location = new Point(200, 151);
            username.Name = "username";
            username.Size = new Size(249, 27);
            username.TabIndex = 2;
            // 
            // password
            // 
            password.Location = new Point(200, 204);
            password.Name = "password";
            password.Size = new Size(249, 27);
            password.TabIndex = 3;
            password.TextChanged += textBox2_TextChanged;
            // 
            // confirmpassword
            // 
            confirmpassword.Location = new Point(200, 247);
            confirmpassword.Name = "confirmpassword";
            confirmpassword.Size = new Size(249, 27);
            confirmpassword.TabIndex = 4;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(128, 158);
            label1.Name = "label1";
            label1.Size = new Size(52, 20);
            label1.TabIndex = 5;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(107, 204);
            label2.Name = "label2";
            label2.Size = new Size(73, 20);
            label2.TabIndex = 6;
            label2.Text = "Password:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(50, 250);
            label3.Name = "label3";
            label3.Size = new Size(130, 20);
            label3.TabIndex = 7;
            label3.Text = "confirm password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(169, 38);
            label4.Name = "label4";
            label4.Size = new Size(344, 46);
            label4.TabIndex = 8;
            label4.Text = "Restaurant Manager";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold | FontStyle.Italic | FontStyle.Underline, GraphicsUnit.Point, 0);
            label5.Location = new Point(252, 84);
            label5.Name = "label5";
            label5.Size = new Size(147, 31);
            label5.TabIndex = 9;
            label5.Text = "Registration";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 467);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(confirmpassword);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private TextBox username;
        private TextBox password;
        private TextBox confirmpassword;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
