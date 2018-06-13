using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

public class ChessBoard : Form {	

	public ChessBoard(){
		Size = new Size(800,800);
		
		TableLayoutPanel tlp = new TableLayoutPanel();
		tlp.Location = new Point(0,0);
		tlp.Size = new Size(800,800);
		tlp.BackColor = Color.LightBlue;
		this.Controls.Add(tlp);
		
		Label topPanel;
		for (int i = 1; i <= 8; i++){
			topPanel = new Label();
			topPanel.Text = i.ToString();
			topPanel.Size = new Size(80,20);
			topPanel.AutoSize = false;
			topPanel.TextAlign = ContentAlignment.MiddleCenter;
			tlp.Controls.Add(topPanel, i+1,0);
		}
		
		Label bottomPanel;
		for (int i = 1; i <= 8; i++){
			bottomPanel = new Label();
			bottomPanel.Text = i.ToString();
			bottomPanel.Size = new Size(80,20);
			bottomPanel.AutoSize = false;
			bottomPanel.TextAlign = ContentAlignment.MiddleCenter;
			tlp.Controls.Add(bottomPanel, i+1,10);
		}
		
		Label leftPanel;
		char a = 'h';
		for(int i = 1; i <= 8; i++){
			leftPanel = new Label();
			leftPanel.Text = a.ToString();
			a--;
			leftPanel.Size = new Size(20,80);
			leftPanel.AutoSize = false;
			leftPanel.TextAlign = ContentAlignment.MiddleCenter;
			tlp.Controls.Add(leftPanel, 0, i+1);
		}
		
		Label rightPanel;
		char b = 'h';
		for(int i = 1; i <= 8; i++){
			rightPanel = new Label();
			rightPanel.Text = b.ToString();
			b--;
			rightPanel.Size = new Size(20,80);
			rightPanel.AutoSize = false;
			rightPanel.TextAlign = ContentAlignment.MiddleCenter;
			tlp.Controls.Add(rightPanel, 10, i+1);
		}
		
		Panel panel;
		Color color;
		for (int i = 1; i <= 8; i++){
			for (int j = 1; j <= 8; j++){
				panel = new Panel();
				color = (i+j)%2 == 0 ? Color.White : Color.Black;
				panel.BackColor = color;
				panel.Size = new Size(80,80);
				tlp.Controls.Add(panel,i+1,j+1);
			}
		}
		
	}
	[STAThread]
	public static void Main(){
		Application.Run(new ChessBoard());
	}
}
