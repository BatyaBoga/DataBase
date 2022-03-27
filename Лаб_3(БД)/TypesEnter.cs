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
    public partial class TypesEnter : Form
    {
        public TypesEnter()
        {
            InitializeComponent();
        }

        private void тип_підприємстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.тип_підприємстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);

        }

        private void TypesEnter_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Тип_підприємства". При необходимости она может быть перемещена или удалена.
            this.тип_підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Тип_підприємства);
            showData();
        }

        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Тип підприємства"].Rows[тип_підприємстваBindingSource.Position];

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

                DataRow dr = каталог_підприємствDataSet.Tables["Тип підприємства"].NewRow();

                dr[0] = maskedTextBox2.Text;
                dr[1] = textBox2.Text;
                dr[2] = richTextBox2.Text;

                каталог_підприємствDataSet.Tables["Тип підприємства"].Rows.Add(dr);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void тип_підприємстваDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            тип_підприємстваBindingSource.Position++;
            showData();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            тип_підприємстваBindingSource.Position--;
            showData();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Тип підприємства"].Rows[тип_підприємстваBindingSource.Position]; 

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
            DataRow dr = каталог_підприємствDataSet.Tables["Тип підприємства"].Rows[тип_підприємстваBindingSource.Position];
            dr.Delete();
        }

        private void TypesEnter_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in каталог_підприємствDataSet.Tables["Тип підприємства"].Rows)
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
            DataRow dr = каталог_підприємствDataSet.Tables["Тип підприємства"].Rows.Find(maskedTextBox3.Text);
            if (dr != null)
                textBox3.Text = dr[1].ToString();
            else
                MessageBox.Show("Not found");
        }
    }
}
