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


namespace TodoList
{



    public partial class Form1 : Form
    {


        SQLiteConnection con;
        SQLiteDataAdapter da;
        SQLiteCommand cmd;
        DataSet ds;

        public string durum = "";



        public Form1()
        {

            InitializeComponent();



            GetList();


        }

        void GetList()
        {

             con = new SQLiteConnection("Data Source=todolist.db;Version=3;");
            // con = new SQLiteConnection("Data Source=C:\\Users\\root\\Desktop\\csharp\\todolist.db;Version=3;");

            da = new SQLiteDataAdapter("Select * From todolist where kadi='" + Form2.kadi + "'", con);
            ds = new DataSet();

            con.Open();
            da.Fill(ds, "todolist");
            dataGridView1.DataSource = ds.Tables["todolist"];
            con.Close();

            

        }


        void CheckBox1()
        {
            if (checkBox1.Checked)
            {
                durum = "Tamamland�";
            }
            else
            {
                durum = "Bekliyor";
            }
        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckBox1();

            if ((textBox2.Text != String.Empty || textBox2.Text != "") && (textBox3.Text != String.Empty || textBox3.Text != ""))
            {
                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "insert into todolist(baslik,aciklama,tarih,durum, kadi) values ('" + textBox2.Text + "','" + textBox3.Text + "', '" + dateTimePicker1.Text + "',  '" + durum + "', '" + Form2.kadi + "')";
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();

                textBox2.BackColor = SystemColors.Window;
                textBox3.BackColor = SystemColors.Window;

                MessageBox.Show("��erikler Ba�ar�yla Eklendi!", "Ba�ar�l�");
            }

            else
            {
                MessageBox.Show("Ba�l�k veya A��klama bo� b�rak�lamaz!", "Hata");
                textBox2.BackColor = Color.Yellow;
                textBox3.BackColor = Color.Yellow;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            CheckBox1();

            if (textBox1.Text != String.Empty || textBox1.Text != "")
            {

                textBox1.BackColor = SystemColors.Window;

                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "update todolist set baslik='" + textBox2.Text + "',aciklama='" + textBox3.Text + "', tarih='" + dateTimePicker1.Text + "' , durum='" + durum + "' where ID='" + textBox1.Text + "' and kadi='" + Form2.kadi + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();

                MessageBox.Show("��erikler Ba�ar�yla D�zenlendi!", "Ba�ar�l�");
            }
            else
            {
                MessageBox.Show("id Alan� bo� b�rak�lamaz!", "Hata");
                textBox1.BackColor = Color.Yellow;
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox1.Text != "" || textBox1.Text != String.Empty)
            {

                textBox1.BackColor = SystemColors.Window;

                cmd = new SQLiteCommand();
                con.Open();
                cmd.Connection = con;
                cmd.CommandText = "delete from todolist where ID='" + textBox1.Text + "' and kadi='" + Form2.kadi + "'";
                cmd.ExecuteNonQuery();
                con.Close();
                GetList();

                MessageBox.Show("��erikler ba�ar� ile silindi!", "Ba�ar�l�");
            }

            else
            {
                textBox1.BackColor = Color.Yellow;

                MessageBox.Show("id Alan� Bo� b�rak�lamaz!", "Hata");
            }

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";

            dateTimePicker1.Value = DateTime.Today;

            checkBox1.Checked = false;

            MessageBox.Show("Form temizlendi!", "Ba�ar�l�");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Hide();

            Form ilk_form;


            ilk_form = new Form2();
            ilk_form.Show();
            
        }
    }
}
