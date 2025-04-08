using System.Globalization;

namespace GestionNegocio
{
    partial class MenuPrincipal
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
            nombreNegocio = new Label();
            controlPestanas = new TabControl();
            pestanaCobros = new TabPage();
            botonResetearMovimientos = new Button();
            botonBuscarMovimientos = new Button();
            textoMetodoDePago = new Label();
            movimientoBotonEditar = new Button();
            movimientoFecha = new DateTimePicker();
            movimientoMetodoDePago = new ComboBox();
            movimientoCedula = new TextBox();
            botonEliminarMovimiento = new Button();
            montoTotal = new Label();
            textoTotal = new Label();
            tablaDeMovimientos = new DataGridView();
            movimientoTextoRegistrar = new Label();
            movimientoBotonEgreso = new Button();
            movimientoBotonIngreso = new Button();
            movimientoMonto = new TextBox();
            movimientoDescripcion = new TextBox();
            pestanaInventario = new TabPage();
            botonBuscarProducto = new Button();
            botonEliminarProducto = new Button();
            tablaInventario = new DataGridView();
            botonAgregarProducto = new Button();
            descripcionProducto = new TextBox();
            marcaProducto = new TextBox();
            precioProducto = new TextBox();
            cantidadProducto = new TextBox();
            nombreProducto = new TextBox();
            pestanaClientes = new TabPage();
            botonEditarCliente = new Button();
            cedulaCliente = new TextBox();
            botonBuscarCliente = new Button();
            correoCliente = new TextBox();
            botonEliminarCliente = new Button();
            tablaClientes = new DataGridView();
            botonAgregarCliente = new Button();
            residenciaCliente = new TextBox();
            edadCliente = new TextBox();
            nombreCliente = new TextBox();
            pestanaFacturas = new TabPage();
            textoProximamenteFacturas = new Label();
            pestanaAjustes = new TabPage();
            labelAjustesSeguridad = new Label();
            panelAjustesSeguridad = new Panel();
            textBoxAjustesCredencialNueva = new TextBox();
            textBoxAjustesCredencialAntigua = new TextBox();
            labelAjustesCredencialAntigua = new Label();
            labelAjustesCredencialNueva = new Label();
            labelAjustesInterfaz = new Label();
            botonGuardarCambiosAjustes = new Button();
            panelAjustesInterfaz = new Panel();
            textBoxAjustesNombre = new TextBox();
            comboBoxAjustesTema = new ComboBox();
            ajustesLabelNombre = new Label();
            labelAjustesTema = new Label();
            labelPanelAdministrativo = new Label();
            controlPestanas.SuspendLayout();
            pestanaCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDeMovimientos).BeginInit();
            pestanaInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).BeginInit();
            pestanaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            pestanaFacturas.SuspendLayout();
            pestanaAjustes.SuspendLayout();
            panelAjustesSeguridad.SuspendLayout();
            panelAjustesInterfaz.SuspendLayout();
            SuspendLayout();
            // 
            // nombreNegocio
            // 
            nombreNegocio.AutoSize = true;
            nombreNegocio.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreNegocio.Location = new Point(12, 21);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.Size = new Size(408, 54);
            nombreNegocio.TabIndex = 0;
            nombreNegocio.Text = "Nombre Del Negocio";
            // 
            // controlPestanas
            // 
            controlPestanas.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            controlPestanas.Controls.Add(pestanaCobros);
            controlPestanas.Controls.Add(pestanaInventario);
            controlPestanas.Controls.Add(pestanaClientes);
            controlPestanas.Controls.Add(pestanaFacturas);
            controlPestanas.Controls.Add(pestanaAjustes);
            controlPestanas.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            controlPestanas.Location = new Point(12, 89);
            controlPestanas.Name = "controlPestanas";
            controlPestanas.RightToLeft = RightToLeft.No;
            controlPestanas.SelectedIndex = 0;
            controlPestanas.Size = new Size(1114, 602);
            controlPestanas.TabIndex = 1;
            // 
            // pestanaCobros
            // 
            pestanaCobros.BackColor = Color.White;
            pestanaCobros.Controls.Add(botonResetearMovimientos);
            pestanaCobros.Controls.Add(botonBuscarMovimientos);
            pestanaCobros.Controls.Add(textoMetodoDePago);
            pestanaCobros.Controls.Add(movimientoBotonEditar);
            pestanaCobros.Controls.Add(movimientoFecha);
            pestanaCobros.Controls.Add(movimientoMetodoDePago);
            pestanaCobros.Controls.Add(movimientoCedula);
            pestanaCobros.Controls.Add(botonEliminarMovimiento);
            pestanaCobros.Controls.Add(montoTotal);
            pestanaCobros.Controls.Add(textoTotal);
            pestanaCobros.Controls.Add(tablaDeMovimientos);
            pestanaCobros.Controls.Add(movimientoTextoRegistrar);
            pestanaCobros.Controls.Add(movimientoBotonEgreso);
            pestanaCobros.Controls.Add(movimientoBotonIngreso);
            pestanaCobros.Controls.Add(movimientoMonto);
            pestanaCobros.Controls.Add(movimientoDescripcion);
            pestanaCobros.Location = new Point(4, 37);
            pestanaCobros.Name = "pestanaCobros";
            pestanaCobros.Padding = new Padding(3);
            pestanaCobros.Size = new Size(1106, 561);
            pestanaCobros.TabIndex = 0;
            pestanaCobros.Text = "Movimiento y cobro";
            // 
            // botonResetearMovimientos
            // 
            botonResetearMovimientos.BackColor = Color.Transparent;
            botonResetearMovimientos.Font = new Font("Segoe UI", 12F);
            botonResetearMovimientos.Location = new Point(350, 424);
            botonResetearMovimientos.Name = "botonResetearMovimientos";
            botonResetearMovimientos.Size = new Size(54, 36);
            botonResetearMovimientos.TabIndex = 19;
            botonResetearMovimientos.Text = "↻";
            botonResetearMovimientos.UseVisualStyleBackColor = false;
            botonResetearMovimientos.Click += botonResetearMovimientos_Click;
            // 
            // botonBuscarMovimientos
            // 
            botonBuscarMovimientos.BackColor = Color.Transparent;
            botonBuscarMovimientos.Font = new Font("Segoe UI", 12F);
            botonBuscarMovimientos.Location = new Point(207, 481);
            botonBuscarMovimientos.Name = "botonBuscarMovimientos";
            botonBuscarMovimientos.Size = new Size(197, 36);
            botonBuscarMovimientos.TabIndex = 18;
            botonBuscarMovimientos.Text = "Buscar por cedula";
            botonBuscarMovimientos.UseVisualStyleBackColor = false;
            botonBuscarMovimientos.Click += botonBuscarMovimientos_Click;
            // 
            // textoMetodoDePago
            // 
            textoMetodoDePago.AutoSize = true;
            textoMetodoDePago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoMetodoDePago.Location = new Point(53, 240);
            textoMetodoDePago.Name = "textoMetodoDePago";
            textoMetodoDePago.Size = new Size(165, 28);
            textoMetodoDePago.TabIndex = 17;
            textoMetodoDePago.Text = "Metodo de pago";
            // 
            // movimientoBotonEditar
            // 
            movimientoBotonEditar.BackColor = Color.SkyBlue;
            movimientoBotonEditar.Font = new Font("Segoe UI", 12F);
            movimientoBotonEditar.Location = new Point(53, 481);
            movimientoBotonEditar.Name = "movimientoBotonEditar";
            movimientoBotonEditar.Size = new Size(137, 36);
            movimientoBotonEditar.TabIndex = 16;
            movimientoBotonEditar.Text = "Editar";
            movimientoBotonEditar.UseVisualStyleBackColor = false;
            movimientoBotonEditar.Click += movimientoBotonEditar_Click;
            // 
            // movimientoFecha
            // 
            movimientoFecha.CalendarForeColor = SystemColors.ActiveCaptionText;
            movimientoFecha.Location = new Point(53, 336);
            movimientoFecha.Name = "movimientoFecha";
            movimientoFecha.Size = new Size(351, 34);
            movimientoFecha.TabIndex = 15;
            // 
            // movimientoMetodoDePago
            // 
            movimientoMetodoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            movimientoMetodoDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoMetodoDePago.ForeColor = SystemColors.WindowFrame;
            movimientoMetodoDePago.FormattingEnabled = true;
            movimientoMetodoDePago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de Debito", "En linea" });
            movimientoMetodoDePago.Location = new Point(53, 280);
            movimientoMetodoDePago.Name = "movimientoMetodoDePago";
            movimientoMetodoDePago.Size = new Size(351, 36);
            movimientoMetodoDePago.TabIndex = 14;
            // 
            // movimientoCedula
            // 
            movimientoCedula.BorderStyle = BorderStyle.FixedSingle;
            movimientoCedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoCedula.Location = new Point(53, 191);
            movimientoCedula.Name = "movimientoCedula";
            movimientoCedula.PlaceholderText = "Cedula del cliente";
            movimientoCedula.Size = new Size(351, 34);
            movimientoCedula.TabIndex = 13;
            // 
            // botonEliminarMovimiento
            // 
            botonEliminarMovimiento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarMovimiento.BackColor = Color.LightCoral;
            botonEliminarMovimiento.Font = new Font("Segoe UI", 12F);
            botonEliminarMovimiento.Location = new Point(918, 488);
            botonEliminarMovimiento.Name = "botonEliminarMovimiento";
            botonEliminarMovimiento.Size = new Size(137, 36);
            botonEliminarMovimiento.TabIndex = 12;
            botonEliminarMovimiento.Text = "Eliminar";
            botonEliminarMovimiento.UseVisualStyleBackColor = false;
            botonEliminarMovimiento.Click += botonEliminarMovimiento_Click;
            // 
            // montoTotal
            // 
            montoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            montoTotal.AutoSize = true;
            montoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold);
            montoTotal.Location = new Point(590, 482);
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
            textoTotal.Location = new Point(502, 481);
            textoTotal.Name = "textoTotal";
            textoTotal.Size = new Size(92, 41);
            textoTotal.TabIndex = 10;
            textoTotal.Text = "Total:";
            // 
            // tablaDeMovimientos
            // 
            tablaDeMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaDeMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            tablaDeMovimientos.DefaultCellStyle = dataGridViewCellStyle1;
            tablaDeMovimientos.Location = new Point(502, 44);
            tablaDeMovimientos.Name = "tablaDeMovimientos";
            tablaDeMovimientos.RowHeadersWidth = 51;
            tablaDeMovimientos.Size = new Size(553, 414);
            tablaDeMovimientos.TabIndex = 9;
            tablaDeMovimientos.CellFormatting += tablaDeMovimientos_CellFormatting;
            // 
            // movimientoTextoRegistrar
            // 
            movimientoTextoRegistrar.AutoSize = true;
            movimientoTextoRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movimientoTextoRegistrar.Location = new Point(53, 383);
            movimientoTextoRegistrar.Name = "movimientoTextoRegistrar";
            movimientoTextoRegistrar.Size = new Size(148, 28);
            movimientoTextoRegistrar.TabIndex = 8;
            movimientoTextoRegistrar.Text = "Registrar como";
            // 
            // movimientoBotonEgreso
            // 
            movimientoBotonEgreso.BackColor = Color.PaleVioletRed;
            movimientoBotonEgreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonEgreso.Location = new Point(207, 424);
            movimientoBotonEgreso.Name = "movimientoBotonEgreso";
            movimientoBotonEgreso.Size = new Size(137, 36);
            movimientoBotonEgreso.TabIndex = 7;
            movimientoBotonEgreso.Text = "Egreso";
            movimientoBotonEgreso.UseVisualStyleBackColor = false;
            movimientoBotonEgreso.Click += movimientoBotonEgreso_Click;
            // 
            // movimientoBotonIngreso
            // 
            movimientoBotonIngreso.BackColor = Color.LightGreen;
            movimientoBotonIngreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonIngreso.Location = new Point(53, 424);
            movimientoBotonIngreso.Name = "movimientoBotonIngreso";
            movimientoBotonIngreso.Size = new Size(137, 36);
            movimientoBotonIngreso.TabIndex = 6;
            movimientoBotonIngreso.Text = "Ingreso";
            movimientoBotonIngreso.UseVisualStyleBackColor = false;
            movimientoBotonIngreso.Click += movimientoBotonIngreso_Click;
            // 
            // movimientoMonto
            // 
            movimientoMonto.BorderStyle = BorderStyle.FixedSingle;
            movimientoMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoMonto.Location = new Point(53, 140);
            movimientoMonto.Name = "movimientoMonto";
            movimientoMonto.PlaceholderText = "Monto: $000,000.00";
            movimientoMonto.Size = new Size(351, 34);
            movimientoMonto.TabIndex = 5;
            // 
            // movimientoDescripcion
            // 
            movimientoDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoDescripcion.Location = new Point(53, 44);
            movimientoDescripcion.Multiline = true;
            movimientoDescripcion.Name = "movimientoDescripcion";
            movimientoDescripcion.PlaceholderText = "Descripcion";
            movimientoDescripcion.Size = new Size(351, 80);
            movimientoDescripcion.TabIndex = 3;
            // 
            // pestanaInventario
            // 
            pestanaInventario.Controls.Add(botonBuscarProducto);
            pestanaInventario.Controls.Add(botonEliminarProducto);
            pestanaInventario.Controls.Add(tablaInventario);
            pestanaInventario.Controls.Add(botonAgregarProducto);
            pestanaInventario.Controls.Add(descripcionProducto);
            pestanaInventario.Controls.Add(marcaProducto);
            pestanaInventario.Controls.Add(precioProducto);
            pestanaInventario.Controls.Add(cantidadProducto);
            pestanaInventario.Controls.Add(nombreProducto);
            pestanaInventario.Location = new Point(4, 37);
            pestanaInventario.Name = "pestanaInventario";
            pestanaInventario.Padding = new Padding(3);
            pestanaInventario.Size = new Size(1106, 561);
            pestanaInventario.TabIndex = 1;
            pestanaInventario.Text = "Inventario";
            pestanaInventario.UseVisualStyleBackColor = true;
            // 
            // botonBuscarProducto
            // 
            botonBuscarProducto.Location = new Point(899, 23);
            botonBuscarProducto.Name = "botonBuscarProducto";
            botonBuscarProducto.Size = new Size(162, 83);
            botonBuscarProducto.TabIndex = 8;
            botonBuscarProducto.Text = "Buscar";
            botonBuscarProducto.UseVisualStyleBackColor = true;
            // 
            // botonEliminarProducto
            // 
            botonEliminarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarProducto.BackColor = Color.LightCoral;
            botonEliminarProducto.Font = new Font("Segoe UI", 12F);
            botonEliminarProducto.Location = new Point(946, 501);
            botonEliminarProducto.Name = "botonEliminarProducto";
            botonEliminarProducto.Size = new Size(137, 36);
            botonEliminarProducto.TabIndex = 7;
            botonEliminarProducto.Text = "Eliminar";
            botonEliminarProducto.UseVisualStyleBackColor = false;
            botonEliminarProducto.Click += botonEliminarProducto_Click;
            // 
            // tablaInventario
            // 
            tablaInventario.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            tablaInventario.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            tablaInventario.DefaultCellStyle = dataGridViewCellStyle2;
            tablaInventario.Location = new Point(20, 175);
            tablaInventario.Name = "tablaInventario";
            tablaInventario.RowHeadersWidth = 51;
            tablaInventario.Size = new Size(1063, 290);
            tablaInventario.TabIndex = 6;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Location = new Point(721, 23);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(162, 83);
            botonAgregarProducto.TabIndex = 5;
            botonAgregarProducto.Text = "Agregar";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
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
            // pestanaClientes
            // 
            pestanaClientes.Controls.Add(botonEditarCliente);
            pestanaClientes.Controls.Add(cedulaCliente);
            pestanaClientes.Controls.Add(botonBuscarCliente);
            pestanaClientes.Controls.Add(correoCliente);
            pestanaClientes.Controls.Add(botonEliminarCliente);
            pestanaClientes.Controls.Add(tablaClientes);
            pestanaClientes.Controls.Add(botonAgregarCliente);
            pestanaClientes.Controls.Add(residenciaCliente);
            pestanaClientes.Controls.Add(edadCliente);
            pestanaClientes.Controls.Add(nombreCliente);
            pestanaClientes.Location = new Point(4, 37);
            pestanaClientes.Name = "pestanaClientes";
            pestanaClientes.Padding = new Padding(3);
            pestanaClientes.Size = new Size(1106, 561);
            pestanaClientes.TabIndex = 4;
            pestanaClientes.Text = "Clientes";
            pestanaClientes.UseVisualStyleBackColor = true;
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.BackColor = Color.SkyBlue;
            botonEditarCliente.Font = new Font("Segoe UI", 12F);
            botonEditarCliente.Location = new Point(26, 462);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(137, 36);
            botonEditarCliente.TabIndex = 19;
            botonEditarCliente.Text = "Editar";
            botonEditarCliente.UseVisualStyleBackColor = false;
            botonEditarCliente.Click += botonEditarCliente_Click;
            // 
            // cedulaCliente
            // 
            cedulaCliente.BorderStyle = BorderStyle.FixedSingle;
            cedulaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cedulaCliente.Location = new Point(26, 105);
            cedulaCliente.Name = "cedulaCliente";
            cedulaCliente.PlaceholderText = "Cedula";
            cedulaCliente.Size = new Size(244, 34);
            cedulaCliente.TabIndex = 18;
            // 
            // botonBuscarCliente
            // 
            botonBuscarCliente.Location = new Point(108, 273);
            botonBuscarCliente.Name = "botonBuscarCliente";
            botonBuscarCliente.Size = new Size(162, 83);
            botonBuscarCliente.TabIndex = 17;
            botonBuscarCliente.Text = "Buscar";
            botonBuscarCliente.UseVisualStyleBackColor = true;
            botonBuscarCliente.Click += botonBuscarCliente_Click;
            // 
            // correoCliente
            // 
            correoCliente.BorderStyle = BorderStyle.FixedSingle;
            correoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correoCliente.Location = new Point(26, 213);
            correoCliente.Name = "correoCliente";
            correoCliente.PlaceholderText = "Correo";
            correoCliente.Size = new Size(425, 34);
            correoCliente.TabIndex = 16;
            // 
            // botonEliminarCliente
            // 
            botonEliminarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarCliente.BackColor = Color.LightCoral;
            botonEliminarCliente.Font = new Font("Segoe UI", 12F);
            botonEliminarCliente.Location = new Point(314, 462);
            botonEliminarCliente.Name = "botonEliminarCliente";
            botonEliminarCliente.Size = new Size(137, 36);
            botonEliminarCliente.TabIndex = 15;
            botonEliminarCliente.Text = "Eliminar";
            botonEliminarCliente.UseVisualStyleBackColor = false;
            botonEliminarCliente.Click += botonEliminarCliente_Click;
            // 
            // tablaClientes
            // 
            tablaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            tablaClientes.DefaultCellStyle = dataGridViewCellStyle3;
            tablaClientes.Location = new Point(503, 55);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.Size = new Size(567, 443);
            tablaClientes.TabIndex = 14;
            // 
            // botonAgregarCliente
            // 
            botonAgregarCliente.Location = new Point(289, 273);
            botonAgregarCliente.Name = "botonAgregarCliente";
            botonAgregarCliente.Size = new Size(162, 83);
            botonAgregarCliente.TabIndex = 13;
            botonAgregarCliente.Text = "Agregar";
            botonAgregarCliente.UseVisualStyleBackColor = true;
            botonAgregarCliente.Click += botonAgregarCliente_Click;
            // 
            // residenciaCliente
            // 
            residenciaCliente.BorderStyle = BorderStyle.FixedSingle;
            residenciaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            residenciaCliente.Location = new Point(26, 158);
            residenciaCliente.Name = "residenciaCliente";
            residenciaCliente.PlaceholderText = "Residencia";
            residenciaCliente.Size = new Size(425, 34);
            residenciaCliente.TabIndex = 11;
            // 
            // edadCliente
            // 
            edadCliente.BorderStyle = BorderStyle.FixedSingle;
            edadCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edadCliente.Location = new Point(289, 105);
            edadCliente.Name = "edadCliente";
            edadCliente.PlaceholderText = "Edad";
            edadCliente.Size = new Size(162, 34);
            edadCliente.TabIndex = 10;
            // 
            // nombreCliente
            // 
            nombreCliente.BorderStyle = BorderStyle.FixedSingle;
            nombreCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCliente.Location = new Point(26, 55);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.PlaceholderText = "Nombre del cliente";
            nombreCliente.Size = new Size(425, 34);
            nombreCliente.TabIndex = 8;
            // 
            // pestanaFacturas
            // 
            pestanaFacturas.Controls.Add(textoProximamenteFacturas);
            pestanaFacturas.Location = new Point(4, 37);
            pestanaFacturas.Name = "pestanaFacturas";
            pestanaFacturas.Size = new Size(1106, 561);
            pestanaFacturas.TabIndex = 2;
            pestanaFacturas.Text = "Facturas";
            pestanaFacturas.UseVisualStyleBackColor = true;
            // 
            // textoProximamenteFacturas
            // 
            textoProximamenteFacturas.AutoSize = true;
            textoProximamenteFacturas.Location = new Point(473, 262);
            textoProximamenteFacturas.Name = "textoProximamenteFacturas";
            textoProximamenteFacturas.Size = new Size(145, 28);
            textoProximamenteFacturas.TabIndex = 0;
            textoProximamenteFacturas.Text = "Proximamente";
            // 
            // pestanaAjustes
            // 
            pestanaAjustes.Controls.Add(labelAjustesSeguridad);
            pestanaAjustes.Controls.Add(panelAjustesSeguridad);
            pestanaAjustes.Controls.Add(labelAjustesInterfaz);
            pestanaAjustes.Controls.Add(botonGuardarCambiosAjustes);
            pestanaAjustes.Controls.Add(panelAjustesInterfaz);
            pestanaAjustes.Location = new Point(4, 37);
            pestanaAjustes.Name = "pestanaAjustes";
            pestanaAjustes.Size = new Size(1106, 561);
            pestanaAjustes.TabIndex = 3;
            pestanaAjustes.Text = "Ajustes";
            pestanaAjustes.UseVisualStyleBackColor = true;
            // 
            // labelAjustesSeguridad
            // 
            labelAjustesSeguridad.AutoSize = true;
            labelAjustesSeguridad.BackColor = Color.Transparent;
            labelAjustesSeguridad.ForeColor = Color.Gray;
            labelAjustesSeguridad.Location = new Point(43, 220);
            labelAjustesSeguridad.Name = "labelAjustesSeguridad";
            labelAjustesSeguridad.Size = new Size(104, 28);
            labelAjustesSeguridad.TabIndex = 6;
            labelAjustesSeguridad.Text = "Seguridad";
            // 
            // panelAjustesSeguridad
            // 
            panelAjustesSeguridad.BackColor = Color.Gainsboro;
            panelAjustesSeguridad.Controls.Add(textBoxAjustesCredencialNueva);
            panelAjustesSeguridad.Controls.Add(textBoxAjustesCredencialAntigua);
            panelAjustesSeguridad.Controls.Add(labelAjustesCredencialAntigua);
            panelAjustesSeguridad.Controls.Add(labelAjustesCredencialNueva);
            panelAjustesSeguridad.Location = new Point(43, 251);
            panelAjustesSeguridad.Name = "panelAjustesSeguridad";
            panelAjustesSeguridad.Size = new Size(515, 141);
            panelAjustesSeguridad.TabIndex = 7;
            // 
            // textBoxAjustesCredencialNueva
            // 
            textBoxAjustesCredencialNueva.Location = new Point(240, 75);
            textBoxAjustesCredencialNueva.Name = "textBoxAjustesCredencialNueva";
            textBoxAjustesCredencialNueva.Size = new Size(242, 34);
            textBoxAjustesCredencialNueva.TabIndex = 4;
            // 
            // textBoxAjustesCredencialAntigua
            // 
            textBoxAjustesCredencialAntigua.Location = new Point(240, 23);
            textBoxAjustesCredencialAntigua.Name = "textBoxAjustesCredencialAntigua";
            textBoxAjustesCredencialAntigua.Size = new Size(242, 34);
            textBoxAjustesCredencialAntigua.TabIndex = 2;
            // 
            // labelAjustesCredencialAntigua
            // 
            labelAjustesCredencialAntigua.AutoSize = true;
            labelAjustesCredencialAntigua.BackColor = Color.Gainsboro;
            labelAjustesCredencialAntigua.Location = new Point(14, 23);
            labelAjustesCredencialAntigua.Name = "labelAjustesCredencialAntigua";
            labelAjustesCredencialAntigua.Size = new Size(192, 28);
            labelAjustesCredencialAntigua.TabIndex = 1;
            labelAjustesCredencialAntigua.Text = "| Credencial antigua";
            // 
            // labelAjustesCredencialNueva
            // 
            labelAjustesCredencialNueva.AutoSize = true;
            labelAjustesCredencialNueva.BackColor = Color.Gainsboro;
            labelAjustesCredencialNueva.Location = new Point(14, 78);
            labelAjustesCredencialNueva.Name = "labelAjustesCredencialNueva";
            labelAjustesCredencialNueva.Size = new Size(179, 28);
            labelAjustesCredencialNueva.TabIndex = 3;
            labelAjustesCredencialNueva.Text = "| Credencial nueva";
            // 
            // labelAjustesInterfaz
            // 
            labelAjustesInterfaz.AutoSize = true;
            labelAjustesInterfaz.BackColor = Color.Transparent;
            labelAjustesInterfaz.ForeColor = Color.Gray;
            labelAjustesInterfaz.Location = new Point(43, 31);
            labelAjustesInterfaz.Name = "labelAjustesInterfaz";
            labelAjustesInterfaz.Size = new Size(81, 28);
            labelAjustesInterfaz.TabIndex = 5;
            labelAjustesInterfaz.Text = "Interfaz";
            // 
            // botonGuardarCambiosAjustes
            // 
            botonGuardarCambiosAjustes.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonGuardarCambiosAjustes.Font = new Font("Segoe UI Semibold", 9F);
            botonGuardarCambiosAjustes.Location = new Point(922, 502);
            botonGuardarCambiosAjustes.Name = "botonGuardarCambiosAjustes";
            botonGuardarCambiosAjustes.Size = new Size(161, 41);
            botonGuardarCambiosAjustes.TabIndex = 0;
            botonGuardarCambiosAjustes.Text = "Guardar Cambios";
            botonGuardarCambiosAjustes.UseVisualStyleBackColor = true;
            botonGuardarCambiosAjustes.Click += botonGuardarCambiosAjustes_Click;
            // 
            // panelAjustesInterfaz
            // 
            panelAjustesInterfaz.BackColor = Color.Gainsboro;
            panelAjustesInterfaz.Controls.Add(textBoxAjustesNombre);
            panelAjustesInterfaz.Controls.Add(comboBoxAjustesTema);
            panelAjustesInterfaz.Controls.Add(ajustesLabelNombre);
            panelAjustesInterfaz.Controls.Add(labelAjustesTema);
            panelAjustesInterfaz.Location = new Point(43, 62);
            panelAjustesInterfaz.Name = "panelAjustesInterfaz";
            panelAjustesInterfaz.Size = new Size(515, 141);
            panelAjustesInterfaz.TabIndex = 5;
            // 
            // textBoxAjustesNombre
            // 
            textBoxAjustesNombre.Location = new Point(240, 23);
            textBoxAjustesNombre.Name = "textBoxAjustesNombre";
            textBoxAjustesNombre.Size = new Size(242, 34);
            textBoxAjustesNombre.TabIndex = 2;
            // 
            // comboBoxAjustesTema
            // 
            comboBoxAjustesTema.FormattingEnabled = true;
            comboBoxAjustesTema.Items.AddRange(new object[] { "Azul", "Verde", "Amarillo", "Naranja", "Rojo", "Violeta", "Negro", "Gris" });
            comboBoxAjustesTema.Location = new Point(240, 75);
            comboBoxAjustesTema.Name = "comboBoxAjustesTema";
            comboBoxAjustesTema.Size = new Size(242, 36);
            comboBoxAjustesTema.TabIndex = 4;
            // 
            // ajustesLabelNombre
            // 
            ajustesLabelNombre.AutoSize = true;
            ajustesLabelNombre.BackColor = Color.Gainsboro;
            ajustesLabelNombre.Location = new Point(14, 23);
            ajustesLabelNombre.Name = "ajustesLabelNombre";
            ajustesLabelNombre.Size = new Size(212, 28);
            ajustesLabelNombre.TabIndex = 1;
            ajustesLabelNombre.Text = "| Nombre del negocio";
            // 
            // labelAjustesTema
            // 
            labelAjustesTema.AutoSize = true;
            labelAjustesTema.BackColor = Color.Gainsboro;
            labelAjustesTema.Location = new Point(14, 78);
            labelAjustesTema.Name = "labelAjustesTema";
            labelAjustesTema.Size = new Size(152, 28);
            labelAjustesTema.TabIndex = 3;
            labelAjustesTema.Text = "| Tema de color";
            // 
            // labelPanelAdministrativo
            // 
            labelPanelAdministrativo.AutoSize = true;
            labelPanelAdministrativo.Font = new Font("Segoe UI Semibold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelPanelAdministrativo.ForeColor = SystemColors.ControlDarkDark;
            labelPanelAdministrativo.Location = new Point(894, 39);
            labelPanelAdministrativo.Name = "labelPanelAdministrativo";
            labelPanelAdministrativo.Size = new Size(228, 31);
            labelPanelAdministrativo.TabIndex = 2;
            labelPanelAdministrativo.Text = "Panel Administrativo";
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1138, 703);
            Controls.Add(labelPanelAdministrativo);
            Controls.Add(controlPestanas);
            Controls.Add(nombreNegocio);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "MenuPrincipal";
            Text = "Vista administrador";
            FormClosing += FormMenuPrincipal_FormClosing;
            Load += MenuPrincipal_Load;
            controlPestanas.ResumeLayout(false);
            pestanaCobros.ResumeLayout(false);
            pestanaCobros.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDeMovimientos).EndInit();
            pestanaInventario.ResumeLayout(false);
            pestanaInventario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).EndInit();
            pestanaClientes.ResumeLayout(false);
            pestanaClientes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).EndInit();
            pestanaFacturas.ResumeLayout(false);
            pestanaFacturas.PerformLayout();
            pestanaAjustes.ResumeLayout(false);
            pestanaAjustes.PerformLayout();
            panelAjustesSeguridad.ResumeLayout(false);
            panelAjustesSeguridad.PerformLayout();
            panelAjustesInterfaz.ResumeLayout(false);
            panelAjustesInterfaz.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        #region Elementos principales

        // componentes
        private Label nombreNegocio;
        private TabControl controlPestanas;
        private TabPage pestanaCobros;
        private TabPage pestanaInventario;
        private TabPage pestanaAjustes;
        private TabPage pestanaFacturas;
        private Label labelPanelAdministrativo;


        // setters
        public void SetColorNombreNegocio(Color colorFondo, Color colorTexto)
        {
            nombreNegocio.BackColor = colorFondo;
            nombreNegocio.ForeColor = colorTexto;
        }
        public void SetNombreNegocio(string nombre)
        {
            nombreNegocio.Text = nombre;
        }

        #endregion
       
        #region Pestana movimientos y cobros

        // componentes
        private TextBox movimientoMonto;
        private Label movimientoTextoMonto;
        private TextBox movimientoDescripcion;
        private Label movimientoTextoDescripcion;
        private Label movimientoTextoRegistrar;
        private Button movimientoBotonEgreso;
        private Button movimientoBotonIngreso;
        private DataGridView tablaDeMovimientos;
        private Label montoTotal;
        private Label textoTotal;
        private TextBox movimientoCedula;
        private ComboBox movimientoMetodoDePago;
        private DateTimePicker movimientoFecha;
        private Button movimientoBotonEditar;
        private Button botonEliminarMovimiento;
        private Label textoMetodoDePago;
        private Button botonBuscarMovimientos;
        private Button botonResetearMovimientos;

        // setters 
        public void LimpiarMonto()
        {
            movimientoMonto.Clear();
        }
        public void LimpiarDescripcion()
        {
            movimientoDescripcion.Clear();
        }
        public void SetColorTextoTotal(Color colorFondo, Color colorTexto)
        {
            textoTotal.BackColor = colorFondo;
            textoTotal.ForeColor = colorTexto;
        }
        public void SetMontoTotal(String total)
        {
            montoTotal.Text = total;
        }
        public void LimpiarCedulaMovimiento()
        {
            movimientoCedula.Clear();
        }
        public void LimpiarMetodoDePago()
        {
            movimientoMetodoDePago.SelectedIndex = -1;
        }
        public void SetColorBotonBuscarMovimientos(Color colorFondo, Color colorTexto)
        {
            botonBuscarMovimientos.BackColor = colorFondo;
            botonBuscarMovimientos.ForeColor = colorTexto;
        }
        public void SetDescripcionMovimiento(string descripcion)
        {
            movimientoDescripcion.Text = descripcion;
        }
        public void SetMontoMovimiento(string monto)
        {
            movimientoMonto.Text = monto;
        }
        public void SetCedulaMovimiento(string cedula)
        {
            movimientoCedula.Text = cedula;
        }
        public void SetMetodoDePagoMovimiento(string metodoDePago)
        {
            movimientoMetodoDePago.Text = metodoDePago;
        }

        

        // getters
        public string GetDescripcionMovimiento()
        {
            return movimientoDescripcion.Text.Trim();
        }
        public string GetMovimientoTextoMonto()
        {
            return movimientoMonto.Text.Trim();
        }
        public DataGridView GetTablaDeMovimientos()
        {
            return tablaDeMovimientos;
        }
        public long GetCedulaClienteMovimiento()
        {
            long cedula;

            if (long.TryParse(movimientoCedula.Text.Trim(), out cedula))
            {
                return cedula;
            }
            else
            {
                MessageBox.Show("Introduzca una cedula valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string GetMetodoDePago()
        {
            return movimientoMetodoDePago.Text.Trim();
        }
        public string GetFechaMovimientoString()
        {
            return movimientoFecha.Value.ToString("yyyy-MM-dd", CultureInfo.InvariantCulture);
        }

        #endregion

        #region Pestana inventario

        // componentes
        private TextBox nombreProducto;
        private TextBox cantidadProducto;
        private TextBox marcaProducto;
        private TextBox precioProducto;
        private TextBox descripcionProducto;
        private Button botonAgregarProducto;
        private DataGridView tablaInventario;
        private Button botonEliminarProducto;
        private Button botonBuscarProducto;

        // getters
        public string GetNombreProducto()
        {
            return nombreProducto.Text.Trim();
        }
        public int GetCantidadProducto()
        {
            int cantidad;

            if (int.TryParse(cantidadProducto.Text.Trim(), out cantidad))
            {
                return cantidad;
            }
            else
            {
                MessageBox.Show("Introduzca una cantidad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public decimal GetPrecioProducto()
        {
            decimal precio;

            if (decimal.TryParse(cantidadProducto.Text.Trim(), out precio))
            {
                return precio;
            }
            else
            {
                MessageBox.Show("Introduzca un precio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string GetMarcaProdudcto()
        {
            return marcaProducto.Text.Trim();
        }
        public string GetDescripcionProducto()
        {
            return descripcionProducto.Text.Trim();
        }
        public DataGridView GetTablaInventario()
        {
            return tablaInventario;
        }

        // setters
        public void SetColorBotonAgregarProducto(Color colorFondo, Color colorTexto)
        {
            botonAgregarProducto.BackColor = colorFondo;
            botonAgregarProducto.ForeColor = colorTexto;
        }
        public void SetColorBotonBuscarProducto(Color colorFondo, Color colorTexto)
        {
            botonBuscarProducto.BackColor = colorFondo;
            botonBuscarProducto.ForeColor = colorTexto;
        }
        public void LimpiarNombreProducto()
        {
            nombreProducto.Clear();
        }
        public void LimpiarCantidadProducto()
        {
            cantidadProducto.Clear();
        }
        public void LimpiarPrecioProducto()
        {
            precioProducto.Clear();
        }
        public void LimpiarMarcaProducto()
        {
            marcaProducto.Clear();
        }
        public void LimpiarDescripcionProducto()
        {
            descripcionProducto.Clear();
        }

        #endregion
        
        #region Pestana clientes

        // componentes
        private TabPage pestanaClientes;
        private Button botonEliminarCliente;
        private DataGridView tablaClientes;
        private Button botonAgregarCliente;
        private TextBox residenciaCliente;
        private TextBox edadCliente;
        private TextBox textBox4;
        private TextBox nombreCliente;
        private TextBox correoCliente;
        private TextBox cedulaCliente;
        private Button botonBuscarCliente;
        private Button botonEditarCliente;

        // getters
        public string GetNombreCliente()
        {
            return nombreCliente.Text.Trim();
        }
        public int GetEdadCliente()
        {
            int edad;
            if (int.TryParse(edadCliente.Text.Trim(), out edad))
            {
                return edad;
            }
            else
            {
                MessageBox.Show("Introduzca una edad valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public string GetResidenciaCliente()
        {
            return residenciaCliente.Text.Trim();
        }
        public string GetCorreoCliente()
        {
            return correoCliente.Text.Trim().ToLower();
        }
        public long GetCedulaCliente()
        {
            long cedula;
            if (long.TryParse(cedulaCliente.Text.Trim(), out cedula))
            {
                return cedula;
            }
            else
            {
                MessageBox.Show("Introduzca una cedula valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }
        public DataGridView GetTablaClientes()
        {
            return tablaClientes;
        }

        // setters
        public void LimpiarNombreCliente()
        {
            nombreCliente.Clear();
        }
        public void LimpiarEdadCliente()
        {
            edadCliente.Clear();
        }
        public void LimpiarResidenciaCliente()
        {
            residenciaCliente.Clear();
        }
        public void LimpiarCorreoCliente()
        {
            correoCliente.Clear();
        }
        public void LimpiarCedulaCliente()
        {
            cedulaCliente.Clear();
        }
        public void SetColorBotonAgregarCliente(Color colorFondo, Color colorTexto)
        {
            botonAgregarCliente.BackColor = colorFondo;
            botonAgregarCliente.ForeColor = colorTexto;
        }
        public void SetColorBotonBuscarCliente(Color colorFondo, Color colorTexto)
        {
            botonBuscarCliente.BackColor = colorFondo;
            botonBuscarCliente.ForeColor = colorTexto;
        }
        public void SetNombreCliente(string nombre)
        {
            nombreCliente.Text = nombre;
        }
        public void SetEdadCliente(int edad)
        {
            edadCliente.Text = edad.ToString();
        }
        public void SetResidenciaCliente(string residencia)
        {
            residenciaCliente.Text = residencia;
        }
        public void SetCorreoCliente(string correo)
        {
            correoCliente.Text = correo;
        }
        public void SetCedulaCliente(int cedula)
        {
            cedulaCliente.Text = cedula.ToString();
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

        #endregion

        #region Pestana facturas

        // componentes
        private Label textoProximamenteFacturas;

#endregion
        
        #region Pestana ajustes

        // componentes
        private Button botonGuardarCambiosAjustes;
        private Label ajustesLabelNombre;
        private ComboBox comboBoxAjustesTema;
        private Label labelAjustesTema;
        private TextBox textBoxAjustesNombre;
        private Panel panelAjustesInterfaz;
        private Label labelAjustesInterfaz;
        private Label labelAjustesSeguridad;
        private Panel panelAjustesSeguridad;
        private TextBox textBoxAjustesCredencialNueva;
        private TextBox textBoxAjustesCredencialAntigua;
        private Label labelAjustesCredencialAntigua;
        private Label labelAjustesCredencialNueva;

        //getters
        public string GetNuevoNombre()
        {
            return textBoxAjustesNombre.Text.Trim();
        }
        public string GetTemaSeleccionado()
        {
            return comboBoxAjustesTema.Text.Trim();
        }
        public string GetCredencialAntigua()
        {
            return textBoxAjustesCredencialAntigua.Text.Trim();
        }
        public string GetCredencialNueva()
        {
            return textBoxAjustesCredencialNueva.Text.Trim();
        }

        // setters
        public void LimpiarNombreAjustes()
        {
            textBoxAjustesNombre.Clear();
        }
        public void LimpiarTemaAjustes()
        {
            comboBoxAjustesTema.SelectedIndex = -1;
        }
        public void LimpiarCredencialAntigua()
        {
            textBoxAjustesCredencialAntigua.Clear();
        }
        public void LimpiarCredencialNueva()
        {
            textBoxAjustesCredencialNueva.Clear();
        }

        #endregion



    }
}