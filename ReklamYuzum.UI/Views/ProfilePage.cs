using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ReklamYuzum.Business.Abstract;
using ReklamYuzum.Entities.Concrete;

namespace ReklamYuzum.UI.Views
{
	public partial class ProfilePage : Form
	{
		private readonly IProfileService _profileService;
		private readonly Profile _profile;

		public ProfilePage(IProfileService profileService, Profile profile)
		{
			_profileService = profileService;
			_profile = profile;
			InitializeComponent();
		}

		private void ProfilePage_Load(object sender, EventArgs e)
		{
			lblFollowedCount.Text = _profile.Followed.ToString();
			lblFollowersCount.Text = _profile.Followers.ToString();
			lblProfilName.Text = _profile.ProfileName;
		}

		private void btnPhoto_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter =
				"Image Files (*.jpg; *.jpeg; *.png; *.gif; *.bmp)|*.jpg; *.jpeg; *.png; *.gif; *.bmp|All files (*.*)|*.*";
			openFileDialog.Title = "Select an Image File";

			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				string imagePath = openFileDialog.FileName;
				_profile.ProfilePhoto = imagePath;
				_profileService.Update(_profile);

				// Yüklenen görüntüyü yeniden boyutlandır
				using (var originalImage = new Bitmap(imagePath))
				{
					int maxWidth = pictureBoxPhoto.Width;
					int maxHeight = pictureBoxPhoto.Height;

					// Yeniden boyutlandırma oranını hesapla
					double ratioX = (double)maxWidth / originalImage.Width;
					double ratioY = (double)maxHeight / originalImage.Height;
					double ratio = Math.Min(ratioX, ratioY);

					// Yeniden boyutlandırılmış görüntüyü oluştur
					int newWidth = (int)(originalImage.Width * ratio);
					int newHeight = (int)(originalImage.Height * ratio);
					var resizedImage = new Bitmap(newWidth, newHeight);

					// Yeniden boyutlandırılmış görüntüyü oluşturulan Bitmap'e çizin
					using (Graphics graphics = Graphics.FromImage(resizedImage))
					{
						graphics.DrawImage(originalImage, 0, 0, newWidth, newHeight);
					}

					// Yeniden boyutlandırılmış görüntüyü PictureBox'a atayın
					pictureBoxPhoto.Image = resizedImage;
				}
			}
		}
	}
}
