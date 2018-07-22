using System;
using System.Windows.Forms;
using System.Drawing;

namespace Main.Search{
	partial class SearchAllButton{
		Button sAllButton = new Button();
		public Button searchAllB{get {return sAllButton;}}
		public void searchAllButton(){
			sAllButton.Text = "Search All";
			sAllButton.Size = new Size(150,50);
			sAllButton.Location = new Point(200,200);
			sAllButton.Font = new Font("Arial",14);
			sAllButton.Click += new EventHandler(buttonListener);
		}
	}
	
	partial class SearchAllButton{
		void buttonListener(object sender, EventArgs e){
			SearchAll searchall = new SearchAll();
			searchall.searchAll();
		}
	}
}