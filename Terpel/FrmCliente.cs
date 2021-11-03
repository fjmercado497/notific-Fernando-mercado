using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using ENTITY;

namespace Terpel
{
    public partial class FrmCliente : Form
    {
        Cliente cliente;
        public FrmCliente()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            ClienteService service = new ClienteService();
            Cliente cliente = MapearCliente();
            string Mensaje = service.Guardar(cliente);
            MessageBox.Show(Mensaje, "MENSAJE DE GUARDADO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

        }

        private Cliente MapearCliente()
        {
            cliente = new Cliente();
            cliente.Cedula = TxtCedula.Text.Trim();
            cliente.Primernombre = TxtPrimerNombre.Text.Trim();
            cliente.Segundonombre = TxtSegundoNombre.Text.Trim();
            cliente.Primerapellido = TxtPrimerApellido.Text.Trim();
            cliente.Segundoapellido = TxtSegundoApellido.Text.Trim();
            cliente.Telefono = TxtTelefono.Text.Trim();
            cliente.Email = TxtEmail.Text.Trim();
            cliente.Marca = TxtMarca.Text.Trim();
            cliente.Modelo = TxtModelo.Text.Trim();
            cliente.Tipodeaceite = TxtTipoAceite.Text.Trim();
            cliente.Referenciaaceite = TxtReferenciaAceite.Text.Trim();
            cliente.Tipofiltro = TxtTipoFiltro.Text.Trim();
            cliente.Referenciafiltro = TxtReferenciaFiltro.Text.Trim();
            return cliente;

        }

        private void TxtCedula_TextChanged(object sender, EventArgs e)
        {

        }

        private void TxtSegundoNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
