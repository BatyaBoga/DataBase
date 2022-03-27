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
    public partial class Settlements : Form
    {
        public Settlements()
        {
            InitializeComponent();
        }

        private void населені_пунктиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.населені_пунктиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);

        }

        private void Settlements_Load(object sender, EventArgs e)
        {
      
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Населені_пункти". При необходимости она может быть перемещена или удалена.
            this.населені_пунктиTableAdapter.Fill(this.каталог_підприємствDataSet.Населені_пункти);
            showData();
        }

        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Населені пункти"].Rows[населеніПунктиBindingSource.Position];

                maskedTextBox3.Text = dr[0].ToString();
                textBox2.Text = dr[1].ToString();
                comboBox2.SelectedItem = dr[2].ToString();
                maskedTextBox4.Text = dr[3].ToString();
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            населеніПунктиBindingSource.Position++;
            showData();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            населеніПунктиBindingSource.Position--;
            showData();
        }

        private void населені_пунктиDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Населені пункти"].NewRow();

                dr[0] =maskedTextBox3.Text;
                dr[1] = textBox2.Text;
                dr[2] = comboBox2.SelectedItem;
                dr[3] = maskedTextBox4.Text;

                каталог_підприємствDataSet.Tables["Населені пункти"].Rows.Add(dr);

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Населені пункти"].Rows[населеніПунктиBindingSource.Position]; ;

                dr[0] = maskedTextBox3.Text;
                dr[1] = textBox2.Text;
                dr[2] = comboBox2.SelectedItem;
                dr[3] = maskedTextBox4.Text;

               

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Населені пункти"].Rows[населеніПунктиBindingSource.Position];
            dr.Delete();
        }

        private void Settlements_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach(DataRow dr in каталог_підприємствDataSet.Tables["Населені пункти"].Rows)
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
            DataRow dr = каталог_підприємствDataSet.Tables["Населені пункти"].Rows.Find(maskedTextBox5.Text);
            if (dr != null)
                textBox3.Text = dr[1].ToString();
            else
                MessageBox.Show("Not found");
           
           
        }
    }
}
