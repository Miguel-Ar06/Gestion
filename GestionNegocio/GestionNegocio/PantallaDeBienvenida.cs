using System.ComponentModel;
using GestionNegocio.MainClasses;
using GestionNegocio.UIclasses;

namespace GestionNegocio
{
    public partial class PantallaDeBienvenida : Form
    {
        private static string rutaDeLaAplicacion = AppDomain.CurrentDomain.BaseDirectory;
        private static string rutaArchivoNegocio = Path.Combine(rutaDeLaAplicacion, "Resources", "data", "negocioConfig.csv");
        private static string rutaDeArchivoClientes = Path.Combine(rutaDeLaAplicacion, "Resources", "data", "clientes.csv");

        private Negocio negocio;
        private bool negocioExiste;

        private bool modoAdmin = true;

        private static BindingList<Cliente> clientes = HerramientasCsv.ListaStringsAClientes(HerramientasCsv.LeerTodasLasLineas(rutaDeArchivoClientes));

        #region paleta de colores del programa y diccionario de temas

        public PaletaDeColor coloresPrograma;
        public static Dictionary<string, PaletaDeColor> temas = new Dictionary<string, PaletaDeColor>();

        public PantallaDeBienvenida()
        {
            InitializeComponent();
            this.AutoScaleMode = AutoScaleMode.Dpi;

            // poblar diccionario con temas
            temas.Add("Azul", new PaletaDeColor("Azul", Color.FromArgb(0, 128, 255), Color.FromArgb(0, 153, 153), Color.FromArgb(255, 255, 255)));
            temas.Add("Verde", new PaletaDeColor("Verde", Color.FromArgb(0, 204, 102), Color.FromArgb(102, 204, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Amarillo", new PaletaDeColor("Amarillo", Color.FromArgb(204, 204, 0), Color.FromArgb(102, 102, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Naranja", new PaletaDeColor("Naranja", Color.FromArgb(255, 126, 0), Color.FromArgb(153, 76, 0), Color.FromArgb(255, 255, 255)));
            temas.Add("Rojo", new PaletaDeColor("Rojo", Color.FromArgb(204, 0, 0), Color.FromArgb(204, 0, 102), Color.FromArgb(255, 255, 255)));
            temas.Add("Violeta", new PaletaDeColor("Violeta", Color.FromArgb(102, 0, 204), Color.FromArgb(153, 0, 153), Color.FromArgb(255, 255, 255)));
            temas.Add("Negro", new PaletaDeColor("Negro", Color.FromArgb(32, 32, 32), Color.FromArgb(64, 64, 64), Color.FromArgb(255, 255, 255)));
            temas.Add("Gris", new PaletaDeColor("Gris", Color.FromArgb(96, 96, 96), Color.FromArgb(160, 160, 160), Color.FromArgb(255, 255, 255)));

            // inicializar negocio desde el csv
            negocio = HerramientasCsv.GetNegocioDesdeCsv(rutaArchivoNegocio, temas);

            negocioExiste = !String.IsNullOrEmpty(negocio.nombre);
        }

        private void PantallaDeBienvenida_Load(object sender, EventArgs e)
        {
            SetColorTextoBienvenida(negocio.coloresPrograma.colorPrincipal);

            if (negocioExiste == false)
            {
                SetModoIngresoAAdmin(true, !negocioExiste);
            }
            else
            {
                SetModoIngresoAAdmin(false, !negocioExiste);
            }
        }

        string colorSeleccionado;
        private void selectorColor_SelectedItemChanged(object sender, EventArgs e)
        {
            colorSeleccionado = GetItemTextoSelectorColor();

            if (temas.ContainsKey(colorSeleccionado))
            {
                coloresPrograma = temas[colorSeleccionado];
                Console.WriteLine("Color establecido a " + colorSeleccionado);
            }
            else
            {
                coloresPrograma = temas["Gris"];
                Console.WriteLine("Color del tema establecido a color por defecto gris");
            }

            SetColorBotonBienvenida(coloresPrograma.colorPrincipal, coloresPrograma.colorTextos);
            SetColorTextoBienvenida(coloresPrograma.colorPrincipal);
            Console.WriteLine("Paleta de color cambiada a " + coloresPrograma.nombre);
        }

        #endregion


        #region eventos
        private void botonRegistrarse_Click(object sender, EventArgs e)
        {
            long clienteCedula = GetCedula();
            string clienteNombre = GetNombre();
            string clienteCorreo = GetCorreo();
            int clienteEdad = GetEdad();
            string clienteResidencia = GetResidencia();
            string clienteContrasena = GetContrasena();

            Cliente clienteActual = new Cliente(clienteCedula, clienteNombre, clienteCorreo, clienteEdad, clienteResidencia, clienteContrasena);

            if (clienteCedula != -1 && clienteNombre != "" && clienteCorreo != "" && clienteEdad != -1 && clienteResidencia != "" && ValidarCorreo(clienteCorreo))
            {
                if (cedulaClienteExiste(clienteCedula) == false)
                {
                    clientes.Add(clienteActual);
                    HerramientasCsv.AgregarCliente(rutaDeArchivoClientes, clienteActual);
                    Console.WriteLine("Cliente registrado exitosamente");
                    LimpiarCedula();
                    LimpiarNombre();
                    LimpiarCorreo();
                    LimpiarEdad();
                    LimpiarResidencia();
                }
                else
                {
                    MessageBox.Show("El cliente ya existe", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Rellene los campos correctamente", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Error, cliente no agregado");
            }
        }

        private bool cedulaClienteExiste(long cedula)
        {
            foreach (Cliente cliente in clientes)
            {
                if (cliente.cedula == cedula)
                {
                    return true;
                }
            }
            return false;
        }

        private void botonAdminCliente_Click(object sender, EventArgs e)
        {
            if (modoAdmin == true)
            {
                SetModoIngresoAAdmin(false, !negocioExiste);
                modoAdmin = false;
            }
            else
            {
                SetModoIngresoAAdmin(true, !negocioExiste);
                modoAdmin = true;
            }
        }

        private void botonIniciarSesion_Click(object sender, EventArgs e)
        {

        }

        private void botonIngresar_Click(object sender, EventArgs e)
        {
            if (!negocioExiste)
            {
                colorSeleccionado = GetItemTextoSelectorColor();
                if (temas.ContainsKey(colorSeleccionado) == false)
                {
                    coloresPrograma = temas["Gris"];
                    Console.WriteLine("Color del tema establecido a color por defecto gris");
                }

                if (GetNombreNegocio() == "" || GetCredencial() == "")
                {
                    MessageBox.Show("Rellene los campos indicados.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    coloresPrograma = temas[colorSeleccionado];
                    negocio = new Negocio(GetNombreNegocio(), coloresPrograma, GetCredencial());
                    Console.WriteLine("Ventana de menu abierta");
                    MenuPrincipal menuPrincipal = new MenuPrincipal(negocio);
                    HerramientasCsv.ActualizarConfiguracionNegocio(rutaArchivoNegocio, negocio);
                    menuPrincipal.Show();

                    this.Hide();
                    Console.WriteLine("Ventana de bienvenida cerrada");
                }
            }
            else
            {
                Negocio negocioActual = HerramientasCsv.GetNegocioDesdeCsv(rutaArchivoNegocio, temas);
                string credencialIntroducida = GetCredencial();

                if (credencialIntroducida == negocioActual.credencial)
                {
                    MenuPrincipal menuPrincipal = new MenuPrincipal(negocio);
                    menuPrincipal.Show();
                    this.Hide();
                }
            }


        }

        #endregion

    }
}
