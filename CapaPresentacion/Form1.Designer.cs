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
            btnLimpiar = new Button();
            label1 = new Label();
            txtTipo = new TextBox();
            dgvCuentas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).BeginInit();
            SuspendLayout();
            // 
            // lblId
            // 
            lblId.AutoSize = true;
            lblId.Location = new Point(102, 290);
            lblId.Name = "lblId";
            lblId.Size = new Size(24, 20);
            lblId.TabIndex = 0;
            lblId.Text = "ID";
            // 
            // txtId
            // 
            txtId.Location = new Point(134, 287);
            txtId.Name = "txtId";
            txtId.Size = new Size(285, 27);
            txtId.TabIndex = 1;
            // 
            // btnBuscar
            // 
            btnBuscar.BackColor = SystemColors.Window;
            btnBuscar.Location = new Point(425, 287);
            btnBuscar.Name = "btnBuscar";
            btnBuscar.Size = new Size(109, 28);
            btnBuscar.TabIndex = 2;
            btnBuscar.Text = "Buscar";
            btnBuscar.UseVisualStyleBackColor = false;
            btnBuscar.Click += btnBuscar_Click;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(22, 345);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(64, 20);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre";
            // 
            // lblNumCuenta
            // 
            lblNumCuenta.AutoSize = true;
            lblNumCuenta.Location = new Point(302, 345);
            lblNumCuenta.Name = "lblNumCuenta";
            lblNumCuenta.Size = new Size(55, 20);
            lblNumCuenta.TabIndex = 4;
            lblNumCuenta.Text = "Cuenta";
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(197, 402);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(39, 20);
            lblTipo.TabIndex = 5;
            lblTipo.Text = "Tipo";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(78, 466);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(53, 20);
            lblMonto.TabIndex = 6;
            lblMonto.Text = "Monto";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(92, 342);
            txtNombre.Name = "txtNombre";
            txtNombre.ReadOnly = true;
            txtNombre.Size = new Size(196, 27);
            txtNombre.TabIndex = 7;
            // 
            // txtCuenta
            // 
            txtCuenta.Location = new Point(363, 342);
            txtCuenta.Name = "txtCuenta";
            txtCuenta.ReadOnly = true;
            txtCuenta.Size = new Size(196, 27);
            txtCuenta.TabIndex = 8;
            // 
            // txtMonto
            // 
            txtMonto.Location = new Point(148, 459);
            txtMonto.Name = "txtMonto";
            txtMonto.Size = new Size(307, 27);
            txtMonto.TabIndex = 10;
            // 
            // btnDepositar
            // 
            btnDepositar.Location = new Point(134, 492);
            btnDepositar.Name = "btnDepositar";
            btnDepositar.Size = new Size(94, 29);
            btnDepositar.TabIndex = 12;
            btnDepositar.Text = "Depositar";
            btnDepositar.UseVisualStyleBackColor = true;
            btnDepositar.Click += btnDepositar_Click;
            // 
            // lblConsultar
            // 
            lblConsultar.Location = new Point(373, 492);
            lblConsultar.Name = "lblConsultar";
            lblConsultar.Size = new Size(94, 29);
            lblConsultar.TabIndex = 13;
            lblConsultar.Text = "Consultar";
            lblConsultar.UseVisualStyleBackColor = true;
            lblConsultar.Click += lblConsultar_Click;
            // 
            // lblRetirar
            // 
            lblRetirar.Location = new Point(253, 492);
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
            lblSaldo.Location = new Point(253, 544);
            lblSaldo.Name = "lblSaldo";
            lblSaldo.Size = new Size(93, 20);
            lblSaldo.TabIndex = 15;
            lblSaldo.Text = "Saldo Actual";
            // 
            // txtSaldoActual
            // 
            txtSaldoActual.Location = new Point(128, 583);
            txtSaldoActual.Name = "txtSaldoActual";
            txtSaldoActual.ReadOnly = true;
            txtSaldoActual.Size = new Size(353, 27);
            txtSaldoActual.TabIndex = 16;
            // 
            // btnLimpiar
            // 
            btnLimpiar.Location = new Point(248, 631);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(109, 33);
            btnLimpiar.TabIndex = 18;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = true;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Times New Roman", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(166, 23);
            label1.Name = "label1";
            label1.Size = new Size(289, 53);
            label1.TabIndex = 19;
            label1.Text = "Banco Eurux";
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(242, 399);
            txtTipo.Name = "txtTipo";
            txtTipo.ReadOnly = true;
            txtTipo.Size = new Size(124, 27);
            txtTipo.TabIndex = 20;
            // 
            // dgvCuentas
            // 
            dgvCuentas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvCuentas.Location = new Point(148, 79);
            dgvCuentas.Name = "dgvCuentas";
            dgvCuentas.ReadOnly = true;
            dgvCuentas.RowHeadersWidth = 51;
            dgvCuentas.Size = new Size(333, 188);
            dgvCuentas.TabIndex = 21;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(639, 702);
            Controls.Add(dgvCuentas);
            Controls.Add(txtTipo);
            Controls.Add(label1);
            Controls.Add(btnLimpiar);
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
            Text = "SISTEMA BANCARIO";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvCuentas).EndInit();
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
        private Button btnDepositar;
        private Button lblConsultar;
        private Button lblRetirar;
        private Label lblSaldo;
        private TextBox txtSaldoActual;
        private Button btnLimpiar;
        private Label label1;
        private TextBox txtTipo;
        private DataGridView dgvCuentas;
    }
}
