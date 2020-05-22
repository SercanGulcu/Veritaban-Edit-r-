using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data;


namespace FinalProject
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();

            string myConnnection = "datasource=localhost; port=3306;username=root;password=Sercan.123; ";
            MySqlConnection myConn = new MySqlConnection(myConnnection);

            myConn.Open();

            MySqlCommand command = new MySqlCommand();
            command = myConn.CreateCommand();
            command.CommandText = "SELECT schema_name FROM information_schema.schemata where schema_name not like '%_schema' and schema_name not like 'mysql';";
            MySqlDataReader Reader1;
            Reader1 = command.ExecuteReader();

            while (Reader1.Read())
            {
                string row = "";
                for (int i = 0; i < Reader1.FieldCount; i++)
                    row += Reader1.GetValue(i).ToString();
                trV1.Nodes.Add(row);

            }
            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                trV1.Nodes[i].Nodes.Add("Tables");
                trV1.Nodes[i].Nodes.Add("Views");
                trV1.Nodes[i].Nodes.Add("Stored Procedure");
                trV1.Nodes[i].Nodes.Add("Functions ");
            }

            Reader1.Close();
            Reader1.Dispose();
            myConn.Close();


            myConn.Open();
            MySqlCommand command_table = new MySqlCommand();
            command_table = myConn.CreateCommand();
            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                command_table.CommandText = "SELECT table_name FROM information_schema.tables WHERE table_schema ='" + trV1.Nodes[i].Text + "' ";
                MySqlDataReader Reader2;
                Reader2 = command_table.ExecuteReader();

                while (Reader2.Read())
                {
                    string table = "";
                    for (int j = 0; j < Reader2.FieldCount; j++)
                        table += Reader2.GetValue(j).ToString();
                    trV1.Nodes[i].Nodes[0].Nodes.Add(table);


                }
                Reader2.Close();
                Reader2.Dispose();
            }
            myConn.Close();

            myConn.Open();
            MySqlCommand command_view = new MySqlCommand();
            command_view = myConn.CreateCommand();
            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                command_view.CommandText = "SELECT table_name FROM information_schema.tables WHERE table_type='VIEW' AND table_schema ='" + trV1.Nodes[i].Text + "' ";
                MySqlDataReader Reader3;
                Reader3 = command_view.ExecuteReader();

                while (Reader3.Read())
                {
                    string view = "";
                    for (int j = 0; j < Reader3.FieldCount; j++)
                        view += Reader3.GetValue(j).ToString();
                    trV1.Nodes[i].Nodes[1].Nodes.Add(view);


                }
                Reader3.Close();
                Reader3.Dispose();
            }

            myConn.Close();

            myConn.Open();
            MySqlCommand command_procedure = new MySqlCommand();
            command_procedure = myConn.CreateCommand();
            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                command_procedure.CommandText = "SHOW PROCEDURE STATUS WHERE Db  ='" + trV1.Nodes[i].Text + "' ";
                MySqlDataReader Reader4;
                Reader4 = command_procedure.ExecuteReader();

                while (Reader4.Read())
                {
                    string procedure = "";
                    for (int j = 0; j < Reader4.FieldCount; j++)
                        procedure += Reader4.GetValue(j).ToString();
                    trV1.Nodes[i].Nodes[2].Nodes.Add(procedure);


                }
                Reader4.Close();
                Reader4.Dispose();
            }


            myConn.Close();

            myConn.Open();
            MySqlCommand command_function = new MySqlCommand();
            command_function = myConn.CreateCommand();
            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                command_function.CommandText = "SHOW FUNCTION STATUS WHERE Db  ='" + trV1.Nodes[i].Text + "' ";
                MySqlDataReader Reader5;
                Reader5 = command_function.ExecuteReader();

                while (Reader5.Read())
                {
                    string function = "";
                    for (int j = 0; j < Reader5.FieldCount; j++)
                        function += Reader5.GetValue(j).ToString();
                    trV1.Nodes[i].Nodes[3].Nodes.Add(function);


                }
                Reader5.Close();
                Reader5.Dispose();
            }

            ContextMenuStrip docMenu = new ContextMenuStrip();

            ToolStripMenuItem SelectRows = new ToolStripMenuItem();
            SelectRows.Text = "Select Rows";
            ToolStripMenuItem AlterTable = new ToolStripMenuItem();
            AlterTable.Text = "Alter Table";
            ToolStripMenuItem DropTable = new ToolStripMenuItem();
            DropTable.Text = "Drop Table";

            docMenu.Items.AddRange(new ToolStripMenuItem[] { SelectRows, AlterTable, DropTable });



            for (int i = 0; i < trV1.Nodes.Count; i++)
            {
                for (int j = 0; j < trV1.Nodes[i].Nodes[0].Nodes.Count; j++)
                {
                    trV1.Nodes[i].Nodes[0].Nodes[j].ContextMenuStrip = docMenu;
                }
            }

            SelectRows.Click += SelectRows_Click;


            void SelectRows_Click(object sender, System.EventArgs e)
            {



                MySqlConnection connection = new MySqlConnection("datasource=localhost;port=3306;username=root;password=Sercan.123");

                connection.Open();

              
                

                try
                {


                    MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM " + trV1.SelectedNode.Parent.Parent.Text + "." + trV1.SelectedNode.Text + " ", connection);


                    DataSet ds = new DataSet();

                    adapter.Fill(ds, trV1.SelectedNode.Text);
                    dataGridView1.DataSource = ds.Tables[trV1.SelectedNode.Text];
                    string a = ds.Tables[0].Columns.ToString();
                   


                    //MySqlDataAdapter adapter = new MySqlDataAdapter("SELECT * FROM blm437.ogrenci ", connection);
                   
                    //DataSet ds = new DataSet();

                    //adapter.Fill(ds, "ogrenci");
                    //dataGridView1.DataSource = ds.Tables["ogrenci"];
                   


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);




                }


            }
        }








    }

}
    

