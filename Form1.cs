using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeApplication1
{
    public partial class Form1 : Form
    {
        DataTable table = new DataTable("table");
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            table.Columns.Add("ID", Type.GetType("System.String"));
            table.Columns.Add("firstname", Type.GetType("System.String"));
            table.Columns.Add("lastname", Type.GetType("System.String"));
            table.Columns.Add("Position", Type.GetType("System.String"));

            dataGridView1.DataSource = table;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string T1 = textBox1.Text;
            string T2 = textBox2.Text;
            string T3 = textBox3.Text;
            string T4 = textBox4.Text;


            if (string.IsNullOrEmpty(T1) || string.IsNullOrEmpty(T2) ||
                string.IsNullOrEmpty(T3) || string.IsNullOrEmpty(T4))
            {
                MessageBox.Show("Please fill out all ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            EmployeeInfo EA = new EmployeeInfo(T1, T2, T3, T4);


            table.Rows.Add(EA.TB1, EA.TB2, EA.TB3, EA.TB4);

            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        class EmployeeInfo
        {
            public string TB1 { get; set; }  
            public string TB2 { get; set; }  
            public string TB3 { get; set; }  
            public string TB4 { get; set; }  

            public EmployeeInfo(string T1, string T2, string T3, string T4)
            {
                TB1 = T1;
                TB2 = T2;
                TB3 = T3;
                TB4 = T4;
            }
        }
    }
}
