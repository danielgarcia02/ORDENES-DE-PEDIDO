using NEGOCIO;
using Cache;
using System;
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
    public partial class Orden : Form
    {
        public Orden()
        {
            InitializeComponent();
            if(DocumentoCache.ID > 0)
            {
                MostrarProductos();
            }
        }

        private void MostrarProductos()
        {
            NOrden Persona = new NOrden();
            DTVDetalle.Columns.Clear();
            DTVDetalle.DataSource = Persona.DetalleOrden(Convert.ToInt32(ClienteCache.IDENTIFICACION),DocumentoCache.ID);
        }
        int Cont = 0;
        public static double TotalO = 0;

        private void Btnagregar_Click(object sender, EventArgs e)
        {
            NOrden Producto = new NOrden();
            string Nombre = Producto.NombreProducto(Txtcodigo.Text);
            if (string.IsNullOrEmpty(Nombre) && string.IsNullOrEmpty(Txtnombre.Text))
            {
                MessageBox.Show("Debe suministrar un nombre para crear el producto");
            }
            else
            {
                bool Existe = false;
                int NumFila = 0;
                if (Cont == 0)
                {
                    if (string.IsNullOrEmpty(Nombre)) { Nombre = Txtnombre.Text; }
                    DTVDetalle.Rows.Add(Txtcodigo.Text,Nombre , Txtcantidad.Text, Txtvalor.Text);
                    double Total = Convert.ToDouble(DTVDetalle.Rows[Cont].Cells[2].Value) * Convert.ToDouble(DTVDetalle.Rows[Cont].Cells[3].Value);
                    DTVDetalle.Rows[Cont].Cells[4].Value = Total;
                    Cont++;
                    Txtcodigo.Clear();
                    Txtnombre.Clear();
                    Txtcantidad.Clear();
                    Txtvalor.Clear();
                }
                else
                {
                    foreach (DataGridViewRow Fila in DTVDetalle.Rows)
                    {
                        if (Fila.Cells[0].Value.ToString() == Txtcodigo.Text)
                        {
                            Existe = true;
                            NumFila = Fila.Index;
                        }
                    }
                       if (Existe == true)
                        {
                            DTVDetalle.Rows[NumFila].Cells[2].Value = (Convert.ToDouble(Txtcantidad.Text) + Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[2].Value)).ToString();
                            DTVDetalle.Rows[NumFila].Cells[3].Value = (Convert.ToDouble(Txtvalor.Text) + Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[3].Value)).ToString();
                            double Total = Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[2].Value) * Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[3].Value);
                            DTVDetalle.Rows[NumFila].Cells[4].Value = Total;
                            Txtcodigo.Clear();
                            Txtnombre.Clear();
                            Txtcantidad.Clear();
                            Txtvalor.Clear();
                        }
                        else
                        {
                            if(string.IsNullOrEmpty(Nombre)) { Nombre = Txtnombre.Text; }
                            DTVDetalle.Rows.Add(Txtcodigo.Text, Nombre, Txtcantidad.Text, Txtvalor.Text);
                            double Total = Convert.ToDouble(DTVDetalle.Rows[Cont].Cells[2].Value) * Convert.ToDouble(DTVDetalle.Rows[Cont].Cells[3].Value);
                            DTVDetalle.Rows[Cont].Cells[4].Value = Total;
                            Cont++;
                            Txtcodigo.Clear();
                            Txtnombre.Clear();
                            Txtcantidad.Clear();
                            Txtvalor.Clear();
                        }
                }
                TotalO = 0;
                foreach (DataGridViewRow Fila in DTVDetalle.Rows)
                {
                    TotalO += Convert.ToDouble(Fila.Cells[4].Value);
                }
                Lbltotal.Text = TotalO.ToString();
                Txtcodigo.Focus();
            }
        }

        private void Btngrabar_Click(object sender, EventArgs e)
        {
            if(Cont != 0)
            {
                if (string.IsNullOrEmpty(Txtdireccion.Text))
                {
                    MessageBox.Show("Debe asociar una dirección de entrega");
                }
                else
                {
                    NOrden Orden = new NOrden();
                    int NumFila = 0;
                    int Prioridad = 0;
                    if (TotalO <= 500)
                    {
                        Prioridad = 0;
                    }
                    if (500 < TotalO && TotalO <= 1000)
                    {
                        Prioridad = 1;
                    }
                    if (TotalO > 1000)
                    {
                        Prioridad = 2;
                    }
                    try
                    {
                        Orden.InserOrder(ClienteCache.IDENTIFICACION, Txtdireccion.Text, Prioridad, TotalO);
                        foreach (DataGridViewRow Fila in DTVDetalle.Rows)
                        {
                            try
                            {
                                Orden.InsertarDetalle(DocumentoCache.NumOdr, DTVDetalle.Rows[NumFila].Cells[0].Value.ToString(), Convert.ToInt32(DTVDetalle.Rows[NumFila].Cells[2].Value), Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[3].Value), Convert.ToDouble(DTVDetalle.Rows[NumFila].Cells[4].Value));
                                NumFila++;
                            }
                            catch (Exception Error)
                            {
                                MessageBox.Show("Error" + Error);
                            }
                        }
                        MessageBox.Show("Registros grabados correctamente");
                        DTVDetalle.Rows.Clear();
                    }
                    catch (Exception error)
                    {
                        MessageBox.Show("EROR INESPERADO" + error);
                    }
                }
            }
        }
    }
}
