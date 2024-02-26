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
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void сменыBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сменыBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void Form5_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Заказ". При необходимости она может быть перемещена или удалена.
            this.заказTableAdapter.Fill(this.dbDataSet.Заказ);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Смены". При необходимости она может быть перемещена или удалена.
            this.сменыTableAdapter.Fill(this.dbDataSet.Смены);

        }

        private void регистрацияПользователейToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void созданиеСменToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }

        private void просмотрЗаказовToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form5_Официант form4 = new Form5_Официант();
            form4.Show();
            this.Hide();
        }
    }
}
