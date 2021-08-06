using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _002_Diseño_a_DatagridView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataGridViewRow row = new DataGridViewRow();
            row.Cells.Add(new DataGridViewButtonCell()
            {
                Value = "hola"
               
            });
            dataGridView1.Rows.Add(row);
        }
    }
}
