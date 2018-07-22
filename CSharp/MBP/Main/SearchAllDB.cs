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

namespace Main.Search{
	public class SearchAll{
		public void searchAll(){
			SqlConnection log = new SqlConnection();
			log.ConnectionString = @"Data Source=(localdb)\.;Initial Catalog=units";
			SqlCommand logcmd = new SqlCommand("select * from unitdata", log);
			log.Open();
			//MessageBox.Show(logcmd);
			log.Close();
		}
	}
}

string connectionString = "Data Source=.;Initial Catalog=pubs;Integrated Security=True";
            string sql = "SELECT * FROM Stores";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();
            sCommand = new SqlCommand(sql, connection);
            sAdapter = new SqlDataAdapter(sCommand);
            sBuilder = new SqlCommandBuilder(sAdapter);
            sDs = new DataSet();
            sAdapter.Fill(sDs, "Stores");
            sTable = sDs.Tables["Stores"];
            connection.Close();
            dataGridView1.DataSource = sDs.Tables["Stores"];
            dataGridView1.ReadOnly = true;
            save_btn.Enabled = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

/*
public static string ConvertDataTableToHTML(DataTable dt)
    {
        string html = "<table>";
        //add header row
        html += "<tr>";
        for(int i=0;i<dt.Columns.Count;i++)
            html+="<td>"+dt.Columns[i].ColumnName+"</td>";
        html += "</tr>";
        //add rows
        for (int i = 0; i < dt.Rows.Count; i++)
        {
            html += "<tr>";
            for (int j = 0; j< dt.Columns.Count; j++)
                html += "<td>" + dt.Rows[i][j].ToString() + "</td>";
            html += "</tr>";
        }
        html += "</table>";
        return html;
    }*/
	
	/*
	//class variable DataTable, so you can edit it later too!
DataTable table;

//in some of your methods:
using(SqlConnection sqlConn = new SqlConnection("connString"))
{
   string sqlQuery = @"SELECT * FROM MyTable";
   using(SqlCommand cmd = new SqlCommand(sqlQuery, sqlConn))
   {
      SqlDataAdapter ds = new SqlDataAdapter(cmd);
      da.Fill(table);
   }
}

//table is now filled from the data from dataBase!!
//you can loop through it:
foreach(DataRow dr in table.Rows)
{
   //for example 1st column is an int, 2nd is a string:
   int col1 = (int)dr[0];
   string col2 = (string)dr[1];
}
*/