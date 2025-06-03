namespace CapaPresentacion
{
    partial class Form1
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
            lblId = new Label();
            txtId = new TextBox();
            btnBuscar = new Button();
            lblNombre = new Label();
            lblNumCuenta = new Label();
            lblTipo = new Label();
            lblMonto = new Label();
            txtNombre = new TextBox();
            txtCuenta = new TextBox();
            txtMonto = new TextBox();
            btnDepositar = new Button();
            lblConsultar = new Button();
            lblRetirar = new Button();
            lblSaldo = new Label();
            txtSaldoActual = new TextBox();
            cmbTipo = new ComboBox();
            btnLimpiar = new Button();
            btnAgregar = new Button();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(135, 49);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            lblId.Click += lblId_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(186, 46);
            txtId.Name = "txtId";
            txtId.Size = new Size(197, 27);
            txtId.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.Location = new Point(404, 45);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = true;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(116, 96);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(126, 152);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(55, 20);
            lblNumCuenta.TabIndex = 4;
            lblNumCuenta.Text = "Cuenta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(126, 204);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(64, 261);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(187, 96);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(196, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(187, 145);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.Size = new Size(196, 27);
            txtCuenta.TabIndex = 8;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(135, 258);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(307, 27);
            txtMonto.TabIndex = 10;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(126, 305);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 12;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // lblConsultar
            // 
            lblConsultar.Location = new Point(364, 305);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(94, 29);
            lblConsultar.TabIndex = 13;
            lblConsultar.Text = "Consultar";
            lblConsultar.UseVisualStyleBackColor = true;
            lblConsultar.Click += lblConsultar_Click;
            // 
            // lblRetirar
            // 
            lblRetirar.Location = new Point(247, 305);
            lblRetirar.Name = "lblRetirar";
            lblRetirar.Size = new Size(94, 29);
            lblRetirar.TabIndex = 14;
            lblRetirar.Text = "Retirar";
            lblRetirar.UseVisualStyleBackColor = true;
            lblRetirar.Click += lblRetirar_Click;
            // 
            // lblSaldo
            // 
            lblSaldo.AutoSize = true;
            lblSaldo.Location = new Point(24, 362);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(93, 20);
            lblSaldo.TabIndex = 15;
            lblSaldo.Text = "Saldo Actual";
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(126, 359);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.Size = new Size(353, 27);
            txtSaldoActual.TabIndex = 16;
            // 
            // cmbTipo
            // 
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Location = new Point(186, 201);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(197, 28);
            cmbTipo.TabIndex = 17;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(404, 96);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 29);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnAgregar
            // 
            btnAgregar.Location = new Point(23, 46);
            btnAgregar.Name = "btnAgregar";
            btnAgregar.Size = new Size(94, 29);
            btnAgregar.TabIndex = 19;
            btnAgregar.Text = "Agregar";
            btnAgregar.UseVisualStyleBackColor = true;
            btnAgregar.Click += btnAgregar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(553, 422);
            Controls.Add(btnAgregar);
            Controls.Add(btnLimpiar);
            Controls.Add(cmbTipo);
            Controls.Add(txtSaldoActual);
            Controls.Add(lblSaldo);
            Controls.Add(lblRetirar);
            Controls.Add(lblConsultar);
            Controls.Add(btnDepositar);
            Controls.Add(txtMonto);
            Controls.Add(txtCuenta);
            Controls.Add(txtNombre);
            Controls.Add(lblMonto);
            Controls.Add(lblTipo);
            Controls.Add(lblNumCuenta);
            Controls.Add(lblNombre);
            Controls.Add(btnBuscar);
            Controls.Add(txtId);
            Controls.Add(lblId);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblId;
        private TextBox txtId;
        private Button btnBuscar;
        private Label lblNombre;
        private Label lblNumCuenta;
        private Label lblTipo;
        private Label lblMonto;
        private TextBox txtNombre;
        private TextBox txtCuenta;
        private TextBox txtMonto;
        private ComboBox cmbTipo;
        private Button btnDepositar;
        private Button lblConsultar;
        private Button lblRetirar;
        private Label lblSaldo;
        private TextBox txtSaldoActual;
        private Button btnLimpiar;
        private Button btnAgregar;
    }
}
