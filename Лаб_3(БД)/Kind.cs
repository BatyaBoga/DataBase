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
    public partial class Kind : Form
    {
        public Kind()
        {
            InitializeComponent();
        }

        private void вид_діяльностіBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.вид_діяльностіBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);

        }

        private void Kind_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Вид_діяльності". При необходимости она может быть перемещена или удалена.
            this.вид_діяльностіTableAdapter.Fill(this.каталог_підприємствDataSet.Вид_діяльності);
            showData();
        }
        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Вид діяльності"].Rows[вид_діяльностіBindingSource.Position];

                maskedTextBox2.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                richTextBox2.Text = dr[2].ToString();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Вид діяльності"].NewRow();

                dr[0] = maskedTextBox2.Text;
                dr[1] = textBox2.Text;
                dr[2] = richTextBox2.Text;

                каталог_підприємствDataSet.Tables["Вид діяльності"].Rows.Add(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void вид_діяльностіDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            вид_діяльностіBindingSource.Position++;
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            вид_діяльностіBindingSource.Position--;
            showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Вид діяльності"].Rows[вид_діяльностіBindingSource.Position];

                dr[0] = maskedTextBox2.Text;
                dr[1] = textBox2.Text;
                dr[2] = richTextBox2.Text;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Вид діяльності"].Rows[вид_діяльностіBindingSource.Position];
            dr.Delete();
        }

        private void Kind_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in каталог_підприємствDataSet.Tables["Вид діяльності"].Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                {
                    e.Cancel = true;
                    MessageBox.Show("Save data!");
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Каталог_підприємствDataSet.Вид_діяльностіRow dr = каталог_підприємствDataSet.Вид_діяльності.FindByКод((maskedTextBox3.Text).ToString());
            if (dr != null)
                MessageBox.Show(dr[1].ToString());
            else
                MessageBox.Show("Not found");

            
        }

        
    }
}
