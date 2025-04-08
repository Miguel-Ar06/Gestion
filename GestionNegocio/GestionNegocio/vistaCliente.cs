using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionNegocio.MainClasses;

namespace GestionNegocio
{
    public partial class vistaCliente : Form
    {
        Cliente cliente;
        Negocio negocio;

        // rutas
        private static string rutaDeAplicacion = AppDomain.CurrentDomain.BaseDirectory;
        private static string rutaDeArchivoClientes = Path.Combine(rutaDeAplicacion, "Resources", "data", "clientes.csv");
        private static string rutaDeArchivoMovimientos = Path.Combine(rutaDeAplicacion, "Resources", "data", "movimientos.csv");
        private static string rutaArchivoNegocio = Path.Combine(rutaDeAplicacion, "Resources", "data", "negocioConfig.csv");

        // datagrids y fuentes
        private static BindingList<Movimiento> movimientos = HerramientasCsv.ListaStringsAMovimientos(HerramientasCsv.LeerTodasLasLineas(rutaDeArchivoMovimientos));
        private DataGridView _tablaHistorial;
        private BindingSource registroDeMovimientos = new BindingSource();

        private static BindingList<Producto> productos = new BindingList<Producto>(); // pendiente el archivo csv
        private DataGridView _tablaCarrito;
        private BindingSource registroInventario = new BindingSource();

        public vistaCliente(Cliente cliente, Negocio negocio)
        {
            InitializeComponent();
            this.cliente = cliente;
            this.negocio = negocio;
        }

        private void vistaCliente_Load(object sender, EventArgs e)
        {
            // interfaz
            nombreNegocio.Text = negocio.nombre;
            nombreNegocio.ForeColor = negocio.coloresPrograma.colorSecundario;

            labelNombreClienteInterfaz.Text = cliente.nombre;
            labelNombreClienteInterfaz.ForeColor = negocio.coloresPrograma.colorPrincipal;

            botonBuscarProducto.ForeColor = negocio.coloresPrograma.colorSecundario;

            // Datagrids
            _tablaCarrito = tablaDeCarrito;
            _tablaHistorial = tablaHistorial;

            //pestana perfil
            textBoxNombre.Text = cliente.nombre;
            textBoxCedula.Text = cliente.cedula.ToString();
            textBoxCorreo.Text = cliente.correo;
            textBoxEdad.Text = cliente.edad.ToString();
            textBoxResidencia.Text = cliente.residencia;
        }

        private void vistaCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
