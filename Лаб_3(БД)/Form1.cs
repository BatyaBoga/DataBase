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
    public partial class fEnterprises : Form
    {
        
        public fEnterprises()
        {
            InitializeComponent();
        }

        private void підприємстваBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.підприємстваBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.каталог_підприємствDataSet);
            this.підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Підприємства); 

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Тип_підприємства". При необходимости она может быть перемещена или удалена.
            this.тип_підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Тип_підприємства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Керівники". При необходимости она может быть перемещена или удалена.
            this.керівникиTableAdapter.Fill(this.каталог_підприємствDataSet.Керівники);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Населені_пункти". При необходимости она может быть перемещена или удалена.
            this.населені_пунктиTableAdapter.Fill(this.каталог_підприємствDataSet.Населені_пункти);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Діяльності_підприємства". При необходимости она может быть перемещена или удалена.
            this.діяльності_підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Діяльності_підприємства);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "каталог_підприємствDataSet.Підприємства". При необходимости она может быть перемещена или удалена.
            this.підприємстваTableAdapter.Fill(this.каталог_підприємствDataSet.Підприємства);
            showData();

            comboBox7.Items.Clear();
            comboBox8.Items.Clear();
            comboBox9.Items.Clear();    



            for (int i = 0; i < каталог_підприємствDataSet.Населені_пункти.Rows.Count; i++)
            {
                comboBox7.Items.Add(каталог_підприємствDataSet.Населені_пункти.Rows[i][1]);
            }

            for (int i = 0; i < каталог_підприємствDataSet.Керівники.Rows.Count; i++)
            {
                comboBox8.Items.Add(каталог_підприємствDataSet.Керівники.Rows[i][1]);
            }
            for (int i = 0; i < каталог_підприємствDataSet.Тип_підприємства.Rows.Count; i++)
            {
                comboBox9.Items.Add(каталог_підприємствDataSet.Тип_підприємства.Rows[i][1]);
            }

            var dr_kp = каталог_підприємствDataSet.Підприємства.Rows[0];

            var dr_np = каталог_підприємствDataSet.Населені_пункти.Select("[Код] = '" + dr_kp[3].ToString()+"'");
            comboBox7.SelectedIndex = comboBox7.FindString(dr_np[0][1].ToString());

            var dr_kerivnuk = каталог_підприємствDataSet.Керівники.Select("[Код] = '" + dr_kp[5].ToString() + "'");
            comboBox8.SelectedIndex = comboBox8.FindString(dr_kerivnuk[0][1].ToString());

            var dr_tippdriy = каталог_підприємствDataSet.Тип_підприємства.Select("[Код] = '" + dr_kp[10].ToString() + "'");
            comboBox9.SelectedIndex = comboBox9.FindString(dr_tippdriy[0][1].ToString());




        }

        private void showData()
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].Rows[підприємстваBindingSource.Position];

                maskedTextBox4.Text = dr[0].ToString();
                textBox10.Text = dr[1].ToString();
                richTextBox2.Text = dr[2].ToString();
                textBox9.Text = dr[4].ToString();
                textBox8.Text = dr[6].ToString();
                textBox7.Text = dr[7].ToString();
                maskedTextBox3.Text = dr[8].ToString();
                textBox6.Text = dr[9].ToString();

                
                var dr_np = каталог_підприємствDataSet.Населені_пункти.Select("[Код] = '" + dr[3].ToString() + "'");
                comboBox7.SelectedIndex = comboBox7.FindString(dr_np[0][1].ToString());

                var dr_kerivnuk = каталог_підприємствDataSet.Керівники.Select("[Код] = '" + dr[5].ToString() + "'");
                comboBox8.SelectedIndex = comboBox8.FindString(dr_kerivnuk[0][1].ToString());

                var dr_tippdriy = каталог_підприємствDataSet.Тип_підприємства.Select("[Код] = '" + dr[10].ToString() + "'");
                comboBox9.SelectedIndex = comboBox9.FindString(dr_tippdriy[0][1].ToString());


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void типToolStripMenuItem_Click(object sender, EventArgs e)
        {
            TypesEnter te = new TypesEnter();
            te.ShowDialog();
        }

        private void керівникиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Leaders ld = new Leaders();
            ld.ShowDialog();
        }

        private void населеніПунктиToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Settlements st = new Settlements();
            st.ShowDialog();
        }

        private void діяльностіПідприємствToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Activities at = new Activities();
            at.ShowDialog();
        }

        private void видДіяльностіToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kind kd = new Kind();
            kd.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            підприємстваBindingSource.Position++;
            showData();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            підприємстваBindingSource.Position--;
            showData();
        }

        private void підприємстваDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            showData();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].Rows[підприємстваBindingSource.Position];
            dr.Delete();
        }

        private void fEnterprises_FormClosing(object sender, FormClosingEventArgs e)
        {
            foreach (DataRow dr in каталог_підприємствDataSet.Tables["Підприємства"].Rows)
            {
                if (dr.RowState != DataRowState.Unchanged)
                {
                    e.Cancel = true;
                    MessageBox.Show("Save data!");
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].NewRow();
                DataRow[] dr_np = каталог_підприємствDataSet.Населені_пункти.Select("[Назва] = '" + comboBox7.SelectedItem.ToString() + "'");
                DataRow[] dr_kerivnuk = каталог_підприємствDataSet.Керівники.Select("[ПІП] = '" + comboBox8.SelectedItem.ToString() + "'");
                DataRow[] dr_tippdriy = каталог_підприємствDataSet.Тип_підприємства.Select("[Назва] = '" + comboBox9.SelectedItem.ToString() + "'");

                dr[0]= maskedTextBox4.Text;
                dr[1] = textBox10.Text ;
                dr[2] = richTextBox2.Text;
                dr[3] = dr_np[0][0];
                dr[4] = textBox9.Text;
                dr[5] = dr_kerivnuk[0][0];
                dr[6] = textBox8.Text;
                dr[7] = textBox7.Text;
                dr[8] = maskedTextBox3.Text;
                dr[9] = textBox6.Text;
                dr[10] = dr_tippdriy[0][0];


                підприємстваBindingNavigatorSaveItem_Click(sender, e);

                каталог_підприємствDataSet.Tables["Підприємства"].Rows.Add(dr);

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
               // var j = підприємстваDataGridView.CurrentCellAddress;
                
                DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].Rows[підприємстваBindingSource.Position];
                DataRow[] dr_np = каталог_підприємствDataSet.Населені_пункти.Select("[Назва] = '" + comboBox7.SelectedItem.ToString() + "'");
                DataRow[] dr_kerivnuk = каталог_підприємствDataSet.Керівники.Select("[ПІП] = '" + comboBox8.SelectedItem.ToString() + "'");
                DataRow[] dr_tippdriy = каталог_підприємствDataSet.Тип_підприємства.Select("[Назва] = '" + comboBox9.SelectedItem.ToString() + "'");

                dr[0] = maskedTextBox4.Text;
                dr[1] = textBox10.Text;
                dr[2] = richTextBox2.Text;
                dr[3] = dr_np[0][0];
                dr[4] = textBox9.Text;
                dr[5] = dr_kerivnuk[0][0];
                dr[6] = textBox8.Text;
                dr[7] = textBox7.Text;
                dr[8] = maskedTextBox3.Text;
                dr[9] = textBox6.Text;
                dr[10] = dr_tippdriy[0][0];


                підприємстваBindingNavigatorSaveItem_Click(sender, e);
               
               // this.підприємстваDataGridView.CurrentCell= підприємстваDataGridView[j.X, j.Y]; ;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].Rows.Find(textBox14.Text);
            if (dr != null)
                textBox15.Text = dr[1].ToString();
            else
                MessageBox.Show("Not found");

        }

        private void button7_Click(object sender, EventArgs e)
        {
            Каталог_підприємствDataSet.ПідприємстваRow dr = каталог_підприємствDataSet.Підприємства.FindByЄДРПОУ(Convert.ToInt32(maskedTextBox5.Text));
            if (dr != null)
                MessageBox.Show(dr[1].ToString());
            else
                MessageBox.Show("Not found");

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataRow[] dr = каталог_підприємствDataSet.Tables["Підприємства"].Select("[Назва] like '%" + textBox16.Text + "%' ");

            foreach (DataRow fr in dr)
            {
                MessageBox.Show(fr[0].ToString() + " " + fr[4].ToString());
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            checkBox1.Text = checkBox1.Checked == true ? "Filter ON" : "Filter OFF";
        }

        private void filterCheck(ref string filter)
        {
            if (filter != "")
            {
                filter += " AND ";

            }

        }
        private void checkBox1_CheckStateChanged(object sender, EventArgs e)
        {
            string filter = "";

            підприємстваBindingSource.Filter = "";

            if (checkBox1.Checked == true)
            {
                if (checkedListBox1.CheckedItems.Count == 0)
                {
                    підприємстваBindingSource.Filter = "";
                    MessageBox.Show("Оберіть параметри фільтрації");
                    checkBox1.Checked = false;
                }
                else
                {
                    foreach (int i in checkedListBox1.CheckedIndices)
                    {
                        switch (i)
                        {
                            case 0: filter = "[Назва] like '%" + textBox17.Text + "%' "; break;
                            case 1: filterCheck(ref filter); filter += "[Керівник] like '%" + comboBox1.SelectedValue.ToString() + "%' "; break;
                            case 2: filterCheck(ref filter); filter += "[Форма власності] like '%" + comboBox5.SelectedItem.ToString() + "%' "; break;
                            case 3: filterCheck(ref filter);  filter += "[Тип підприємства] like '%" + comboBox6.SelectedValue.ToString() + "%' "; break;
                            case 4: filterCheck(ref filter);
                                filter += "([Рік заснування] >= '" + dateTimePicker1.Text + "') AND ([Рік заснування] <= '" + dateTimePicker2.Text + "')";
                                break; 
                        }
                        
                    }
                    підприємстваBindingSource.Filter = filter;

                    if(підприємстваDataGridView.Rows.Count == 1)
                    {
                        MessageBox.Show("Елменти не знайдені");
                        підприємстваBindingSource.Filter = "";
                        checkBox1.Checked = false;
                    }
                }
               
            }
            else
            {
                підприємстваBindingSource.Filter = "";
                
            }
        }

       private void chenge_inform(object sender, EventArgs e, string name, object ds)
        {
            Information fChoice = new Information();
            DataRow dr = каталог_підприємствDataSet.Tables["Підприємства"].Rows[підприємстваBindingSource.Position];
            fChoice.dataGridView1.DataSource = ds;

            if (fChoice.ShowDialog() == DialogResult.OK)
            {
                var code_pr = fChoice.dataGridView1.CurrentRow.Cells[0].Value;
                dr[name] = code_pr;
                підприємстваBindingNavigatorSaveItem_Click(sender, e);
                showData();
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            chenge_inform(sender, e, "Населений пункт", каталог_підприємствDataSet.Населені_пункти);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            chenge_inform(sender, e, "Керівник", каталог_підприємствDataSet.Керівники);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            chenge_inform(sender, e, "Тип підприємства", каталог_підприємствDataSet.Тип_підприємства);
        }

        public LogForm lf = new LogForm();
        private void button12_Click(object sender, EventArgs e)
        {
            lf.ShowDialog();
            if (lf.DialogResult == DialogResult.Yes)//admin
            {
                menuStrip1.Enabled = true;
                підприємстваBindingNavigator.Enabled = true;
                groupBox1.Enabled = true;
                groupBox2.Enabled = true;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                button12.Visible = false;
                button13.Visible = true;
            }
            if (lf.DialogResult == DialogResult.No)//user
            {
                menuStrip1.Enabled = false;
                підприємстваBindingNavigator.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Visible = true;
                groupBox4.Visible = true;
                groupBox5.Visible = true;
                groupBox6.Visible = true;
                button12.Visible = false;
                button13.Visible = true;
            }
            if (lf.DialogResult == DialogResult.Cancel)//cancel form
            {
                menuStrip1.Enabled = false;
                підприємстваBindingNavigator.Enabled = false;
                groupBox1.Enabled = false;
                groupBox2.Enabled = false;
                groupBox3.Visible = false;
                groupBox4.Visible = false;
                groupBox5.Visible = false;
                groupBox6.Visible = false;
            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            menuStrip1.Enabled = false;
            підприємстваBindingNavigator.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
            groupBox5.Visible = false;
            groupBox6.Visible = false;
            button12.Visible = true;
            button13.Visible = false;

        }
    }
}
