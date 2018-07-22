using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace Layout {
	class MenuBar : Form{
		MenuStrip menuBarStrip = new MenuStrip();
		public MenuStrip menuBarStr {get {return menuBarStrip;}}
		public void menuBar(){
			FileDropDownTool fileDropDown = new FileDropDownTool();
			fileDropDown.fileDropDownTool();
			menuBarStrip.Items.AddRange(new ToolStripItem[]{fileDropDown.file});
			menuBarStrip.BackColor = Color.LightBlue;
			menuBarStrip.Font = new Font("MV Boli",16);
		}
	}
	
	class FileDropDownTool {
		ToolStripMenuItem fileTool = new ToolStripMenuItem();
		public ToolStripMenuItem file {get {return fileTool;}}
		public void fileDropDownTool(){
			SearchDropDownTool searchDropDown = new SearchDropDownTool();
			searchDropDown.searchDropDownTool();
			ExitDropDownTool exitDropDown = new ExitDropDownTool();
			exitDropDown.exitDropDownTool();
			fileTool.DropDownItems.AddRange(new ToolStripItem[]{searchDropDown.search,exitDropDown.exit});
			fileTool.Text = "File";
			
		}
	}
	
	partial class SearchDropDownTool{
		ToolStripMenuItem searchTool = new ToolStripMenuItem();
		public ToolStripMenuItem search {get {return searchTool;}}
		public void searchDropDownTool(){
			searchTool.Text = "Search";
			searchTool.Click += new EventHandler(eventListener);
		}
	}
	
	partial class SearchDropDownTool{
		public void eventListener(object sender, EventArgs e){
			
		}
	}
	
	partial class ExitDropDownTool{
		ToolStripMenuItem exitTool = new ToolStripMenuItem();
		public ToolStripMenuItem exit {get {return exitTool;}}
		public void exitDropDownTool(){
			exitTool.Text = "Exit";
			exitTool.Click += new EventHandler(eventListener);
		}
	}
	
	partial class ExitDropDownTool{
		public void eventListener(object sender, EventArgs e){
			Application.Exit();
		}
	}
}