﻿using System;
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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void CheckStatusAndChangeColor()
        {
            foreach (DataGridViewRow row in сотрудникиDataGridView.Rows)
                {
                if (row.Cells["dataGridViewTextBoxColumn6"].Value != null && row.Cells["dataGridViewTextBoxColumn6"].Value.ToString() == "Уволен")
                {
                    row.Cells["dataGridViewTextBoxColumn6"].Style.BackColor = Color.Red;
                }
                else row.Cells["dataGridViewTextBoxColumn6"].Style.BackColor = Color.Green;
            }    
        }
        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Сотрудники". При необходимости она может быть перемещена или удалена.
            this.сотрудникиTableAdapter.Fill(this.dbDataSet.Сотрудники);
            CheckStatusAndChangeColor();
        }

        private void сотрудникиBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.сотрудникиBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dbDataSet);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                this.Validate();
                this.сотрудникиBindingSource.EndEdit();
                this.сотрудникиTableAdapter.Update(this.dbDataSet.Сотрудники);

                CheckStatusAndChangeColor();

            
            }
            catch
            {
                MessageBox.Show("Введите корректные данные");
            }
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
