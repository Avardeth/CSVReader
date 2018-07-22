using System;
using System.ComponentModel;
using System.Windows.Forms;
using System.Drawing;
using System.Web.UI.HtmlControls;
using Layout;
using Login;
using Main.Search;

namespace Main {
	public class MainPage : Form{
		public MainPage() {
			Size = new Size(800,600);
			StartPosition = FormStartPosition.CenterScreen;
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			
			MenuBar menubar = new MenuBar();
			menubar.menuBar();
			this.Controls.Add(menubar.menuBarStr);
			
			SearchBlock searchBox = new SearchBlock();
			searchBox.searchTextBox();
			this.Controls.Add(searchBox.search);
			
			SearchButton sButton = new SearchButton();
			sButton.searchButton();
			this.Controls.Add(sButton.searchB);
			
			SearchAllButton sAllButton = new SearchAllButton();
			sAllButton.searchAllButton();
			this.Controls.Add(sAllButton.searchAllB);
		}
	}
}