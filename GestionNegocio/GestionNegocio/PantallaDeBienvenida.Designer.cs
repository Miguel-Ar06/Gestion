
namespace GestionNegocio
{
    partial class PantallaDeBienvenida
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PantallaDeBienvenida));
            textoBienvenida = new Label();
            imageList1 = new ImageList(components);
            nombreNegocio = new TextBox();
            selectorColor = new ComboBox();
            botonRegistrarse = new Button();
            iconoNegocioMaterial = new PictureBox();
            textoVersion = new Label();
            textBoxNombre = new TextBox();
            textBoxCorreo = new TextBox();
            textBoxContrasena = new TextBox();
            textBoxResidencia = new TextBox();
            textBoxEdad = new TextBox();
            botonIniciarSesion = new Button();
            botonIngresar = new Button();
            botonAdminCliente = new Button();
            textBoxCredencial = new TextBox();
            textBoxCedula = new TextBox();
            ((System.ComponentModel.ISupportInitialize)iconoNegocioMaterial).BeginInit();
            SuspendLayout();
            // 
            // textoBienvenida
            // 
            textoBienvenida.Anchor = AnchorStyles.Top;
            textoBienvenida.AutoSize = true;
            textoBienvenida.Font = new Font("SchulVokalDotless", 23.9999981F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoBienvenida.ForeColor = Color.FromArgb(64, 64, 64);
            textoBienvenida.ImageAlign = ContentAlignment.TopCenter;
            textoBienvenida.ImageList = imageList1;
            textoBienvenida.Location = new Point(453, 183);
            textoBienvenida.Name = "textoBienvenida";
            textoBienvenida.Size = new Size(240, 41);
            textoBienvenida.TabIndex = 0;
            textoBienvenida.Text = "Bienvenido!";
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth32Bit;
            imageList1.ImageStream = (ImageListStreamer)resources.GetObject("imageList1.ImageStream");
            imageList1.TransparentColor = Color.Transparent;
            imageList1.Images.SetKeyName(0, "store_90dp_434343_FILL0_wght400_GRAD0_opsz48.png");
            // 
            // nombreNegocio
            // 
            nombreNegocio.Anchor = AnchorStyles.Top;
            nombreNegocio.BorderStyle = BorderStyle.FixedSingle;
            nombreNegocio.Location = new Point(438, 364);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.PlaceholderText = "Nombre del negocio";
            nombreNegocio.Size = new Size(270, 27);
            nombreNegocio.TabIndex = 2;
            nombreNegocio.Visible = false;
            // 
            // selectorColor
            // 
            selectorColor.Anchor = AnchorStyles.Top;
            selectorColor.ForeColor = Color.DimGray;
            selectorColor.FormattingEnabled = true;
            selectorColor.Items.AddRange(new object[] { "Azul", "Verde", "Amarillo", "Naranja", "Rojo", "Violeta", "Negro", "Gris" });
            selectorColor.Location = new Point(438, 409);
            selectorColor.Name = "selectorColor";
            selectorColor.Size = new Size(270, 28);
            selectorColor.TabIndex = 3;
            selectorColor.Text = "Tema de color";
            selectorColor.Visible = false;
            selectorColor.SelectedIndexChanged += selectorColor_SelectedItemChanged;
            // 
            // botonRegistrarse
            // 
            botonRegistrarse.Anchor = AnchorStyles.Top;
            botonRegistrarse.BackColor = SystemColors.ControlLightLight;
            botonRegistrarse.ForeColor = SystemColors.ActiveCaptionText;
            botonRegistrarse.Location = new Point(428, 501);
            botonRegistrarse.Name = "botonRegistrarse";
            botonRegistrarse.Size = new Size(141, 43);
            botonRegistrarse.TabIndex = 4;
            botonRegistrarse.Text = "Registrarse";
            botonRegistrarse.UseVisualStyleBackColor = false;
            botonRegistrarse.Click += botonRegistrarse_Click;
            // 
            // iconoNegocioMaterial
            // 
            iconoNegocioMaterial.Anchor = AnchorStyles.Top;
            iconoNegocioMaterial.Image = Properties.Resources.store_20dp_434343_FILL0_wght400_GRAD0_opsz20;
            iconoNegocioMaterial.Location = new Point(527, 100);
            iconoNegocioMaterial.Name = "iconoNegocioMaterial";
            iconoNegocioMaterial.Size = new Size(80, 80);
            iconoNegocioMaterial.SizeMode = PictureBoxSizeMode.AutoSize;
            iconoNegocioMaterial.TabIndex = 5;
            iconoNegocioMaterial.TabStop = false;
            // 
            // textoVersion
            // 
            textoVersion.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textoVersion.AutoSize = true;
            textoVersion.Location = new Point(24, 675);
            textoVersion.Name = "textoVersion";
            textoVersion.Size = new Size(225, 20);
            textoVersion.TabIndex = 6;
            textoVersion.Text = "Ver. Beta 0.1.3. Miguel Arismendi";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Anchor = AnchorStyles.Top;
            textBoxNombre.BorderStyle = BorderStyle.FixedSingle;
            textBoxNombre.Location = new Point(438, 300);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.PlaceholderText = "Nombre";
            textBoxNombre.Size = new Size(193, 27);
            textBoxNombre.TabIndex = 8;
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Anchor = AnchorStyles.Top;
            textBoxCorreo.BorderStyle = BorderStyle.FixedSingle;
            textBoxCorreo.Location = new Point(438, 343);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.PlaceholderText = "Correo";
            textBoxCorreo.Size = new Size(270, 27);
            textBoxCorreo.TabIndex = 9;
            // 
            // textBoxContrasena
            // 
            textBoxContrasena.Anchor = AnchorStyles.Top;
            textBoxContrasena.BorderStyle = BorderStyle.FixedSingle;
            textBoxContrasena.Location = new Point(438, 388);
            textBoxContrasena.Name = "textBoxContrasena";
            textBoxContrasena.PlaceholderText = "Contraseña";
            textBoxContrasena.Size = new Size(270, 27);
            textBoxContrasena.TabIndex = 10;
            // 
            // textBoxResidencia
            // 
            textBoxResidencia.Anchor = AnchorStyles.Top;
            textBoxResidencia.BorderStyle = BorderStyle.FixedSingle;
            textBoxResidencia.Location = new Point(438, 433);
            textBoxResidencia.Name = "textBoxResidencia";
            textBoxResidencia.PlaceholderText = "Residencia";
            textBoxResidencia.Size = new Size(131, 27);
            textBoxResidencia.TabIndex = 11;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Anchor = AnchorStyles.Top;
            textBoxEdad.BorderStyle = BorderStyle.FixedSingle;
            textBoxEdad.Location = new Point(637, 300);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.PlaceholderText = "Edad";
            textBoxEdad.Size = new Size(71, 27);
            textBoxEdad.TabIndex = 12;
            textBoxEdad.Visible = false;
            // 
            // botonIniciarSesion
            // 
            botonIniciarSesion.Anchor = AnchorStyles.Top;
            botonIniciarSesion.BackColor = SystemColors.ControlLightLight;
            botonIniciarSesion.ForeColor = SystemColors.ActiveCaptionText;
            botonIniciarSesion.Location = new Point(585, 501);
            botonIniciarSesion.Name = "botonIniciarSesion";
            botonIniciarSesion.Size = new Size(141, 43);
            botonIniciarSesion.TabIndex = 13;
            botonIniciarSesion.Text = "Iniciar Sesion";
            botonIniciarSesion.UseVisualStyleBackColor = false;
            botonIniciarSesion.Click += botonIniciarSesion_Click;
            // 
            // botonIngresar
            // 
            botonIngresar.Anchor = AnchorStyles.Top;
            botonIngresar.BackColor = SystemColors.ControlLightLight;
            botonIngresar.ForeColor = SystemColors.ActiveCaptionText;
            botonIngresar.Location = new Point(504, 452);
            botonIngresar.Name = "botonIngresar";
            botonIngresar.Size = new Size(141, 43);
            botonIngresar.TabIndex = 14;
            botonIngresar.Text = "Ingresar";
            botonIngresar.UseVisualStyleBackColor = false;
            botonIngresar.Visible = false;
            botonIngresar.Click += botonIngresar_Click;
            // 
            // botonAdminCliente
            // 
            botonAdminCliente.Anchor = AnchorStyles.Top;
            botonAdminCliente.BackColor = SystemColors.ControlLightLight;
            botonAdminCliente.ForeColor = SystemColors.ActiveCaptionText;
            botonAdminCliente.Location = new Point(984, 652);
            botonAdminCliente.Name = "botonAdminCliente";
            botonAdminCliente.Size = new Size(141, 43);
            botonAdminCliente.TabIndex = 15;
            botonAdminCliente.Text = "Admin / cliente";
            botonAdminCliente.UseVisualStyleBackColor = false;
            botonAdminCliente.Click += botonAdminCliente_Click;
            // 
            // textBoxCredencial
            // 
            textBoxCredencial.Anchor = AnchorStyles.Top;
            textBoxCredencial.BorderStyle = BorderStyle.FixedSingle;
            textBoxCredencial.Location = new Point(438, 321);
            textBoxCredencial.Name = "textBoxCredencial";
            textBoxCredencial.PlaceholderText = "Credencial de administrador";
            textBoxCredencial.Size = new Size(270, 27);
            textBoxCredencial.TabIndex = 16;
            textBoxCredencial.Visible = false;
            // 
            // textBoxCedula
            // 
            textBoxCedula.Anchor = AnchorStyles.Top;
            textBoxCedula.BorderStyle = BorderStyle.FixedSingle;
            textBoxCedula.Location = new Point(575, 433);
            textBoxCedula.Name = "textBoxCedula";
            textBoxCedula.PlaceholderText = "Cedula";
            textBoxCedula.Size = new Size(133, 27);
            textBoxCedula.TabIndex = 17;
            // 
            // PantallaDeBienvenida
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1137, 719);
            Controls.Add(textBoxCedula);
            Controls.Add(textBoxCredencial);
            Controls.Add(botonAdminCliente);
            Controls.Add(botonIngresar);
            Controls.Add(botonIniciarSesion);
            Controls.Add(textBoxEdad);
            Controls.Add(textBoxResidencia);
            Controls.Add(textBoxContrasena);
            Controls.Add(textBoxCorreo);
            Controls.Add(textBoxNombre);
            Controls.Add(textoVersion);
            Controls.Add(iconoNegocioMaterial);
            Controls.Add(botonRegistrarse);
            Controls.Add(selectorColor);
            Controls.Add(nombreNegocio);
            Controls.Add(textoBienvenida);
            Name = "PantallaDeBienvenida";
            Text = "Form1";
            Load += PantallaDeBienvenida_Load;
            ((System.ComponentModel.ISupportInitialize)iconoNegocioMaterial).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label textoBienvenida;
        private TextBox nombreNegocio;
        private ComboBox selectorColor;
        private Button botonRegistrarse;
        private ImageList imageList1;
        private PictureBox iconoNegocioMaterial;
        private Label textoVersion;
        private TextBox textBoxNombre;
        private TextBox textBoxCorreo;
        private TextBox textBoxContrasena;
        private TextBox textBoxCedula;
        private TextBox textBoxResidencia;
        private TextBox textBoxEdad;
        private Button botonIniciarSesion;
        private Button botonIngresar;
        private Button botonAdminCliente;
        private TextBox textBoxCredencial;

        // getters
        public string GetItemTextoSelectorColor()
        {
            if (selectorColor.SelectedItem != null)
            {
                return selectorColor.SelectedItem.ToString();
            }
            else
            {
                return "";
            }
        }
        public string GetNombreNegocio()
        {
            return nombreNegocio.Text;
        }
        public string GetCredencial()
        {
            return textBoxCredencial.Text;
        }
        public string GetNombre()
        {
            return textBoxNombre.Text;
        }
        public string GetCorreo()
        {
            return textBoxCorreo.Text.Trim();
        }
        public string GetContrasena()
        {
            return textBoxContrasena.Text.Trim();
        }
        public int GetEdad()
        {
            int edad;
            if (int.TryParse(textBoxEdad.Text.Trim(), out edad))
            {
                return edad;
            }
            else
            {
                MessageBox.Show("Introduzca una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public long GetCedula()
        {
            long cedula;
            if (long.TryParse(textBoxCedula.Text.Trim(), out cedula))
            {
                return cedula;
            }
            else
            {
                MessageBox.Show("Introduzca una cedula valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string GetResidencia()
        {
            return textBoxResidencia.Text.Trim();
        }

        // setters
        public void SetColorBotonBienvenida(Color colorFondo, Color colorTexto)
        {
            botonRegistrarse.BackColor = colorFondo;
            botonRegistrarse.ForeColor = colorTexto;
        }
        public void SetColorTextoBienvenida(Color colorTexto)
        {
            textoBienvenida.ForeColor = colorTexto;
        }
        public void SetModoIngresoAAdmin(bool valor, bool esPrimerIngreso)
        {
            botonIngresar.Visible = valor;
            textBoxCredencial.Visible = valor;
            nombreNegocio.Visible = (esPrimerIngreso && valor);
            selectorColor.Visible = (esPrimerIngreso && valor);

            textBoxNombre.Visible = !valor;
            textBoxCorreo.Visible = !valor;
            textBoxEdad.Visible = !valor;
            textBoxContrasena.Visible = !valor;
            textBoxResidencia.Visible = !valor;
            botonIniciarSesion.Visible = !valor;
            botonRegistrarse.Visible = !valor;
            textBoxCedula.Visible = !valor;
        }
        public void LimpiarCedula()
        {
            textBoxCedula.Clear();
        }
        public void LimpiarNombre()
        {
            textBoxNombre.Clear();
        }
        public void LimpiarCorreo()
        {
            textBoxNombre.Clear();
        }
        public void LimpiarEdad()
        {
            textBoxEdad.Clear();
        }
        public void LimpiarResidencia()
        {
            textBoxResidencia.Clear();
        }

        // utilidades
        public bool ValidarCorreo(string correo)
        {
            try
            {
                var direccionDeCorreo = new System.Net.Mail.MailAddress(correo);
                return direccionDeCorreo.Address == correo;
            }
            catch
            {
                return false;
            }
        }
    }
}
