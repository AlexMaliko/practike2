
namespace WindowsFormsApp1
{
    partial class Form5
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.dbDataSet = new WindowsFormsApp1.dbDataSet();
            this.сменыBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.сменыTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.СменыTableAdapter();
            this.tableAdapterManager = new WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager();
            this.заказTableAdapter = new WindowsFormsApp1.dbDataSetTableAdapters.ЗаказTableAdapter();
            this.сменыBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.сменыBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.сменыDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.кодзаказаDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.столикDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.количествоклиентовDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.статусDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.сменыЗаказBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.регистрацияПользователейToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.созданиеСменToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотрЗаказовToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingNavigator)).BeginInit();
            this.сменыBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменыDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыЗаказBindingSource)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dbDataSet
            // 
            this.dbDataSet.DataSetName = "dbDataSet";
            this.dbDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // сменыBindingSource
            // 
            this.сменыBindingSource.DataMember = "Смены";
            this.сменыBindingSource.DataSource = this.dbDataSet;
            // 
            // сменыTableAdapter
            // 
            this.сменыTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApp1.dbDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.ЗаказTableAdapter = this.заказTableAdapter;
            this.tableAdapterManager.МенюTableAdapter = null;
            this.tableAdapterManager.ПозицииTableAdapter = null;
            this.tableAdapterManager.СменыTableAdapter = this.сменыTableAdapter;
            this.tableAdapterManager.СоставTableAdapter = null;
            this.tableAdapterManager.СотрудникиTableAdapter = null;
            // 
            // заказTableAdapter
            // 
            this.заказTableAdapter.ClearBeforeFill = true;
            // 
            // сменыBindingNavigator
            // 
            this.сменыBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.сменыBindingNavigator.BindingSource = this.сменыBindingSource;
            this.сменыBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.сменыBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.сменыBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.сменыBindingNavigator.Font = new System.Drawing.Font("Segoe UI", 14F);
            this.сменыBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.сменыBindingNavigatorSaveItem});
            this.сменыBindingNavigator.Location = new System.Drawing.Point(1, 105);
            this.сменыBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.сменыBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.сменыBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.сменыBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.сменыBindingNavigator.Name = "сменыBindingNavigator";
            this.сменыBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.сменыBindingNavigator.Size = new System.Drawing.Size(312, 28);
            this.сменыBindingNavigator.TabIndex = 0;
            this.сменыBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(69, 25);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 28);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 25);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 28);
            // 
            // сменыBindingNavigatorSaveItem
            // 
            this.сменыBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.сменыBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("сменыBindingNavigatorSaveItem.Image")));
            this.сменыBindingNavigatorSaveItem.Name = "сменыBindingNavigatorSaveItem";
            this.сменыBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 25);
            this.сменыBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.сменыBindingNavigatorSaveItem.Click += new System.EventHandler(this.сменыBindingNavigatorSaveItem_Click);
            // 
            // сменыDataGridView
            // 
            this.сменыDataGridView.AutoGenerateColumns = false;
            this.сменыDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.сменыDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.сменыDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.сменыDataGridView.DataSource = this.сменыBindingSource;
            this.сменыDataGridView.Location = new System.Drawing.Point(1, 136);
            this.сменыDataGridView.Name = "сменыDataGridView";
            this.сменыDataGridView.Size = new System.Drawing.Size(358, 220);
            this.сменыDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Код_смены";
            this.dataGridViewTextBoxColumn1.HeaderText = "Номер смены";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Дата";
            this.dataGridViewTextBoxColumn2.HeaderText = "Дата";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.кодзаказаDataGridViewTextBoxColumn,
            this.столикDataGridViewTextBoxColumn,
            this.количествоклиентовDataGridViewTextBoxColumn,
            this.статусDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.сменыЗаказBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(391, 136);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(617, 220);
            this.dataGridView1.TabIndex = 2;
            // 
            // кодзаказаDataGridViewTextBoxColumn
            // 
            this.кодзаказаDataGridViewTextBoxColumn.DataPropertyName = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.HeaderText = "Код_заказа";
            this.кодзаказаDataGridViewTextBoxColumn.Name = "кодзаказаDataGridViewTextBoxColumn";
            this.кодзаказаDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // столикDataGridViewTextBoxColumn
            // 
            this.столикDataGridViewTextBoxColumn.DataPropertyName = "Столик";
            this.столикDataGridViewTextBoxColumn.HeaderText = "Столик";
            this.столикDataGridViewTextBoxColumn.Name = "столикDataGridViewTextBoxColumn";
            // 
            // количествоклиентовDataGridViewTextBoxColumn
            // 
            this.количествоклиентовDataGridViewTextBoxColumn.DataPropertyName = "Количество-клиентов";
            this.количествоклиентовDataGridViewTextBoxColumn.HeaderText = "Кол-во клиентов";
            this.количествоклиентовDataGridViewTextBoxColumn.Name = "количествоклиентовDataGridViewTextBoxColumn";
            // 
            // статусDataGridViewTextBoxColumn
            // 
            this.статусDataGridViewTextBoxColumn.DataPropertyName = "Статус";
            this.статусDataGridViewTextBoxColumn.HeaderText = "Статус";
            this.статусDataGridViewTextBoxColumn.Name = "статусDataGridViewTextBoxColumn";
            // 
            // сменыЗаказBindingSource
            // 
            this.сменыЗаказBindingSource.DataMember = "СменыЗаказ";
            this.сменыЗаказBindingSource.DataSource = this.сменыBindingSource;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Смены:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(387, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 24);
            this.label2.TabIndex = 4;
            this.label2.Text = "Заказы:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.регистрацияПользователейToolStripMenuItem,
            this.созданиеСменToolStripMenuItem,
            this.просмотрЗаказовToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1097, 33);
            this.menuStrip1.TabIndex = 56;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // регистрацияПользователейToolStripMenuItem
            // 
            this.регистрацияПользователейToolStripMenuItem.Name = "регистрацияПользователейToolStripMenuItem";
            this.регистрацияПользователейToolStripMenuItem.Size = new System.Drawing.Size(273, 29);
            this.регистрацияПользователейToolStripMenuItem.Text = "Регистрация пользователей";
            this.регистрацияПользователейToolStripMenuItem.Click += new System.EventHandler(this.регистрацияПользователейToolStripMenuItem_Click);
            // 
            // созданиеСменToolStripMenuItem
            // 
            this.созданиеСменToolStripMenuItem.Name = "созданиеСменToolStripMenuItem";
            this.созданиеСменToolStripMenuItem.Size = new System.Drawing.Size(158, 29);
            this.созданиеСменToolStripMenuItem.Text = "Создание смен";
            this.созданиеСменToolStripMenuItem.Click += new System.EventHandler(this.созданиеСменToolStripMenuItem_Click);
            // 
            // просмотрЗаказовToolStripMenuItem
            // 
            this.просмотрЗаказовToolStripMenuItem.Name = "просмотрЗаказовToolStripMenuItem";
            this.просмотрЗаказовToolStripMenuItem.Size = new System.Drawing.Size(188, 29);
            this.просмотрЗаказовToolStripMenuItem.Text = "Просмотр заказов";
            this.просмотрЗаказовToolStripMenuItem.Click += new System.EventHandler(this.просмотрЗаказовToolStripMenuItem_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.RoyalBlue;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Roboto", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.Location = new System.Drawing.Point(391, 362);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(246, 45);
            this.button3.TabIndex = 57;
            this.button3.Text = "Перейти к заказам";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1097, 421);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.сменыDataGridView);
            this.Controls.Add(this.сменыBindingNavigator);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Form5";
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dbDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыBindingNavigator)).EndInit();
            this.сменыBindingNavigator.ResumeLayout(false);
            this.сменыBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.сменыDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.сменыЗаказBindingSource)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dbDataSet dbDataSet;
        private System.Windows.Forms.BindingSource сменыBindingSource;
        private dbDataSetTableAdapters.СменыTableAdapter сменыTableAdapter;
        private dbDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator сменыBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton сменыBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView сменыDataGridView;
        private dbDataSetTableAdapters.ЗаказTableAdapter заказTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource сменыЗаказBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn кодзаказаDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn столикDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn количествоклиентовDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn статусDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem регистрацияПользователейToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem созданиеСменToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem просмотрЗаказовToolStripMenuItem;
        private System.Windows.Forms.Button button3;
    }
}