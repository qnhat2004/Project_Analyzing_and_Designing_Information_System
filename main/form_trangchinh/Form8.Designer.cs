﻿namespace test
{
	partial class Form_dangky
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.panel1.Controls.Add(this.label5);
			this.panel1.Controls.Add(this.textBox2);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.button1);
			this.panel1.Controls.Add(this.textBox1);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Location = new System.Drawing.Point(76, 81);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(599, 359);
			this.panel1.TabIndex = 4;
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.BackColor = System.Drawing.Color.Transparent;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.label5.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label5.Location = new System.Drawing.Point(-6, 224);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(38, 25);
			this.label5.TabIndex = 14;
			this.label5.Text = "➡️";
			// 
			// textBox2
			// 
			this.textBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.textBox2.Location = new System.Drawing.Point(38, 218);
			this.textBox2.Name = "textBox2";
			this.textBox2.PasswordChar = '*';
			this.textBox2.Size = new System.Drawing.Size(523, 31);
			this.textBox2.TabIndex = 13;
			this.textBox2.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.BackColor = System.Drawing.Color.Transparent;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.label4.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label4.Location = new System.Drawing.Point(-6, 124);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(38, 25);
			this.label4.TabIndex = 12;
			this.label4.Text = "➡️";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.ForestGreen;
			this.button1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.button1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.button1.Location = new System.Drawing.Point(85, 286);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(415, 47);
			this.button1.TabIndex = 11;
			this.button1.Text = "Đăng ký";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// textBox1
			// 
			this.textBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.textBox1.Location = new System.Drawing.Point(38, 124);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(523, 31);
			this.textBox1.TabIndex = 9;
			this.textBox1.Leave += new System.EventHandler(this.textBox1_Leave);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.BackColor = System.Drawing.Color.Transparent;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.label3.ForeColor = System.Drawing.Color.Turquoise;
			this.label3.Location = new System.Drawing.Point(2, 178);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(145, 25);
			this.label3.TabIndex = 8;
			this.label3.Text = "Nhập mật khẩu*";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.BackColor = System.Drawing.Color.Transparent;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.label2.ForeColor = System.Drawing.Color.Turquoise;
			this.label2.Location = new System.Drawing.Point(2, 81);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(145, 25);
			this.label2.TabIndex = 7;
			this.label2.Text = "Nhập tài khoản*";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.Transparent;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold);
			this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
			this.label1.Location = new System.Drawing.Point(3, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(220, 25);
			this.label1.TabIndex = 6;
			this.label1.Text = "Chào mừng tới hệ thống!";
			// 
			// Form_dangky
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::test.Properties.Resources.tla_16927191259151174443421;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(763, 518);
			this.Controls.Add(this.panel1);
			this.Name = "Form_dangky";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox2;
	}
}