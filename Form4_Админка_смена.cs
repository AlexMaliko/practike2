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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dbDataSet.Сотрудники);

            this.составTableAdapter.Fill(this.dbDataSet.Состав);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Смены". При необходимости она может быть перемещена или удалена.
            this.сменыTableAdapter.Fill(this.dbDataSet.Смены);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сменыBindingSource.EndEdit();
            this.сменыTableAdapter.Update(this.dbDataSet.Смены);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.сменыTableAdapter.Update(this.dbDataSet.Смены);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сменыСоставBindingSource.EndEdit();
            this.составTableAdapter.Update(this.dbDataSet.Состав);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.составTableAdapter.Update(this.dbDataSet.Состав);
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
            Form5 form5 = new Form5();
            form5.Show();
            this.Hide();
        }
    }
}
