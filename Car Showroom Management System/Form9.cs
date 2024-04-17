using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Car_Showroom_Management_System
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        string connectionString = "datasource=127.0.0.1;port=3306;username=root;password=;database=car;";

        private void add_car()
        {
            string query = "INSERT INTO car_details(body_style, segment, fuel, size, purpose, brand) VALUES ('" + textBox1.Text + "','" + textBox6.Text + "','" + textBox5.Text + "','" + textBox4.Text + "','" + textBox2.Text + "','" + textBox3.Text + "')";

            MySqlConnection databaseConnection = new MySqlConnection(connectionString);
            MySqlCommand commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;
            MySqlDataReader reader;



            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            query = "SELECT * FROM car_details WHERE body_style='" + textBox1.Text + "'AND segment='" + textBox6.Text + "' AND fuel='" + textBox5.Text + "' AND size='" + textBox4.Text + "' AND purpose='" + textBox2.Text + "' AND brand='" + textBox3.Text + "'";

            databaseConnection = new MySqlConnection(connectionString);
            commandDatabase = new MySqlCommand(query, databaseConnection);
            commandDatabase.CommandTimeout = 60;


            try
            {
                databaseConnection.Open();
                reader = commandDatabase.ExecuteReader();

                if (reader.HasRows)
                {
                    MessageBox.Show("Sucesfully inserted");
                    Form3 f3 = new Form3();
                    f3.Show();
                    this.Hide();

                }
                else
                {
                    MessageBox.Show("ERROR!!");
                }
                databaseConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            add_car();
        }
    }
}
