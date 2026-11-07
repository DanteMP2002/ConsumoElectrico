namespace Ejercicio05_ConsumoElectrico
{
    partial class frmRegistro
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRegistro));
            lblNombreCliente = new Label();
            lblLecturaAnterior = new Label();
            lblLecturaActual = new Label();
            lblTipoCliente = new Label();
            grpServicios = new GroupBox();
            rdbNinguno = new RadioButton();
            rdbAlumbrado = new RadioButton();
            btnCalcularRecibo = new Button();
            btnLimpiar = new Button();
            txtNombreCliente = new TextBox();
            numLecturaAnterior = new NumericUpDown();
            numLecturaActual = new NumericUpDown();
            cboTipoCliente = new ComboBox();
            picCalculadora = new PictureBox();
            picLimpiar = new PictureBox();
            grpServicios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numLecturaAnterior).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numLecturaActual).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picCalculadora).BeginInit();
            ((System.ComponentModel.ISupportInitialize)picLimpiar).BeginInit();
            SuspendLayout();
            // 
            // lblNombreCliente
            // 
            lblNombreCliente.AutoSize = true;
            lblNombreCliente.Font = new Font("Consolas", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombreCliente.Location = new Point(25, 25);
            lblNombreCliente.Name = "lblNombreCliente";
            lblNombreCliente.Size = new Size(259, 27);
            lblNombreCliente.TabIndex = 0;
            lblNombreCliente.Text = "Nombre del Cliente:";
            // 
            // lblLecturaAnterior
            // 
            lblLecturaAnterior.AutoSize = true;
            lblLecturaAnterior.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblLecturaAnterior.Location = new Point(25, 70);
            lblLecturaAnterior.Name = "lblLecturaAnterior";
            lblLecturaAnterior.Size = new Size(311, 27);
            lblLecturaAnterior.TabIndex = 1;
            lblLecturaAnterior.Text = "Lectura anterior (kWh):";
            // 
            // lblLecturaActual
            // 
            lblLecturaActual.AutoSize = true;
            lblLecturaActual.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblLecturaActual.Location = new Point(25, 114);
            lblLecturaActual.Name = "lblLecturaActual";
            lblLecturaActual.Size = new Size(285, 27);
            lblLecturaActual.TabIndex = 2;
            lblLecturaActual.Text = "Lectura actual (kWh):";
            // 
            // lblTipoCliente
            // 
            lblTipoCliente.AutoSize = true;
            lblTipoCliente.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            lblTipoCliente.Location = new Point(25, 161);
            lblTipoCliente.Name = "lblTipoCliente";
            lblTipoCliente.Size = new Size(220, 27);
            lblTipoCliente.TabIndex = 3;
            lblTipoCliente.Text = "Tipo de cliente:";
            // 
            // grpServicios
            // 
            grpServicios.Controls.Add(rdbNinguno);
            grpServicios.Controls.Add(rdbAlumbrado);
            grpServicios.Font = new Font("Consolas", 12F);
            grpServicios.Location = new Point(36, 215);
            grpServicios.Name = "grpServicios";
            grpServicios.Size = new Size(505, 104);
            grpServicios.TabIndex = 4;
            grpServicios.TabStop = false;
            grpServicios.Text = "Servicios adicionales:";
            // 
            // rdbNinguno
            // 
            rdbNinguno.AutoSize = true;
            rdbNinguno.Checked = true;
            rdbNinguno.Location = new Point(36, 67);
            rdbNinguno.Name = "rdbNinguno";
            rdbNinguno.Size = new Size(108, 27);
            rdbNinguno.TabIndex = 3;
            rdbNinguno.TabStop = true;
            rdbNinguno.Text = "Ninguno";
            rdbNinguno.UseVisualStyleBackColor = true;
            // 
            // rdbAlumbrado
            // 
            rdbAlumbrado.AutoSize = true;
            rdbAlumbrado.Location = new Point(36, 34);
            rdbAlumbrado.Name = "rdbAlumbrado";
            rdbAlumbrado.Size = new Size(339, 27);
            rdbAlumbrado.TabIndex = 2;
            rdbAlumbrado.Text = "Alumbrado adicional (+ S/18)";
            rdbAlumbrado.UseVisualStyleBackColor = true;
            // 
            // btnCalcularRecibo
            // 
            btnCalcularRecibo.BackColor = Color.DodgerBlue;
            btnCalcularRecibo.Cursor = Cursors.Hand;
            btnCalcularRecibo.Font = new Font("Consolas", 13.8F, FontStyle.Bold);
            btnCalcularRecibo.ForeColor = Color.Snow;
            btnCalcularRecibo.Location = new Point(12, 336);
            btnCalcularRecibo.Name = "btnCalcularRecibo";
            btnCalcularRecibo.Padding = new Padding(50, 0, 0, 0);
            btnCalcularRecibo.Size = new Size(302, 62);
            btnCalcularRecibo.TabIndex = 5;
            btnCalcularRecibo.Text = "Calcular recibo";
            btnCalcularRecibo.UseVisualStyleBackColor = false;
            btnCalcularRecibo.Click += btnCalcularRecibo_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SteelBlue;
            btnLimpiar.Cursor = Cursors.Hand;
            btnLimpiar.Font = new Font("Consolas", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLimpiar.ForeColor = Color.White;
            btnLimpiar.Location = new Point(384, 336);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Padding = new Padding(50, 0, 0, 0);
            btnLimpiar.Size = new Size(186, 62);
            btnLimpiar.TabIndex = 6;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombreCliente
            // 
            txtNombreCliente.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombreCliente.Location = new Point(342, 27);
            txtNombreCliente.Name = "txtNombreCliente";
            txtNombreCliente.PlaceholderText = "Ingrese su Nombre";
            txtNombreCliente.Size = new Size(228, 31);
            txtNombreCliente.TabIndex = 7;
            txtNombreCliente.KeyPress += txtNombreCliente_KeyPress;
            // 
            // numLecturaAnterior
            // 
            numLecturaAnterior.Font = new Font("Consolas", 12F);
            numLecturaAnterior.Location = new Point(342, 73);
            numLecturaAnterior.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLecturaAnterior.Name = "numLecturaAnterior";
            numLecturaAnterior.Size = new Size(170, 31);
            numLecturaAnterior.TabIndex = 8;
            // 
            // numLecturaActual
            // 
            numLecturaActual.Font = new Font("Consolas", 12F);
            numLecturaActual.Location = new Point(342, 117);
            numLecturaActual.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            numLecturaActual.Name = "numLecturaActual";
            numLecturaActual.Size = new Size(170, 31);
            numLecturaActual.TabIndex = 9;
            // 
            // cboTipoCliente
            // 
            cboTipoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            cboTipoCliente.Font = new Font("Consolas", 12F);
            cboTipoCliente.Items.AddRange(new object[] { "Comercial", "Doméstico" });
            cboTipoCliente.Location = new Point(342, 163);
            cboTipoCliente.Name = "cboTipoCliente";
            cboTipoCliente.Size = new Size(151, 31);
            cboTipoCliente.TabIndex = 10;
            // 
            // picCalculadora
            // 
            picCalculadora.BackColor = Color.DodgerBlue;
            picCalculadora.Cursor = Cursors.Hand;
            picCalculadora.Image = Properties.Resources.icons8_calculator_64;
            picCalculadora.Location = new Point(26, 343);
            picCalculadora.Name = "picCalculadora";
            picCalculadora.Size = new Size(48, 48);
            picCalculadora.SizeMode = PictureBoxSizeMode.StretchImage;
            picCalculadora.TabIndex = 11;
            picCalculadora.TabStop = false;
            picCalculadora.Click += btnCalcularRecibo_Click;
            // 
            // picLimpiar
            // 
            picLimpiar.BackColor = Color.SteelBlue;
            picLimpiar.Cursor = Cursors.Hand;
            picLimpiar.Image = Properties.Resources.icons8_clean_50;
            picLimpiar.Location = new Point(393, 343);
            picLimpiar.Name = "picLimpiar";
            picLimpiar.Size = new Size(48, 48);
            picLimpiar.SizeMode = PictureBoxSizeMode.StretchImage;
            picLimpiar.TabIndex = 12;
            picLimpiar.TabStop = false;
            picLimpiar.Click += btnLimpiar_Click;
            // 
            // frmRegistro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Gainsboro;
            ClientSize = new Size(582, 403);
            Controls.Add(picLimpiar);
            Controls.Add(picCalculadora);
            Controls.Add(cboTipoCliente);
            Controls.Add(numLecturaActual);
            Controls.Add(numLecturaAnterior);
            Controls.Add(txtNombreCliente);
            Controls.Add(btnLimpiar);
            Controls.Add(btnCalcularRecibo);
            Controls.Add(grpServicios);
            Controls.Add(lblTipoCliente);
            Controls.Add(lblLecturaActual);
            Controls.Add(lblLecturaAnterior);
            Controls.Add(lblNombreCliente);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "frmRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de consumo";
            Load += frmRegistro_Load;
            grpServicios.ResumeLayout(false);
            grpServicios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numLecturaAnterior).EndInit();
            ((System.ComponentModel.ISupportInitialize)numLecturaActual).EndInit();
            ((System.ComponentModel.ISupportInitialize)picCalculadora).EndInit();
            ((System.ComponentModel.ISupportInitialize)picLimpiar).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNombreCliente;
        private Label lblLecturaAnterior;
        private Label lblLecturaActual;
        private Label lblTipoCliente;
        private GroupBox grpServicios;
        private Button btnCalcularRecibo;
        private Button btnLimpiar;
        private TextBox txtNombreCliente;
        private NumericUpDown numLecturaAnterior;
        private NumericUpDown numLecturaActual;
        private ComboBox cboTipoCliente;
        private PictureBox picCalculadora;
        private PictureBox picLimpiar;
        private RadioButton rdbAlumbrado;
        private RadioButton rdbNinguno;
    }
}
