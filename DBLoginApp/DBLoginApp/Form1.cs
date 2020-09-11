using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DBLoginApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection sqlcon = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\user\source\repos\DBLoginApp\DBLoginApp\LoginDB.mdf;Integrated Security=True");
            // LoginApp 데이터베이스 서버 연결 변수를 선언
            string query = "SELECT * FROM Login WHERE Username='" + textBox1.Text.Trim() + "'" + "and Password='"+textBox2.Text.Trim()+"'";
            // textBox1,2에 입력한 값으로 위 sql문을 query변수에 삽입

            SqlDataAdapter sba = new SqlDataAdapter(query, sqlcon); //query(sql문),sqlcon(LoginApp 데이베이스 서버 주소(?)를 매개변수로 
            DataTable dtbl = new DataTable();
            sba.Fill(dtbl); // ??
            if(dtbl.Rows.Count == 1)
            {
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show(); // Form2 웹페이지(완료 페이지) 출현

            }
            else
            {
                MessageBox.Show("이름과 비밀번호를 체크하세요.");
            }
        }
    }
}
