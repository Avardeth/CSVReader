using System;
using System.Windows.Forms;
using System.Drawing;

namespace Login{
	partial class ConnectButton : Form{
		Button connectB = new Button();
		public Button connectBut{get{return connectB;}}
		public void connectButton(){
			connectB.Size = new Size(100,30);
			connectB.Location = new Point(100,500);
			connectB.Text = "Connect";
			connectB.Click += new EventHandler(this.buttonListener);
		}
	}
	
	partial class ConnectButton{
		public void buttonListener(object sender, EventArgs e){
			Connect con = new Connect();
			con.connect();
		}
	}
}