namespace Control_Cine
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnVender = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtVPel = new System.Windows.Forms.TextBox();
            this.txtVNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelicula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTel = new System.Windows.Forms.MaskedTextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnRentar = new System.Windows.Forms.Button();
            this.dtPicker = new System.Windows.Forms.DateTimePicker();
            this.cmbPel = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pelicula2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rbRentar = new System.Windows.Forms.RadioButton();
            this.rbVender = new System.Windows.Forms.RadioButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnVender);
            this.groupBox1.Controls.Add(this.txtPrecio);
            this.groupBox1.Controls.Add(this.txtVPel);
            this.groupBox1.Controls.Add(this.txtVNombre);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.dataGridView1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(548, 217);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "VENDER";
            // 
            // btnVender
            // 
            this.btnVender.Location = new System.Drawing.Point(392, 64);
            this.btnVender.Name = "btnVender";
            this.btnVender.Size = new System.Drawing.Size(75, 23);
            this.btnVender.TabIndex = 7;
            this.btnVender.Text = "Guardar Venta";
            this.btnVender.UseVisualStyleBackColor = true;
            this.btnVender.Click += new System.EventHandler(this.btnVender_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(256, 50);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(100, 20);
            this.txtPrecio.TabIndex = 6;
            // 
            // txtVPel
            // 
            this.txtVPel.Location = new System.Drawing.Point(126, 50);
            this.txtVPel.Name = "txtVPel";
            this.txtVPel.Size = new System.Drawing.Size(100, 20);
            this.txtVPel.TabIndex = 5;
            // 
            // txtVNombre
            // 
            this.txtVNombre.Location = new System.Drawing.Point(10, 50);
            this.txtVNombre.Name = "txtVNombre";
            this.txtVNombre.Size = new System.Drawing.Size(100, 20);
            this.txtVNombre.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(253, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(123, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Película";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.nombre,
            this.pelicula,
            this.precio});
            this.dataGridView1.Location = new System.Drawing.Point(6, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(350, 115);
            this.dataGridView1.TabIndex = 0;
            // 
            // nombre
            // 
            this.nombre.HeaderText = "Nombre";
            this.nombre.Name = "nombre";
            // 
            // pelicula
            // 
            this.pelicula.HeaderText = "Película";
            this.pelicula.Name = "pelicula";
            // 
            // precio
            // 
            this.precio.HeaderText = "Precio";
            this.precio.Name = "precio";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txtTel);
            this.groupBox2.Controls.Add(this.txtNombre);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.btnCancelar);
            this.groupBox2.Controls.Add(this.btnRentar);
            this.groupBox2.Controls.Add(this.dtPicker);
            this.groupBox2.Controls.Add(this.cmbPel);
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(12, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(830, 252);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "RENTAR";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(220, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Teléfono";
            // 
            // txtTel
            // 
            this.txtTel.Location = new System.Drawing.Point(223, 75);
            this.txtTel.Mask = "000-000-0000";
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(100, 20);
            this.txtTel.TabIndex = 14;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(223, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(220, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 12;
            this.label6.Text = "Nombre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(400, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(91, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Fecha de entrega";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(10, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Películas";
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(712, 42);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(118, 23);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar Renta";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnRentar
            // 
            this.btnRentar.Location = new System.Drawing.Point(614, 42);
            this.btnRentar.Name = "btnRentar";
            this.btnRentar.Size = new System.Drawing.Size(98, 23);
            this.btnRentar.TabIndex = 8;
            this.btnRentar.Text = "Rentar";
            this.btnRentar.UseVisualStyleBackColor = true;
            // 
            // dtPicker
            // 
            this.dtPicker.Location = new System.Drawing.Point(403, 45);
            this.dtPicker.Name = "dtPicker";
            this.dtPicker.Size = new System.Drawing.Size(200, 20);
            this.dtPicker.TabIndex = 3;
            // 
            // cmbPel
            // 
            this.cmbPel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPel.FormattingEnabled = true;
            this.cmbPel.Items.AddRange(new object[] {
            "Piratas del caribe 1",
            "Piratas del caribe 2",
            "Piratas del caribe 3",
            "Piratas del caribe 4",
            "Piratas del caribe \"El regreso\""});
            this.cmbPel.Location = new System.Drawing.Point(10, 45);
            this.cmbPel.Name = "cmbPel";
            this.cmbPel.Size = new System.Drawing.Size(204, 21);
            this.cmbPel.TabIndex = 2;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.telefono,
            this.pelicula2,
            this.fecha,
            this.fechaE});
            this.dataGridView2.Location = new System.Drawing.Point(13, 101);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(602, 145);
            this.dataGridView2.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // telefono
            // 
            this.telefono.HeaderText = "Teléfono";
            this.telefono.Name = "telefono";
            // 
            // pelicula2
            // 
            this.pelicula2.HeaderText = "Película";
            this.pelicula2.Name = "pelicula2";
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha Actual";
            this.fecha.Name = "fecha";
            // 
            // fechaE
            // 
            this.fechaE.HeaderText = "Fecha de entrega";
            this.fechaE.Name = "fechaE";
            // 
            // rbRentar
            // 
            this.rbRentar.AutoSize = true;
            this.rbRentar.Location = new System.Drawing.Point(651, 114);
            this.rbRentar.Name = "rbRentar";
            this.rbRentar.Size = new System.Drawing.Size(99, 17);
            this.rbRentar.TabIndex = 5;
            this.rbRentar.TabStop = true;
            this.rbRentar.Text = "Rentar Película";
            this.rbRentar.UseVisualStyleBackColor = true;
            this.rbRentar.CheckedChanged += new System.EventHandler(this.rbRentar_CheckedChanged);
            // 
            // rbVender
            // 
            this.rbVender.AutoSize = true;
            this.rbVender.Location = new System.Drawing.Point(651, 91);
            this.rbVender.Name = "rbVender";
            this.rbVender.Size = new System.Drawing.Size(101, 17);
            this.rbVender.TabIndex = 4;
            this.rbVender.TabStop = true;
            this.rbVender.Text = "Vender Película";
            this.rbVender.UseVisualStyleBackColor = true;
            this.rbVender.CheckedChanged += new System.EventHandler(this.rbVender_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(847, 494);
            this.Controls.Add(this.rbRentar);
            this.Controls.Add(this.rbVender);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Cine";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnVender;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtVPel;
        private System.Windows.Forms.TextBox txtVNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelicula;
        private System.Windows.Forms.DataGridViewTextBoxColumn precio;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.MaskedTextBox txtTel;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnRentar;
        private System.Windows.Forms.DateTimePicker dtPicker;
        private System.Windows.Forms.ComboBox cmbPel;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn pelicula2;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaE;
        private System.Windows.Forms.RadioButton rbRentar;
        private System.Windows.Forms.RadioButton rbVender;
    }
}

