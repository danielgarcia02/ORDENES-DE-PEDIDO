using NEGOCIO;
using Cache;using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ORDENES_DE_PEDIDO
{
    public partial class Principal : Form
    {
        NOrden Ordern = new NOrden();
        private int Id = 0;
        public Principal()
        {
            InitializeComponent();
        }
        private void MostrarPersona()
        {
            NOrden Persona = new NOrden();
            DTVDcumentos.DataSource = Persona.Mostrar(Convert.ToInt32(Txtcliente.Text));
        }

        private void Btnconsultar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcliente.Text))
            {
                MessageBox.Show("Debe suminsitrar un cliente");
            }
            else
            {
                MostrarPersona();
            }
        }

        private void Principal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtcliente.Text))
            {
                MessageBox.Show("Debe suminsitrar un cliente");
            }
            else
            {
                Id = Convert.ToInt32(Txtcliente.Text);
                ClienteCache.IDENTIFICACION = Id;
                Orden Ordenf = new Orden();
                Ordenf.Show();
            }
        }

        private void Btneditar_Click(object sender, EventArgs e)
        {
            if (Convert.ToInt32(DTVDcumentos.CurrentRow.Cells[5].Value) != 0)
            {
                MessageBox.Show("El registro no se puede editar porque no se encuentra registrado");
            }
            else
            {
                if (DTVDcumentos.SelectedRows.Count > 0)
                {
                    DocumentoCache.ID = Convert.ToInt32(DTVDcumentos.CurrentRow.Cells[0].Value);
                    Orden Orden = new Orden();
                    Orden.Show();
                }
                else
                {
                    MessageBox.Show("Seleccione una fila");
                }
            }
        }
    }
}