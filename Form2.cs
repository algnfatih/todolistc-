using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite; //using SQLite
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace TodoList
{

    public partial class Form2 : Form
    {

        public static string kadi;

        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;



        public Form2()
        {

            InitializeComponent();

             con = new SQLiteConnection("Data Source=todolist.db;Version=3;");
            // con = new SQLiteConnection("Data Source=C:\\Users\\root\\Desktop\\csharp\\todolist.db;Version=3;");

            da = new SQLiteDataAdapter("Select * From users", con);
            ds = new DataSet();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            SQLiteDataReader myReader;


            cmd = new SQLiteCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * from users where kadi ='" + textBox1.Text + "' and pass ='" + textBox2.Text + "'  ";

            myReader = cmd.ExecuteReader();

            int count = 0;
            while (myReader.Read()) {

                count =+ 1;

            }

            if (count == 1) {

                myReader.Close();
                cmd.ExecuteNonQuery();
                con.Close();


                Form ikinci_form;

                kadi = textBox1.Text;

                this.Hide();

                ikinci_form = new Form1();
                ikinci_form.Show();
                

            }

            else
            {
                myReader.Close();
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Lütfen kullanıcı adı veya şifrenizi kontrol ediniz!", "Hata");

                textBox1.BackColor = Color.Yellow;
                textBox2.BackColor = Color.Yellow;
            }


        }
    }
}
