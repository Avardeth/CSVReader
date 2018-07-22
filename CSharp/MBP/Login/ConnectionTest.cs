using System;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace Login{
	class Connect {
		public void connect(){
			string connetionString;
			SqlConnection cnn;
			connetionString = @"Data Source=(localdb)\.; Initial Catalog=efloorDB";
			cnn = new SqlConnection(connetionString);
			cnn.Open();
			MessageBox.Show("Connection Open  !");
			cnn.Close();
		}
	}
}