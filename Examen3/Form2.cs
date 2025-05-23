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
    public partial class Form2 : Form
    {
        string fnombre, fdescripcion;
        int fprecio, fcantidad;
        public Form2()
        {
            InitializeComponent();
            btnAlta.Text = "Registrar";
        }

        private void Form2_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        public Form2(string nombre, int cantidad, int precio, string descripcion) {
            InitializeComponent();
            fnombre = nombre;
            fcantidad = cantidad;
            fprecio = precio;
            fdescripcion = descripcion;
            btnAlta.Text = "Actualizar";
            tbNombre.Text = nombre; tbNombre.Enabled = false;
            numCanti.Value = cantidad;
            numPrecio.Value = precio;
            rtbDescr.Text = descripcion;
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            if (btnAlta.Text == "Registrar")
            {
                try
                {
                    Datos datos = new Datos();
                    bool f = datos.comando("INSERT INTO Productos(NombreProducto,Cantidad,Precio,Descripcion) VALUES "
                    + "('" + tbNombre.Text + "', " + numCanti.Value + ", " + numPrecio.Value + ", '" + rtbDescr.Text + "');");
                    if (f == true)
                    {
                        MessageBox.Show("Se han insertado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al insertar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo ha salido mal");
                }
            }
            else {
                try
                {
                    Datos datos = new Datos();
                    bool f = datos.comando("UPDATE Productos SET Cantidad = " + numCanti.Value+ ", Precio = " + numPrecio.Value + ", Descripcion='" + rtbDescr.Text + "' WHERE NombreProducto = '" + fnombre + "';");
                    if (f == true)
                    {
                        MessageBox.Show("Se han actualizado los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Error al actualizar los datos", "Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Algo ha salido mal");
                }
            }
        }
    }
}
