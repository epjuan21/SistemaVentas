
namespace SistemaVentas
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbcPrincipal = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chkBoxClienteCredito = new System.Windows.Forms.CheckBox();
            this.btnCancelarCliente = new System.Windows.Forms.Button();
            this.btnAgregarCliente = new System.Windows.Forms.Button();
            this.txtClienteDireccion = new System.Windows.Forms.TextBox();
            this.lblClienteDireccion = new System.Windows.Forms.Label();
            this.txtClienteTelefono = new System.Windows.Forms.TextBox();
            this.lblClienteTelefono = new System.Windows.Forms.Label();
            this.txtClienteEmail = new System.Windows.Forms.TextBox();
            this.lblClienteEmail = new System.Windows.Forms.Label();
            this.txtClienteApellido = new System.Windows.Forms.TextBox();
            this.lblClienteApellido = new System.Windows.Forms.Label();
            this.txtClienteNombre = new System.Windows.Forms.TextBox();
            this.lblClienteNombre = new System.Windows.Forms.Label();
            this.txtClienteId = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.pictureBoxCliente = new System.Windows.Forms.PictureBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.lblClienteId = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtBuscarCliente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCliente = new System.Windows.Forms.Button();
            this.tbcPrincipal.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbcPrincipal
            // 
            this.tbcPrincipal.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tbcPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbcPrincipal.Controls.Add(this.tabPage1);
            this.tbcPrincipal.Controls.Add(this.tabPage2);
            this.tbcPrincipal.Location = new System.Drawing.Point(12, 141);
            this.tbcPrincipal.Name = "tbcPrincipal";
            this.tbcPrincipal.SelectedIndex = 0;
            this.tbcPrincipal.Size = new System.Drawing.Size(1159, 708);
            this.tbcPrincipal.TabIndex = 1;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1151, 682);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Ventas";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage2.Location = new System.Drawing.Point(4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1151, 682);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Clientes";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Location = new System.Drawing.Point(326, 78);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(819, 598);
            this.groupBox5.TabIndex = 2;
            this.groupBox5.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox3.Controls.Add(this.chkBoxClienteCredito);
            this.groupBox3.Controls.Add(this.btnCancelarCliente);
            this.groupBox3.Controls.Add(this.btnAgregarCliente);
            this.groupBox3.Controls.Add(this.txtClienteDireccion);
            this.groupBox3.Controls.Add(this.lblClienteDireccion);
            this.groupBox3.Controls.Add(this.txtClienteTelefono);
            this.groupBox3.Controls.Add(this.lblClienteTelefono);
            this.groupBox3.Controls.Add(this.txtClienteEmail);
            this.groupBox3.Controls.Add(this.lblClienteEmail);
            this.groupBox3.Controls.Add(this.txtClienteApellido);
            this.groupBox3.Controls.Add(this.lblClienteApellido);
            this.groupBox3.Controls.Add(this.txtClienteNombre);
            this.groupBox3.Controls.Add(this.lblClienteNombre);
            this.groupBox3.Controls.Add(this.txtClienteId);
            this.groupBox3.Controls.Add(this.tabControl2);
            this.groupBox3.Controls.Add(this.lblClienteId);
            this.groupBox3.Location = new System.Drawing.Point(7, 78);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(313, 598);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            // 
            // chkBoxClienteCredito
            // 
            this.chkBoxClienteCredito.AutoSize = true;
            this.chkBoxClienteCredito.Location = new System.Drawing.Point(10, 507);
            this.chkBoxClienteCredito.Name = "chkBoxClienteCredito";
            this.chkBoxClienteCredito.Size = new System.Drawing.Size(70, 20);
            this.chkBoxClienteCredito.TabIndex = 16;
            this.chkBoxClienteCredito.Text = "Credito";
            this.chkBoxClienteCredito.UseVisualStyleBackColor = true;
            this.chkBoxClienteCredito.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnCancelarCliente
            // 
            this.btnCancelarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCancelarCliente.FlatAppearance.BorderSize = 0;
            this.btnCancelarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarCliente.Image = global::SistemaVentas.Properties.Resources.icons8_retire_hombre_usuario_40;
            this.btnCancelarCliente.Location = new System.Drawing.Point(163, 538);
            this.btnCancelarCliente.Name = "btnCancelarCliente";
            this.btnCancelarCliente.Size = new System.Drawing.Size(51, 44);
            this.btnCancelarCliente.TabIndex = 15;
            this.btnCancelarCliente.UseVisualStyleBackColor = true;
            this.btnCancelarCliente.Click += new System.EventHandler(this.btnCancelarCliente_Click);
            // 
            // btnAgregarCliente
            // 
            this.btnAgregarCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregarCliente.FlatAppearance.BorderSize = 0;
            this.btnAgregarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregarCliente.Image = global::SistemaVentas.Properties.Resources.icons8_añadir_usuario_masculino_40;
            this.btnAgregarCliente.Location = new System.Drawing.Point(72, 538);
            this.btnAgregarCliente.Name = "btnAgregarCliente";
            this.btnAgregarCliente.Size = new System.Drawing.Size(51, 44);
            this.btnAgregarCliente.TabIndex = 14;
            this.btnAgregarCliente.UseVisualStyleBackColor = true;
            this.btnAgregarCliente.Click += new System.EventHandler(this.btnAgregarCliente_Click);
            // 
            // txtClienteDireccion
            // 
            this.txtClienteDireccion.Location = new System.Drawing.Point(167, 477);
            this.txtClienteDireccion.Name = "txtClienteDireccion";
            this.txtClienteDireccion.Size = new System.Drawing.Size(136, 22);
            this.txtClienteDireccion.TabIndex = 13;
            this.txtClienteDireccion.TextChanged += new System.EventHandler(this.txtClienteDireccion_TextChanged);
            // 
            // lblClienteDireccion
            // 
            this.lblClienteDireccion.AutoSize = true;
            this.lblClienteDireccion.Location = new System.Drawing.Point(163, 458);
            this.lblClienteDireccion.Name = "lblClienteDireccion";
            this.lblClienteDireccion.Size = new System.Drawing.Size(109, 16);
            this.lblClienteDireccion.TabIndex = 12;
            this.lblClienteDireccion.Text = "Cliente Dirección";
            // 
            // txtClienteTelefono
            // 
            this.txtClienteTelefono.Location = new System.Drawing.Point(6, 477);
            this.txtClienteTelefono.Name = "txtClienteTelefono";
            this.txtClienteTelefono.Size = new System.Drawing.Size(154, 22);
            this.txtClienteTelefono.TabIndex = 11;
            this.txtClienteTelefono.TextChanged += new System.EventHandler(this.txtClienteTelefono_TextChanged);
            this.txtClienteTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteTelefono_KeyPress);
            // 
            // lblClienteTelefono
            // 
            this.lblClienteTelefono.AutoSize = true;
            this.lblClienteTelefono.Location = new System.Drawing.Point(6, 458);
            this.lblClienteTelefono.Name = "lblClienteTelefono";
            this.lblClienteTelefono.Size = new System.Drawing.Size(106, 16);
            this.lblClienteTelefono.TabIndex = 10;
            this.lblClienteTelefono.Text = "Cliente Teléfono";
            // 
            // txtClienteEmail
            // 
            this.txtClienteEmail.Location = new System.Drawing.Point(167, 416);
            this.txtClienteEmail.Name = "txtClienteEmail";
            this.txtClienteEmail.Size = new System.Drawing.Size(136, 22);
            this.txtClienteEmail.TabIndex = 9;
            this.txtClienteEmail.TextChanged += new System.EventHandler(this.txtClienteEmail_TextChanged);
            // 
            // lblClienteEmail
            // 
            this.lblClienteEmail.AutoSize = true;
            this.lblClienteEmail.Location = new System.Drawing.Point(170, 397);
            this.lblClienteEmail.Name = "lblClienteEmail";
            this.lblClienteEmail.Size = new System.Drawing.Size(86, 16);
            this.lblClienteEmail.TabIndex = 8;
            this.lblClienteEmail.Text = "Cliente Email";
            // 
            // txtClienteApellido
            // 
            this.txtClienteApellido.Location = new System.Drawing.Point(6, 416);
            this.txtClienteApellido.Name = "txtClienteApellido";
            this.txtClienteApellido.Size = new System.Drawing.Size(154, 22);
            this.txtClienteApellido.TabIndex = 7;
            this.txtClienteApellido.TextChanged += new System.EventHandler(this.txtClienteApellido_TextChanged);
            this.txtClienteApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteApellido_KeyPress);
            // 
            // lblClienteApellido
            // 
            this.lblClienteApellido.AutoSize = true;
            this.lblClienteApellido.Location = new System.Drawing.Point(6, 397);
            this.lblClienteApellido.Name = "lblClienteApellido";
            this.lblClienteApellido.Size = new System.Drawing.Size(102, 16);
            this.lblClienteApellido.TabIndex = 6;
            this.lblClienteApellido.Text = "Cliente Apellido";
            // 
            // txtClienteNombre
            // 
            this.txtClienteNombre.Location = new System.Drawing.Point(166, 360);
            this.txtClienteNombre.Name = "txtClienteNombre";
            this.txtClienteNombre.Size = new System.Drawing.Size(137, 22);
            this.txtClienteNombre.TabIndex = 5;
            this.txtClienteNombre.TextChanged += new System.EventHandler(this.txtClienteNombre_TextChanged);
            this.txtClienteNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteNombre_KeyPress);
            // 
            // lblClienteNombre
            // 
            this.lblClienteNombre.AutoSize = true;
            this.lblClienteNombre.Location = new System.Drawing.Point(163, 341);
            this.lblClienteNombre.Name = "lblClienteNombre";
            this.lblClienteNombre.Size = new System.Drawing.Size(101, 16);
            this.lblClienteNombre.TabIndex = 4;
            this.lblClienteNombre.Text = "Cliente Nombre";
            // 
            // txtClienteId
            // 
            this.txtClienteId.Location = new System.Drawing.Point(6, 360);
            this.txtClienteId.Name = "txtClienteId";
            this.txtClienteId.Size = new System.Drawing.Size(154, 22);
            this.txtClienteId.TabIndex = 3;
            this.txtClienteId.TextChanged += new System.EventHandler(this.txtClienteId_TextChanged);
            this.txtClienteId.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtClienteId_KeyPress);
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Location = new System.Drawing.Point(6, 19);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(301, 309);
            this.tabControl2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox4);
            this.tabPage3.Controls.Add(this.label4);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(293, 280);
            this.tabPage3.TabIndex = 0;
            this.tabPage3.Text = "Registro de Clientes";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.pictureBoxCliente);
            this.groupBox4.Location = new System.Drawing.Point(40, 50);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(212, 173);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // pictureBoxCliente
            // 
            this.pictureBoxCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCliente.Image = global::SistemaVentas.Properties.Resources.icons8_usuario_80;
            this.pictureBoxCliente.Location = new System.Drawing.Point(6, 12);
            this.pictureBoxCliente.Name = "pictureBoxCliente";
            this.pictureBoxCliente.Size = new System.Drawing.Size(200, 155);
            this.pictureBoxCliente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCliente.TabIndex = 0;
            this.pictureBoxCliente.TabStop = false;
            this.pictureBoxCliente.Click += new System.EventHandler(this.pictureBoxCliente_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(55, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(141, 16);
            this.label4.TabIndex = 0;
            this.label4.Text = "Informacion del cliente";
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(293, 280);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Pago";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // lblClienteId
            // 
            this.lblClienteId.AutoSize = true;
            this.lblClienteId.Location = new System.Drawing.Point(6, 341);
            this.lblClienteId.Name = "lblClienteId";
            this.lblClienteId.Size = new System.Drawing.Size(63, 16);
            this.lblClienteId.TabIndex = 2;
            this.lblClienteId.Text = "Cliente Id";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.txtBuscarCliente);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(6, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1139, 65);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            // 
            // txtBuscarCliente
            // 
            this.txtBuscarCliente.BackColor = System.Drawing.Color.White;
            this.txtBuscarCliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBuscarCliente.Location = new System.Drawing.Point(320, 32);
            this.txtBuscarCliente.Multiline = true;
            this.txtBuscarCliente.Name = "txtBuscarCliente";
            this.txtBuscarCliente.Size = new System.Drawing.Size(272, 21);
            this.txtBuscarCliente.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(317, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Buscar";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(118, 37);
            this.label2.TabIndex = 0;
            this.label2.Text = "Clientes";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.ForeColor = System.Drawing.Color.Transparent;
            this.groupBox1.Location = new System.Drawing.Point(0, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1183, 79);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(445, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(292, 43);
            this.label1.TabIndex = 0;
            this.label1.Text = "Sistema de Ventas";
            // 
            // btnCliente
            // 
            this.btnCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCliente.FlatAppearance.BorderSize = 0;
            this.btnCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCliente.Image = global::SistemaVentas.Properties.Resources.icons8_buscar_cliente_40;
            this.btnCliente.Location = new System.Drawing.Point(16, 85);
            this.btnCliente.Name = "btnCliente";
            this.btnCliente.Size = new System.Drawing.Size(55, 54);
            this.btnCliente.TabIndex = 4;
            this.btnCliente.UseVisualStyleBackColor = true;
            this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1183, 861);
            this.Controls.Add(this.btnCliente);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.tbcPrincipal);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tbcPrincipal.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabControl2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCliente)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabControl tbcPrincipal;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCliente;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtBuscarCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtClienteDireccion;
        private System.Windows.Forms.Label lblClienteDireccion;
        private System.Windows.Forms.TextBox txtClienteTelefono;
        private System.Windows.Forms.Label lblClienteTelefono;
        private System.Windows.Forms.TextBox txtClienteEmail;
        private System.Windows.Forms.Label lblClienteEmail;
        private System.Windows.Forms.TextBox txtClienteApellido;
        private System.Windows.Forms.Label lblClienteApellido;
        private System.Windows.Forms.TextBox txtClienteNombre;
        private System.Windows.Forms.Label lblClienteNombre;
        private System.Windows.Forms.TextBox txtClienteId;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.PictureBox pictureBoxCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblClienteId;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnCancelarCliente;
        private System.Windows.Forms.Button btnAgregarCliente;
        private System.Windows.Forms.CheckBox chkBoxClienteCredito;
    }
}

