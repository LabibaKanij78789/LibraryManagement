using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Layout;
using MySql.Data.MySqlClient;


namespace LibraryManagement
{
    class DBConnect
    {
        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;
        private int colNo;

        public DBConnect()
        {
            Initialize();
        }

        private void Initialize()
        {
            server = "localhost";
            database = "the_athenaeum";
            uid = "root";
            password = " ";
            string connectionString;
            connectionString = "SERVER=" + server + ";" + "DATABASE=" +
                               database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            try
            {
                connection = new MySqlConnection(connectionString);
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        public MySqlConnection getConnection()
        {
            return this.connection;
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;
            }
            
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement
        public void Insert(String tableName, String[] colStrings, String[] values)
        {
            colNo = colStrings.Length;
            string query = "INSERT INTO " + tableName + " (";

            for (int i = 0; i < colNo; i++)
            {
                query += colStrings[i];
                if (i < colNo - 1)
                {
                    query += ", ";
                }
                else
                {
                    query += ") ";

                }
            }

            query += "VALUES(";

            for (int i = 0; i < colNo; i++)
            {
                query += "'";
                query += values[i];
                query += "'";
                if (i < colNo - 1)
                {
                    query += ", ";
                }
            }

            query += ")";

            MessageBox.Show(query);

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        //Update statement
        public void Update(String tableName, String[] colStrings, String[] values,String condition)
        {
            string query = "UPDATE " + tableName + " SET ";
            colNo = colStrings.Length;


            for (int i = 0; i < colNo; i++)
            {
                query += colStrings[i] + " = '";
                query += values[i];
                query += "\'";
                if (i < colNo - 1)
                {
                    query += ", ";
                }
            }
            query += condition;
            MessageBox.Show(query);
            //Open connection
            try {
                //create mysql command
                    MySqlCommand cmd = new MySqlCommand();
                    //Assign the query using CommandText
                    cmd.CommandText = query;
                    //Assign the connection using Connection
                    cmd.Connection = connection;

                    //Execute query
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Updated");

            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        //Delete statement
        public void Delete(string tableName, string colString, string value)
        {
            string query = "DELETE FROM " + tableName + " WHERE ";
            query += colString + " = ";
            query += "\'";
            query += value;
            query += "\'";
            //colNo = colStrings.Length;


            //for (int i = 0; i < colNo; i++)
            //{
            //    query += colStrings[i] + " = ";
            //    query += "\'";
            //    query += values[i];
            //    query += "\'";
            //    if (i < colNo - 1)
            //    {
            //        query += ", ";
            //    }
            //}

            if (this.OpenConnection() == true)
            {
                MySqlCommand cmd = new MySqlCommand(query, connection);
                cmd.ExecuteNonQuery();
                this.CloseConnection();
            }
        }

        //Select statement
        public Boolean SelectAll(String tableName, string condition)
        {
            string query = "SELECT * FROM "+tableName+condition;
            //colNo = colStrings.Length;
            ////Create a list to store the result
            //List<string>[] list = new List<string>[colNo];
            //for (int i = 0; i < colNo; i++)
            //{
            //    list[i] = new List<string>();
            //}
            ////list[0] = new List<string>();
            ////list[1] = new List<string>();
            ////list[2] = new List<string>();

            try
            {
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(query, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    MessageBox.Show(dataReader.HasRows.ToString());

                    if (dataReader.HasRows)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return false;
        }
        //select specific

        public List<string>[] Select(string tableName, string[] colStrings, bool condition, string conQuery)
        {
            string query = "SELECT ";
            
            colNo = colStrings.Length;
            for (int i = 0; i < colNo; i++)
            {
                query += colStrings[i];
                if (i < colNo - 1)
                {
                    query += ", ";
                }
            }
            query += "FROM " + tableName;

            if (condition)
            {
                query += " " + conQuery;
            }
            //Create a list to store the result
            List<string>[] list = new List<string>[colNo];
            for (int i = 0; i < colNo; i++)
            {
                list[i] = new List<string>();
            }
            //list[0] = new List<string>();
            //list[1] = new List<string>();
            //list[2] = new List<string>();

            //Open connection
            if (this.OpenConnection() == true)
            {
                //Create Command
                MySqlCommand cmd = new MySqlCommand(query, connection);
                //Create a data reader and Execute the command
                MySqlDataReader dataReader = cmd.ExecuteReader();
                if (!dataReader.HasRows)
                {
                    for (int i = 0; i < colNo; i++)
                    {
                        list[i].Clear();
                    }
                }

                //Read the data and store them in the list
                while (dataReader.Read())
                {
                    for (int i = 0; i < colNo; i++)
                    {
                        list[0].Add(dataReader[colStrings[i]] + "");
                    }
                    //list[0].Add(dataReader["id"] + "");
                    //list[1].Add(dataReader["name"] + "");
                    //list[2].Add(dataReader["age"] + "");
                }

                //close Data Reader
                dataReader.Close();

                //close Connection
                this.CloseConnection();

                //return list to be displayed
                return list;
            }
            else
            {
                return list;
            }
        }

        public List<List<string>> selectSearch(string query, string[] colStrings)
        {
            string q = query;
            MessageBox.Show(query);
            //Create a list to store the result
            List<List<string>> list = new List<List<string>>();

            //list[0] = new List<string>();
            //list[1] = new List<string>();
            //list[2] = new List<string>();

            //Open connection
            try
            {
                if (this.OpenConnection() == true)
                {
                    //Create Command
                    MySqlCommand cmd = new MySqlCommand(q, connection);
                    //Create a data reader and Execute the command
                    MySqlDataReader dataReader = cmd.ExecuteReader();

                    //Read the data and store them in the list
                    while (dataReader.Read())
                    {
                        List<string> arr = new List<string>();
                       
                        for (int i = 0; i < colStrings.Length; i++)
                        {
                            arr.Add( dataReader[ colStrings[i] ].ToString() );
                        }
                        list.Add(arr);
                    }

                    //close Data Reader
                    dataReader.Close();

                    //close Connection
                    this.CloseConnection();

                    //return list to be displayed
                   
                }
               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            return list;
        }
        //Count statement
        public int Count(String tableName)
        {
            string query = "SELECT Count(*) FROM"+tableName;
            int Count = -1;

            //Open Connection
            if (this.OpenConnection() == true)
            {
                //Create Mysql Command
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //ExecuteScalar will return one value
                Count = int.Parse(cmd.ExecuteScalar() + "");

                //close Connection
                this.CloseConnection();

                return Count;
            }
            else
            {
                return Count;
            }
        }

        //Backup
        public void Backup()
        {

        }

        //Restore
        public void Restore()
        {
        }
    }
}
