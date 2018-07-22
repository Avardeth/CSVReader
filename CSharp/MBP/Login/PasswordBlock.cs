using System;
using System.Windows.Forms;
using System.Drawing;

namespace Login{
	partial class PassLogin{
		static TextBox passWord = new TextBox();
		public TextBox passW{get{return passWord;}}
		public void passBox(){
			passWord.Size = new Size(200,25);
			passWord.Location = new Point(300,230);
			passWord.Font = new Font(passWord.Font.FontFamily,16);
		}
	}
	
	partial class PassLogin{
		Label passWLabel = new Label();
		public Label passWL {get{return passWLabel;}}
		public void label(){
			passWLabel.Text = "Password:";
			passWLabel.Size = new Size(200,25);
			passWLabel.Location = new Point(300,200);
			passWLabel.Font = new Font(passWLabel.Font.FontFamily,16);
		}
	}
}