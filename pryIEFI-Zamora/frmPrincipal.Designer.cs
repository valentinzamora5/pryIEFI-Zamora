﻿namespace pryIEFI_Zamora
{
    partial class frmPrincipal
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
            this.Registro = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.mrcRegistro = new System.Windows.Forms.GroupBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblPuntaje = new System.Windows.Forms.Label();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblImporte = new System.Windows.Forms.Label();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.mrcSexo = new System.Windows.Forms.GroupBox();
            this.optFem = new System.Windows.Forms.RadioButton();
            this.optMasc = new System.Windows.Forms.RadioButton();
            this.cmbPaises = new System.Windows.Forms.ComboBox();
            this.lblEdad = new System.Windows.Forms.Label();
            this.lblSeleccionarPais = new System.Windows.Forms.Label();
            this.nudEdad = new System.Windows.Forms.NumericUpDown();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnAgregarPais = new System.Windows.Forms.Button();
            this.txtAgregarPais = new System.Windows.Forms.TextBox();
            this.lblRegistrarPais = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nudImporte = new System.Windows.Forms.NumericUpDown();
            this.nudPuntaje = new System.Windows.Forms.NumericUpDown();
            this.Registro.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.mrcRegistro.SuspendLayout();
            this.mrcSexo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).BeginInit();
            this.SuspendLayout();
            // 
            // Registro
            // 
            this.Registro.Controls.Add(this.tabPage1);
            this.Registro.Controls.Add(this.tabPage2);
            this.Registro.Location = new System.Drawing.Point(237, 82);
            this.Registro.Name = "Registro";
            this.Registro.SelectedIndex = 0;
            this.Registro.Size = new System.Drawing.Size(236, 452);
            this.Registro.TabIndex = 19;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.mrcRegistro);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(228, 426);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Registro";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // mrcRegistro
            // 
            this.mrcRegistro.Controls.Add(this.nudImporte);
            this.mrcRegistro.Controls.Add(this.nudPuntaje);
            this.mrcRegistro.Controls.Add(this.lblNombre);
            this.mrcRegistro.Controls.Add(this.lblApellido);
            this.mrcRegistro.Controls.Add(this.lblPuntaje);
            this.mrcRegistro.Controls.Add(this.btnRegistrar);
            this.mrcRegistro.Controls.Add(this.txtNombre);
            this.mrcRegistro.Controls.Add(this.lblImporte);
            this.mrcRegistro.Controls.Add(this.txtApellido);
            this.mrcRegistro.Controls.Add(this.mrcSexo);
            this.mrcRegistro.Controls.Add(this.cmbPaises);
            this.mrcRegistro.Controls.Add(this.lblEdad);
            this.mrcRegistro.Controls.Add(this.lblSeleccionarPais);
            this.mrcRegistro.Controls.Add(this.nudEdad);
            this.mrcRegistro.Location = new System.Drawing.Point(6, 8);
            this.mrcRegistro.Name = "mrcRegistro";
            this.mrcRegistro.Size = new System.Drawing.Size(200, 401);
            this.mrcRegistro.TabIndex = 16;
            this.mrcRegistro.TabStop = false;
            this.mrcRegistro.Text = "Registro";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Location = new System.Drawing.Point(11, 71);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(44, 13);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblPuntaje
            // 
            this.lblPuntaje.AutoSize = true;
            this.lblPuntaje.Location = new System.Drawing.Point(11, 303);
            this.lblPuntaje.Name = "lblPuntaje";
            this.lblPuntaje.Size = new System.Drawing.Size(43, 13);
            this.lblPuntaje.TabIndex = 14;
            this.lblPuntaje.Text = "Puntaje";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Enabled = false;
            this.btnRegistrar.Location = new System.Drawing.Point(109, 345);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrar.TabIndex = 2;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click_1);
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(84, 34);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged_1);
            // 
            // lblImporte
            // 
            this.lblImporte.AutoSize = true;
            this.lblImporte.Location = new System.Drawing.Point(11, 265);
            this.lblImporte.Name = "lblImporte";
            this.lblImporte.Size = new System.Drawing.Size(42, 13);
            this.lblImporte.TabIndex = 12;
            this.lblImporte.Text = "Importe";
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.Location = new System.Drawing.Point(84, 68);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(100, 20);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.TextChanged += new System.EventHandler(this.txtApellido_TextChanged_1);
            // 
            // mrcSexo
            // 
            this.mrcSexo.Controls.Add(this.optFem);
            this.mrcSexo.Controls.Add(this.optMasc);
            this.mrcSexo.Enabled = false;
            this.mrcSexo.Location = new System.Drawing.Point(14, 173);
            this.mrcSexo.Name = "mrcSexo";
            this.mrcSexo.Size = new System.Drawing.Size(170, 72);
            this.mrcSexo.TabIndex = 11;
            this.mrcSexo.TabStop = false;
            this.mrcSexo.Text = "Sexo";
            // 
            // optFem
            // 
            this.optFem.AutoSize = true;
            this.optFem.Location = new System.Drawing.Point(70, 42);
            this.optFem.Name = "optFem";
            this.optFem.Size = new System.Drawing.Size(71, 17);
            this.optFem.TabIndex = 1;
            this.optFem.TabStop = true;
            this.optFem.Text = "Femenino";
            this.optFem.UseVisualStyleBackColor = true;
            this.optFem.CheckedChanged += new System.EventHandler(this.optFem_CheckedChanged);
            // 
            // optMasc
            // 
            this.optMasc.AutoSize = true;
            this.optMasc.Location = new System.Drawing.Point(70, 19);
            this.optMasc.Name = "optMasc";
            this.optMasc.Size = new System.Drawing.Size(73, 17);
            this.optMasc.TabIndex = 0;
            this.optMasc.TabStop = true;
            this.optMasc.Text = "Masculino";
            this.optMasc.UseVisualStyleBackColor = true;
            this.optMasc.CheckedChanged += new System.EventHandler(this.optMasc_CheckedChanged_1);
            // 
            // cmbPaises
            // 
            this.cmbPaises.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaises.Enabled = false;
            this.cmbPaises.FormattingEnabled = true;
            this.cmbPaises.Location = new System.Drawing.Point(84, 104);
            this.cmbPaises.Name = "cmbPaises";
            this.cmbPaises.Size = new System.Drawing.Size(100, 21);
            this.cmbPaises.TabIndex = 5;
            this.cmbPaises.SelectedIndexChanged += new System.EventHandler(this.cmbPaises_SelectedIndexChanged_1);
            // 
            // lblEdad
            // 
            this.lblEdad.AutoSize = true;
            this.lblEdad.Location = new System.Drawing.Point(11, 149);
            this.lblEdad.Name = "lblEdad";
            this.lblEdad.Size = new System.Drawing.Size(32, 13);
            this.lblEdad.TabIndex = 10;
            this.lblEdad.Text = "Edad";
            // 
            // lblSeleccionarPais
            // 
            this.lblSeleccionarPais.AutoSize = true;
            this.lblSeleccionarPais.Location = new System.Drawing.Point(11, 107);
            this.lblSeleccionarPais.Name = "lblSeleccionarPais";
            this.lblSeleccionarPais.Size = new System.Drawing.Size(27, 13);
            this.lblSeleccionarPais.TabIndex = 6;
            this.lblSeleccionarPais.Text = "Pais";
            // 
            // nudEdad
            // 
            this.nudEdad.Enabled = false;
            this.nudEdad.Location = new System.Drawing.Point(84, 147);
            this.nudEdad.Minimum = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudEdad.Name = "nudEdad";
            this.nudEdad.Size = new System.Drawing.Size(100, 20);
            this.nudEdad.TabIndex = 9;
            this.nudEdad.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.nudEdad.ValueChanged += new System.EventHandler(this.nudEdad_ValueChanged_1);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(228, 426);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Registro Pais";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnAgregarPais);
            this.groupBox2.Controls.Add(this.txtAgregarPais);
            this.groupBox2.Controls.Add(this.lblRegistrarPais);
            this.groupBox2.Location = new System.Drawing.Point(11, 19);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(200, 111);
            this.groupBox2.TabIndex = 17;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Añadir pais";
            // 
            // btnAgregarPais
            // 
            this.btnAgregarPais.Location = new System.Drawing.Point(110, 65);
            this.btnAgregarPais.Name = "btnAgregarPais";
            this.btnAgregarPais.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarPais.TabIndex = 16;
            this.btnAgregarPais.Text = "Agregar";
            this.btnAgregarPais.UseVisualStyleBackColor = true;
            this.btnAgregarPais.Click += new System.EventHandler(this.btnAgregarPais_Click_1);
            // 
            // txtAgregarPais
            // 
            this.txtAgregarPais.Location = new System.Drawing.Point(85, 30);
            this.txtAgregarPais.Name = "txtAgregarPais";
            this.txtAgregarPais.Size = new System.Drawing.Size(100, 20);
            this.txtAgregarPais.TabIndex = 8;
            // 
            // lblRegistrarPais
            // 
            this.lblRegistrarPais.AutoSize = true;
            this.lblRegistrarPais.Location = new System.Drawing.Point(12, 33);
            this.lblRegistrarPais.Name = "lblRegistrarPais";
            this.lblRegistrarPais.Size = new System.Drawing.Size(67, 13);
            this.lblRegistrarPais.TabIndex = 7;
            this.lblRegistrarPais.Text = "Agregar Pais";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(297, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 25);
            this.label1.TabIndex = 20;
            this.label1.Text = "REGISTRAR";
            // 
            // nudImporte
            // 
            this.nudImporte.Location = new System.Drawing.Point(74, 263);
            this.nudImporte.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudImporte.Minimum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImporte.Name = "nudImporte";
            this.nudImporte.Size = new System.Drawing.Size(120, 20);
            this.nudImporte.TabIndex = 21;
            this.nudImporte.Value = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.nudImporte.ValueChanged += new System.EventHandler(this.nudImporte_ValueChanged);
            // 
            // nudPuntaje
            // 
            this.nudPuntaje.DecimalPlaces = 1;
            this.nudPuntaje.Location = new System.Drawing.Point(74, 301);
            this.nudPuntaje.Maximum = new decimal(new int[] {
            99999,
            0,
            0,
            0});
            this.nudPuntaje.Minimum = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            this.nudPuntaje.Name = "nudPuntaje";
            this.nudPuntaje.Size = new System.Drawing.Size(120, 20);
            this.nudPuntaje.TabIndex = 22;
            this.nudPuntaje.Value = new decimal(new int[] {
            1295,
            0,
            0,
            65536});
            this.nudPuntaje.ValueChanged += new System.EventHandler(this.nudPuntaje_ValueChanged);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(688, 582);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Registro);
            this.Name = "frmPrincipal";
            this.Text = "REGISTRAR";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.Registro.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.mrcRegistro.ResumeLayout(false);
            this.mrcRegistro.PerformLayout();
            this.mrcSexo.ResumeLayout(false);
            this.mrcSexo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudEdad)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudImporte)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudPuntaje)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl Registro;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox mrcRegistro;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblPuntaje;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblImporte;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.GroupBox mrcSexo;
        private System.Windows.Forms.RadioButton optFem;
        private System.Windows.Forms.RadioButton optMasc;
        private System.Windows.Forms.ComboBox cmbPaises;
        private System.Windows.Forms.Label lblEdad;
        private System.Windows.Forms.Label lblSeleccionarPais;
        private System.Windows.Forms.NumericUpDown nudEdad;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnAgregarPais;
        private System.Windows.Forms.TextBox txtAgregarPais;
        private System.Windows.Forms.Label lblRegistrarPais;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown nudImporte;
        private System.Windows.Forms.NumericUpDown nudPuntaje;
    }
}

