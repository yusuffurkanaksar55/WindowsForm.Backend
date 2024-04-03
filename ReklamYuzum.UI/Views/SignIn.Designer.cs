namespace ReklamYuzum.UI.Views
{
	partial class SignIn
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
			label1 = new Label();
			label2 = new Label();
			tbxSignInMail = new TextBox();
			tbxSignInPassword = new TextBox();
			btnSignIn = new Button();
			SuspendLayout();
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(122, 75);
			label1.Name = "label1";
			label1.Size = new Size(109, 25);
			label1.TabIndex = 0;
			label1.Text = "Email Adresi";
			// 
			// label2
			// 
			label2.AutoSize = true;
			label2.Location = new Point(122, 166);
			label2.Name = "label2";
			label2.Size = new Size(60, 25);
			label2.TabIndex = 1;
			label2.Text = "Parola";
			// 
			// tbxSignInMail
			// 
			tbxSignInMail.Location = new Point(251, 75);
			tbxSignInMail.Name = "tbxSignInMail";
			tbxSignInMail.Size = new Size(258, 31);
			tbxSignInMail.TabIndex = 2;
			// 
			// tbxSignInPassword
			// 
			tbxSignInPassword.Location = new Point(251, 166);
			tbxSignInPassword.Name = "tbxSignInPassword";
			tbxSignInPassword.Size = new Size(258, 31);
			tbxSignInPassword.TabIndex = 3;
			// 
			// btnSignIn
			// 
			btnSignIn.Location = new Point(260, 232);
			btnSignIn.Name = "btnSignIn";
			btnSignIn.Size = new Size(249, 44);
			btnSignIn.TabIndex = 4;
			btnSignIn.Text = "Giriş Yap";
			btnSignIn.UseVisualStyleBackColor = true;
			btnSignIn.Click += btnSignIn_Click;
			// 
			// SignIn
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(698, 361);
			Controls.Add(btnSignIn);
			Controls.Add(tbxSignInPassword);
			Controls.Add(tbxSignInMail);
			Controls.Add(label2);
			Controls.Add(label1);
			Name = "SignIn";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "SignIn";
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label label1;
		private Label label2;
		private TextBox tbxSignInMail;
		private TextBox tbxSignInPassword;
		private Button btnSignIn;
	}
}