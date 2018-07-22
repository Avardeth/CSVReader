using System;
using System.Windows.Forms;
using System.Drawing;

namespace Main.Search{
	class SearchBlock{
		TextBox searchBox = new TextBox();
		public TextBox search {get {return searchBox;}}
		public void searchTextBox(){
			searchBox.Size = new Size(400,50);
			searchBox.Location = new Point(100,100);
			searchBox.Font = new Font(searchBox.Font.FontFamily,16);
		}
	}
}