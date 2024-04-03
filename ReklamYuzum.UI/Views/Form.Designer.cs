namespace ReklamYuzum.UI
{
	partial class frmRegister
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
			tbxFirstName = new TextBox();
			tbxLastName = new TextBox();
			tbxMail = new TextBox();
			tbxPassword = new TextBox();
			groupBox1 = new GroupBox();
			tbxProfileName = new TextBox();
			label5 = new Label();
			btnSignIn = new Button();
			btnSignUp = new Button();
			groupBox1.SuspendLayout();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(53, 41);
			label1.Name = "label1";
			label1.Size = new Size(107, 25);
			label1.TabIndex = 0;
			label1.Text = "Kullanıcı Adı";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(53, 93);
			label2.Name = "label2";
			label2.Size = new Size(134, 25);
			label2.TabIndex = 1;
			label2.Text = "Kullanıcı Soyadı";
			// 
			// label3
			// 
			label3.AutoSize = true;
			label3.Location = new Point(53, 198);
			label3.Name = "label3";
			label3.Size = new Size(168, 25);
			label3.TabIndex = 2;
			label3.Text = "Kullanıcı Mail Adresi";
			// 
			// label4
			// 
			label4.AutoSize = true;
			label4.Location = new Point(53, 254);
			label4.Name = "label4";
			label4.Size = new Size(60, 25);
			label4.TabIndex = 3;
			label4.Text = "Parola";
			// 
			// tbxFirstName
			// 
			tbxFirstName.Location = new Point(237, 41);
			tbxFirstName.Name = "tbxFirstName";
			tbxFirstName.Size = new Size(276, 31);
			tbxFirstName.TabIndex = 4;
			// 
			// tbxLastName
			// 
			tbxLastName.Location = new Point(237, 90);
			tbxLastName.Name = "tbxLastName";
			tbxLastName.Size = new Size(276, 31);
			tbxLastName.TabIndex = 5;
			// 
			// tbxMail
			// 
			tbxMail.Location = new Point(237, 195);
			tbxMail.Name = "tbxMail";
			tbxMail.Size = new Size(276, 31);
			tbxMail.TabIndex = 6;
			// 
			// tbxPassword
			// 
			tbxPassword.Location = new Point(237, 254);
			tbxPassword.Name = "tbxPassword";
			tbxPassword.Size = new Size(276, 31);
			tbxPassword.TabIndex = 7;
			tbxPassword.UseSystemPasswordChar = true;
			// 
			// groupBox1
			// 
			groupBox1.Controls.Add(tbxProfileName);
			groupBox1.Controls.Add(label5);
			groupBox1.Controls.Add(btnSignIn);
			groupBox1.Controls.Add(tbxMail);
			groupBox1.Controls.Add(tbxPassword);
			groupBox1.Controls.Add(label1);
			groupBox1.Controls.Add(label2);
			groupBox1.Controls.Add(tbxLastName);
			groupBox1.Controls.Add(label3);
			groupBox1.Controls.Add(tbxFirstName);
			groupBox1.Controls.Add(label4);
			groupBox1.Location = new Point(149, 18);
			groupBox1.Name = "groupBox1";
			groupBox1.Size = new Size(609, 424);
			groupBox1.TabIndex = 8;
			groupBox1.TabStop = false;
			groupBox1.Text = "Kullanıcı Giriş Ekranı";
			// 
			// tbxProfileName
			// 
			tbxProfileName.Location = new Point(237, 145);
			tbxProfileName.Name = "tbxProfileName";
			tbxProfileName.Size = new Size(276, 31);
			tbxProfileName.TabIndex = 11;
			// 
			// label5
			// 
			label5.AutoSize = true;
			label5.Location = new Point(53, 145);
			label5.Name = "label5";
			label5.Size = new Size(85, 25);
			label5.TabIndex = 10;
			label5.Text = "Profil Adı";
			// 
			// btnSignIn
			// 
			btnSignIn.Location = new Point(22, 325);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.Size = new Size(491, 49);
			btnSignIn.TabIndex = 9;
			btnSignIn.Text = "Kayıt Ol";
			btnSignIn.UseVisualStyleBackColor = true;
			btnSignIn.Click += btnSignIn_Click;
			// 
			// btnSignUp
			// 
			btnSignUp.BackColor = SystemColors.InactiveCaption;
			btnSignUp.Location = new Point(779, 35);
			btnSignUp.Name = "btnSignUp";
			btnSignUp.Size = new Size(122, 49);
			btnSignUp.TabIndex = 10;
			btnSignUp.Text = "Giriş Yap";
			btnSignUp.UseVisualStyleBackColor = false;
			btnSignUp.Click += btnSignUp_Click;
			// 
			// frmRegister
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			BackColor = SystemColors.InactiveCaption;
			ClientSize = new Size(967, 530);
			Controls.Add(btnSignUp);
			Controls.Add(groupBox1);
			Name = "frmRegister";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "Giriş Ekranı";
			groupBox1.ResumeLayout(false);
			groupBox1.PerformLayout();
			ResumeLayout(false);
		}

		#endregion

		private Label label1;
		private Label label2;
		private Label label3;
		private Label label4;
		private TextBox tbxFirstName;
		private TextBox tbxLastName;
		private TextBox tbxMail;
		private TextBox tbxPassword;
		private GroupBox groupBox1;
		private Button btnSignIn;
		private Button btnSignUp;
		private TextBox tbxProfileName;
		private Label label5;
	}
}
