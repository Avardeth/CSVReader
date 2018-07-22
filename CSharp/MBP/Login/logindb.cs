using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Main;

namespace Login{
	public class logindb : Form{
		public void login_Click(object sender, EventArgs e){     
			UserLogin UL = new UserLogin();
			PassLogin PL = new PassLogin();
			SqlConnection log = new SqlConnection();
			log.ConnectionString = @"Data Source=(localdb)\.;Initial Catalog=efloordb";
			SqlCommand logcmd = new SqlCommand("select count (*) from login where loginname=@usr and password=@pwd", log);
			logcmd.Parameters.Clear();
			logcmd.Parameters.AddWithValue("@usr", UL.userN.Text);
			logcmd.Parameters.AddWithValue("@pwd", PL.passW.Text);
			log.Open();  
			
			if(logcmd.ExecuteScalar().ToString()=="1"){
				this.Hide();
				MainPage mainpage = new MainPage();
				mainpage.Show();
            } else{
				MessageBox.Show("YOU ARE NOT GRANTED WITH ACCESS");
				UL.userN.Clear();
				PL.passW.Clear();
			}
			log.Close();
		}
	}
}