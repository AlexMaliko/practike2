namespace WindowsFormsApp1
{
    partial class Form5_Официант
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5_Официант));
            System.Windows.Forms.Label код_заказаLabel;
            System.Windows.Forms.Label столикLabel;
            System.Windows.Forms.Label количество_клиентовLabel;
            System.Windows.Forms.Label код_сменыLabel;
            System.Windows.Forms.Label количествоLabel;
            System.Windows.Forms.Label блюдоLabel;
            System.Windows.Forms.Label статусLabel1;
            this.dbDataSet = new WindowsFormsApp1.dbDataSet();
            this.заказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.заказTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ЗаказTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager();
            this.заказBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.заказBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.код_заказаTextBox = new System.Windows.Forms.TextBox();
            this.столикTextBox = new System.Windows.Forms.TextBox();
            this.количество_клиентовTextBox = new System.Windows.Forms.TextBox();
            this.код_сменыTextBox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.заказПозицииBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.позицииTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ПозицииTableAdapter();
            this.кодпозицииDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.блюдоDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.количествоTextBox = new System.Windows.Forms.TextBox();
            this.блюдоComboBox = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem1 = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem1 = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem1 = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem1 = new System.Windows.Forms.ToolStripButton();
            this.менюBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.менюTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.МенюTableAdapter();
            this.статусComboBox = new System.Windows.Forms.ComboBox();
            код_заказаLabel = new System.Windows.Forms.Label();
            столикLabel = new System.Windows.Forms.Label();
            количество_клиентовLabel = new System.Windows.Forms.Label();
            код_сменыLabel = new System.Windows.Forms.Label();
            количествоLabel = new System.Windows.Forms.Label();
            блюдоLabel = new System.Windows.Forms.Label();
            статусLabel1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).BeginInit();
            this.заказBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказПозицииBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // заказBindingSource
            // 
            this.заказBindingSource.DataMember = "Заказ";
            this.заказBindingSource.DataSource = this.dbDataSet;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.МенюTableAdapter = this.менюTableAdapter;
            this.tableAdapterManager.ПозицииTableAdapter = this.позицииTableAdapter;
            this.tableAdapterManager.СменыTableAdapter = null;
            this.tableAdapterManager.СоставTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // заказBindingNavigator
            // 
            this.заказBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.заказBindingNavigator.BindingSource = this.заказBindingSource;
            this.заказBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.заказBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.заказBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.заказBindingNavigatorSaveItem});
            this.заказBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.заказBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.заказBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.заказBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.заказBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.заказBindingNavigator.Name = "заказBindingNavigator";
            this.заказBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.заказBindingNavigator.Size = new System.Drawing.Size(1052, 25);
            this.заказBindingNavigator.TabIndex = 0;
            this.заказBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
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
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(43, 15);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // заказBindingNavigatorSaveItem
            // 
            this.заказBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.заказBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("заказBindingNavigatorSaveItem.Image")));
            this.заказBindingNavigatorSaveItem.Name = "заказBindingNavigatorSaveItem";
            this.заказBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.заказBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.заказBindingNavigatorSaveItem.Click += new System.EventHandler(this.заказBindingNavigatorSaveItem_Click);
            // 
            // код_заказаLabel
            // 
            код_заказаLabel.AutoSize = true;
            код_заказаLabel.Location = new System.Drawing.Point(12, 61);
            код_заказаLabel.Name = "код_заказаLabel";
            код_заказаLabel.Size = new System.Drawing.Size(114, 24);
            код_заказаLabel.TabIndex = 1;
            код_заказаLabel.Text = "Код заказа:";
            // 
            // код_заказаTextBox
            // 
            this.код_заказаTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Код_заказа", true));
            this.код_заказаTextBox.Location = new System.Drawing.Point(230, 58);
            this.код_заказаTextBox.Name = "код_заказаTextBox";
            this.код_заказаTextBox.Size = new System.Drawing.Size(158, 29);
            this.код_заказаTextBox.TabIndex = 2;
            // 
            // столикLabel
            // 
            столикLabel.AutoSize = true;
            столикLabel.Location = new System.Drawing.Point(12, 96);
            столикLabel.Name = "столикLabel";
            столикLabel.Size = new System.Drawing.Size(79, 24);
            столикLabel.TabIndex = 3;
            столикLabel.Text = "Столик:";
            // 
            // столикTextBox
            // 
            this.столикTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Столик", true));
            this.столикTextBox.Location = new System.Drawing.Point(230, 93);
            this.столикTextBox.Name = "столикTextBox";
            this.столикTextBox.Size = new System.Drawing.Size(158, 29);
            this.столикTextBox.TabIndex = 4;
            // 
            // количество_клиентовLabel
            // 
            количество_клиентовLabel.AutoSize = true;
            количество_клиентовLabel.Location = new System.Drawing.Point(12, 131);
            количество_клиентовLabel.Name = "количество_клиентовLabel";
            количество_клиентовLabel.Size = new System.Drawing.Size(212, 24);
            количество_клиентовLabel.TabIndex = 5;
            количество_клиентовLabel.Text = "Количество-клиентов:";
            // 
            // количество_клиентовTextBox
            // 
            this.количество_клиентовTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Количество-клиентов", true));
            this.количество_клиентовTextBox.Location = new System.Drawing.Point(230, 128);
            this.количество_клиентовTextBox.Name = "количество_клиентовTextBox";
            this.количество_клиентовTextBox.Size = new System.Drawing.Size(158, 29);
            this.количество_клиентовTextBox.TabIndex = 6;
            // 
            // код_сменыLabel
            // 
            код_сменыLabel.AutoSize = true;
            код_сменыLabel.Location = new System.Drawing.Point(12, 166);
            код_сменыLabel.Name = "код_сменыLabel";
            код_сменыLabel.Size = new System.Drawing.Size(113, 24);
            код_сменыLabel.TabIndex = 7;
            код_сменыLabel.Text = "Код смены:";
            // 
            // код_сменыTextBox
            // 
            this.код_сменыTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Код_смены", true));
            this.код_сменыTextBox.Location = new System.Drawing.Point(230, 163);
            this.код_сменыTextBox.Name = "код_сменыTextBox";
            this.код_сменыTextBox.Size = new System.Drawing.Size(158, 29);
            this.код_сменыTextBox.TabIndex = 8;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодпозицииDataGridViewTextBoxColumn,
            this.количествоDataGridViewTextBoxColumn,
            this.блюдоDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.заказПозицииBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(406, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(626, 271);
            this.dataGridView1.TabIndex = 11;
            // 
            // заказПозицииBindingSource
            // 
            this.заказПозицииBindingSource.DataMember = "ЗаказПозиции";
            this.заказПозицииBindingSource.DataSource = this.заказBindingSource;
            // 
            // позицииTableAdapter
            // 
            this.позицииTableAdapter.ClearBeforeFill = true;
            // 
            // кодпозицииDataGridViewTextBoxColumn
            // 
            this.кодпозицииDataGridViewTextBoxColumn.DataPropertyName = "Код_позиции";
            this.кодпозицииDataGridViewTextBoxColumn.HeaderText = "Позиция";
            this.кодпозицииDataGridViewTextBoxColumn.Name = "кодпозицииDataGridViewTextBoxColumn";
            this.кодпозицииDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // количествоDataGridViewTextBoxColumn
            // 
            this.количествоDataGridViewTextBoxColumn.DataPropertyName = "Количество";
            this.количествоDataGridViewTextBoxColumn.HeaderText = "Количество";
            this.количествоDataGridViewTextBoxColumn.Name = "количествоDataGridViewTextBoxColumn";
            // 
            // блюдоDataGridViewTextBoxColumn
            // 
            this.блюдоDataGridViewTextBoxColumn.DataPropertyName = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.HeaderText = "Блюдо";
            this.блюдоDataGridViewTextBoxColumn.Name = "блюдоDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.RoyalBlue;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(16, 311);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(372, 45);
            this.button1.TabIndex = 58;
            this.button1.Text = "Обновить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(16, 243);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(372, 45);
            this.button3.TabIndex = 57;
            this.button3.Text = "Сохранить";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // количествоLabel
            // 
            количествоLabel.AutoSize = true;
            количествоLabel.Location = new System.Drawing.Point(434, 343);
            количествоLabel.Name = "количествоLabel";
            количествоLabel.Size = new System.Drawing.Size(122, 24);
            количествоLabel.TabIndex = 58;
            количествоLabel.Text = "Количество:";
            // 
            // количествоTextBox
            // 
            this.количествоTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказПозицииBindingSource, "Количество", true));
            this.количествоTextBox.Location = new System.Drawing.Point(562, 340);
            this.количествоTextBox.Name = "количествоTextBox";
            this.количествоTextBox.Size = new System.Drawing.Size(100, 29);
            this.количествоTextBox.TabIndex = 59;
            // 
            // блюдоLabel
            // 
            блюдоLabel.AutoSize = true;
            блюдоLabel.Location = new System.Drawing.Point(726, 346);
            блюдоLabel.Name = "блюдоLabel";
            блюдоLabel.Size = new System.Drawing.Size(75, 24);
            блюдоLabel.TabIndex = 59;
            блюдоLabel.Text = "Блюдо:";
            // 
            // блюдоComboBox
            // 
            this.блюдоComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказПозицииBindingSource, "Блюдо", true));
            this.блюдоComboBox.DataSource = this.менюBindingSource;
            this.блюдоComboBox.DisplayMember = "Название";
            this.блюдоComboBox.FormattingEnabled = true;
            this.блюдоComboBox.Location = new System.Drawing.Point(807, 343);
            this.блюдоComboBox.Name = "блюдоComboBox";
            this.блюдоComboBox.Size = new System.Drawing.Size(225, 32);
            this.блюдоComboBox.TabIndex = 60;
            this.блюдоComboBox.ValueMember = "Название";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.RoyalBlue;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(438, 449);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(372, 45);
            this.button2.TabIndex = 62;
            this.button2.Text = "Обновить";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.RoyalBlue;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.Location = new System.Drawing.Point(438, 398);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(372, 45);
            this.button4.TabIndex = 61;
            this.button4.Text = "Сохранить";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.bindingNavigatorAddNewItem1;
            this.bindingNavigator1.BindingSource = this.заказПозицииBindingSource;
            this.bindingNavigator1.CountItem = this.bindingNavigatorCountItem1;
            this.bindingNavigator1.DeleteItem = this.bindingNavigatorDeleteItem1;
            this.bindingNavigator1.Dock = System.Windows.Forms.DockStyle.None;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem1,
            this.bindingNavigatorMovePreviousItem1,
            this.bindingNavigatorSeparator3,
            this.bindingNavigatorPositionItem1,
            this.bindingNavigatorCountItem1,
            this.bindingNavigatorSeparator4,
            this.bindingNavigatorMoveNextItem1,
            this.bindingNavigatorMoveLastItem1,
            this.bindingNavigatorSeparator5,
            this.bindingNavigatorAddNewItem1,
            this.bindingNavigatorDeleteItem1});
            this.bindingNavigator1.Location = new System.Drawing.Point(406, 30);
            this.bindingNavigator1.MoveFirstItem = this.bindingNavigatorMoveFirstItem1;
            this.bindingNavigator1.MoveLastItem = this.bindingNavigatorMoveLastItem1;
            this.bindingNavigator1.MoveNextItem = this.bindingNavigatorMoveNextItem1;
            this.bindingNavigator1.MovePreviousItem = this.bindingNavigatorMovePreviousItem1;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.bindingNavigatorPositionItem1;
            this.bindingNavigator1.Size = new System.Drawing.Size(263, 25);
            this.bindingNavigator1.TabIndex = 63;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem1
            // 
            this.bindingNavigatorMoveFirstItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem1.Image")));
            this.bindingNavigatorMoveFirstItem1.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem1.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem1
            // 
            this.bindingNavigatorMovePreviousItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem1.Image")));
            this.bindingNavigatorMovePreviousItem1.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem1.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator3
            // 
            this.bindingNavigatorSeparator3.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem1
            // 
            this.bindingNavigatorPositionItem1.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem1.AutoSize = false;
            this.bindingNavigatorPositionItem1.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem1.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem1.Text = "0";
            this.bindingNavigatorPositionItem1.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorCountItem1
            // 
            this.bindingNavigatorCountItem1.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem1.Size = new System.Drawing.Size(43, 22);
            this.bindingNavigatorCountItem1.Text = "для {0}";
            this.bindingNavigatorCountItem1.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorSeparator4
            // 
            this.bindingNavigatorSeparator4.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator4.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem1
            // 
            this.bindingNavigatorMoveNextItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem1.Image")));
            this.bindingNavigatorMoveNextItem1.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem1.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem1
            // 
            this.bindingNavigatorMoveLastItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem1.Image")));
            this.bindingNavigatorMoveLastItem1.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem1.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator5
            // 
            this.bindingNavigatorSeparator5.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator5.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorAddNewItem1
            // 
            this.bindingNavigatorAddNewItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem1.Image")));
            this.bindingNavigatorAddNewItem1.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem1.Text = "Добавить";
            // 
            // bindingNavigatorDeleteItem1
            // 
            this.bindingNavigatorDeleteItem1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem1.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem1.Image")));
            this.bindingNavigatorDeleteItem1.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem1.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem1.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem1.Text = "Удалить";
            // 
            // менюBindingSource
            // 
            this.менюBindingSource.DataMember = "Меню";
            this.менюBindingSource.DataSource = this.dbDataSet;
            // 
            // менюTableAdapter
            // 
            this.менюTableAdapter.ClearBeforeFill = true;
            // 
            // статусLabel1
            // 
            статусLabel1.AutoSize = true;
            статусLabel1.Location = new System.Drawing.Point(12, 206);
            статусLabel1.Name = "статусLabel1";
            статусLabel1.Size = new System.Drawing.Size(77, 24);
            статусLabel1.TabIndex = 63;
            статусLabel1.Text = "Статус:";
            статусLabel1.Click += new System.EventHandler(this.статусLabel1_Click);
            // 
            // статусComboBox
            // 
            this.статусComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.заказBindingSource, "Статус", true));
            this.статусComboBox.FormattingEnabled = true;
            this.статусComboBox.Items.AddRange(new object[] {
            "Оплачен",
            "Не оплачен"});
            this.статусComboBox.Location = new System.Drawing.Point(230, 198);
            this.статусComboBox.Name = "статусComboBox";
            this.статусComboBox.Size = new System.Drawing.Size(158, 32);
            this.статусComboBox.TabIndex = 64;
            this.статусComboBox.SelectedIndexChanged += new System.EventHandler(this.статусComboBox_SelectedIndexChanged);
            // 
            // Form5_Официант
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1052, 514);
            this.Controls.Add(статусLabel1);
            this.Controls.Add(this.статусComboBox);
            this.Controls.Add(this.bindingNavigator1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button4);
            this.Controls.Add(блюдоLabel);
            this.Controls.Add(this.блюдоComboBox);
            this.Controls.Add(количествоLabel);
            this.Controls.Add(this.количествоTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(код_заказаLabel);
            this.Controls.Add(this.код_заказаTextBox);
            this.Controls.Add(столикLabel);
            this.Controls.Add(this.столикTextBox);
            this.Controls.Add(количество_клиентовLabel);
            this.Controls.Add(this.количество_клиентовTextBox);
            this.Controls.Add(код_сменыLabel);
            this.Controls.Add(this.код_сменыTextBox);
            this.Controls.Add(this.заказBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "Form5_Официант";
            this.Text = "Form5_Официант";
            this.Load += new System.EventHandler(this.Form5_Официант_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказBindingNavigator)).EndInit();
            this.заказBindingNavigator.ResumeLayout(false);
            this.заказBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.заказПозицииBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.менюBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource заказBindingSource;
        private dbDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator заказBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton заказBindingNavigatorSaveItem;
        private dbDataSetTableAdapters.ПозицииTableAdapter позицииTableAdapter;
        private System.Windows.Forms.TextBox код_заказаTextBox;
        private System.Windows.Forms.TextBox столикTextBox;
        private System.Windows.Forms.TextBox количество_клиентовTextBox;
        private System.Windows.Forms.TextBox код_сменыTextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource заказПозицииBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодпозицииDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn блюдоDataGridViewTextBoxColumn;
        private dbDataSetTableAdapters.МенюTableAdapter менюTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox количествоTextBox;
        private System.Windows.Forms.ComboBox блюдоComboBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem1;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator3;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator4;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem1;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator5;
        private System.Windows.Forms.BindingSource менюBindingSource;
        private System.Windows.Forms.ComboBox статусComboBox;
    }
}