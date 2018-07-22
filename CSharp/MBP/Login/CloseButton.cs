using System;
using System.Windows.Forms;
using System.Drawing;

namespace Login.LayoutInit{
	partial class CloseButton : Form{
		Label closeApp = new Label();
		public Label closeAp {get {return closeApp;}}
		public void closeLabel(){
			closeApp.Size = new Size(100,30);
			closeApp.Location = new Point(600,500);
			closeApp.Font = new Font(closeApp.Font.FontFamily,16);
			closeApp.Text = "(X)Close";
			closeApp.Click += new EventHandler(this.labelListener);
		}
	}
		
	partial class CloseButton{
		public void labelListener(object sender, EventArgs e) {
			Label clickedLabel = sender as Label;
			if (clickedLabel != null)
				Application.Exit();
		}
	}
}