using System;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;

namespace CSV {
	class CSVParserUI : InitComponent {
		
		public CSVParserUI(){
			initComponent();
		}
		
		public static void Main(){
			Application.Run(new CSVParserUI());
		}
	}

	class InitComponent : ButtonListener{
		public static TextBox filePath = new TextBox();
		public string file = filePath.Text;
		public static ComboBox comboBox = new ComboBox();
		public int selectedSeparatorIndex = comboBox.SelectedIndex;
		public void initComponent() {
			Size = new Size(800,600);
			StartPosition = FormStartPosition.CenterScreen;
			
			Label filePathLabel = new Label();
			filePathLabel.Text = "File path:";
			filePathLabel.Size = new Size(100,25);
			filePathLabel.Location = new Point(100,70);
			filePathLabel.Font = new Font(filePathLabel.Font.FontFamily,14);
			Controls.Add(filePathLabel);
			
			filePath.Location = new Point(100,100);
			filePath.Size = new Size(400,25);
			filePath.Font = new Font(filePath.Font.FontFamily,14);
			Controls.Add(filePath);
			
			comboBox.Size = new Size(200,25);
			comboBox.Location = new Point(100,200);
			comboBox.Font = new Font(comboBox.Font.FontFamily,14);
			string[] separator = {"Comma (,)", "Dot (.)", "Semi Colon (;)", "ForwardSlash (/)", "BackSlash (\\)", "Space ( )"};
			comboBox.Items.AddRange(separator);
			Controls.Add(comboBox);
			
			Label separatorLabel = new Label();
			separatorLabel.Text = "Please give 1 or more separator:";
			separatorLabel.Size = new Size(400,25);
			separatorLabel.Location = new Point(100,170);
			separatorLabel.Font = new Font(separatorLabel.Font.FontFamily,14);
			Controls.Add(separatorLabel);
			
			Button startButton = new Button();
			startButton.Text = "Start";
			startButton.Location = new Point(350,400);
			startButton.Size = new Size(100,50);
			Controls.Add(startButton);
			startButton.Click += new EventHandler(buttonListener);
		}
	}
	
	class ButtonListener : Form {
		public void buttonListener(object sender, EventArgs e) {
			InitComponent init = new InitComponent();
			MessageBox.Show("Success");
			CreateFile.createFile(CreateWords.createWords(init.file));
		}
	}
}
