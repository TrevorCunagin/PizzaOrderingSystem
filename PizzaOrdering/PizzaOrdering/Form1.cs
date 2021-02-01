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

namespace PizzaOrdering
{
    public partial class Form1 : Form
    {
        int shoppingCartItem = 0;
        String shoppingCartTitle = "";
        int cheese = 0;
        int pepperoni = 0;
        int sausage = 0;
        int supreme = 0;
        double total = 0;

        public Form1()
        {
            InitializeComponent();
        }
        public delegate void delPassData(TextBox text);

        //supreme pizza button
        private void button1_Click(object sender, EventArgs e)
        {
            shoppingCartItem++;
            supreme++;
            total += 9.99;
            label1.Text = shoppingCartTitle + shoppingCartItem;

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE cunaginpizza SET inventory = inventory - 1 WHERE name = 'Supreme'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

       

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        //cheese pizza button
        private void button3_Click(object sender, EventArgs e)
        {
            shoppingCartItem++;
            cheese++;
            total += 7.99;
            label1.Text = shoppingCartTitle + shoppingCartItem;

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE cunaginpizza SET inventory = inventory - 1 WHERE name = 'Cheese'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }

        

        //login button
        private void button7_Click(object sender, EventArgs e)
        {
            var form2 = new Form2();
            form2.Show();
        }
        //check order status button
        private void button2_Click(object sender, EventArgs e)
        {
            var form3 = new Form3(cheese, pepperoni, sausage, supreme, total);
            form3.Show();
        }
        //checkout button
        private void button4_Click(object sender, EventArgs e)
        {
            var form4 = new Form4(cheese, pepperoni, sausage, supreme, total);
            form4.Show();
        }
        //sausage pizza button
        private void button5_Click(object sender, EventArgs e)
        {
            shoppingCartItem++;
            sausage++;
            total += 8.99;
            label1.Text = shoppingCartTitle + shoppingCartItem;

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE cunaginpizza SET inventory = inventory - 1 WHERE name = 'Sausage'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            conn.Close();
            Console.WriteLine("Done.");
        }
        //pepperoni pizza button
        private void button6_Click(object sender, EventArgs e)
        {
            shoppingCartItem++;
            pepperoni++;
            total += 8.99;
            label1.Text = shoppingCartTitle + shoppingCartItem;

            string connStr = "server=157.89.28.130;user=ChangK;database=csc340;port=3306;password=Wallace#409;";

            MySql.Data.MySqlClient.MySqlConnection conn = new MySql.Data.MySqlClient.MySqlConnection(connStr);

            try
            {

                Console.WriteLine("Connecting to MySQL...");
                conn.Open();
                string sql = "UPDATE cunaginpizza SET inventory = inventory - 1 WHERE name = 'Pepperoni'";
                MySql.Data.MySqlClient.MySqlCommand cmd = new MySql.Data.MySqlClient.MySqlCommand(sql, conn);

                MySqlDataReader myReader = cmd.ExecuteReader();

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
