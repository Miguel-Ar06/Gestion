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
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
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
            textoProximamenteAjustes = new Label();
            buscarIdProducto = new TextBox();
            controlPestanas.SuspendLayout();
            pestanaCobros.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaDeMovimientos).BeginInit();
            pestanaInventario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaInventario).BeginInit();
            pestanaClientes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tablaClientes).BeginInit();
            pestanaFacturas.SuspendLayout();
            pestanaAjustes.SuspendLayout();
            SuspendLayout();
            // 
            // nombreNegocio
            // 
            nombreNegocio.AutoSize = true;
            nombreNegocio.Font = new Font("Segoe UI Semibold", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nombreNegocio.Location = new Point(15, 26);
            nombreNegocio.Margin = new Padding(4, 0, 4, 0);
            nombreNegocio.Name = "nombreNegocio";
            nombreNegocio.Size = new Size(495, 65);
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
            controlPestanas.Location = new Point(15, 111);
            controlPestanas.Margin = new Padding(4, 4, 4, 4);
            controlPestanas.Name = "controlPestanas";
            controlPestanas.RightToLeft = RightToLeft.No;
            controlPestanas.SelectedIndex = 0;
            controlPestanas.Size = new Size(1392, 752);
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
            pestanaCobros.Location = new Point(4, 41);
            pestanaCobros.Margin = new Padding(4, 4, 4, 4);
            pestanaCobros.Name = "pestanaCobros";
            pestanaCobros.Padding = new Padding(4, 4, 4, 4);
            pestanaCobros.Size = new Size(1384, 707);
            pestanaCobros.TabIndex = 0;
            pestanaCobros.Text = "Movimiento y cobro";
            // 
            // botonResetearMovimientos
            // 
            botonResetearMovimientos.BackColor = Color.Transparent;
            botonResetearMovimientos.Font = new Font("Segoe UI", 12F);
            botonResetearMovimientos.Location = new Point(438, 530);
            botonResetearMovimientos.Margin = new Padding(4, 4, 4, 4);
            botonResetearMovimientos.Name = "botonResetearMovimientos";
            botonResetearMovimientos.Size = new Size(68, 45);
            botonResetearMovimientos.TabIndex = 19;
            botonResetearMovimientos.Text = "↻";
            botonResetearMovimientos.UseVisualStyleBackColor = false;
            botonResetearMovimientos.Click += botonResetearMovimientos_Click;
            // 
            // botonBuscarMovimientos
            // 
            botonBuscarMovimientos.BackColor = Color.Transparent;
            botonBuscarMovimientos.Font = new Font("Segoe UI", 12F);
            botonBuscarMovimientos.Location = new Point(259, 601);
            botonBuscarMovimientos.Margin = new Padding(4, 4, 4, 4);
            botonBuscarMovimientos.Name = "botonBuscarMovimientos";
            botonBuscarMovimientos.Size = new Size(246, 45);
            botonBuscarMovimientos.TabIndex = 18;
            botonBuscarMovimientos.Text = "Buscar por cedula";
            botonBuscarMovimientos.UseVisualStyleBackColor = false;
            botonBuscarMovimientos.Click += botonBuscarMovimientos_Click;
            // 
            // textoMetodoDePago
            // 
            textoMetodoDePago.AutoSize = true;
            textoMetodoDePago.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoMetodoDePago.Location = new Point(66, 300);
            textoMetodoDePago.Margin = new Padding(4, 0, 4, 0);
            textoMetodoDePago.Name = "textoMetodoDePago";
            textoMetodoDePago.Size = new Size(196, 32);
            textoMetodoDePago.TabIndex = 17;
            textoMetodoDePago.Text = "Metodo de pago";
            // 
            // movimientoBotonEditar
            // 
            movimientoBotonEditar.BackColor = Color.SkyBlue;
            movimientoBotonEditar.Font = new Font("Segoe UI", 12F);
            movimientoBotonEditar.Location = new Point(66, 601);
            movimientoBotonEditar.Margin = new Padding(4, 4, 4, 4);
            movimientoBotonEditar.Name = "movimientoBotonEditar";
            movimientoBotonEditar.Size = new Size(171, 45);
            movimientoBotonEditar.TabIndex = 16;
            movimientoBotonEditar.Text = "Editar";
            movimientoBotonEditar.UseVisualStyleBackColor = false;
            movimientoBotonEditar.Click += movimientoBotonEditar_Click;
            // 
            // movimientoFecha
            // 
            movimientoFecha.CalendarForeColor = SystemColors.ActiveCaptionText;
            movimientoFecha.Location = new Point(66, 420);
            movimientoFecha.Margin = new Padding(4, 4, 4, 4);
            movimientoFecha.Name = "movimientoFecha";
            movimientoFecha.Size = new Size(438, 39);
            movimientoFecha.TabIndex = 15;
            // 
            // movimientoMetodoDePago
            // 
            movimientoMetodoDePago.DropDownStyle = ComboBoxStyle.DropDownList;
            movimientoMetodoDePago.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoMetodoDePago.ForeColor = SystemColors.WindowFrame;
            movimientoMetodoDePago.FormattingEnabled = true;
            movimientoMetodoDePago.Items.AddRange(new object[] { "Efectivo", "Tarjeta de credito", "Tarjeta de Debito", "En linea" });
            movimientoMetodoDePago.Location = new Point(66, 350);
            movimientoMetodoDePago.Margin = new Padding(4, 4, 4, 4);
            movimientoMetodoDePago.Name = "movimientoMetodoDePago";
            movimientoMetodoDePago.Size = new Size(438, 40);
            movimientoMetodoDePago.TabIndex = 14;
            // 
            // movimientoCedula
            // 
            movimientoCedula.BorderStyle = BorderStyle.FixedSingle;
            movimientoCedula.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoCedula.Location = new Point(66, 239);
            movimientoCedula.Margin = new Padding(4, 4, 4, 4);
            movimientoCedula.Name = "movimientoCedula";
            movimientoCedula.PlaceholderText = "Cedula del cliente";
            movimientoCedula.Size = new Size(438, 39);
            movimientoCedula.TabIndex = 13;
            // 
            // botonEliminarMovimiento
            // 
            botonEliminarMovimiento.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarMovimiento.BackColor = Color.LightCoral;
            botonEliminarMovimiento.Font = new Font("Segoe UI", 12F);
            botonEliminarMovimiento.Location = new Point(1148, 610);
            botonEliminarMovimiento.Margin = new Padding(4, 4, 4, 4);
            botonEliminarMovimiento.Name = "botonEliminarMovimiento";
            botonEliminarMovimiento.Size = new Size(171, 45);
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
            montoTotal.Location = new Point(738, 602);
            montoTotal.Margin = new Padding(4, 0, 4, 0);
            montoTotal.Name = "montoTotal";
            montoTotal.Size = new Size(109, 48);
            montoTotal.TabIndex = 11;
            montoTotal.Text = "0.00$";
            // 
            // textoTotal
            // 
            textoTotal.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            textoTotal.AutoSize = true;
            textoTotal.Font = new Font("Segoe UI Semibold", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textoTotal.Location = new Point(628, 601);
            textoTotal.Margin = new Padding(4, 0, 4, 0);
            textoTotal.Name = "textoTotal";
            textoTotal.Size = new Size(109, 48);
            textoTotal.TabIndex = 10;
            textoTotal.Text = "Total:";
            // 
            // tablaDeMovimientos
            // 
            tablaDeMovimientos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaDeMovimientos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = SystemColors.Window;
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle5.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle5.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            tablaDeMovimientos.DefaultCellStyle = dataGridViewCellStyle5;
            tablaDeMovimientos.Location = new Point(628, 55);
            tablaDeMovimientos.Margin = new Padding(4, 4, 4, 4);
            tablaDeMovimientos.Name = "tablaDeMovimientos";
            tablaDeMovimientos.RowHeadersWidth = 51;
            tablaDeMovimientos.Size = new Size(691, 518);
            tablaDeMovimientos.TabIndex = 9;
            tablaDeMovimientos.CellFormatting += tablaDeMovimientos_CellFormatting;
            // 
            // movimientoTextoRegistrar
            // 
            movimientoTextoRegistrar.AutoSize = true;
            movimientoTextoRegistrar.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            movimientoTextoRegistrar.Location = new Point(66, 479);
            movimientoTextoRegistrar.Margin = new Padding(4, 0, 4, 0);
            movimientoTextoRegistrar.Name = "movimientoTextoRegistrar";
            movimientoTextoRegistrar.Size = new Size(178, 32);
            movimientoTextoRegistrar.TabIndex = 8;
            movimientoTextoRegistrar.Text = "Registrar como";
            // 
            // movimientoBotonEgreso
            // 
            movimientoBotonEgreso.BackColor = Color.PaleVioletRed;
            movimientoBotonEgreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonEgreso.Location = new Point(259, 530);
            movimientoBotonEgreso.Margin = new Padding(4, 4, 4, 4);
            movimientoBotonEgreso.Name = "movimientoBotonEgreso";
            movimientoBotonEgreso.Size = new Size(171, 45);
            movimientoBotonEgreso.TabIndex = 7;
            movimientoBotonEgreso.Text = "Egreso";
            movimientoBotonEgreso.UseVisualStyleBackColor = false;
            movimientoBotonEgreso.Click += movimientoBotonEgreso_Click;
            // 
            // movimientoBotonIngreso
            // 
            movimientoBotonIngreso.BackColor = Color.LightGreen;
            movimientoBotonIngreso.Font = new Font("Segoe UI", 12F);
            movimientoBotonIngreso.Location = new Point(66, 530);
            movimientoBotonIngreso.Margin = new Padding(4, 4, 4, 4);
            movimientoBotonIngreso.Name = "movimientoBotonIngreso";
            movimientoBotonIngreso.Size = new Size(171, 45);
            movimientoBotonIngreso.TabIndex = 6;
            movimientoBotonIngreso.Text = "Ingreso";
            movimientoBotonIngreso.UseVisualStyleBackColor = false;
            movimientoBotonIngreso.Click += movimientoBotonIngreso_Click;
            // 
            // movimientoMonto
            // 
            movimientoMonto.BorderStyle = BorderStyle.FixedSingle;
            movimientoMonto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoMonto.Location = new Point(66, 175);
            movimientoMonto.Margin = new Padding(4, 4, 4, 4);
            movimientoMonto.Name = "movimientoMonto";
            movimientoMonto.PlaceholderText = "Monto: $000,000.00";
            movimientoMonto.Size = new Size(438, 39);
            movimientoMonto.TabIndex = 5;
            // 
            // movimientoDescripcion
            // 
            movimientoDescripcion.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            movimientoDescripcion.Location = new Point(66, 55);
            movimientoDescripcion.Margin = new Padding(4, 4, 4, 4);
            movimientoDescripcion.Multiline = true;
            movimientoDescripcion.Name = "movimientoDescripcion";
            movimientoDescripcion.PlaceholderText = "Descripcion";
            movimientoDescripcion.Size = new Size(438, 99);
            movimientoDescripcion.TabIndex = 3;
            // 
            // pestanaInventario
            // 
            pestanaInventario.Controls.Add(buscarIdProducto);
            pestanaInventario.Controls.Add(botonBuscarProducto);
            pestanaInventario.Controls.Add(botonEliminarProducto);
            pestanaInventario.Controls.Add(tablaInventario);
            pestanaInventario.Controls.Add(botonAgregarProducto);
            pestanaInventario.Controls.Add(descripcionProducto);
            pestanaInventario.Controls.Add(precioProducto);
            pestanaInventario.Controls.Add(cantidadProducto);
            pestanaInventario.Controls.Add(nombreProducto);
            pestanaInventario.Location = new Point(4, 41);
            pestanaInventario.Margin = new Padding(4, 4, 4, 4);
            pestanaInventario.Name = "pestanaInventario";
            pestanaInventario.Padding = new Padding(4, 4, 4, 4);
            pestanaInventario.Size = new Size(1384, 707);
            pestanaInventario.TabIndex = 1;
            pestanaInventario.Text = "Inventario";
            pestanaInventario.UseVisualStyleBackColor = true;
            // 
            // botonBuscarProducto
            // 
            botonBuscarProducto.Location = new Point(1124, 29);
            botonBuscarProducto.Margin = new Padding(4, 4, 4, 4);
            botonBuscarProducto.Name = "botonBuscarProducto";
            botonBuscarProducto.Size = new Size(202, 104);
            botonBuscarProducto.TabIndex = 8;
            botonBuscarProducto.Text = "Buscar";
            botonBuscarProducto.UseVisualStyleBackColor = true;
            botonBuscarProducto.Click += botonBuscarProducto_Click;
            // 
            // botonEliminarProducto
            // 
            botonEliminarProducto.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarProducto.BackColor = Color.LightCoral;
            botonEliminarProducto.Font = new Font("Segoe UI", 12F);
            botonEliminarProducto.Location = new Point(1182, 626);
            botonEliminarProducto.Margin = new Padding(4, 4, 4, 4);
            botonEliminarProducto.Name = "botonEliminarProducto";
            botonEliminarProducto.Size = new Size(171, 45);
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
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = SystemColors.Window;
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle4.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.False;
            tablaInventario.DefaultCellStyle = dataGridViewCellStyle4;
            tablaInventario.Location = new Point(25, 219);
            tablaInventario.Margin = new Padding(4, 4, 4, 4);
            tablaInventario.Name = "tablaInventario";
            tablaInventario.RowHeadersWidth = 51;
            tablaInventario.Size = new Size(1329, 362);
            tablaInventario.TabIndex = 6;
            // 
            // botonAgregarProducto
            // 
            botonAgregarProducto.Location = new Point(901, 29);
            botonAgregarProducto.Margin = new Padding(4, 4, 4, 4);
            botonAgregarProducto.Name = "botonAgregarProducto";
            botonAgregarProducto.Size = new Size(202, 104);
            botonAgregarProducto.TabIndex = 5;
            botonAgregarProducto.Text = "Agregar";
            botonAgregarProducto.UseVisualStyleBackColor = true;
            botonAgregarProducto.Click += botonAgregarProducto_Click;
            // 
            // descripcionProducto
            // 
            descripcionProducto.BorderStyle = BorderStyle.FixedSingle;
            descripcionProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            descripcionProducto.Location = new Point(25, 92);
            descripcionProducto.Margin = new Padding(4, 4, 4, 4);
            descripcionProducto.Multiline = true;
            descripcionProducto.Name = "descripcionProducto";
            descripcionProducto.PlaceholderText = "Descripcion";
            descripcionProducto.Size = new Size(600, 88);
            descripcionProducto.TabIndex = 4;
            // 
            // precioProducto
            // 
            precioProducto.BorderStyle = BorderStyle.FixedSingle;
            precioProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            precioProducto.Location = new Point(474, 29);
            precioProducto.Margin = new Padding(4, 4, 4, 4);
            precioProducto.Name = "precioProducto";
            precioProducto.PlaceholderText = "*Precio ($)";
            precioProducto.Size = new Size(151, 39);
            precioProducto.TabIndex = 2;
            // 
            // cantidadProducto
            // 
            cantidadProducto.BorderStyle = BorderStyle.FixedSingle;
            cantidadProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cantidadProducto.Location = new Point(312, 29);
            cantidadProducto.Margin = new Padding(4, 4, 4, 4);
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.PlaceholderText = "*Cantidad";
            cantidadProducto.Size = new Size(140, 39);
            cantidadProducto.TabIndex = 1;
            // 
            // nombreProducto
            // 
            nombreProducto.BorderStyle = BorderStyle.FixedSingle;
            nombreProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreProducto.Location = new Point(25, 29);
            nombreProducto.Margin = new Padding(4, 4, 4, 4);
            nombreProducto.Name = "nombreProducto";
            nombreProducto.PlaceholderText = "*Nombre del producto";
            nombreProducto.Size = new Size(258, 39);
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
            pestanaClientes.Location = new Point(4, 41);
            pestanaClientes.Margin = new Padding(4, 4, 4, 4);
            pestanaClientes.Name = "pestanaClientes";
            pestanaClientes.Padding = new Padding(4, 4, 4, 4);
            pestanaClientes.Size = new Size(1384, 707);
            pestanaClientes.TabIndex = 4;
            pestanaClientes.Text = "Clientes";
            pestanaClientes.UseVisualStyleBackColor = true;
            // 
            // botonEditarCliente
            // 
            botonEditarCliente.BackColor = Color.SkyBlue;
            botonEditarCliente.Font = new Font("Segoe UI", 12F);
            botonEditarCliente.Location = new Point(32, 578);
            botonEditarCliente.Margin = new Padding(4, 4, 4, 4);
            botonEditarCliente.Name = "botonEditarCliente";
            botonEditarCliente.Size = new Size(171, 45);
            botonEditarCliente.TabIndex = 19;
            botonEditarCliente.Text = "Editar";
            botonEditarCliente.UseVisualStyleBackColor = false;
            botonEditarCliente.Click += botonEditarCliente_Click;
            // 
            // cedulaCliente
            // 
            cedulaCliente.BorderStyle = BorderStyle.FixedSingle;
            cedulaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cedulaCliente.Location = new Point(32, 131);
            cedulaCliente.Margin = new Padding(4, 4, 4, 4);
            cedulaCliente.Name = "cedulaCliente";
            cedulaCliente.PlaceholderText = "Cedula";
            cedulaCliente.Size = new Size(304, 39);
            cedulaCliente.TabIndex = 18;
            // 
            // botonBuscarCliente
            // 
            botonBuscarCliente.Location = new Point(135, 341);
            botonBuscarCliente.Margin = new Padding(4, 4, 4, 4);
            botonBuscarCliente.Name = "botonBuscarCliente";
            botonBuscarCliente.Size = new Size(202, 104);
            botonBuscarCliente.TabIndex = 17;
            botonBuscarCliente.Text = "Buscar";
            botonBuscarCliente.UseVisualStyleBackColor = true;
            botonBuscarCliente.Click += botonBuscarCliente_Click;
            // 
            // correoCliente
            // 
            correoCliente.BorderStyle = BorderStyle.FixedSingle;
            correoCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            correoCliente.Location = new Point(32, 266);
            correoCliente.Margin = new Padding(4, 4, 4, 4);
            correoCliente.Name = "correoCliente";
            correoCliente.PlaceholderText = "Correo";
            correoCliente.Size = new Size(531, 39);
            correoCliente.TabIndex = 16;
            // 
            // botonEliminarCliente
            // 
            botonEliminarCliente.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            botonEliminarCliente.BackColor = Color.LightCoral;
            botonEliminarCliente.Font = new Font("Segoe UI", 12F);
            botonEliminarCliente.Location = new Point(392, 578);
            botonEliminarCliente.Margin = new Padding(4, 4, 4, 4);
            botonEliminarCliente.Name = "botonEliminarCliente";
            botonEliminarCliente.Size = new Size(171, 45);
            botonEliminarCliente.TabIndex = 15;
            botonEliminarCliente.Text = "Eliminar";
            botonEliminarCliente.UseVisualStyleBackColor = false;
            botonEliminarCliente.Click += botonEliminarCliente_Click;
            // 
            // tablaClientes
            // 
            tablaClientes.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            tablaClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = SystemColors.Window;
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 12F);
            dataGridViewCellStyle6.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle6.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.False;
            tablaClientes.DefaultCellStyle = dataGridViewCellStyle6;
            tablaClientes.Location = new Point(629, 69);
            tablaClientes.Margin = new Padding(4, 4, 4, 4);
            tablaClientes.Name = "tablaClientes";
            tablaClientes.RowHeadersWidth = 51;
            tablaClientes.Size = new Size(709, 554);
            tablaClientes.TabIndex = 14;
            // 
            // botonAgregarCliente
            // 
            botonAgregarCliente.Location = new Point(361, 341);
            botonAgregarCliente.Margin = new Padding(4, 4, 4, 4);
            botonAgregarCliente.Name = "botonAgregarCliente";
            botonAgregarCliente.Size = new Size(202, 104);
            botonAgregarCliente.TabIndex = 13;
            botonAgregarCliente.Text = "Agregar";
            botonAgregarCliente.UseVisualStyleBackColor = true;
            botonAgregarCliente.Click += botonAgregarCliente_Click;
            // 
            // residenciaCliente
            // 
            residenciaCliente.BorderStyle = BorderStyle.FixedSingle;
            residenciaCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            residenciaCliente.Location = new Point(32, 198);
            residenciaCliente.Margin = new Padding(4, 4, 4, 4);
            residenciaCliente.Name = "residenciaCliente";
            residenciaCliente.PlaceholderText = "Residencia";
            residenciaCliente.Size = new Size(531, 39);
            residenciaCliente.TabIndex = 11;
            // 
            // edadCliente
            // 
            edadCliente.BorderStyle = BorderStyle.FixedSingle;
            edadCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            edadCliente.Location = new Point(361, 131);
            edadCliente.Margin = new Padding(4, 4, 4, 4);
            edadCliente.Name = "edadCliente";
            edadCliente.PlaceholderText = "Edad";
            edadCliente.Size = new Size(202, 39);
            edadCliente.TabIndex = 10;
            // 
            // nombreCliente
            // 
            nombreCliente.BorderStyle = BorderStyle.FixedSingle;
            nombreCliente.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            nombreCliente.Location = new Point(32, 69);
            nombreCliente.Margin = new Padding(4, 4, 4, 4);
            nombreCliente.Name = "nombreCliente";
            nombreCliente.PlaceholderText = "Nombre del cliente";
            nombreCliente.Size = new Size(531, 39);
            nombreCliente.TabIndex = 8;
            // 
            // pestanaFacturas
            // 
            pestanaFacturas.Controls.Add(textoProximamenteFacturas);
            pestanaFacturas.Location = new Point(4, 41);
            pestanaFacturas.Margin = new Padding(4, 4, 4, 4);
            pestanaFacturas.Name = "pestanaFacturas";
            pestanaFacturas.Size = new Size(1384, 707);
            pestanaFacturas.TabIndex = 2;
            pestanaFacturas.Text = "Facturas";
            pestanaFacturas.UseVisualStyleBackColor = true;
            // 
            // textoProximamenteFacturas
            // 
            textoProximamenteFacturas.AutoSize = true;
            textoProximamenteFacturas.Location = new Point(591, 328);
            textoProximamenteFacturas.Margin = new Padding(4, 0, 4, 0);
            textoProximamenteFacturas.Name = "textoProximamenteFacturas";
            textoProximamenteFacturas.Size = new Size(173, 32);
            textoProximamenteFacturas.TabIndex = 0;
            textoProximamenteFacturas.Text = "Proximamente";
            // 
            // pestanaAjustes
            // 
            pestanaAjustes.Controls.Add(textoProximamenteAjustes);
            pestanaAjustes.Location = new Point(4, 41);
            pestanaAjustes.Margin = new Padding(4, 4, 4, 4);
            pestanaAjustes.Name = "pestanaAjustes";
            pestanaAjustes.Size = new Size(1384, 707);
            pestanaAjustes.TabIndex = 3;
            pestanaAjustes.Text = "Ajustes";
            pestanaAjustes.UseVisualStyleBackColor = true;
            // 
            // textoProximamenteAjustes
            // 
            textoProximamenteAjustes.AutoSize = true;
            textoProximamenteAjustes.Location = new Point(595, 316);
            textoProximamenteAjustes.Margin = new Padding(4, 0, 4, 0);
            textoProximamenteAjustes.Name = "textoProximamenteAjustes";
            textoProximamenteAjustes.Size = new Size(173, 32);
            textoProximamenteAjustes.TabIndex = 1;
            textoProximamenteAjustes.Text = "Proximamente";
            // 
            // buscarIdProducto
            // 
            buscarIdProducto.BorderStyle = BorderStyle.FixedSingle;
            buscarIdProducto.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buscarIdProducto.Location = new Point(649, 29);
            buscarIdProducto.Margin = new Padding(4);
            buscarIdProducto.Name = "buscarIdProducto";
            buscarIdProducto.PlaceholderText = "*Buscar ID";
            buscarIdProducto.Size = new Size(151, 39);
            buscarIdProducto.TabIndex = 9;
            // 
            // MenuPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1422, 879);
            Controls.Add(controlPestanas);
            Controls.Add(nombreNegocio);
            ForeColor = SystemColors.ActiveCaptionText;
            Margin = new Padding(4, 4, 4, 4);
            Name = "MenuPrincipal";
            Text = "MenuPrincipal";
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
        private TextBox precioProducto;
        private TextBox descripcionProducto;
        private Button botonAgregarProducto;
        private DataGridView tablaInventario;
        private Button botonEliminarProducto;
        private Button botonBuscarProducto;

        // getters

        public int GetIdProducto()
        {
            int idProducto;
            if (int.TryParse(buscarIdProducto.Text.Trim(), out idProducto))
            {
                return idProducto;
            }
            else
            {
                MessageBox.Show("Introduzca un ID valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
        }

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

            if (decimal.TryParse(precioProducto.Text.Trim(), out precio))
            {
                return precio;
            }
            else
            {
                MessageBox.Show("Introduzca un precio valido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return -1;
            }
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
            return correoCliente.Text.Trim();
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

        // getters

        // setters

        #endregion

        #region Pestana ajustes

        // componentes
        private Label textoProximamenteAjustes;

        //getters

        // setters

        #endregion


        private Button botonResetearMovimientos;
        private TextBox buscarIdProducto;
    }
}