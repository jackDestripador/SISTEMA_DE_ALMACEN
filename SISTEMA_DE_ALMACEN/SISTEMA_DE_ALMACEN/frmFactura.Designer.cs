﻿/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 19/11/2015
 * Hora: 09:58 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
namespace SISTEMA_DE_ALMACEN
{
	partial class frmFactura
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
			this.panel1 = new System.Windows.Forms.Panel();
			this.label1 = new System.Windows.Forms.Label();
			this.lstTabla = new System.Windows.Forms.ListView();
			this.crmFactura = new System.Windows.Forms.ColumnHeader();
			this.listView1 = new System.Windows.Forms.ListView();
			this.clmFecha = new System.Windows.Forms.ColumnHeader();
			this.label2 = new System.Windows.Forms.Label();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.textBox3 = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.textBox4 = new System.Windows.Forms.TextBox();
			this.listView2 = new System.Windows.Forms.ListView();
			this.crmCantidad = new System.Windows.Forms.ColumnHeader();
			this.clmDescripcion = new System.Windows.Forms.ColumnHeader();
			this.clmPrecio = new System.Windows.Forms.ColumnHeader();
			this.clmImporte = new System.Windows.Forms.ColumnHeader();
			this.label6 = new System.Windows.Forms.Label();
			this.textBox5 = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.textBox6 = new System.Windows.Forms.TextBox();
			this.label8 = new System.Windows.Forms.Label();
			this.textBox7 = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
			this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.panel1.Location = new System.Drawing.Point(12, 12);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(155, 72);
			this.panel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(135, 91);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(127, 23);
			this.label1.TabIndex = 1;
			this.label1.Text = "Datos del cliente";
			// 
			// lstTabla
			// 
			this.lstTabla.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.lstTabla.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.crmFactura});
			this.lstTabla.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.lstTabla.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lstTabla.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.lstTabla.Location = new System.Drawing.Point(351, 6);
			this.lstTabla.Name = "lstTabla";
			this.lstTabla.Size = new System.Drawing.Size(110, 48);
			this.lstTabla.TabIndex = 17;
			this.lstTabla.UseCompatibleStateImageBehavior = false;
			this.lstTabla.View = System.Windows.Forms.View.Details;
			// 
			// crmFactura
			// 
			this.crmFactura.Text = "Factura";
			this.crmFactura.Width = 106;
			// 
			// listView1
			// 
			this.listView1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.clmFecha});
			this.listView1.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listView1.Location = new System.Drawing.Point(351, 61);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(110, 48);
			this.listView1.TabIndex = 18;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// clmFecha
			// 
			this.clmFecha.Text = "Fecha";
			this.clmFecha.Width = 106;
			// 
			// label2
			// 
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(13, 128);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 23);
			this.label2.TabIndex = 19;
			this.label2.Text = "Cliente:";
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(81, 127);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(375, 20);
			this.textBox1.TabIndex = 21;
			// 
			// label3
			// 
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(13, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 22;
			this.label3.Text = "Dirección:";
			// 
			// textBox2
			// 
			this.textBox2.Location = new System.Drawing.Point(92, 154);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(364, 20);
			this.textBox2.TabIndex = 23;
			// 
			// label4
			// 
			this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(13, 182);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(100, 23);
			this.label4.TabIndex = 24;
			this.label4.Text = "CIudad:";
			// 
			// textBox3
			// 
			this.textBox3.Location = new System.Drawing.Point(81, 181);
			this.textBox3.Name = "textBox3";
			this.textBox3.Size = new System.Drawing.Size(375, 20);
			this.textBox3.TabIndex = 25;
			// 
			// label5
			// 
			this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(260, 216);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 23);
			this.label5.TabIndex = 26;
			this.label5.Text = "RFC:";
			// 
			// textBox4
			// 
			this.textBox4.Location = new System.Drawing.Point(305, 213);
			this.textBox4.Name = "textBox4";
			this.textBox4.Size = new System.Drawing.Size(151, 20);
			this.textBox4.TabIndex = 27;
			// 
			// listView2
			// 
			this.listView2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.listView2.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.crmCantidad,
									this.clmDescripcion,
									this.clmPrecio,
									this.clmImporte});
			this.listView2.Cursor = System.Windows.Forms.Cursors.IBeam;
			this.listView2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listView2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
			this.listView2.Location = new System.Drawing.Point(13, 242);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(466, 237);
			this.listView2.TabIndex = 28;
			this.listView2.UseCompatibleStateImageBehavior = false;
			this.listView2.View = System.Windows.Forms.View.Details;
			// 
			// crmCantidad
			// 
			this.crmCantidad.Text = "Cantidad";
			this.crmCantidad.Width = 69;
			// 
			// clmDescripcion
			// 
			this.clmDescripcion.Text = "Descripcion";
			this.clmDescripcion.Width = 220;
			// 
			// clmPrecio
			// 
			this.clmPrecio.Text = "Precio";
			this.clmPrecio.Width = 90;
			// 
			// clmImporte
			// 
			this.clmImporte.Text = "Importe";
			this.clmImporte.Width = 82;
			// 
			// label6
			// 
			this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(285, 482);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(100, 23);
			this.label6.TabIndex = 29;
			this.label6.Text = "Sub Total";
			// 
			// textBox5
			// 
			this.textBox5.Location = new System.Drawing.Point(351, 479);
			this.textBox5.Name = "textBox5";
			this.textBox5.Size = new System.Drawing.Size(128, 20);
			this.textBox5.TabIndex = 30;
			// 
			// label7
			// 
			this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(285, 504);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(100, 23);
			this.label7.TabIndex = 31;
			this.label7.Text = "Iva";
			// 
			// textBox6
			// 
			this.textBox6.Location = new System.Drawing.Point(351, 502);
			this.textBox6.Name = "textBox6";
			this.textBox6.Size = new System.Drawing.Size(128, 20);
			this.textBox6.TabIndex = 32;
			// 
			// label8
			// 
			this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label8.Location = new System.Drawing.Point(285, 526);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(100, 23);
			this.label8.TabIndex = 33;
			this.label8.Text = "Total";
			// 
			// textBox7
			// 
			this.textBox7.Location = new System.Drawing.Point(351, 524);
			this.textBox7.Name = "textBox7";
			this.textBox7.Size = new System.Drawing.Size(128, 20);
			this.textBox7.TabIndex = 34;
			// 
			// frmFactura
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
			this.ClientSize = new System.Drawing.Size(500, 560);
			this.Controls.Add(this.textBox7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.textBox6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.textBox5);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.textBox4);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.textBox3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.lstTabla);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.panel1);
			this.Name = "frmFactura";
			this.Text = "Factura";
			this.Load += new System.EventHandler(this.FrmFacturaLoad);
			this.ResumeLayout(false);
			this.PerformLayout();
		}
		private System.Windows.Forms.TextBox textBox7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.TextBox textBox6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.TextBox textBox5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.ColumnHeader clmImporte;
		private System.Windows.Forms.ColumnHeader clmPrecio;
		private System.Windows.Forms.ColumnHeader clmDescripcion;
		private System.Windows.Forms.ColumnHeader crmCantidad;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.TextBox textBox4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.TextBox textBox3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox textBox2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox textBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ColumnHeader clmFecha;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader crmFactura;
		private System.Windows.Forms.ListView lstTabla;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Panel panel1;
	}
}
