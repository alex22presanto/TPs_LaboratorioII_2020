namespace FromCorreo
{
    partial class frmPpal
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
            this.components = new System.ComponentModel.Container();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnMostarTodos = new System.Windows.Forms.Button();
            this.rtbMostar = new System.Windows.Forms.RichTextBox();
            this.lstEstadoIngresado = new System.Windows.Forms.ListBox();
            this.lstEstadoEnViaje = new System.Windows.Forms.ListBox();
            this.lstEstadoEntregado = new System.Windows.Forms.ListBox();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.mTxtTrackingID = new System.Windows.Forms.MaskedTextBox();
            this.lblEstadoIngresado = new System.Windows.Forms.Label();
            this.lblEstadoEnViaje = new System.Windows.Forms.Label();
            this.lblEstadoEntregado = new System.Windows.Forms.Label();
            this.lblTrackinID = new System.Windows.Forms.Label();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.grbEstadosP = new System.Windows.Forms.GroupBox();
            this.grbPaquete = new System.Windows.Forms.GroupBox();
            this.cmsListas = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mostrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.grbEstadosP.SuspendLayout();
            this.grbPaquete.SuspendLayout();
            this.cmsListas.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(169, 24);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(141, 52);
            this.btnAgregar.TabIndex = 0;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnMostarTodos
            // 
            this.btnMostarTodos.Location = new System.Drawing.Point(169, 86);
            this.btnMostarTodos.Name = "btnMostarTodos";
            this.btnMostarTodos.Size = new System.Drawing.Size(141, 52);
            this.btnMostarTodos.TabIndex = 1;
            this.btnMostarTodos.Text = "MostarTodos";
            this.btnMostarTodos.UseVisualStyleBackColor = true;
            this.btnMostarTodos.Click += new System.EventHandler(this.btnMostarTodos_Click);
            // 
            // rtbMostar
            // 
            this.rtbMostar.Enabled = false;
            this.rtbMostar.Location = new System.Drawing.Point(6, 321);
            this.rtbMostar.Name = "rtbMostar";
            this.rtbMostar.Size = new System.Drawing.Size(462, 161);
            this.rtbMostar.TabIndex = 2;
            this.rtbMostar.Text = "";
            // 
            // lstEstadoIngresado
            // 
            this.lstEstadoIngresado.FormattingEnabled = true;
            this.lstEstadoIngresado.Location = new System.Drawing.Point(19, 49);
            this.lstEstadoIngresado.Name = "lstEstadoIngresado";
            this.lstEstadoIngresado.Size = new System.Drawing.Size(234, 238);
            this.lstEstadoIngresado.TabIndex = 3;
            // 
            // lstEstadoEnViaje
            // 
            this.lstEstadoEnViaje.FormattingEnabled = true;
            this.lstEstadoEnViaje.Location = new System.Drawing.Point(277, 49);
            this.lstEstadoEnViaje.Name = "lstEstadoEnViaje";
            this.lstEstadoEnViaje.Size = new System.Drawing.Size(234, 238);
            this.lstEstadoEnViaje.TabIndex = 4;
            // 
            // lstEstadoEntregado
            // 
            this.lstEstadoEntregado.ContextMenuStrip = this.cmsListas;
            this.lstEstadoEntregado.FormattingEnabled = true;
            this.lstEstadoEntregado.Location = new System.Drawing.Point(533, 49);
            this.lstEstadoEntregado.Name = "lstEstadoEntregado";
            this.lstEstadoEntregado.Size = new System.Drawing.Size(234, 238);
            this.lstEstadoEntregado.TabIndex = 5;
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(6, 102);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(157, 20);
            this.txtDireccion.TabIndex = 6;
            // 
            // mTxtTrackingID
            // 
            this.mTxtTrackingID.Location = new System.Drawing.Point(6, 45);
            this.mTxtTrackingID.Mask = "000-000-0000";
            this.mTxtTrackingID.Name = "mTxtTrackingID";
            this.mTxtTrackingID.Size = new System.Drawing.Size(157, 20);
            this.mTxtTrackingID.TabIndex = 7;
            // 
            // lblEstadoIngresado
            // 
            this.lblEstadoIngresado.AutoSize = true;
            this.lblEstadoIngresado.Location = new System.Drawing.Point(16, 33);
            this.lblEstadoIngresado.Name = "lblEstadoIngresado";
            this.lblEstadoIngresado.Size = new System.Drawing.Size(54, 13);
            this.lblEstadoIngresado.TabIndex = 8;
            this.lblEstadoIngresado.Text = "Ingresado";
            // 
            // lblEstadoEnViaje
            // 
            this.lblEstadoEnViaje.AutoSize = true;
            this.lblEstadoEnViaje.Location = new System.Drawing.Point(274, 33);
            this.lblEstadoEnViaje.Name = "lblEstadoEnViaje";
            this.lblEstadoEnViaje.Size = new System.Drawing.Size(46, 13);
            this.lblEstadoEnViaje.TabIndex = 9;
            this.lblEstadoEnViaje.Text = "En Viaje";
            // 
            // lblEstadoEntregado
            // 
            this.lblEstadoEntregado.AutoSize = true;
            this.lblEstadoEntregado.Location = new System.Drawing.Point(530, 33);
            this.lblEstadoEntregado.Name = "lblEstadoEntregado";
            this.lblEstadoEntregado.Size = new System.Drawing.Size(56, 13);
            this.lblEstadoEntregado.TabIndex = 10;
            this.lblEstadoEntregado.Text = "Entregado";
            // 
            // lblTrackinID
            // 
            this.lblTrackinID.AutoSize = true;
            this.lblTrackinID.Location = new System.Drawing.Point(6, 29);
            this.lblTrackinID.Name = "lblTrackinID";
            this.lblTrackinID.Size = new System.Drawing.Size(63, 13);
            this.lblTrackinID.TabIndex = 11;
            this.lblTrackinID.Text = "Tracking ID";
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Location = new System.Drawing.Point(6, 86);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(52, 13);
            this.lblDireccion.TabIndex = 12;
            this.lblDireccion.Text = "Direccion";
            // 
            // grbEstadosP
            // 
            this.grbEstadosP.Controls.Add(this.lblEstadoEntregado);
            this.grbEstadosP.Controls.Add(this.lblEstadoEnViaje);
            this.grbEstadosP.Controls.Add(this.lblEstadoIngresado);
            this.grbEstadosP.Controls.Add(this.lstEstadoEntregado);
            this.grbEstadosP.Controls.Add(this.lstEstadoEnViaje);
            this.grbEstadosP.Controls.Add(this.lstEstadoIngresado);
            this.grbEstadosP.Location = new System.Drawing.Point(6, 14);
            this.grbEstadosP.Name = "grbEstadosP";
            this.grbEstadosP.Size = new System.Drawing.Size(785, 300);
            this.grbEstadosP.TabIndex = 13;
            this.grbEstadosP.TabStop = false;
            this.grbEstadosP.Text = "Estados Paquetes";
            // 
            // grbPaquete
            // 
            this.grbPaquete.Controls.Add(this.lblDireccion);
            this.grbPaquete.Controls.Add(this.lblTrackinID);
            this.grbPaquete.Controls.Add(this.mTxtTrackingID);
            this.grbPaquete.Controls.Add(this.txtDireccion);
            this.grbPaquete.Controls.Add(this.btnMostarTodos);
            this.grbPaquete.Controls.Add(this.btnAgregar);
            this.grbPaquete.Location = new System.Drawing.Point(474, 321);
            this.grbPaquete.Name = "grbPaquete";
            this.grbPaquete.Size = new System.Drawing.Size(317, 161);
            this.grbPaquete.TabIndex = 14;
            this.grbPaquete.TabStop = false;
            this.grbPaquete.Text = "Paquete";
            // 
            // cmsListas
            // 
            this.cmsListas.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mostrarToolStripMenuItem});
            this.cmsListas.Name = "cmsListas";
            this.cmsListas.Size = new System.Drawing.Size(116, 26);
            // 
            // mostrarToolStripMenuItem
            // 
            this.mostrarToolStripMenuItem.Name = "mostrarToolStripMenuItem";
            this.mostrarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.mostrarToolStripMenuItem.Text = "Mostrar";
            this.mostrarToolStripMenuItem.Click += new System.EventHandler(this.mostrarToolStripMenuItem_Click);
            // 
            // frmPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 491);
            this.Controls.Add(this.grbPaquete);
            this.Controls.Add(this.grbEstadosP);
            this.Controls.Add(this.rtbMostar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPpal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Correo UTN de Alex Presanto";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmPpal_FormClosing);
            this.grbEstadosP.ResumeLayout(false);
            this.grbEstadosP.PerformLayout();
            this.grbPaquete.ResumeLayout(false);
            this.grbPaquete.PerformLayout();
            this.cmsListas.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnMostarTodos;
        private System.Windows.Forms.RichTextBox rtbMostar;
        private System.Windows.Forms.ListBox lstEstadoIngresado;
        private System.Windows.Forms.ListBox lstEstadoEnViaje;
        private System.Windows.Forms.ListBox lstEstadoEntregado;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.MaskedTextBox mTxtTrackingID;
        private System.Windows.Forms.Label lblEstadoIngresado;
        private System.Windows.Forms.Label lblEstadoEnViaje;
        private System.Windows.Forms.Label lblEstadoEntregado;
        private System.Windows.Forms.Label lblTrackinID;
        private System.Windows.Forms.Label lblDireccion;
        private System.Windows.Forms.GroupBox grbEstadosP;
        private System.Windows.Forms.GroupBox grbPaquete;
        private System.Windows.Forms.ContextMenuStrip cmsListas;
        private System.Windows.Forms.ToolStripMenuItem mostrarToolStripMenuItem;
    }
}

