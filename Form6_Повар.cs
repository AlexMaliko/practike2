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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void CheckStatusAndChangeColor()
        {
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells["статусDataGridViewTextBoxColumn"].Value != null && row.Cells["статусDataGridViewTextBoxColumn"].Value.ToString() == "Не готово")
                {
                    row.Cells["статусDataGridViewTextBoxColumn"].Style.BackColor = Color.Red;
                }
                else row.Cells["статусDataGridViewTextBoxColumn"].Style.BackColor = Color.Green;
            }
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dbDataSet.Позиции". При необходимости она может быть перемещена или удалена.
            this.позицииTableAdapter.Fill(this.dbDataSet.Позиции);
            CheckStatusAndChangeColor();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.позицииBindingSource.EndEdit();
            this.позицииTableAdapter.Update(this.dbDataSet.Позиции);
            CheckStatusAndChangeColor();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.позицииTableAdapter.Update(this.dbDataSet.Позиции);
            CheckStatusAndChangeColor();
        }
    }
}
