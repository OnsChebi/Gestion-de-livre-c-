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
            var con = new SQLiteConnection(cs);
            con.Open();
            var cmd = new SQLiteCommand(con);
            try
            {
                cmd.CommandText = "INSERT INTO livre(title, author, isbn) VALUES(@title, @author, @isbn)";
                string title = title_txt.Text;
                string author = author_txt.Text;
                string isbn = isbn_txt.Text;

                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@author", author);
                cmd.Parameters.AddWithValue("@isbn", isbn);

                dataGridView1.ColumnCount = 3;
               
                string[] row = new string[] { title, author, isbn };
                dataGridView1.Rows.Add(row);

                cmd.ExecuteNonQuery();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot insert data");
                return;
            }

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
            string query = "UPDATE livre Set isbn=@isbn where title=@title";

            using (SQLiteConnection conn = new SQLiteConnection(connectionString))
            {
                conn.Open();

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@isbn", isbn_txt.Text);
                    cmd.Parameters.AddWithValue("@title", title_txt.Text);

                    cmd.ExecuteNonQuery();
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
                        cmd.ExecuteNonQuery(); // This line has been changed
                    }
                }

                dataGridView1.Rows.Clear();
                data_show();
            }
            catch (Exception)
            {
                Console.WriteLine("cannot delete data");
                return;
            }
        }
    }
}
        
