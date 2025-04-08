namespace GestionNegocio
{
    partial class vistaCliente
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            nombreNegocio = new Label();
            pestanaAjustes = new TabPage();
            botonGuardarCambios = new Button();
            labelProximaRecompensa = new Label();
            labelProgresoNivel = new Label();
            labelNivel = new Label();
            progressBarNivel = new ProgressBar();
            textBoxContrasenaNueva = new TextBox();
            labelContrasenaNueva = new Label();
            textBoxContrasenaActual = new TextBox();
            labelContrasenaActual = new Label();
            labelCuponesDisponibles = new Label();
            tablaCuponesDisponibles = new DataGridView();
            botonEditarCliente = new Button();
            textBoxEdad = new TextBox();
            labelEdad = new Label();
            textBoxResidencia = new TextBox();
            labelResidencia = new Label();
            textBoxCorreo = new TextBox();
            labelCorreo = new Label();
            textBoxCedula = new TextBox();
            labelCedula = new Label();
            textBoxNombre = new TextBox();
            labelNombre = new Label();
            pestanaHistorial = new TabPage();
            botonBuscarProducto = new Button();
            tablaHistorial = new DataGridView();
            descripcionProducto = new TextBox();
            marcaProducto = new TextBox();
            precioProducto = new TextBox();
            cantidadProducto = new TextBox();
            nombreProducto = new TextBox();
            pestanaComprar = new TabPage();
            textBoxDescripcion = new TextBox();
            botonAgregarCupon = new Button();
            comboBoxCupon = new ComboBox();
            botonEliminarDescuento = new Button();
            tablaDescuentos = new DataGridView();
            labelDescuentos = new Label();
            labelEscogerCupon = new Label();
            botonAgregarProducto = new Button();
            comboBoxProductos = new ComboBox();
            labelEsocgerProducto = new Label();
            textoMetodoDePago = new Label();
            MetodoDePago = new ComboBox();
            montoTotal = new Label();
            textoTotal = new Label();
            tablaDeCarrito = new DataGridView();
            labelCarrito = new Label();
            botonEliminarCarrito = new Button();
            botonCompletarCompra = new Button();
            controlPestanas = new TabControl();
            labelNombreClienteInterfaz = new Label();
            pestanaAjustes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCuponesDisponibles).BeginInit();
            pestanaHistorial.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaHistorial).BeginInit();
            pestanaComprar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDescuentos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tablaDeCarrito).BeginInit();
            controlPestanas.SuspendLayout();
            SuspendLayout();
            // 
            // nombreNegocio
            // 
            nombreNegocio.AutoSize = true;
            nombreNegocio.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            nombreNegocio.Location = new Point(870, 22);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.Size = new Size(308, 41);
            nombreNegocio.TabIndex = 2;
            nombreNegocio.Text = "Nombre Del Negocio";
            // 
            // pestanaAjustes
            // 
            pestanaAjustes.Controls.Add(botonGuardarCambios);
            pestanaAjustes.Controls.Add(labelProximaRecompensa);
            pestanaAjustes.Controls.Add(labelProgresoNivel);
            pestanaAjustes.Controls.Add(labelNivel);
            pestanaAjustes.Controls.Add(progressBarNivel);
            pestanaAjustes.Controls.Add(textBoxContrasenaNueva);
            pestanaAjustes.Controls.Add(labelContrasenaNueva);
            pestanaAjustes.Controls.Add(textBoxContrasenaActual);
            pestanaAjustes.Controls.Add(labelContrasenaActual);
            pestanaAjustes.Controls.Add(labelCuponesDisponibles);
            pestanaAjustes.Controls.Add(tablaCuponesDisponibles);
            pestanaAjustes.Controls.Add(botonEditarCliente);
            pestanaAjustes.Controls.Add(textBoxEdad);
            pestanaAjustes.Controls.Add(labelEdad);
            pestanaAjustes.Controls.Add(textBoxResidencia);
            pestanaAjustes.Controls.Add(labelResidencia);
            pestanaAjustes.Controls.Add(textBoxCorreo);
            pestanaAjustes.Controls.Add(labelCorreo);
            pestanaAjustes.Controls.Add(textBoxCedula);
            pestanaAjustes.Controls.Add(labelCedula);
            pestanaAjustes.Controls.Add(textBoxNombre);
            pestanaAjustes.Controls.Add(labelNombre);
            pestanaAjustes.Location = new Point(4, 37);
            pestanaAjustes.Name = "pestanaAjustes";
            pestanaAjustes.Size = new Size(1162, 574);
            pestanaAjustes.TabIndex = 3;
            pestanaAjustes.Text = "Perfil";
            pestanaAjustes.UseVisualStyleBackColor = true;
            // 
            // botonGuardarCambios
            // 
            botonGuardarCambios.Location = new Point(31, 515);
            botonGuardarCambios.Name = "botonGuardarCambios";
            botonGuardarCambios.Size = new Size(183, 41);
            botonGuardarCambios.TabIndex = 34;
            botonGuardarCambios.Text = "Guardar cambios";
            botonGuardarCambios.UseVisualStyleBackColor = true;
            botonGuardarCambios.Visible = false;
            // 
            // labelProximaRecompensa
            // 
            labelProximaRecompensa.AutoSize = true;
            labelProximaRecompensa.Location = new Point(595, 277);
            labelProximaRecompensa.Name = "labelProximaRecompensa";
            labelProximaRecompensa.Size = new Size(238, 28);
            labelProximaRecompensa.TabIndex = 33;
            labelProximaRecompensa.Text = "Proxima recompensa: ---";
            // 
            // labelProgresoNivel
            // 
            labelProgresoNivel.AutoSize = true;
            labelProgresoNivel.Location = new Point(977, 228);
            labelProgresoNivel.Name = "labelProgresoNivel";
            labelProgresoNivel.Size = new Size(63, 28);
            labelProgresoNivel.TabIndex = 32;
            labelProgresoNivel.Text = "--/--$";
            // 
            // labelNivel
            // 
            labelNivel.AutoSize = true;
            labelNivel.Location = new Point(595, 191);
            labelNivel.Name = "labelNivel";
            labelNivel.Size = new Size(74, 28);
            labelNivel.TabIndex = 31;
            labelNivel.Text = "Nivel x";
            // 
            // progressBarNivel
            // 
            progressBarNivel.Location = new Point(595, 227);
            progressBarNivel.Name = "progressBarNivel";
            progressBarNivel.Size = new Size(361, 29);
            progressBarNivel.TabIndex = 30;
            // 
            // textBoxContrasenaNueva
            // 
            textBoxContrasenaNueva.Location = new Point(31, 394);
            textBoxContrasenaNueva.Name = "textBoxContrasenaNueva";
            textBoxContrasenaNueva.ReadOnly = true;
            textBoxContrasenaNueva.Size = new Size(391, 34);
            textBoxContrasenaNueva.TabIndex = 29;
            textBoxContrasenaNueva.Visible = false;
            textBoxContrasenaNueva.WordWrap = false;
            // 
            // labelContrasenaNueva
            // 
            labelContrasenaNueva.AutoSize = true;
            labelContrasenaNueva.Location = new Point(31, 363);
            labelContrasenaNueva.Name = "labelContrasenaNueva";
            labelContrasenaNueva.Size = new Size(175, 28);
            labelContrasenaNueva.TabIndex = 28;
            labelContrasenaNueva.Text = "Contraseña nueva";
            labelContrasenaNueva.Visible = false;
            // 
            // textBoxContrasenaActual
            // 
            textBoxContrasenaActual.Location = new Point(31, 308);
            textBoxContrasenaActual.Name = "textBoxContrasenaActual";
            textBoxContrasenaActual.ReadOnly = true;
            textBoxContrasenaActual.Size = new Size(391, 34);
            textBoxContrasenaActual.TabIndex = 27;
            textBoxContrasenaActual.Visible = false;
            // 
            // labelContrasenaActual
            // 
            labelContrasenaActual.AutoSize = true;
            labelContrasenaActual.Location = new Point(31, 277);
            labelContrasenaActual.Name = "labelContrasenaActual";
            labelContrasenaActual.Size = new Size(173, 28);
            labelContrasenaActual.TabIndex = 26;
            labelContrasenaActual.Text = "Contraseña actual";
            labelContrasenaActual.Visible = false;
            // 
            // labelCuponesDisponibles
            // 
            labelCuponesDisponibles.AutoSize = true;
            labelCuponesDisponibles.Location = new Point(595, 28);
            labelCuponesDisponibles.Name = "labelCuponesDisponibles";
            labelCuponesDisponibles.Size = new Size(328, 28);
            labelCuponesDisponibles.TabIndex = 25;
            labelCuponesDisponibles.Text = "Cupones y descuentos disponibles";
            // 
            // tablaCuponesDisponibles
            // 
            tablaCuponesDisponibles.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaCuponesDisponibles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tablaCuponesDisponibles.DefaultCellStyle = dataGridViewCellStyle1;
            tablaCuponesDisponibles.Location = new Point(595, 59);
            tablaCuponesDisponibles.Name = "tablaCuponesDisponibles";
            tablaCuponesDisponibles.RowHeadersWidth = 51;
            tablaCuponesDisponibles.Size = new Size(536, 114);
            tablaCuponesDisponibles.TabIndex = 24;
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.Location = new Point(994, 515);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(137, 41);
            botonEditarCliente.TabIndex = 11;
            botonEditarCliente.Text = "Editar";
            botonEditarCliente.UseVisualStyleBackColor = true;
            // 
            // textBoxEdad
            // 
            textBoxEdad.Location = new Point(438, 139);
            textBoxEdad.Name = "textBoxEdad";
            textBoxEdad.ReadOnly = true;
            textBoxEdad.Size = new Size(115, 34);
            textBoxEdad.TabIndex = 10;
            // 
            // labelEdad
            // 
            labelEdad.AutoSize = true;
            labelEdad.Location = new Point(438, 108);
            labelEdad.Name = "labelEdad";
            labelEdad.Size = new Size(56, 28);
            labelEdad.TabIndex = 9;
            labelEdad.Text = "Edad";
            // 
            // textBoxResidencia
            // 
            textBoxResidencia.Location = new Point(31, 222);
            textBoxResidencia.Name = "textBoxResidencia";
            textBoxResidencia.ReadOnly = true;
            textBoxResidencia.Size = new Size(391, 34);
            textBoxResidencia.TabIndex = 8;
            // 
            // labelResidencia
            // 
            labelResidencia.AutoSize = true;
            labelResidencia.Location = new Point(31, 191);
            labelResidencia.Name = "labelResidencia";
            labelResidencia.Size = new Size(107, 28);
            labelResidencia.TabIndex = 7;
            labelResidencia.Text = "Residencia";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(31, 139);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.ReadOnly = true;
            textBoxCorreo.Size = new Size(391, 34);
            textBoxCorreo.TabIndex = 6;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(31, 108);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(73, 28);
            labelCorreo.TabIndex = 5;
            labelCorreo.Text = "Correo";
            // 
            // textBoxCedula
            // 
            textBoxCedula.Location = new Point(330, 59);
            textBoxCedula.Name = "textBoxCedula";
            textBoxCedula.ReadOnly = true;
            textBoxCedula.Size = new Size(223, 34);
            textBoxCedula.TabIndex = 4;
            // 
            // labelCedula
            // 
            labelCedula.AutoSize = true;
            labelCedula.Location = new Point(330, 28);
            labelCedula.Name = "labelCedula";
            labelCedula.Size = new Size(74, 28);
            labelCedula.TabIndex = 3;
            labelCedula.Text = "Cedula";
            // 
            // textBoxNombre
            // 
            textBoxNombre.Location = new Point(31, 59);
            textBoxNombre.Name = "textBoxNombre";
            textBoxNombre.ReadOnly = true;
            textBoxNombre.Size = new Size(284, 34);
            textBoxNombre.TabIndex = 2;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Location = new Point(31, 28);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(87, 28);
            labelNombre.TabIndex = 1;
            labelNombre.Text = "Nombre";
            // 
            // pestanaHistorial
            // 
            pestanaHistorial.Controls.Add(botonBuscarProducto);
            pestanaHistorial.Controls.Add(tablaHistorial);
            pestanaHistorial.Controls.Add(descripcionProducto);
            pestanaHistorial.Controls.Add(marcaProducto);
            pestanaHistorial.Controls.Add(precioProducto);
            pestanaHistorial.Controls.Add(cantidadProducto);
            pestanaHistorial.Controls.Add(nombreProducto);
            pestanaHistorial.Location = new Point(4, 37);
            pestanaHistorial.Name = "pestanaHistorial";
            pestanaHistorial.Padding = new Padding(3);
            pestanaHistorial.Size = new Size(1162, 574);
            pestanaHistorial.TabIndex = 1;
            pestanaHistorial.Text = "Historial";
            pestanaHistorial.UseVisualStyleBackColor = true;
            // 
            // botonBuscarProducto
            // 
            botonBuscarProducto.Location = new Point(727, 23);
            botonBuscarProducto.Name = "botonBuscarProducto";
            botonBuscarProducto.Size = new Size(162, 83);
            botonBuscarProducto.TabIndex = 8;
            botonBuscarProducto.Text = "Buscar";
            botonBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // tablaHistorial
            // 
            tablaHistorial.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaHistorial.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaHistorial.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tablaHistorial.DefaultCellStyle = dataGridViewCellStyle2;
            tablaHistorial.Location = new Point(20, 162);
            tablaHistorial.Name = "tablaHistorial";
            tablaHistorial.RowHeadersWidth = 51;
            tablaHistorial.Size = new Size(1126, 390);
            tablaHistorial.TabIndex = 6;
            // 
            // descripcionProducto
            // 
            descripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            descripcionProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcionProducto.Location = new Point(20, 74);
            descripcionProducto.Multiline = true;
            descripcionProducto.Name = "descripcionProducto";
            descripcionProducto.PlaceholderText = "Descripcion";
            descripcionProducto.Size = new Size(480, 71);
            descripcionProducto.TabIndex = 4;
            // 
            // marcaProducto
            // 
            marcaProducto.BorderStyle = BorderStyle.FixedSingle;
            marcaProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            marcaProducto.Location = new Point(516, 23);
            marcaProducto.Name = "marcaProducto";
            marcaProducto.PlaceholderText = "Marca";
            marcaProducto.Size = new Size(189, 34);
            marcaProducto.TabIndex = 3;
            // 
            // precioProducto
            // 
            precioProducto.BorderStyle = BorderStyle.FixedSingle;
            precioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioProducto.Location = new Point(379, 23);
            precioProducto.Name = "precioProducto";
            precioProducto.PlaceholderText = "*Precio ($)";
            precioProducto.Size = new Size(121, 34);
            precioProducto.TabIndex = 2;
            // 
            // cantidadProducto
            // 
            cantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            cantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadProducto.Location = new Point(250, 23);
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.PlaceholderText = "*Cantidad";
            cantidadProducto.Size = new Size(112, 34);
            cantidadProducto.TabIndex = 1;
            // 
            // nombreProducto
            // 
            nombreProducto.BorderStyle = BorderStyle.FixedSingle;
            nombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreProducto.Location = new Point(20, 23);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.PlaceholderText = "*Nombre del producto";
            nombreProducto.Size = new Size(207, 34);
            nombreProducto.TabIndex = 0;
            // 
            // pestanaComprar
            // 
            pestanaComprar.BackColor = Color.White;
            pestanaComprar.Controls.Add(textBoxDescripcion);
            pestanaComprar.Controls.Add(botonAgregarCupon);
            pestanaComprar.Controls.Add(comboBoxCupon);
            pestanaComprar.Controls.Add(botonEliminarDescuento);
            pestanaComprar.Controls.Add(tablaDescuentos);
            pestanaComprar.Controls.Add(labelDescuentos);
            pestanaComprar.Controls.Add(labelEscogerCupon);
            pestanaComprar.Controls.Add(botonAgregarProducto);
            pestanaComprar.Controls.Add(comboBoxProductos);
            pestanaComprar.Controls.Add(labelEsocgerProducto);
            pestanaComprar.Controls.Add(textoMetodoDePago);
            pestanaComprar.Controls.Add(MetodoDePago);
            pestanaComprar.Controls.Add(montoTotal);
            pestanaComprar.Controls.Add(textoTotal);
            pestanaComprar.Controls.Add(tablaDeCarrito);
            pestanaComprar.Controls.Add(labelCarrito);
            pestanaComprar.Controls.Add(botonEliminarCarrito);
            pestanaComprar.Controls.Add(botonCompletarCompra);
            pestanaComprar.Location = new Point(4, 37);
            pestanaComprar.Name = "pestanaComprar";
            pestanaComprar.Padding = new Padding(3);
            pestanaComprar.Size = new Size(1162, 574);
            pestanaComprar.TabIndex = 0;
            pestanaComprar.Text = "Comprar";
            // 
            // textBoxDescripcion
            // 
            textBoxDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxDescripcion.Location = new Point(58, 245);
            textBoxDescripcion.Multiline = true;
            textBoxDescripcion.Name = "textBoxDescripcion";
            textBoxDescripcion.PlaceholderText = "Descripcion (opcional)";
            textBoxDescripcion.Size = new Size(349, 69);
            textBoxDescripcion.TabIndex = 27;
            // 
            // botonAgregarCupon
            // 
            botonAgregarCupon.BackColor = Color.LightBlue;
            botonAgregarCupon.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAgregarCupon.Location = new Point(334, 182);
            botonAgregarCupon.Name = "botonAgregarCupon";
            botonAgregarCupon.Size = new Size(73, 36);
            botonAgregarCupon.TabIndex = 26;
            botonAgregarCupon.Text = "+";
            botonAgregarCupon.UseVisualStyleBackColor = false;
            // 
            // comboBoxCupon
            // 
            comboBoxCupon.FormattingEnabled = true;
            comboBoxCupon.Location = new Point(56, 184);
            comboBoxCupon.Name = "comboBoxCupon";
            comboBoxCupon.Size = new Size(272, 36);
            comboBoxCupon.TabIndex = 25;
            // 
            // botonEliminarDescuento
            // 
            botonEliminarDescuento.BackColor = Color.PaleVioletRed;
            botonEliminarDescuento.Font = new Font("Segoe UI", 12F);
            botonEliminarDescuento.Location = new Point(984, 309);
            botonEliminarDescuento.Name = "botonEliminarDescuento";
            botonEliminarDescuento.Size = new Size(137, 36);
            botonEliminarDescuento.TabIndex = 24;
            botonEliminarDescuento.Text = "Eliminar";
            botonEliminarDescuento.UseVisualStyleBackColor = false;
            // 
            // tablaDescuentos
            // 
            tablaDescuentos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaDescuentos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tablaDescuentos.DefaultCellStyle = dataGridViewCellStyle3;
            tablaDescuentos.Location = new Point(473, 351);
            tablaDescuentos.Name = "tablaDescuentos";
            tablaDescuentos.RowHeadersWidth = 51;
            tablaDescuentos.Size = new Size(648, 109);
            tablaDescuentos.TabIndex = 23;
            // 
            // labelDescuentos
            // 
            labelDescuentos.AutoSize = true;
            labelDescuentos.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            labelDescuentos.Location = new Point(473, 304);
            labelDescuentos.Name = "labelDescuentos";
            labelDescuentos.Size = new Size(280, 41);
            labelDescuentos.TabIndex = 22;
            labelDescuentos.Text = "Descuentos activos";
            // 
            // labelEscogerCupon
            // 
            labelEscogerCupon.AutoSize = true;
            labelEscogerCupon.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEscogerCupon.Location = new Point(56, 143);
            labelEscogerCupon.Name = "labelEscogerCupon";
            labelEscogerCupon.Size = new Size(250, 28);
            labelEscogerCupon.TabIndex = 21;
            labelEscogerCupon.Text = "Escoger cupon/Descuento";
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.BackColor = Color.LightBlue;
            botonAgregarProducto.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            botonAgregarProducto.Location = new Point(334, 88);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(73, 36);
            botonAgregarProducto.TabIndex = 20;
            botonAgregarProducto.Text = "+";
            botonAgregarProducto.UseVisualStyleBackColor = false;
            // 
            // comboBoxProductos
            // 
            comboBoxProductos.FormattingEnabled = true;
            comboBoxProductos.Location = new Point(56, 88);
            comboBoxProductos.Name = "comboBoxProductos";
            comboBoxProductos.Size = new Size(272, 36);
            comboBoxProductos.TabIndex = 19;
            // 
            // labelEsocgerProducto
            // 
            labelEsocgerProducto.AutoSize = true;
            labelEsocgerProducto.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEsocgerProducto.Location = new Point(56, 46);
            labelEsocgerProducto.Name = "labelEsocgerProducto";
            labelEsocgerProducto.Size = new Size(164, 28);
            labelEsocgerProducto.TabIndex = 18;
            labelEsocgerProducto.Text = "Escojer producto";
            // 
            // textoMetodoDePago
            // 
            textoMetodoDePago.AutoSize = true;
            textoMetodoDePago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoMetodoDePago.Location = new Point(56, 327);
            textoMetodoDePago.Name = "textoMetodoDePago";
            textoMetodoDePago.Size = new Size(165, 28);
            textoMetodoDePago.TabIndex = 17;
            textoMetodoDePago.Text = "Metodo de pago";
            // 
            // MetodoDePago
            // 
            MetodoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            MetodoDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            MetodoDePago.ForeColor = SystemColors.WindowFrame;
            MetodoDePago.FormattingEnabled = true;
            MetodoDePago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de Debito", "En linea" });
            MetodoDePago.Location = new Point(56, 369);
            MetodoDePago.Name = "MetodoDePago";
            MetodoDePago.Size = new Size(351, 36);
            MetodoDePago.TabIndex = 14;
            // 
            // montoTotal
            // 
            montoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            montoTotal.AutoSize = true;
            montoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            montoTotal.Location = new Point(562, 473);
            montoTotal.Name = "montoTotal";
            montoTotal.Size = new Size(93, 41);
            montoTotal.TabIndex = 11;
            montoTotal.Text = "0.00$";
            // 
            // textoTotal
            // 
            textoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textoTotal.AutoSize = true;
            textoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoTotal.Location = new Point(473, 473);
            textoTotal.Name = "textoTotal";
            textoTotal.Size = new Size(92, 41);
            textoTotal.TabIndex = 10;
            textoTotal.Text = "Total:";
            // 
            // tablaDeCarrito
            // 
            tablaDeCarrito.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaDeCarrito.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tablaDeCarrito.DefaultCellStyle = dataGridViewCellStyle4;
            tablaDeCarrito.Location = new Point(473, 86);
            tablaDeCarrito.Name = "tablaDeCarrito";
            tablaDeCarrito.RowHeadersWidth = 51;
            tablaDeCarrito.Size = new Size(648, 195);
            tablaDeCarrito.TabIndex = 9;
            // 
            // labelCarrito
            // 
            labelCarrito.AutoSize = true;
            labelCarrito.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            labelCarrito.Location = new Point(473, 38);
            labelCarrito.Name = "labelCarrito";
            labelCarrito.Size = new Size(112, 41);
            labelCarrito.TabIndex = 8;
            labelCarrito.Text = "Carrito";
            // 
            // botonEliminarCarrito
            // 
            botonEliminarCarrito.BackColor = Color.PaleVioletRed;
            botonEliminarCarrito.Font = new Font("Segoe UI", 12F);
            botonEliminarCarrito.Location = new Point(984, 44);
            botonEliminarCarrito.Name = "botonEliminarCarrito";
            botonEliminarCarrito.Size = new Size(137, 36);
            botonEliminarCarrito.TabIndex = 7;
            botonEliminarCarrito.Text = "Eliminar";
            botonEliminarCarrito.UseVisualStyleBackColor = false;
            // 
            // botonCompletarCompra
            // 
            botonCompletarCompra.BackColor = Color.LightGreen;
            botonCompletarCompra.Font = new Font("Segoe UI", 12F);
            botonCompletarCompra.Location = new Point(898, 479);
            botonCompletarCompra.Name = "botonCompletarCompra";
            botonCompletarCompra.Size = new Size(223, 36);
            botonCompletarCompra.TabIndex = 6;
            botonCompletarCompra.Text = "Completar compra";
            botonCompletarCompra.UseVisualStyleBackColor = false;
            // 
            // controlPestanas
            // 
            controlPestanas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlPestanas.Controls.Add(pestanaComprar);
            controlPestanas.Controls.Add(pestanaHistorial);
            controlPestanas.Controls.Add(pestanaAjustes);
            controlPestanas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlPestanas.Location = new Point(12, 78);
            controlPestanas.Name = "controlPestanas";
            controlPestanas.RightToLeft = RightToLeft.No;
            controlPestanas.SelectedIndex = 0;
            controlPestanas.Size = new Size(1170, 615);
            controlPestanas.TabIndex = 3;
            // 
            // labelNombreClienteInterfaz
            // 
            labelNombreClienteInterfaz.AutoSize = true;
            labelNombreClienteInterfaz.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold);
            labelNombreClienteInterfaz.Location = new Point(16, 12);
            labelNombreClienteInterfaz.Name = "labelNombreClienteInterfaz";
            labelNombreClienteInterfaz.Size = new Size(373, 54);
            labelNombreClienteInterfaz.TabIndex = 4;
            labelNombreClienteInterfaz.Text = "Nombre Del cliente";
            // 
            // vistaCliente
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1194, 703);
            Controls.Add(labelNombreClienteInterfaz);
            Controls.Add(controlPestanas);
            Controls.Add(nombreNegocio);
            Name = "vistaCliente";
            Text = "Vista cliente";
            FormClosing += vistaCliente_FormClosing;
            Load += vistaCliente_Load;
            pestanaAjustes.ResumeLayout(false);
            pestanaAjustes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaCuponesDisponibles).EndInit();
            pestanaHistorial.ResumeLayout(false);
            pestanaHistorial.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaHistorial).EndInit();
            pestanaComprar.ResumeLayout(false);
            pestanaComprar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDescuentos).EndInit();
            ((System.ComponentModel.ISupportInitialize)tablaDeCarrito).EndInit();
            controlPestanas.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label nombreNegocio;
        public TabPage pestanaAjustes;
        public TabPage pestanaHistorial;
        public Button botonBuscarProducto;
        public DataGridView tablaHistorial;
        public TextBox descripcionProducto;
        public TextBox marcaProducto;
        public TextBox precioProducto;
        public TextBox cantidadProducto;
        public TextBox nombreProducto;
        public TabPage pestanaComprar;
        public Label textoMetodoDePago;
        public ComboBox MetodoDePago;
        public Label montoTotal;
        public Label textoTotal;
        public Button botonEliminarCarrito;
        public Button botonCompletarCompra;
        public TabControl controlPestanas;
        public Label labelCarrito;
        public Button botonAgregarProducto;
        public ComboBox comboBoxProductos;
        public Label labelEsocgerProducto;
        public Label labelEscogerCupon;
        public Button botonAgregarCupon;
        public ComboBox comboBoxCupon;
        public Button botonEliminarDescuento;
        public DataGridView tablaDescuentos;
        public Label labelDescuentos;
        public Label labelNombreClienteInterfaz;
        public TextBox textBoxDescripcion;
        public TextBox textBoxEdad;
        public Label labelEdad;
        public TextBox textBoxResidencia;
        public Label labelResidencia;
        public TextBox textBoxCorreo;
        public Label labelCorreo;
        public TextBox textBoxCedula;
        public Label labelCedula;
        public TextBox textBoxNombre;
        public Label labelNombre;
        public Label labelCuponesDisponibles;
        public DataGridView tablaCuponesDisponibles;
        public Button botonEditarCliente;
        public TextBox textBoxContrasenaActual;
        public Label labelContrasenaActual;
        public Label labelProximaRecompensa;
        public Label labelProgresoNivel;
        public Label labelNivel;
        public ProgressBar progressBarNivel;
        public TextBox textBoxContrasenaNueva;
        public Label labelContrasenaNueva;
        public Button botonGuardarCambios;
        public DataGridView tablaDeCarrito;
    }
}