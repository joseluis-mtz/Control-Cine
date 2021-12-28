using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_Cine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtPrecio.Text = "$230";
            txtPrecio.Enabled = false;
            groupBox1.Enabled = false;
            groupBox2.Enabled = false;
            cmbPel.SelectedIndex = 0;
        }

        private void rbVender_CheckedChanged(object sender, EventArgs e)
        {
            groupBox1.Enabled = true;
            groupBox2.Enabled = false;
        }

        private void rbRentar_CheckedChanged(object sender, EventArgs e)
        {
            groupBox2.Enabled = true;
            groupBox1.Enabled = false;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            if (txtVNombre.TextLength > 0 && txtVPel.TextLength > 0)
            {
                dataGridView1.Rows.Add(txtVNombre.Text, txtVPel.Text, txtPrecio.Text);
            }
            else
            {
                MessageBox.Show("Llena los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
