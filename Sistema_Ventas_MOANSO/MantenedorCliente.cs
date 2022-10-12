using CapaEntidad;
using CapaLogica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Ventas_MOANSO
{
    public partial class MantenedorCliente : Form
    {
        public MantenedorCliente()
        {
            InitializeComponent();
            listarCliente();
            gb_DatosCliente.Enabled = false;
            txt_idCliente.Enabled = false;
        }
        public void listarCliente()
        {
            dgvCliente.DataSource = logCliente.Instancia.ListarCliente();
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            gb_DatosCliente.Enabled = true;

            btn_Agregar.Visible = true;
            LimpiarVariables();
            btn_Modificar.Visible = false;

        }
        private void LimpiarVariables()
        {
            txt_RazonSocial.Text = "";
            txt_idTipoCliente.Text = "";
            txt_idCiudad.Text = "";
            //cbkEstadoCliente.Checked = false;
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            //insertar
            try
            {
                entCliente c = new entCliente();
                c.razonSocial = txt_RazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txt_idTipoCliente.Text.Trim());
                c.fecRegCliente = dt_FechaRegCliente.Value;
                c.idCiudad = int.Parse(txt_idCiudad.Text.Trim());
                c.estCliente = cb_EstadoCliente.Checked;
                logCliente.Instancia.InsertaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_DatosCliente.Enabled = false;
            listarCliente();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void dgvCliente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow filaActual = dgvCliente.Rows[e.RowIndex]; //
            txt_idCliente.Text = filaActual.Cells[0].Value.ToString();
            txt_RazonSocial.Text = filaActual.Cells[1].Value.ToString();
            txt_idTipoCliente.Text = filaActual.Cells[2].Value.ToString();
            dt_FechaRegCliente.Text = filaActual.Cells[3].Value.ToString();
            txt_idCiudad.Text = filaActual.Cells[4].Value.ToString();
            cb_EstadoCliente.Checked = Convert.ToBoolean(filaActual.Cells[5].Value);

        }

        private void btn_Editar_Click(object sender, EventArgs e)
        {
            gb_DatosCliente.Enabled = true;
            btn_Modificar.Visible = true;
            btn_Agregar.Visible = false;

        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            try
            {
                entCliente c = new entCliente();
                c.idCliente = int.Parse(txt_idCliente.Text.Trim());
                c.razonSocial = txt_RazonSocial.Text.Trim();
                c.idTipoCliente = int.Parse(txt_idTipoCliente.Text.Trim());
                c.fecRegCliente = dt_FechaRegCliente.Value;
                c.idCiudad = int.Parse(txt_idCiudad.Text.Trim());
                c.estCliente = cb_EstadoCliente.Checked;
                logCliente.Instancia.EditaCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_DatosCliente.Enabled = false;
            listarCliente();

        }

        private void btn_Deshabilitar_Click(object sender, EventArgs e)
        {            
            try
            {
                entCliente c = new entCliente();

                c.idCliente = int.Parse(txt_idCliente.Text.Trim());
                cb_EstadoCliente.Checked = false;
                c.estCliente = cb_EstadoCliente.Checked;
                logCliente.Instancia.DeshabilitarCliente(c);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error.." + ex);
            }
            LimpiarVariables();
            gb_DatosCliente.Enabled = false;
            listarCliente();
            

        }
    }
}

