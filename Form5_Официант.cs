using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form5_Официант : Form
    {
        public Form5_Официант()
        {
            InitializeComponent();
        }

        private void заказBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form5_Официант_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Меню". При необходимости она может быть перемещена или удалена.
            this.менюTableAdapter.Fill(this.dbDataSet.Меню);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Позиции". При необходимости она может быть перемещена или удалена.
            this.позицииTableAdapter.Fill(this.dbDataSet.Позиции);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.dbDataSet.Заказ);

        }

        private void статусComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void статусLabel1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказBindingSource.EndEdit();
            this.заказTableAdapter.Update(this.dbDataSet.Заказ);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            this.заказTableAdapter.Update(this.dbDataSet.Заказ);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.заказПозицииBindingSource.EndEdit();
            this.позицииTableAdapter.Update(this.dbDataSet.Позиции);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.позицииTableAdapter.Update(this.dbDataSet.Позиции);
        }

      
    }
}
