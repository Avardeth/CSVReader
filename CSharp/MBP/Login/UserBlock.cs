using System;
using System.Windows.Forms;
using System.Drawing;

namespace Login{
	partial class UserLogin{
		static TextBox userName = new TextBox();
		public TextBox userN {get {return userName;}}
		public void userBox(){
			userName.Size = new Size(200,25);
			userName.Location = new Point(300,150);
			userName.Font = new Font(userName.Font.FontFamily,16);
		}
	}
	
	partial class UserLogin{
		Label userLabel = new Label();
		public Label userL {get {return userLabel;}}
		public void label(){
			userLabel.Text = "User name:";
			userLabel.Size = new Size(200,25);
			userLabel.Location = new Point(300,120);
			userLabel.Font = new Font(userLabel.Font.FontFamily, 16);
		}
	}
}