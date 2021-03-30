
namespace ORDENES_DE_PEDIDO
{
    partial class Principal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Txtcliente = new System.Windows.Forms.TextBox();
            this.DTVDcumentos = new System.Windows.Forms.DataGridView();
            this.Btnagregar = new System.Windows.Forms.Button();
            this.Btnconsultar = new System.Windows.Forms.Button();
            this.Btneditar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DTVDcumentos)).BeginInit();
            this.SuspendLayout();
            // 
            // Txtcliente
            // 
            this.Txtcliente.ForeColor = System.Drawing.Color.DimGray;
            this.Txtcliente.Location = new System.Drawing.Point(135, 29);
            this.Txtcliente.Name = "Txtcliente";
            this.Txtcliente.Size = new System.Drawing.Size(133, 20);
            this.Txtcliente.TabIndex = 0;
            this.Txtcliente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // DTVDcumentos
            // 
            this.DTVDcumentos.AllowUserToAddRows = false;
            this.DTVDcumentos.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DTVDcumentos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DTVDcumentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DTVDcumentos.Location = new System.Drawing.Point(12, 69);
            this.DTVDcumentos.Name = "DTVDcumentos";
            this.DTVDcumentos.Size = new System.Drawing.Size(851, 298);
            this.DTVDcumentos.TabIndex = 1;
            // 
            // Btnagregar
            // 
            this.Btnagregar.Location = new System.Drawing.Point(295, 26);
            this.Btnagregar.Name = "Btnagregar";
            this.Btnagregar.Size = new System.Drawing.Size(94, 23);
            this.Btnagregar.TabIndex = 2;
            this.Btnagregar.Text = "Agregar";
            this.Btnagregar.UseVisualStyleBackColor = true;
            this.Btnagregar.Click += new System.EventHandler(this.Btnagregar_Click);
            // 
            // Btnconsultar
            // 
            this.Btnconsultar.Location = new System.Drawing.Point(416, 26);
            this.Btnconsultar.Name = "Btnconsultar";
            this.Btnconsultar.Size = new System.Drawing.Size(94, 23);
            this.Btnconsultar.TabIndex = 3;
            this.Btnconsultar.Text = "Consultar";
            this.Btnconsultar.UseVisualStyleBackColor = true;
            this.Btnconsultar.Click += new System.EventHandler(this.Btnconsultar_Click);
            // 
            // Btneditar
            // 
            this.Btneditar.Location = new System.Drawing.Point(536, 26);
            this.Btneditar.Name = "Btneditar";
            this.Btneditar.Size = new System.Drawing.Size(94, 23);
            this.Btneditar.TabIndex = 4;
            this.Btneditar.Text = "Editar";
            this.Btneditar.UseVisualStyleBackColor = true;
            this.Btneditar.Click += new System.EventHandler(this.Btneditar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo cliente";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 379);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btneditar);
            this.Controls.Add(this.Btnconsultar);
            this.Controls.Add(this.Btnagregar);
            this.Controls.Add(this.DTVDcumentos);
            this.Controls.Add(this.Txtcliente);
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PAGINA PRINCIPAL";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Principal_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DTVDcumentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Txtcliente;
        private System.Windows.Forms.DataGridView DTVDcumentos;
        private System.Windows.Forms.Button Btnagregar;
        private System.Windows.Forms.Button Btnconsultar;
        private System.Windows.Forms.Button Btneditar;
        private System.Windows.Forms.Label label1;
    }
}

