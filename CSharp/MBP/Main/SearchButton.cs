using System;
using System.Windows.Forms;
using System.Drawing;

namespace Main.Search{
	partial class SearchButton{
		Button sButton = new Button();
		public Button searchB{get {return sButton;}}
		public void searchButton(){
			sButton.Text = "Search";
			sButton.Size = new Size(100,50);
			sButton.Location = new Point(100,200);
			sButton.Font = new Font("Arial",14);
			sButton.Click += new EventHandler(buttonListener);
		}
	}
	
	partial class SearchButton{
		void buttonListener(object sender, EventArgs e){
			
		}
	}
}