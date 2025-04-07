using System;
using System.Drawing;
using System.Windows.Forms;

namespace Restourant
{
    partial class Home
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            dataGridView1 = new DataGridView();
            ID = new TextBox();
            location = new TextBox();
            manager = new TextBox();
            type = new TextBox();
            income = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(10, 9);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(792, 301);
            dataGridView1.TabIndex = 0;
            // 
            // ID
            // 
            ID.Location = new Point(194, 333);
            ID.Margin = new Padding(3, 2, 3, 2);
            ID.Name = "ID";
            ID.Size = new Size(136, 23);
            ID.TabIndex = 1;
            ID.TextChanged += ID_TextChanged;
            // 
            // location
            // 
            location.Location = new Point(194, 358);
            location.Margin = new Padding(3, 2, 3, 2);
            location.Name = "location";
            location.Size = new Size(136, 23);
            location.TabIndex = 2;
            // 
            // manager
            // 
            manager.Location = new Point(194, 382);
            manager.Margin = new Padding(3, 2, 3, 2);
            manager.Name = "manager";
            manager.Size = new Size(136, 23);
            manager.TabIndex = 3;
            // 
            // type
            // 
            type.Location = new Point(194, 407);
            type.Margin = new Padding(3, 2, 3, 2);
            type.Name = "type";
            type.Size = new Size(136, 23);
            type.TabIndex = 4;
            // 
            // income
            // 
            income.Location = new Point(194, 432);
            income.Margin = new Padding(3, 2, 3, 2);
            income.Name = "income";
            income.Size = new Size(136, 23);
            income.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(136, 338);
            label1.Name = "label1";
            label1.Size = new Size(26, 15);
            label1.TabIndex = 8;
            label1.Text = "ID :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(97, 363);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 7;
            label2.Text = "Location :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(97, 388);
            label3.Name = "label3";
            label3.Size = new Size(60, 15);
            label3.TabIndex = 6;
            label3.Text = "Manager :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 410);
            label4.Name = "label4";
            label4.Size = new Size(37, 15);
            label4.TabIndex = 5;
            label4.Text = "Type :";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(70, 437);
            label5.Name = "label5";
            label5.Size = new Size(82, 15);
            label5.TabIndex = 4;
            label5.Text = "Daily Income :";
            // 
            // button1
            // 
            button1.Location = new Point(355, 382);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(94, 20);
            button1.TabIndex = 3;
            button1.Text = "Insert";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(466, 382);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Size = new Size(94, 20);
            button2.TabIndex = 2;
            button2.Text = "Update";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(577, 382);
            button3.Margin = new Padding(3, 2, 3, 2);
            button3.Name = "button3";
            button3.Size = new Size(94, 20);
            button3.TabIndex = 1;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(687, 382);
            button4.Margin = new Padding(3, 2, 3, 2);
            button4.Name = "button4";
            button4.Size = new Size(94, 20);
            button4.TabIndex = 0;
            button4.Text = "View";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(813, 484);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(income);
            Controls.Add(type);
            Controls.Add(manager);
            Controls.Add(location);
            Controls.Add(ID);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Home";
            Text = "Home";
            Load += Home_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox ID;
        private System.Windows.Forms.TextBox location;
        private System.Windows.Forms.TextBox manager;
        private System.Windows.Forms.TextBox type;
        private System.Windows.Forms.TextBox income;
        private System.Windows.Forms.Label label1, label2, label3, label4, label5;
        private System.Windows.Forms.Button button1, button2, button3, button4;
    }
}
