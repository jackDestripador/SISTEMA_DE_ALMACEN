/*
 * Creado por SharpDevelop.
 * Usuario: marcoantonio
 * Fecha: 12/11/2015
 * Hora: 10:00 p. m.
 * 
 * Para cambiar esta plantilla use Herramientas | Opciones | Codificación | Editar Encabezados Estándar
 */
using System;
using System.Drawing;
using System.Windows.Forms;
//using MySql;
//using MySql.Data.MySqlClient;

namespace SISTEMA_DE_ALMACEN
{
	/// <summary>
	/// Description of frmRegistro.
	/// </summary>
	public partial class frmRegistro : Form
	{
		public frmRegistro()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		
		//MySqlConnection conectar  = new MySqlConnection("server =127.0.0.1; Material = Nombre; Uid = root; pwd =admin;");
		
		void BtnAgregarClick(object sender, EventArgs e)
		{
			
	
			ListViewItem lista = new ListViewItem(txtProducto.Text);
			lista.SubItems.Add(txtMarca.Text);
			lista.SubItems.Add(txtCantidad.Text);
			lista.SubItems.Add(txtProvedor.Text);
			lista.SubItems.Add(txtPrecio.Text);
			lstTabla.Items.Add(lista);
		}
		
		
		
		void Label4Click(object sender, EventArgs e)
		{
			this.Close();
		}
		
		void LstTablaSelectedIndexChanged(object sender, EventArgs e)
		{
			
		}
		
		void BtnQuitarClick(object sender, EventArgs e)
		{
			foreach (ListViewItem lista in lstTabla.SelectedItems)
			{
				lista.Remove();
			}
		}
		
		void BtnLimpiarClick(object sender, EventArgs e)
		{
			lstTabla.Items.Clear();
		}
	}
}
