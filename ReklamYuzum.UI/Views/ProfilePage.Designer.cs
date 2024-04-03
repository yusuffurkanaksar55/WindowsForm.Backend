namespace ReklamYuzum.UI.Views
{
	partial class ProfilePage
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
			lblFollowers = new Label();
			lblFollowed = new Label();
			lblFollowersCount = new Label();
			lblFollowedCount = new Label();
			lblProfilName = new Label();
			label1 = new Label();
			lblPostCount = new Label();
			pictureBoxPhoto = new PictureBox();
			btnPhoto = new Button();
			((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).BeginInit();
			SuspendLayout();
			// 
			// lblFollowers
			// 
			lblFollowers.AutoSize = true;
			lblFollowers.Location = new Point(104, 116);
			lblFollowers.Name = "lblFollowers";
			lblFollowers.Size = new Size(113, 25);
			lblFollowers.TabIndex = 0;
			lblFollowers.Text = "Takipçi Sayısı";
			lblFollowers.UseWaitCursor = true;
			// 
			// lblFollowed
			// 
			lblFollowed.AutoSize = true;
			lblFollowed.Location = new Point(285, 116);
			lblFollowed.Name = "lblFollowed";
			lblFollowed.Size = new Size(123, 25);
			lblFollowed.TabIndex = 1;
			lblFollowed.Text = "Takip Edilenler";
			lblFollowed.UseWaitCursor = true;
			// 
			// lblFollowersCount
			// 
			lblFollowersCount.AutoSize = true;
			lblFollowersCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			lblFollowersCount.Location = new Point(93, 69);
			lblFollowersCount.Name = "lblFollowersCount";
			lblFollowersCount.Size = new Size(0, 30);
			lblFollowersCount.TabIndex = 2;
			lblFollowersCount.UseWaitCursor = true;
			// 
			// lblFollowedCount
			// 
			lblFollowedCount.AutoSize = true;
			lblFollowedCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			lblFollowedCount.Location = new Point(285, 69);
			lblFollowedCount.Name = "lblFollowedCount";
			lblFollowedCount.Size = new Size(0, 30);
			lblFollowedCount.TabIndex = 3;
			lblFollowedCount.UseWaitCursor = true;
			// 
			// lblProfilName
			// 
			lblProfilName.AutoSize = true;
			lblProfilName.Location = new Point(746, 32);
			lblProfilName.Name = "lblProfilName";
			lblProfilName.Size = new Size(0, 25);
			lblProfilName.TabIndex = 4;
			lblProfilName.UseWaitCursor = true;
			// 
			// label1
			// 
			label1.AutoSize = true;
			label1.Location = new Point(444, 116);
			label1.Name = "label1";
			label1.Size = new Size(124, 25);
			label1.TabIndex = 5;
			label1.Text = "Gönderi Sayısı";
			label1.UseWaitCursor = true;
			// 
			// lblPostCount
			// 
			lblPostCount.AutoSize = true;
			lblPostCount.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point, 162);
			lblPostCount.Location = new Point(437, 68);
			lblPostCount.Name = "lblPostCount";
			lblPostCount.Size = new Size(0, 30);
			lblPostCount.TabIndex = 6;
			lblPostCount.UseWaitCursor = true;
			// 
			// pictureBoxPhoto
			// 
			pictureBoxPhoto.Location = new Point(702, 69);
			pictureBoxPhoto.Name = "pictureBoxPhoto";
			pictureBoxPhoto.Size = new Size(285, 108);
			pictureBoxPhoto.SizeMode = PictureBoxSizeMode.AutoSize;
			pictureBoxPhoto.TabIndex = 7;
			pictureBoxPhoto.TabStop = false;
			// 
			// btnPhoto
			// 
			btnPhoto.Font = new Font("Segoe UI", 8F, FontStyle.Regular, GraphicsUnit.Point, 162);
			btnPhoto.Location = new Point(702, 183);
			btnPhoto.Name = "btnPhoto";
			btnPhoto.Size = new Size(135, 34);
			btnPhoto.TabIndex = 8;
			btnPhoto.Text = "Profil Fotoğraf";
			btnPhoto.UseVisualStyleBackColor = true;
			btnPhoto.Click += btnPhoto_Click;
			// 
			// ProfilePage
			// 
			AutoScaleDimensions = new SizeF(10F, 25F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(1093, 845);
			Controls.Add(btnPhoto);
			Controls.Add(pictureBoxPhoto);
			Controls.Add(lblPostCount);
			Controls.Add(label1);
			Controls.Add(lblProfilName);
			Controls.Add(lblFollowedCount);
			Controls.Add(lblFollowersCount);
			Controls.Add(lblFollowed);
			Controls.Add(lblFollowers);
			Name = "ProfilePage";
			StartPosition = FormStartPosition.CenterScreen;
			Text = "ProfilePage";
			Load += ProfilePage_Load;
			((System.ComponentModel.ISupportInitialize)pictureBoxPhoto).EndInit();
			ResumeLayout(false);
			PerformLayout();
		}

		#endregion

		private Label lblFollowers;
		private Label lblFollowed;
		private Label lblFollowersCount;
		private Label lblFollowedCount;
		private Label lblProfilName;
		private Label label1;
		private Label lblPostCount;
		private PictureBox pictureBoxPhoto;
		private Button btnPhoto;
	}
}