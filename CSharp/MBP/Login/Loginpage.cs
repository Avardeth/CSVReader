using System;
using System.Drawing;
using System.Windows.Forms;
using System.ComponentModel;
using System.Linq;
using Main;
using Login.LayoutInit;

namespace Login {
	public class LoginPage : Form {
		public LoginPage() {
			Size = new Size(800,600);
			StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;	// remove title bar
			
			CloseButton CB = new LayoutInit.CloseButton();
			CB.closeLabel();
			this.Controls.Add(CB.closeAp);
			
			//UserBlock
			UserLogin UL = new UserLogin();
			UL.label();
			UL.userBox();
			Controls.Add(UL.userN);
			Controls.Add(UL.userL);
			//UserBlock end
		
			//PasswordBlock
			PassLogin PL = new PassLogin();
			PL.label();
			PL.passBox();
			Controls.Add(PL.passW);
			Controls.Add(PL.passWL);
			//PasswordBlock end
			
			//LoginButton
			LoginButton LB = new LoginButton();
			LB.loginButton();
			Controls.Add(LB.loginB);
			//LoginButton end
			
			ConnectButton ConnB = new ConnectButton();
			ConnB.connectButton();
			this.Controls.Add(ConnB.connectBut);
		}
	}
}