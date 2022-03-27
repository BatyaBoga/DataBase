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
    public partial class Activities : Form
    {
        public Activities()
        {
            InitializeComponent();
        }

        private void діяльності_підприємстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.діяльності_підприємстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);

        }

        private void Activities_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Вид_діяльності". При необходимости она может быть перемещена или удалена.
            this.вид_діяльностіTableAdapter.Fill(this.каталог_підприємствDataSet.Вид_діяльності);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Діяльності_підприємства". При необходимости она может быть перемещена или удалена.
            this.діяльності_підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Діяльності_підприємства);
            showData();

            
        }


        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Діяльності підприємства"].Rows[діяльності_підприємстваBindingSource.Position];
              
                maskedTextBox2.Text = dr[0].ToString();
                textBox1.Text = dr[1].ToString();
                checkBox2.Checked = Convert.ToBoolean(dr[2]);


        

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

                DataRow dr = каталог_підприємствDataSet.Tables["Діяльності підприємства"].Rows[діяльності_підприємстваBindingSource.Position];

                dr[0] = maskedTextBox2.Text;
                dr[1] = textBox1.Text;
                dr[2] = checkBox2.Checked;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            діяльності_підприємстваBindingSource.Position++;
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            діяльності_підприємстваBindingSource.Position--;
            showData();
        }

        private void діяльності_підприємстваDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Діяльності підприємства"].NewRow();

                dr[0] = maskedTextBox2.Text  ;
                dr[1] = textBox1.Text ;
                dr[2] = checkBox2.Checked;


                каталог_підприємствDataSet.Tables["Діяльності підприємства"].Rows.Add(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Activities_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in каталог_підприємствDataSet.Tables["Діяльності підприємства"].Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                {
                    e.Cancel = true;
                    MessageBox.Show("Save data!");
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Діяльності підприємства"].Rows[діяльності_підприємстваBindingSource.Position]; 
            dr.Delete();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            /*
            DataRow[] dr = каталог_підприємствDataSet.Tables["Діяльності підприємства"].Select("[ЄДРПОУ] like '%" + textBox3.Text + "%' ");

            foreach (DataRow fr in dr)
            {
                MessageBox.Show(fr[0].ToString() + " " + fr[1].ToString());
            }
            */

        }
    }
}
