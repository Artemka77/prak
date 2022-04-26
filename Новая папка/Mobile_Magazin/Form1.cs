using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Mobile_Magazin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void markBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.markBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dataSet1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Proizvoditel". При необходимости она может быть перемещена или удалена.
            this.proizvoditelTableAdapter.Fill(this.dataSet1.Proizvoditel);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Prodazha". При необходимости она может быть перемещена или удалена.
            this.prodazhaTableAdapter.Fill(this.dataSet1.Prodazha);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavshik". При необходимости она может быть перемещена или удалена.
            this.postavshikTableAdapter.Fill(this.dataSet1.Postavshik);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Postavka". При необходимости она может быть перемещена или удалена.
            this.postavkaTableAdapter.Fill(this.dataSet1.Postavka);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.OC". При необходимости она может быть перемещена или удалена.
            this.oCTableAdapter.Fill(this.dataSet1.OC);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Model". При необходимости она может быть перемещена или удалена.
            this.modelTableAdapter.Fill(this.dataSet1.Model);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "dataSet1.Mark". При необходимости она может быть перемещена или удалена.
            this.markTableAdapter.Fill(this.dataSet1.Mark);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            markBindingSource.AddNew();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            markBindingSource.EndEdit();
            markTableAdapter.Update(dataSet1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            modelBindingSource.AddNew();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modelBindingSource.EndEdit();
            modelTableAdapter.Update(dataSet1);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            oCBindingSource.AddNew();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            oCBindingSource.EndEdit();
            oCTableAdapter.Update(dataSet1);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            postavkaBindingSource.AddNew();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            postavkaBindingSource.EndEdit();
            postavkaTableAdapter.Update(dataSet1);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.AddNew();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            postavshikBindingSource.EndEdit();
            postavshikTableAdapter.Update(dataSet1);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            prodazhaBindingSource.AddNew();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            prodazhaBindingSource.EndEdit();
            prodazhaTableAdapter.Update(dataSet1);
        }

        private void button14_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.AddNew();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            proizvoditelBindingSource.EndEdit();
            proizvoditelTableAdapter.Update(dataSet1);
        }

        private void markDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
