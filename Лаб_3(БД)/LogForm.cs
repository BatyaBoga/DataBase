using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лаб_3_БД_
{
    public partial class LogForm : Form
    {
        public LogForm()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void LogForm_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.UsersInfo". При необходимости она может быть перемещена или удалена.
            this.usersInfoTableAdapter.Fill(this.каталог_підприємствDataSet.UsersInfo);

            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow[] dr = каталог_підприємствDataSet.UsersInfo.Select("[Логін] = '" + textBox1.Text + "' and [Пароль] = '" + textBox2.Text + "'");
                if (Convert.ToInt32(dr[0][2]) == 222)  //user
                {
                    DialogResult = DialogResult.No;
                    MessageBox.Show("Welcome, user !");
                }
                if (Convert.ToInt32(dr[0][2]) == 111)  //admin
                {
                    DialogResult = DialogResult.Yes;
                    MessageBox.Show("Nice to meet you, Admin !");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("!!! INCORRECT DATA !!! ");
            }
        }
    }
}
