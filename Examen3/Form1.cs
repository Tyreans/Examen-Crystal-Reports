using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Acceso_Datos_App_P23130577;

namespace Examen3
{
    public partial class Form1 : Form
    {
        private int filaSeleccionada = -1;
        public Form1()
        {
            InitializeComponent();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.FormClosed += Form2_Closed;
            form.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ActualizarGrid();
        }

        private void ActualizarGrid()
        {
            Datos obj = new Datos();
            DataSet ds = obj.consulta("SELECT * From Productos");
            if (ds != null)
            {
                dataGridView1.DataSource = ds.Tables[0];
            }
        }

        private void dataGridView1_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0 && e.Button == MouseButtons.Left)
            {

                dataGridView1.CurrentCell = dataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                filaSeleccionada = e.RowIndex;

                contextMenuStrip1.Show(Cursor.Position);
            }
        }

        private void actualizarToolStripMenuItem_Click(object sender, EventArgs e)
        {

                string nombre = dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString();
                int cantidad = Convert.ToInt32(dataGridView1.Rows[filaSeleccionada].Cells[1].Value);
                int precio = Convert.ToInt32(dataGridView1.Rows[filaSeleccionada].Cells[2].Value);
                string descripcion = dataGridView1.Rows[filaSeleccionada].Cells[3].Value.ToString();
                Form2 form = new Form2(nombre, cantidad, precio, descripcion);
                form.FormClosed += Form2_Closed; 
                form.Show();

        }

        private void Form2_Closed(object sender, FormClosedEventArgs e)
        {
            ActualizarGrid();
        }
        private void eliminarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show(
            "¿Estás seguro de continuar?",    
            "Confirmación",                  
            MessageBoxButtons.OKCancel,      
            MessageBoxIcon.Question);

            if (resultado == DialogResult.OK)
            {
                try
                {
                    Datos datos = new Datos();
                    bool f = datos.comando("DELETE FROM Productos WHERE NombreProducto = '" + dataGridView1.Rows[filaSeleccionada].Cells[0].Value.ToString() + "';");
                    if (f == true)
                    {
                        MessageBox.Show("Se ha borrado correctamente", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ActualizarGrid();
                    }
                    else
                    {
                        MessageBox.Show("Error al borrar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ActualizarGrid();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo ha salido mal");
                }
            }
            else
            {
                MessageBox.Show("Operación cancelada.");
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            Reporte frm = new Reporte();
            frm.Show();
        }
    }
}
