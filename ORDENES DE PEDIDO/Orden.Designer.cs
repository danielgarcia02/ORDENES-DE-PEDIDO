
namespace ORDENES_DE_PEDIDO
{
    partial class Orden
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTVDetalle = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Valor_unitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total_parcial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Txtdireccion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Productos = new System.Windows.Forms.GroupBox();
            this.Txtnombre = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtvalor = new System.Windows.Forms.TextBox();
            this.Txtcantidad = new System.Windows.Forms.TextBox();
            this.Txtcodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btngrabar = new System.Windows.Forms.Button();
            this.Lbltotal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTVDetalle)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Productos.SuspendLayout();
            this.SuspendLayout();
            // 
            // DTVDetalle
            // 
            this.DTVDetalle.AllowUserToAddRows = false;
            this.DTVDetalle.AllowUserToDeleteRows = false;
            this.DTVDetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTVDetalle.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTVDetalle.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.DTVDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVDetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nombre,
            this.Cantidad,
            this.Valor_unitario,
            this.Total_parcial});
            this.DTVDetalle.Enabled = false;
            this.DTVDetalle.Location = new System.Drawing.Point(12, 135);
            this.DTVDetalle.Name = "DTVDetalle";
            this.DTVDetalle.ReadOnly = true;
            this.DTVDetalle.RowHeadersVisible = false;
            this.DTVDetalle.Size = new System.Drawing.Size(562, 315);
            this.DTVDetalle.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            this.Codigo.ReadOnly = true;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.ReadOnly = true;
            // 
            // Valor_unitario
            // 
            this.Valor_unitario.HeaderText = "Valor unitario";
            this.Valor_unitario.Name = "Valor_unitario";
            this.Valor_unitario.ReadOnly = true;
            // 
            // Total_parcial
            // 
            this.Total_parcial.HeaderText = "Total parcial";
            this.Total_parcial.Name = "Total_parcial";
            this.Total_parcial.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Txtdireccion);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(383, 47);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Cabecera";
            // 
            // Txtdireccion
            // 
            this.Txtdireccion.Location = new System.Drawing.Point(119, 13);
            this.Txtdireccion.Name = "Txtdireccion";
            this.Txtdireccion.Size = new System.Drawing.Size(129, 20);
            this.Txtdireccion.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Dirección entrega:";
            // 
            // Productos
            // 
            this.Productos.Controls.Add(this.Txtnombre);
            this.Productos.Controls.Add(this.label5);
            this.Productos.Controls.Add(this.Txtvalor);
            this.Productos.Controls.Add(this.Txtcantidad);
            this.Productos.Controls.Add(this.Txtcodigo);
            this.Productos.Controls.Add(this.label4);
            this.Productos.Controls.Add(this.label3);
            this.Productos.Controls.Add(this.label2);
            this.Productos.Location = new System.Drawing.Point(12, 65);
            this.Productos.Name = "Productos";
            this.Productos.Size = new System.Drawing.Size(481, 64);
            this.Productos.TabIndex = 2;
            this.Productos.TabStop = false;
            this.Productos.Text = "Productos";
            // 
            // Txtnombre
            // 
            this.Txtnombre.Location = new System.Drawing.Point(119, 37);
            this.Txtnombre.Name = "Txtnombre";
            this.Txtnombre.Size = new System.Drawing.Size(118, 20);
            this.Txtnombre.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(116, 20);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Nombre";
            // 
            // Txtvalor
            // 
            this.Txtvalor.Location = new System.Drawing.Point(308, 37);
            this.Txtvalor.Name = "Txtvalor";
            this.Txtvalor.Size = new System.Drawing.Size(100, 20);
            this.Txtvalor.TabIndex = 5;
            // 
            // Txtcantidad
            // 
            this.Txtcantidad.Location = new System.Drawing.Point(243, 38);
            this.Txtcantidad.Name = "Txtcantidad";
            this.Txtcantidad.Size = new System.Drawing.Size(59, 20);
            this.Txtcantidad.TabIndex = 4;
            // 
            // Txtcodigo
            // 
            this.Txtcodigo.Location = new System.Drawing.Point(10, 38);
            this.Txtcodigo.Name = "Txtcodigo";
            this.Txtcodigo.Size = new System.Drawing.Size(100, 20);
            this.Txtcodigo.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(305, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Valor unitario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(240, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Codigo producto:";
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(432, 12);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(142, 23);
            this.Btnagregar.TabIndex = 3;
            this.Btnagregar.Text = "Agregar y/o Editar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btngrabar
            // 
            this.Btngrabar.Location = new System.Drawing.Point(499, 41);
            this.Btngrabar.Name = "Btngrabar";
            this.Btngrabar.Size = new System.Drawing.Size(75, 23);
            this.Btngrabar.TabIndex = 4;
            this.Btngrabar.Text = "Grabar";
            this.Btngrabar.UseVisualStyleBackColor = true;
            this.Btngrabar.Click += new System.EventHandler(this.Btngrabar_Click);
            // 
            // Lbltotal
            // 
            this.Lbltotal.AutoSize = true;
            this.Lbltotal.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lbltotal.Location = new System.Drawing.Point(515, 453);
            this.Lbltotal.Name = "Lbltotal";
            this.Lbltotal.Size = new System.Drawing.Size(0, 19);
            this.Lbltotal.TabIndex = 6;
            // 
            // Orden
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(586, 480);
            this.Controls.Add(this.Lbltotal);
            this.Controls.Add(this.Btngrabar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.Productos);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.DTVDetalle);
            this.Name = "Orden";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden";
            ((System.ComponentModel.ISupportInitialize)(this.DTVDetalle)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Productos.ResumeLayout(false);
            this.Productos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DTVDetalle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtdireccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Productos;
        private System.Windows.Forms.TextBox Txtvalor;
        private System.Windows.Forms.TextBox Txtcantidad;
        private System.Windows.Forms.TextBox Txtcodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btngrabar;
        private System.Windows.Forms.Label Lbltotal;
        private System.Windows.Forms.TextBox Txtnombre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Valor_unitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total_parcial;
    }
}