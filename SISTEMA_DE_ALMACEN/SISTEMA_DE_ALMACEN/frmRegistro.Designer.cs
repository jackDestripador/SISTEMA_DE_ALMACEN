/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 10:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SISTEMA_DE_ALMACEN
{
	partial class frmRegistro
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.txtProducto = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.txtMarca = new System.Windows.Forms.TextBox();
			this.lblMarca = new System.Windows.Forms.Label();
			this.txtCantidad = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtProvedor = new System.Windows.Forms.TextBox();
			this.btnAgregar = new System.Windows.Forms.Button();
			this.btnQuitar = new System.Windows.Forms.Button();
			this.lstTabla = new System.Windows.Forms.ListView();
			this.cmlCantidad = new System.Windows.Forms.ColumnHeader();
			this.cmlMarca = new System.Windows.Forms.ColumnHeader();
			this.clmCantidad = new System.Windows.Forms.ColumnHeader();
			this.cmlProvedor = new System.Windows.Forms.ColumnHeader();
			this.clmPrecio = new System.Windows.Forms.ColumnHeader();
			this.Precio = new System.Windows.Forms.Label();
			this.txtPrecio = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.btnLimpiar = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(12, 39);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Producto:";
			// 
			// txtProducto
			// 
			this.txtProducto.Location = new System.Drawing.Point(104, 38);
			this.txtProducto.Name = "txtProducto";
			this.txtProducto.Size = new System.Drawing.Size(198, 20);
			this.txtProducto.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 84);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 2;
			this.label2.Text = "Marca:";
			// 
			// txtMarca
			// 
			this.txtMarca.Location = new System.Drawing.Point(104, 83);
			this.txtMarca.Name = "txtMarca";
			this.txtMarca.Size = new System.Drawing.Size(198, 20);
			this.txtMarca.TabIndex = 3;
			// 
			// lblMarca
			// 
			this.lblMarca.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblMarca.Location = new System.Drawing.Point(12, 128);
			this.lblMarca.Name = "lblMarca";
			this.lblMarca.Size = new System.Drawing.Size(100, 23);
			this.lblMarca.TabIndex = 4;
			this.lblMarca.Text = "Cantidad:";
			// 
			// txtCantidad
			// 
			this.txtCantidad.Location = new System.Drawing.Point(104, 127);
			this.txtCantidad.Name = "txtCantidad";
			this.txtCantidad.Size = new System.Drawing.Size(198, 20);
			this.txtCantidad.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 6;
			this.label3.Text = "Provedor:";
			// 
			// txtProvedor
			// 
			this.txtProvedor.Location = new System.Drawing.Point(104, 172);
			this.txtProvedor.Name = "txtProvedor";
			this.txtProvedor.Size = new System.Drawing.Size(198, 20);
			this.txtProvedor.TabIndex = 7;
			// 
			// btnAgregar
			// 
			this.btnAgregar.BackColor = System.Drawing.SystemColors.Control;
			this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregar.Location = new System.Drawing.Point(12, 265);
			this.btnAgregar.Name = "btnAgregar";
			this.btnAgregar.Size = new System.Drawing.Size(123, 29);
			this.btnAgregar.TabIndex = 9;
			this.btnAgregar.Text = "Agregar Productos";
			this.btnAgregar.UseVisualStyleBackColor = false;
			this.btnAgregar.Click += new System.EventHandler(this.BtnAgregarClick);
			// 
			// btnQuitar
			// 
			this.btnQuitar.BackColor = System.Drawing.SystemColors.Control;
			this.btnQuitar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnQuitar.Location = new System.Drawing.Point(195, 265);
			this.btnQuitar.Name = "btnQuitar";
			this.btnQuitar.Size = new System.Drawing.Size(123, 29);
			this.btnQuitar.TabIndex = 17;
			this.btnQuitar.Text = "Quitar";
			this.btnQuitar.UseVisualStyleBackColor = false;
			this.btnQuitar.Click += new System.EventHandler(this.BtnQuitarClick);
			// 
			// lstTabla
			// 
			this.lstTabla.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.lstTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.cmlCantidad,
									this.cmlMarca,
									this.clmCantidad,
									this.cmlProvedor,
									this.clmPrecio});
			this.lstTabla.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lstTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstTabla.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lstTabla.Location = new System.Drawing.Point(344, 12);
			this.lstTabla.Name = "lstTabla";
			this.lstTabla.Size = new System.Drawing.Size(551, 357);
			this.lstTabla.TabIndex = 16;
			this.lstTabla.UseCompatibleStateImageBehavior = false;
			this.lstTabla.View = System.Windows.Forms.View.Details;
			this.lstTabla.SelectedIndexChanged += new System.EventHandler(this.LstTablaSelectedIndexChanged);
			// 
			// cmlCantidad
			// 
			this.cmlCantidad.Text = "Producto";
			this.cmlCantidad.Width = 141;
			// 
			// cmlMarca
			// 
			this.cmlMarca.Text = "Marca";
			this.cmlMarca.Width = 95;
			// 
			// clmCantidad
			// 
			this.clmCantidad.Text = "Cantidad";
			this.clmCantidad.Width = 72;
			// 
			// cmlProvedor
			// 
			this.cmlProvedor.Text = "Provedor";
			this.cmlProvedor.Width = 144;
			// 
			// clmPrecio
			// 
			this.clmPrecio.Text = "Precio";
			this.clmPrecio.Width = 96;
			// 
			// Precio
			// 
			this.Precio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Precio.Location = new System.Drawing.Point(13, 212);
			this.Precio.Name = "Precio";
			this.Precio.Size = new System.Drawing.Size(100, 23);
			this.Precio.TabIndex = 19;
			this.Precio.Text = "Precio";
			// 
			// txtPrecio
			// 
			this.txtPrecio.Location = new System.Drawing.Point(104, 211);
			this.txtPrecio.Name = "txtPrecio";
			this.txtPrecio.Size = new System.Drawing.Size(198, 20);
			this.txtPrecio.TabIndex = 20;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 366);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 21;
			this.label4.Text = "Salir";
			this.label4.Click += new System.EventHandler(this.Label4Click);
			// 
			// btnLimpiar
			// 
			this.btnLimpiar.BackColor = System.Drawing.SystemColors.Control;
			this.btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnLimpiar.Location = new System.Drawing.Point(12, 315);
			this.btnLimpiar.Name = "btnLimpiar";
			this.btnLimpiar.Size = new System.Drawing.Size(123, 29);
			this.btnLimpiar.TabIndex = 22;
			this.btnLimpiar.Text = "Limpiar";
			this.btnLimpiar.UseVisualStyleBackColor = false;
			this.btnLimpiar.Click += new System.EventHandler(this.BtnLimpiarClick);
			// 
			// frmRegistro
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(932, 398);
			this.Controls.Add(this.btnLimpiar);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.txtPrecio);
			this.Controls.Add(this.Precio);
			this.Controls.Add(this.btnQuitar);
			this.Controls.Add(this.lstTabla);
			this.Controls.Add(this.btnAgregar);
			this.Controls.Add(this.txtProvedor);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.txtCantidad);
			this.Controls.Add(this.lblMarca);
			this.Controls.Add(this.txtMarca);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.txtProducto);
			this.Controls.Add(this.label1);
			this.Name = "frmRegistro";
			this.Text = "frmRegistro";
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.Button btnLimpiar;
		private System.Windows.Forms.ColumnHeader clmPrecio;
		private System.Windows.Forms.ColumnHeader cmlProvedor;
		private System.Windows.Forms.ColumnHeader clmCantidad;
		private System.Windows.Forms.ColumnHeader cmlMarca;
		private System.Windows.Forms.ColumnHeader cmlCantidad;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtPrecio;
		private System.Windows.Forms.Label Precio;
		private System.Windows.Forms.Button btnQuitar;
		private System.Windows.Forms.ListView lstTabla;
		private System.Windows.Forms.Button btnAgregar;
		private System.Windows.Forms.TextBox txtProvedor;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtCantidad;
		private System.Windows.Forms.Label lblMarca;
		private System.Windows.Forms.TextBox txtMarca;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txtProducto;
		private System.Windows.Forms.Label label1;
	}
}
