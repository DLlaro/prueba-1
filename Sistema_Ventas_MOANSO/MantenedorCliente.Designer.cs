namespace Sistema_Ventas_MOANSO
{
    partial class MantenedorCliente
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
            this.btn_Nuevo = new System.Windows.Forms.Button();
            this.dgvCliente = new System.Windows.Forms.DataGridView();
            this.gb_DatosCliente = new System.Windows.Forms.GroupBox();
            this.btn_Cancelar = new System.Windows.Forms.Button();
            this.dt_FechaRegCliente = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_EstadoCliente = new System.Windows.Forms.CheckBox();
            this.txt_idCiudad = new System.Windows.Forms.TextBox();
            this.btn_Modificar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.txt_idTipoCliente = new System.Windows.Forms.TextBox();
            this.txt_RazonSocial = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_idCliente = new System.Windows.Forms.TextBox();
            this.lbl_cliente = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btn_Deshabilitar = new System.Windows.Forms.Button();
            this.btn_Editar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).BeginInit();
            this.gb_DatosCliente.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Nuevo.Location = new System.Drawing.Point(69, 16);
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(76, 40);
            this.btn_Nuevo.TabIndex = 0;
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.UseVisualStyleBackColor = true;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // dgvCliente
            // 
            this.dgvCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCliente.Location = new System.Drawing.Point(69, 61);
            this.dgvCliente.Name = "dgvCliente";
            this.dgvCliente.Size = new System.Drawing.Size(539, 172);
            this.dgvCliente.TabIndex = 1;
            this.dgvCliente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCliente_CellClick);
            // 
            // gb_DatosCliente
            // 
            this.gb_DatosCliente.Controls.Add(this.btn_Cancelar);
            this.gb_DatosCliente.Controls.Add(this.dt_FechaRegCliente);
            this.gb_DatosCliente.Controls.Add(this.label3);
            this.gb_DatosCliente.Controls.Add(this.cb_EstadoCliente);
            this.gb_DatosCliente.Controls.Add(this.txt_idCiudad);
            this.gb_DatosCliente.Controls.Add(this.btn_Modificar);
            this.gb_DatosCliente.Controls.Add(this.btn_Agregar);
            this.gb_DatosCliente.Controls.Add(this.txt_idTipoCliente);
            this.gb_DatosCliente.Controls.Add(this.txt_RazonSocial);
            this.gb_DatosCliente.Controls.Add(this.label4);
            this.gb_DatosCliente.Controls.Add(this.label2);
            this.gb_DatosCliente.Controls.Add(this.label1);
            this.gb_DatosCliente.Controls.Add(this.txt_idCliente);
            this.gb_DatosCliente.Controls.Add(this.lbl_cliente);
            this.gb_DatosCliente.Location = new System.Drawing.Point(32, 301);
            this.gb_DatosCliente.Name = "gb_DatosCliente";
            this.gb_DatosCliente.Size = new System.Drawing.Size(831, 179);
            this.gb_DatosCliente.TabIndex = 2;
            this.gb_DatosCliente.TabStop = false;
            this.gb_DatosCliente.Text = "Datos del CLIENTE";
            // 
            // btn_Cancelar
            // 
            this.btn_Cancelar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cancelar.Location = new System.Drawing.Point(713, 111);
            this.btn_Cancelar.Name = "btn_Cancelar";
            this.btn_Cancelar.Size = new System.Drawing.Size(99, 40);
            this.btn_Cancelar.TabIndex = 8;
            this.btn_Cancelar.Text = "Cancelar";
            this.btn_Cancelar.UseVisualStyleBackColor = true;
            // 
            // dt_FechaRegCliente
            // 
            this.dt_FechaRegCliente.Location = new System.Drawing.Point(435, 134);
            this.dt_FechaRegCliente.Name = "dt_FechaRegCliente";
            this.dt_FechaRegCliente.Size = new System.Drawing.Size(200, 20);
            this.dt_FechaRegCliente.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(432, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Fecha de Registro:";
            // 
            // cb_EstadoCliente
            // 
            this.cb_EstadoCliente.AutoSize = true;
            this.cb_EstadoCliente.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_EstadoCliente.Location = new System.Drawing.Point(435, 27);
            this.cb_EstadoCliente.Name = "cb_EstadoCliente";
            this.cb_EstadoCliente.Size = new System.Drawing.Size(104, 19);
            this.cb_EstadoCliente.TabIndex = 9;
            this.cb_EstadoCliente.Text = "Estado Cliente";
            this.cb_EstadoCliente.UseVisualStyleBackColor = true;
            // 
            // txt_idCiudad
            // 
            this.txt_idCiudad.Location = new System.Drawing.Point(65, 111);
            this.txt_idCiudad.Name = "txt_idCiudad";
            this.txt_idCiudad.Size = new System.Drawing.Size(100, 20);
            this.txt_idCiudad.TabIndex = 8;
            // 
            // btn_Modificar
            // 
            this.btn_Modificar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Modificar.Location = new System.Drawing.Point(713, 63);
            this.btn_Modificar.Name = "btn_Modificar";
            this.btn_Modificar.Size = new System.Drawing.Size(99, 40);
            this.btn_Modificar.TabIndex = 3;
            this.btn_Modificar.Text = "Modificar";
            this.btn_Modificar.UseVisualStyleBackColor = true;
            this.btn_Modificar.Click += new System.EventHandler(this.btn_Modificar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Location = new System.Drawing.Point(713, 14);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(99, 40);
            this.btn_Agregar.TabIndex = 4;
            this.btn_Agregar.Text = "Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // txt_idTipoCliente
            // 
            this.txt_idTipoCliente.Location = new System.Drawing.Point(88, 88);
            this.txt_idTipoCliente.Name = "txt_idTipoCliente";
            this.txt_idTipoCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_idTipoCliente.TabIndex = 7;
            // 
            // txt_RazonSocial
            // 
            this.txt_RazonSocial.Location = new System.Drawing.Point(88, 60);
            this.txt_RazonSocial.Name = "txt_RazonSocial";
            this.txt_RazonSocial.Size = new System.Drawing.Size(308, 20);
            this.txt_RazonSocial.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ciudad:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Razon Social:";
            // 
            // txt_idCliente
            // 
            this.txt_idCliente.Location = new System.Drawing.Point(64, 30);
            this.txt_idCliente.Name = "txt_idCliente";
            this.txt_idCliente.Size = new System.Drawing.Size(100, 20);
            this.txt_idCliente.TabIndex = 1;
            // 
            // lbl_cliente
            // 
            this.lbl_cliente.AutoSize = true;
            this.lbl_cliente.Location = new System.Drawing.Point(16, 33);
            this.lbl_cliente.Name = "lbl_cliente";
            this.lbl_cliente.Size = new System.Drawing.Size(42, 13);
            this.lbl_cliente.TabIndex = 0;
            this.lbl_cliente.Text = "Cliente:";
            // 
            // btn_Salir
            // 
            this.btn_Salir.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Salir.Location = new System.Drawing.Point(532, 16);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.Size = new System.Drawing.Size(76, 40);
            this.btn_Salir.TabIndex = 5;
            this.btn_Salir.Text = "Salir";
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.btn_Salir_Click);
            // 
            // btn_Deshabilitar
            // 
            this.btn_Deshabilitar.Font = new System.Drawing.Font("Arial", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deshabilitar.Location = new System.Drawing.Point(239, 16);
            this.btn_Deshabilitar.Name = "btn_Deshabilitar";
            this.btn_Deshabilitar.Size = new System.Drawing.Size(121, 40);
            this.btn_Deshabilitar.TabIndex = 6;
            this.btn_Deshabilitar.Text = "Deshabilitar";
            this.btn_Deshabilitar.UseVisualStyleBackColor = true;
            this.btn_Deshabilitar.Click += new System.EventHandler(this.btn_Deshabilitar_Click);
            // 
            // btn_Editar
            // 
            this.btn_Editar.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Editar.Location = new System.Drawing.Point(157, 15);
            this.btn_Editar.Name = "btn_Editar";
            this.btn_Editar.Size = new System.Drawing.Size(76, 40);
            this.btn_Editar.TabIndex = 7;
            this.btn_Editar.Text = "Editar";
            this.btn_Editar.UseVisualStyleBackColor = true;
            this.btn_Editar.Click += new System.EventHandler(this.btn_Editar_Click);
            // 
            // MantenedorCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(878, 503);
            this.Controls.Add(this.btn_Editar);
            this.Controls.Add(this.btn_Deshabilitar);
            this.Controls.Add(this.btn_Salir);
            this.Controls.Add(this.gb_DatosCliente);
            this.Controls.Add(this.dgvCliente);
            this.Controls.Add(this.btn_Nuevo);
            this.Name = "MantenedorCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mantenedor Clientes";
            ((System.ComponentModel.ISupportInitialize)(this.dgvCliente)).EndInit();
            this.gb_DatosCliente.ResumeLayout(false);
            this.gb_DatosCliente.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Nuevo;
        private System.Windows.Forms.DataGridView dgvCliente;
        private System.Windows.Forms.GroupBox gb_DatosCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_idCliente;
        private System.Windows.Forms.Label lbl_cliente;
        private System.Windows.Forms.Button btn_Modificar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Salir;
        private System.Windows.Forms.Button btn_Deshabilitar;
        private System.Windows.Forms.Button btn_Editar;
        private System.Windows.Forms.TextBox txt_idCiudad;
        private System.Windows.Forms.TextBox txt_idTipoCliente;
        private System.Windows.Forms.TextBox txt_RazonSocial;
        private System.Windows.Forms.DateTimePicker dt_FechaRegCliente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cb_EstadoCliente;
        private System.Windows.Forms.Button btn_Cancelar;
    }
}

