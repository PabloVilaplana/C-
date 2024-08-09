using System;
using System.Data;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto0108_Note_App
{
    public partial class Form1 : Form
    {

        DataTable table;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            table = new DataTable();
            table.Columns.Add("Title", typeof(String));
            table.Columns.Add("Messages", typeof(String));

            dataGridView1.DataSource = table;
            dataGridView1.Columns["Messages"].Visible = false;
            dataGridView1.Columns["Title"].Width = 240;
        }

        private void textMessage_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textTitle.Clear();
            textMessage.Clear();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            table.Rows.Add(textTitle.Text, textMessage.Text);

            textTitle.Clear();
            textMessage.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {


            try
            {
                int index = dataGridView1.CurrentCell.RowIndex;
                if (index > -1)
                {
                    textTitle.Text = table.Rows[index].ItemArray[0].ToString();
                    textMessage.Text = table.Rows[index].ItemArray[1].ToString();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Por favor selecciona una fila para leer.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



    }

        private void button4_Click(object sender, EventArgs e)
        {

            if (dataGridView1.RowCount > 0 && dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.Rows.RemoveAt(dataGridView1.SelectedRows[0].Index);
            }
            else if (dataGridView1.RowCount > 0)
            {
                dataGridView1.Rows.RemoveAt(0);
            }
            else
            {
                MessageBox.Show("No hay filas para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
    }
}