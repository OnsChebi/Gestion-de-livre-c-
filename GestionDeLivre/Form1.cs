using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using System.Data.SqlClient;

namespace GestionDeLivre
{

    public partial class Form1 : Form
    {   //path of data base
        string path = "livreDB.db";
        //database creatdebug folder
        string cs = @"Data Source=" + Application.StartupPath + "\\livreDB.db;Version=3;";
       // SQLiteConnection con;
       // SQLiteCommand cmd;
        SQLiteDataReader reader;

        public Form1()
        {
            InitializeComponent();
            // Setup DataGridView columns
            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Title";
            dataGridView1.Columns[1].Name = "Author";
            dataGridView1.Columns[2].Name = "ISBN";
        }
        //show data in table
        private void data_show()
        {
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);

            cmd.CommandText = "SELECT * FROM livre";

            using (SQLiteDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    dataGridView1.Rows.Add(reader["title"], reader["author"],reader["isbn"]);
                }
            }
        }
        //create database and table
        private void Create_db()
        {
            if (!System.IO.File.Exists(path))
            {
                SQLiteConnection.CreateFile(path);
                using (var sqlite = new SQLiteConnection("Data Source=" + path))
                {
                    sqlite.Open();
                    string query = "CREATE TABLE IF NOT EXISTS livre (isbn INTEGER PRIMARY KEY, title TEXT, author TEXT)";
                    SQLiteCommand command = new SQLiteCommand(query, sqlite);
                    command.ExecuteNonQuery();
                    sqlite.Close();
                }
            }
            else
            {
                Console.WriteLine("database cannot create");
                return;
            }
        }
        //insert data

        private void button1_Click(object sender, EventArgs e)
        {
            string title = title_txt.Text;
            string author = author_txt.Text;
            string isbn = isbn_txt.Text;
            // Validate user input
            if (string.IsNullOrEmpty(title))
            {
                MessageBox.Show("Please enter a title.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler method
            }
            if (string.IsNullOrEmpty(author))
            {
                MessageBox.Show("Please enter an author.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler method
            }
            if (string.IsNullOrEmpty(isbn))
            {
                MessageBox.Show("Please enter an ISBN.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Exit the event handler method
            }
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            
            // Check if a book with the same ISBN already exists
            var checkCmd = new SQLiteCommand("SELECT COUNT(*) FROM livre WHERE isbn = @isbn", con);
            checkCmd.Parameters.AddWithValue("@isbn", isbn);
            var count = Convert.ToInt32(checkCmd.ExecuteScalar());
            if (count == 0)
            {
                // ISBN does not exist in the table
                var query = new SQLiteCommand(con);
                try
                {
                    cmd.CommandText = "INSERT INTO livre(title, author, isbn) VALUES(@title, @author, @isbn)";
                    cmd.Parameters.AddWithValue("@title", title);
                    cmd.Parameters.AddWithValue("@author", author);
                    cmd.Parameters.AddWithValue("@isbn", isbn);

                    dataGridView1.ColumnCount = 3;

                    string[] row = new string[] { title, author, isbn };
                    dataGridView1.Rows.Add(row);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("The book has been added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {   // If there is an error during insert, show it to the user
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Console.WriteLine("cannot insert data");
                    return;
                }

            }
            else
            {
                // ISBN exists - book has already been added
                // Console.WriteLine("A book with this ISBN already exists.");
                // ISBN exists - book has already been added, inform the user
                MessageBox.Show("A book with this ISBN already exists. Please use a unique ISBN.", "ISBN Duplicate", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            con.Close();
        }

    

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Title_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ISBN_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {// Load database and show data
            Create_db();
            data_show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source=" + Application.StartupPath + "\\livreDB.db;Version=3;";
            string query = "UPDATE livre SET title=@title, author=@author WHERE isbn=@isbn";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                try 
                { 
                    conn.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@isbn", isbn_txt.Text);
                        cmd.Parameters.AddWithValue("@title", title_txt.Text);
                        cmd.Parameters.AddWithValue("@author", author_txt.Text);

                        int rowsAffected = cmd.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The book has been updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No book found with the given ISBN to update.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            dataGridView1.Rows.Clear();
            data_show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {
                using (SQLiteConnection con = new SQLiteConnection(cs))
                {
                    con.Open();

                    using (SQLiteCommand cmd = new SQLiteCommand(con))
                    {
                        string query = "DELETE FROM livre where title=@Title";
                        cmd.CommandText = query;
                        cmd.Parameters.AddWithValue("@Title", title_txt.Text);
                        int rowsAffected = cmd.ExecuteNonQuery();
                        // Check if any row was actually deleted
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("The book has been deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("No book found with the given title to delete.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                }

                dataGridView1.Rows.Clear();
                data_show();// Refresh data in dataGridView1
            }
            catch (Exception ex)
            {
                //Console.WriteLine("cannot delete data");
                //return;
                MessageBox.Show("Cannot delete data. Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
        
