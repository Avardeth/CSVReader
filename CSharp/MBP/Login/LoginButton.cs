using System;
using System.Windows.Forms;
using System.Drawing;

namespace Login{
	class LoginButton{
		Button login = new Button();
		public Button loginB{get{return login;}}
		public void loginButton(){
			login.Text = "Login";
			login.Size = new Size(200,50);
			login.Location = new Point(300,300);
			login.Font = new Font(login.Font.FontFamily, 16);
			logindb ldb = new logindb();
			login.Click += new EventHandler(ldb.login_Click);
		}
	}
}