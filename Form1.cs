using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ViewModels;
using ViewModels.Library;

namespace SistemaVentas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /* *********************************
         * 
         * 
         *    CODIGO DEL CLIENTE
         * 
         * 
         * *********************************
         */

        #region Cliente
        private ClientesVM clientes;

        private void btnCliente_Click(object sender, EventArgs e)
        {
            var textBoxCliente = new List<TextBox>();
            textBoxCliente.Add(txtClienteId);
            textBoxCliente.Add(txtClienteNombre);
            textBoxCliente.Add(txtClienteApellido);
            textBoxCliente.Add(txtClienteEmail);
            textBoxCliente.Add(txtClienteTelefono);
            textBoxCliente.Add(txtClienteDireccion);

            var labelCliente = new List<Label>();
            labelCliente.Add(lblClienteId);
            labelCliente.Add(lblClienteNombre);
            labelCliente.Add(lblClienteApellido);
            labelCliente.Add(lblClienteEmail);
            labelCliente.Add(lblClienteTelefono);
            labelCliente.Add(lblClienteDireccion);

            object[] objects =
            {
                pictureBoxCliente,
                chkBoxClienteCredito,
                Properties.Resources.icons8_usuario_80
            };
            clientes = new ClientesVM(objects, textBoxCliente, labelCliente);

            tbcPrincipal.SelectedIndex = 1;
        }
        

        private void pictureBoxCliente_Click(object sender, EventArgs e)
        {
            Objects.uploadImage.CargarImagen(pictureBoxCliente);
        }

        private void txtClienteId_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteId.Text.Equals(""))
            {
                lblClienteId.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteId.Text = "Cliente Id";
                lblClienteId.ForeColor = Color.Green;
            }
        }

        private void txtClienteId_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberkeyPress(e);
        }

        private void txtClienteNombre_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteNombre.Text.Equals(""))
            {
                lblClienteNombre.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteNombre.Text = "Cliente Nombre";
                lblClienteNombre.ForeColor = Color.Green;
            }
        }

        private void txtClienteNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void txtClienteApellido_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteApellido.Text.Equals(""))
            {
                lblClienteApellido.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteApellido.Text = "Cliente Apellido";
                lblClienteApellido.ForeColor = Color.Green;
            }
        }

        private void txtClienteApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.textKeyPress(e);
        }

        private void txtClienteEmail_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteEmail.Text.Equals(""))
            {
                lblClienteEmail.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteEmail.Text = "Cliente Email";
                lblClienteEmail.ForeColor = Color.Green;
            }
        }

        private void txtClienteTelefono_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteTelefono.Text.Equals(""))
            {
                lblClienteTelefono.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteTelefono.Text = "Cliente Telefono";
                lblClienteTelefono.ForeColor = Color.Green;
            }
        }

        private void txtClienteTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            Objects.eventos.numberkeyPress(e);
        }

        private void txtClienteDireccion_TextChanged(object sender, EventArgs e)
        {
            if (txtClienteDireccion.Text.Equals(""))
            {
                lblClienteDireccion.ForeColor = Color.LightSlateGray;
            }
            else
            {
                lblClienteDireccion.Text = "Cliente Dirección";
                lblClienteDireccion.ForeColor = Color.Green;
            }
        }
        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            clientes.guardarCliente();
        }

        private void btnCancelarCliente_Click(object sender, EventArgs e)
        {

        }

        #endregion

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
