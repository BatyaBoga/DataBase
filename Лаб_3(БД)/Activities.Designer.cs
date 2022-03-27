namespace Лаб_3_БД_
{
    partial class Activities
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Activities));
            this.каталог_підприємствDataSet = new Лаб_3_БД_.Каталог_підприємствDataSet();
            this.діяльності_підприємстваBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.діяльності_підприємстваTableAdapter = new Лаб_3_БД_.Каталог_підприємствDataSetTableAdapters.Діяльності_підприємстваTableAdapter();
            this.tableAdapterManager = new Лаб_3_БД_.Каталог_підприємствDataSetTableAdapters.TableAdapterManager();
            this.діяльності_підприємстваBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.діяльності_підприємстваBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.діяльності_підприємстваDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.видДіяльностіBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.maskedTextBox2 = new System.Windows.Forms.MaskedTextBox();
            this.вид_діяльностіTableAdapter = new Лаб_3_БД_.Каталог_підприємствDataSetTableAdapters.Вид_діяльностіTableAdapter();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.button6 = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.каталог_підприємствDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваBindingNavigator)).BeginInit();
            this.діяльності_підприємстваBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваDataGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видДіяльностіBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // каталог_підприємствDataSet
            // 
            this.каталог_підприємствDataSet.DataSetName = "Каталог_підприємствDataSet";
            this.каталог_підприємствDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // діяльності_підприємстваBindingSource
            // 
            this.діяльності_підприємстваBindingSource.DataMember = "Діяльності підприємства";
            this.діяльності_підприємстваBindingSource.DataSource = this.каталог_підприємствDataSet;
            // 
            // діяльності_підприємстваTableAdapter
            // 
            this.діяльності_підприємстваTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = Лаб_3_БД_.Каталог_підприємствDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.Вид_діяльностіTableAdapter = null;
            this.tableAdapterManager.Діяльності_підприємстваTableAdapter = this.діяльності_підприємстваTableAdapter;
            this.tableAdapterManager.КерівникиTableAdapter = null;
            this.tableAdapterManager.Населені_пунктиTableAdapter = null;
            this.tableAdapterManager.Ошибки_вставкиTableAdapter = null;
            this.tableAdapterManager.ПідприємстваTableAdapter = null;
            this.tableAdapterManager.Тип_підприємстваTableAdapter = null;
            // 
            // діяльності_підприємстваBindingNavigator
            // 
            this.діяльності_підприємстваBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.діяльності_підприємстваBindingNavigator.BindingSource = this.діяльності_підприємстваBindingSource;
            this.діяльності_підприємстваBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.діяльності_підприємстваBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.діяльності_підприємстваBindingNavigator.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.діяльності_підприємстваBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.діяльності_підприємстваBindingNavigatorSaveItem});
            this.діяльності_підприємстваBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.діяльності_підприємстваBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.діяльності_підприємстваBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.діяльності_підприємстваBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.діяльності_підприємстваBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.діяльності_підприємстваBindingNavigator.Name = "діяльності_підприємстваBindingNavigator";
            this.діяльності_підприємстваBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.діяльності_підприємстваBindingNavigator.Size = new System.Drawing.Size(936, 25);
            this.діяльності_підприємстваBindingNavigator.TabIndex = 0;
            this.діяльності_підприємстваBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(48, 22);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            this.bindingNavigatorMovePreviousItem.Click += new System.EventHandler(this.button1_Click);
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 8.830189F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            this.bindingNavigatorMoveNextItem.Click += new System.EventHandler(this.button2_Click);
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(25, 22);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // діяльності_підприємстваBindingNavigatorSaveItem
            // 
            this.діяльності_підприємстваBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.діяльності_підприємстваBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("діяльності_підприємстваBindingNavigatorSaveItem.Image")));
            this.діяльності_підприємстваBindingNavigatorSaveItem.Name = "діяльності_підприємстваBindingNavigatorSaveItem";
            this.діяльності_підприємстваBindingNavigatorSaveItem.Size = new System.Drawing.Size(25, 22);
            this.діяльності_підприємстваBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.діяльності_підприємстваBindingNavigatorSaveItem.Click += new System.EventHandler(this.діяльності_підприємстваBindingNavigatorSaveItem_Click);
            // 
            // діяльності_підприємстваDataGridView
            // 
            this.діяльності_підприємстваDataGridView.AutoGenerateColumns = false;
            this.діяльності_підприємстваDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.діяльності_підприємстваDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewCheckBoxColumn1});
            this.діяльності_підприємстваDataGridView.DataSource = this.діяльності_підприємстваBindingSource;
            this.діяльності_підприємстваDataGridView.Location = new System.Drawing.Point(0, 28);
            this.діяльності_підприємстваDataGridView.Name = "діяльності_підприємстваDataGridView";
            this.діяльності_підприємстваDataGridView.RowHeadersWidth = 45;
            this.діяльності_підприємстваDataGridView.Size = new System.Drawing.Size(346, 330);
            this.діяльності_підприємстваDataGridView.TabIndex = 1;
            this.діяльності_підприємстваDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.діяльності_підприємстваDataGridView_CellClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ЄДРПОУ";
            this.dataGridViewTextBoxColumn1.HeaderText = "ЄДРПОУ";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 110;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Код";
            this.dataGridViewTextBoxColumn2.HeaderText = "Код";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Основна діяльність";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Основна діяльність";
            this.dataGridViewCheckBoxColumn1.MinimumWidth = 6;
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            this.dataGridViewCheckBoxColumn1.Width = 110;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Location = new System.Drawing.Point(352, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(283, 131);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Automatic";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.діяльності_підприємстваBindingSource, "Код", true));
            this.comboBox1.DataSource = this.видДіяльностіBindingSource;
            this.comboBox1.DisplayMember = "Назва";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(6, 76);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(265, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "Код";
            // 
            // видДіяльностіBindingSource
            // 
            this.видДіяльностіBindingSource.DataMember = "Вид діяльності";
            this.видДіяльностіBindingSource.DataSource = this.каталог_підприємствDataSet;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.діяльності_підприємстваBindingSource, "Основна діяльність", true));
            this.checkBox1.Location = new System.Drawing.Point(6, 103);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(124, 17);
            this.checkBox1.TabIndex = 5;
            this.checkBox1.Text = "Основна діяльність";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вид діяльності";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "ЄДРПОУ";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.діяльності_підприємстваBindingSource, "ЄДРПОУ", true));
            this.maskedTextBox1.Location = new System.Drawing.Point(6, 37);
            this.maskedTextBox1.Mask = "0000000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button4);
            this.groupBox2.Controls.Add(this.button3);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.checkBox2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.maskedTextBox2);
            this.groupBox2.Location = new System.Drawing.Point(352, 200);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(283, 158);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Manual";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(9, 77);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(262, 20);
            this.textBox1.TabIndex = 13;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(66, 126);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(55, 23);
            this.button5.TabIndex = 12;
            this.button5.Text = "Delete";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(127, 126);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(56, 23);
            this.button4.TabIndex = 11;
            this.button4.Text = "Edit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(0, 126);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(60, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Add";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(242, 126);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(25, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(211, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(25, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(6, 103);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(124, 17);
            this.checkBox2.TabIndex = 5;
            this.checkBox2.Text = "Основна діяльність";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 60);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Вид діяльності";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(54, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "ЄДРПОУ";
            // 
            // maskedTextBox2
            // 
            this.maskedTextBox2.Location = new System.Drawing.Point(6, 37);
            this.maskedTextBox2.Mask = "0000000";
            this.maskedTextBox2.Name = "maskedTextBox2";
            this.maskedTextBox2.Size = new System.Drawing.Size(100, 20);
            this.maskedTextBox2.TabIndex = 0;
            // 
            // вид_діяльностіTableAdapter
            // 
            this.вид_діяльностіTableAdapter.ClearBeforeFill = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.textBox3);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Controls.Add(this.button6);
            this.groupBox3.Location = new System.Drawing.Point(641, 28);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(289, 131);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Пошук";
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 50);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 23);
            this.button6.TabIndex = 9;
            this.button6.Text = "Пошук";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(6, 79);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(262, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(6, 24);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(131, 20);
            this.textBox3.TabIndex = 15;
            // 
            // Activities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 370);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.діяльності_підприємстваDataGridView);
            this.Controls.Add(this.діяльності_підприємстваBindingNavigator);
            this.Name = "Activities";
            this.Text = "Діяльності підприємств";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Activities_FormClosing);
            this.Load += new System.EventHandler(this.Activities_Load);
            ((System.ComponentModel.ISupportInitialize)(this.каталог_підприємствDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваBindingNavigator)).EndInit();
            this.діяльності_підприємстваBindingNavigator.ResumeLayout(false);
            this.діяльності_підприємстваBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.діяльності_підприємстваDataGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.видДіяльностіBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Каталог_підприємствDataSet каталог_підприємствDataSet;
        private System.Windows.Forms.BindingSource діяльності_підприємстваBindingSource;
        private Каталог_підприємствDataSetTableAdapters.Діяльності_підприємстваTableAdapter діяльності_підприємстваTableAdapter;
        private Каталог_підприємствDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator діяльності_підприємстваBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton діяльності_підприємстваBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView діяльності_підприємстваDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox maskedTextBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.BindingSource видДіяльностіBindingSource;
        private Каталог_підприємствDataSetTableAdapters.Вид_діяльностіTableAdapter вид_діяльностіTableAdapter;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
    }
}