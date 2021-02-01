using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaOrdering
{
    public partial class Form4 : Form
    {
        private double totalPrice;
        private int amount;

        public Form4(int cheese, int pepperoni, int sausage, int supreme, double total)
        {
            InitializeComponent();
            totalPrice = total;
            amount = cheese + pepperoni + sausage + supreme;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                string localFirst = textBox1.Text;
                string localLast = textBox2.Text;
                string localCard = textBox3.Text;
                int localCode = Int32.Parse(textBox4.Text);
                string localUser = textBox5.Text;
                string localPassword = textBox6.Text;
                string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";
                MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);
                try
                {
                    Console.WriteLine("Connecting to MySQL...");
                    conn.Open();
                    string sql = "UPDATE cunaginorder SET cunaginorder.cardnumber = @ucard, cunaginorder.seccode = @ucode WHERE username = @uuser AND password = @upass;" +
                    "INSERT INTO cunaginorder (amount, quantity) VALUES (@total, @amount);";
                    MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@ufirst", localFirst);
                    cmd.Parameters.AddWithValue("@ulast", localLast);
                    cmd.Parameters.AddWithValue("@ucard", localCard);
                    cmd.Parameters.AddWithValue("@ucode", localCode);
                    cmd.Parameters.AddWithValue("@uuser", localUser);
                    cmd.Parameters.AddWithValue("@upass", localPassword);
                    cmd.Parameters.AddWithValue("@total", totalPrice);
                    cmd.Parameters.AddWithValue("@amount", amount);
                cmd.ExecuteNonQuery();
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.ToString());
                    }
                    conn.Close();
                    Console.WriteLine("Done.");
            }


        }
    }

