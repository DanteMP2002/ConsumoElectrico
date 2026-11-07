namespace Ejercicio05_ConsumoElectrico
{
    partial class frmResultado
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmResultado));
            lblNombreCliente = new Label();
            lblTarifa = new Label();
            lblMontoConsumo = new Label();
            lblBono = new Label();
            lblRecargo = new Label();
            pnlTitulo = new Panel();
            lblSubTitulo = new Label();
            lblTitulo = new Label();
            pnlConsumoCalculado = new Panel();
            lblConsumoCalculadoValor = new Label();
            pnlNombreCliente = new Panel();
            lblNombreClienteValor = new Label();
            lblTotalPago = new Label();
            pnlTarifa = new Panel();
            lblTarifaValor = new Label();
            lblPorKwh = new Label();
            pnlMontoConsumo = new Panel();
            lblMontoConsumoValor = new Label();
            pnlBono = new Panel();
            lblBonoValor = new Label();
            pnlRecargo = new Panel();
            lblRecargoValor = new Label();
            pnlTotalPago = new Panel();
            lblTotalPagoValor = new Label();
            lblConsumoCalculado = new Label();
            pnlTitulo.SuspendLayout();
            pnlConsumoCalculado.SuspendLayout();
            pnlNombreCliente.SuspendLayout();
            pnlTarifa.SuspendLayout();
            pnlMontoConsumo.SuspendLayout();
            pnlBono.SuspendLayout();
            pnlRecargo.SuspendLayout();
            pnlTotalPago.SuspendLayout();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblNombreCliente.Location = new Point(50, 95);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(259, 27);
            lblNombreCliente.TabIndex = 3;
            lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // lblTarifa
            // 
            lblTarifa.AutoSize = true;
            lblTarifa.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblTarifa.Location = new Point(50, 195);
            lblTarifa.Name = "lblTarifa";
            lblTarifa.Size = new Size(220, 27);
            lblTarifa.TabIndex = 4;
            lblTarifa.Text = "Tarifa aplicada:";
            // 
            // lblMontoConsumo
            // 
            lblMontoConsumo.AutoSize = true;
            lblMontoConsumo.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblMontoConsumo.Location = new Point(50, 245);
            lblMontoConsumo.Name = "lblMontoConsumo";
            lblMontoConsumo.Size = new Size(246, 27);
            lblMontoConsumo.TabIndex = 5;
            lblMontoConsumo.Text = "Monto por consumo:";
            // 
            // lblBono
            // 
            lblBono.AutoSize = true;
            lblBono.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblBono.Location = new Point(50, 295);
            lblBono.Name = "lblBono";
            lblBono.Size = new Size(207, 27);
            lblBono.TabIndex = 6;
            lblBono.Text = "Bono de ahorro:";
            // 
            // lblRecargo
            // 
            lblRecargo.AutoSize = true;
            lblRecargo.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblRecargo.Location = new Point(50, 345);
            lblRecargo.Name = "lblRecargo";
            lblRecargo.Size = new Size(298, 27);
            lblRecargo.TabIndex = 7;
            lblRecargo.Text = "Recargo por alumbrado:";
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = Color.FromArgb(200, 255, 1);
            pnlTitulo.Controls.Add(lblSubTitulo);
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(782, 65);
            pnlTitulo.TabIndex = 8;
            // 
            // lblSubTitulo
            // 
            lblSubTitulo.AutoSize = true;
            lblSubTitulo.Font = new Font("Consolas", 10.2F, FontStyle.Italic, GraphicsUnit.Point, 0);
            lblSubTitulo.ForeColor = SystemColors.ControlDarkDark;
            lblSubTitulo.Location = new Point(269, 42);
            lblSubTitulo.Name = "lblSubTitulo";
            lblSubTitulo.Size = new Size(261, 20);
            lblSubTitulo.TabIndex = 18;
            lblSubTitulo.Text = "CONSUMO DE ENERGIA ELECTRICA";
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(241, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(315, 33);
            lblTitulo.TabIndex = 17;
            lblTitulo.Text = "RESULTADO DEL RECIBO";
            // 
            // pnlConsumoCalculado
            // 
            pnlConsumoCalculado.BackColor = Color.FromArgb(220, 255, 180);
            pnlConsumoCalculado.BorderStyle = BorderStyle.Fixed3D;
            pnlConsumoCalculado.Controls.Add(lblConsumoCalculadoValor);
            pnlConsumoCalculado.Location = new Point(380, 137);
            pnlConsumoCalculado.Name = "pnlConsumoCalculado";
            pnlConsumoCalculado.Size = new Size(300, 40);
            pnlConsumoCalculado.TabIndex = 10;
            // 
            // lblConsumoCalculadoValor
            // 
            lblConsumoCalculadoValor.AutoSize = true;
            lblConsumoCalculadoValor.BackColor = Color.Transparent;
            lblConsumoCalculadoValor.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblConsumoCalculadoValor.Location = new Point(15, 2);
            lblConsumoCalculadoValor.Name = "lblConsumoCalculadoValor";
            lblConsumoCalculadoValor.Size = new Size(159, 36);
            lblConsumoCalculadoValor.TabIndex = 4;
            lblConsumoCalculadoValor.Text = "0000  Kwh";
            lblConsumoCalculadoValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlNombreCliente
            // 
            pnlNombreCliente.BackColor = Color.White;
            pnlNombreCliente.BorderStyle = BorderStyle.Fixed3D;
            pnlNombreCliente.Controls.Add(lblNombreClienteValor);
            pnlNombreCliente.Location = new Point(380, 87);
            pnlNombreCliente.Name = "pnlNombreCliente";
            pnlNombreCliente.Size = new Size(320, 40);
            pnlNombreCliente.TabIndex = 11;
            // 
            // lblNombreClienteValor
            // 
            lblNombreClienteValor.BackColor = Color.Transparent;
            lblNombreClienteValor.FlatStyle = FlatStyle.System;
            lblNombreClienteValor.Font = new Font("Consolas", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreClienteValor.Location = new Point(2, 6);
            lblNombreClienteValor.Name = "lblNombreClienteValor";
            lblNombreClienteValor.Size = new Size(313, 27);
            lblNombreClienteValor.TabIndex = 0;
            lblNombreClienteValor.Text = "NOMBRE DE CLIENTE";
            lblNombreClienteValor.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // lblTotalPago
            // 
            lblTotalPago.AutoSize = true;
            lblTotalPago.Font = new Font("Consolas", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPago.Location = new Point(29, 417);
            lblTotalPago.Name = "lblTotalPago";
            lblTotalPago.Size = new Size(328, 47);
            lblTotalPago.TabIndex = 12;
            lblTotalPago.Text = "TOTAL A PAGAR:";
            // 
            // pnlTarifa
            // 
            pnlTarifa.BackColor = Color.Azure;
            pnlTarifa.BorderStyle = BorderStyle.Fixed3D;
            pnlTarifa.Controls.Add(lblTarifaValor);
            pnlTarifa.Controls.Add(lblPorKwh);
            pnlTarifa.Location = new Point(380, 187);
            pnlTarifa.Name = "pnlTarifa";
            pnlTarifa.Size = new Size(300, 40);
            pnlTarifa.TabIndex = 11;
            // 
            // lblTarifaValor
            // 
            lblTarifaValor.AutoSize = true;
            lblTarifaValor.BackColor = Color.Transparent;
            lblTarifaValor.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTarifaValor.Location = new Point(7, 2);
            lblTarifaValor.Name = "lblTarifaValor";
            lblTarifaValor.Size = new Size(127, 36);
            lblTarifaValor.TabIndex = 2;
            lblTarifaValor.Text = "S/ 0.00";
            lblTarifaValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblPorKwh
            // 
            lblPorKwh.BackColor = Color.Transparent;
            lblPorKwh.Dock = DockStyle.Right;
            lblPorKwh.Font = new Font("Consolas", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPorKwh.Location = new Point(193, 0);
            lblPorKwh.Name = "lblPorKwh";
            lblPorKwh.Size = new Size(103, 36);
            lblPorKwh.TabIndex = 0;
            lblPorKwh.Text = "por Kwh";
            lblPorKwh.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlMontoConsumo
            // 
            pnlMontoConsumo.BackColor = Color.FromArgb(234, 254, 255);
            pnlMontoConsumo.BorderStyle = BorderStyle.Fixed3D;
            pnlMontoConsumo.Controls.Add(lblMontoConsumoValor);
            pnlMontoConsumo.Location = new Point(380, 237);
            pnlMontoConsumo.Name = "pnlMontoConsumo";
            pnlMontoConsumo.Size = new Size(300, 40);
            pnlMontoConsumo.TabIndex = 12;
            // 
            // lblMontoConsumoValor
            // 
            lblMontoConsumoValor.AutoSize = true;
            lblMontoConsumoValor.BackColor = Color.Transparent;
            lblMontoConsumoValor.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblMontoConsumoValor.Location = new Point(7, 2);
            lblMontoConsumoValor.Name = "lblMontoConsumoValor";
            lblMontoConsumoValor.Size = new Size(143, 36);
            lblMontoConsumoValor.TabIndex = 3;
            lblMontoConsumoValor.Text = "S/ 00.00";
            lblMontoConsumoValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlBono
            // 
            pnlBono.BackColor = Color.FromArgb(210, 255, 210);
            pnlBono.BorderStyle = BorderStyle.Fixed3D;
            pnlBono.Controls.Add(lblBonoValor);
            pnlBono.Location = new Point(380, 287);
            pnlBono.Name = "pnlBono";
            pnlBono.Size = new Size(200, 40);
            pnlBono.TabIndex = 13;
            // 
            // lblBonoValor
            // 
            lblBonoValor.AutoSize = true;
            lblBonoValor.BackColor = Color.Transparent;
            lblBonoValor.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBonoValor.Location = new Point(4, 2);
            lblBonoValor.Name = "lblBonoValor";
            lblBonoValor.Size = new Size(159, 36);
            lblBonoValor.TabIndex = 4;
            lblBonoValor.Text = "-S/ 00.00";
            lblBonoValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlRecargo
            // 
            pnlRecargo.BackColor = Color.FromArgb(255, 192, 192);
            pnlRecargo.BorderStyle = BorderStyle.Fixed3D;
            pnlRecargo.Controls.Add(lblRecargoValor);
            pnlRecargo.Location = new Point(380, 337);
            pnlRecargo.Name = "pnlRecargo";
            pnlRecargo.Size = new Size(200, 40);
            pnlRecargo.TabIndex = 14;
            // 
            // lblRecargoValor
            // 
            lblRecargoValor.AutoSize = true;
            lblRecargoValor.BackColor = Color.Transparent;
            lblRecargoValor.Font = new Font("Consolas", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblRecargoValor.Location = new Point(2, 2);
            lblRecargoValor.Name = "lblRecargoValor";
            lblRecargoValor.Size = new Size(159, 36);
            lblRecargoValor.TabIndex = 1;
            lblRecargoValor.Text = "+S/ 00.00";
            lblRecargoValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // pnlTotalPago
            // 
            pnlTotalPago.BackColor = Color.FromArgb(255, 170, 150);
            pnlTotalPago.BorderStyle = BorderStyle.Fixed3D;
            pnlTotalPago.Controls.Add(lblTotalPagoValor);
            pnlTotalPago.Location = new Point(380, 417);
            pnlTotalPago.Name = "pnlTotalPago";
            pnlTotalPago.Size = new Size(340, 47);
            pnlTotalPago.TabIndex = 15;
            // 
            // lblTotalPagoValor
            // 
            lblTotalPagoValor.AutoSize = true;
            lblTotalPagoValor.BackColor = Color.Transparent;
            lblTotalPagoValor.Dock = DockStyle.Fill;
            lblTotalPagoValor.Font = new Font("Consolas", 22.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTotalPagoValor.Location = new Point(0, 0);
            lblTotalPagoValor.Name = "lblTotalPagoValor";
            lblTotalPagoValor.Size = new Size(199, 43);
            lblTotalPagoValor.TabIndex = 1;
            lblTotalPagoValor.Text = "S/ 000.00";
            lblTotalPagoValor.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblConsumoCalculado
            // 
            lblConsumoCalculado.AutoSize = true;
            lblConsumoCalculado.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblConsumoCalculado.Location = new Point(50, 145);
            lblConsumoCalculado.Name = "lblConsumoCalculado";
            lblConsumoCalculado.Size = new Size(246, 27);
            lblConsumoCalculado.TabIndex = 16;
            lblConsumoCalculado.Text = "Consumo Calculado:";
            // 
            // frmResultado
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(782, 503);
            Controls.Add(lblConsumoCalculado);
            Controls.Add(pnlTotalPago);
            Controls.Add(pnlRecargo);
            Controls.Add(pnlBono);
            Controls.Add(pnlMontoConsumo);
            Controls.Add(pnlTarifa);
            Controls.Add(lblTotalPago);
            Controls.Add(pnlNombreCliente);
            Controls.Add(pnlConsumoCalculado);
            Controls.Add(pnlTitulo);
            Controls.Add(lblRecargo);
            Controls.Add(lblBono);
            Controls.Add(lblMontoConsumo);
            Controls.Add(lblTarifa);
            Controls.Add(lblNombreCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmResultado";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Resultado";
            Load += frmResultado_Load;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlConsumoCalculado.ResumeLayout(false);
            pnlConsumoCalculado.PerformLayout();
            pnlNombreCliente.ResumeLayout(false);
            pnlTarifa.ResumeLayout(false);
            pnlTarifa.PerformLayout();
            pnlMontoConsumo.ResumeLayout(false);
            pnlMontoConsumo.PerformLayout();
            pnlBono.ResumeLayout(false);
            pnlBono.PerformLayout();
            pnlRecargo.ResumeLayout(false);
            pnlRecargo.PerformLayout();
            pnlTotalPago.ResumeLayout(false);
            pnlTotalPago.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblBono;
        private Panel pnlBono;
        private Label lblRecargo;
        private Panel pnlRecargo;
        private Label lblNombreCliente;
        private Label lblTarifa;
        private Label lblMontoConsumo;
        private Panel pnlTitulo;
        private Panel pnlConsumoCalculado;
        private Panel pnlNombreCliente;
        private Label lblTotalPago;
        private Panel pnlTotalPago;
        private Panel pnlTarifa;
        private Label lblPorKwh;
        private Panel pnlMontoConsumo;
        private Label lblRecargoValor;
        private Label lblTotalPagoValor;
        private Label lblTarifaValor;
        private Label lblMontoConsumoValor;
        private Label lblBonoValor;
        private Label lblSubTitulo;
        private Label lblTitulo;
        private Label lblConsumoCalculadoValor;
        private Label lblConsumoCalculado;
        private Label lblNombreClienteValor;
    }
}