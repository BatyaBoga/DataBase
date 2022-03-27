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
    public partial class Leaders : Form
    {
        public Leaders()
        {
            InitializeComponent();
        }

        private void керівникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.керівникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);

        }

        private void Leaders_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Керівники". При необходимости она может быть перемещена или удалена.
            this.керівникиTableAdapter.Fill(this.каталог_підприємствDataSet.Керівники);
            showData();

        }


        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Керівники"].Rows[керівникиBindingSource.Position];

                maskedTextBox2.Text = dr[0].ToString();
                textBox4.Text = dr[1].ToString();
                textBox3.Text = dr[2].ToString();
               richTextBox2.Text = dr[3].ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            керівникиBindingSource.Position++;
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            керівникиBindingSource.Position--;
            showData();
        }

        private void керівникиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Керівники"].NewRow();

                dr[0] = maskedTextBox2.Text;
                dr[1] = textBox4.Text;
                dr[2] = textBox3.Text;
                dr[3] = richTextBox2.Text;

                каталог_підприємствDataSet.Tables["Керівники"].Rows.Add(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
   }

        private void button4_Click(object sender, EventArgs e)
        {
            
                try
                {

                    DataRow dr = каталог_підприємствDataSet.Tables["Керівники"].Rows[керівникиBindingSource.Position];

                    dr[0] = maskedTextBox2.Text;
                    dr[1] = textBox4.Text;
                    dr[2] = textBox3.Text;
                    dr[3] = richTextBox2.Text;

                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);

                }
            }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Керівники"].Rows[керівникиBindingSource.Position];
            dr.Delete();
        }

        private void Leaders_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in каталог_підприємствDataSet.Tables["Керівники"].Rows)
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
            DataRow[] dr = каталог_підприємствDataSet.Tables["Керівники"].Select("[ПІП] like '%"+textBox6.Text+"%' ");

            foreach (DataRow fr in dr)
            {
                MessageBox.Show(fr[0].ToString() +" "+ fr[1].ToString());
            }
        }
    }
}
